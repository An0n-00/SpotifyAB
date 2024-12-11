using Microsoft.Win32;
using SharpCompress.Common;
using SharpCompress.Readers;
using System.Diagnostics;
using System.Runtime.InteropServices;
using Windows.UI.Notifications;

namespace SpotifyAB
{
    public partial class Dashboard : Form
    {
        [DllImport("user32.dll")]
        [return: MarshalAs(UnmanagedType.Bool)]
        private static extern bool FlashWindow(IntPtr hwnd, bool bInvert);

        private ToolTip toolTip1;

        public Dashboard()
        {
            InitializeComponent();
            BlockSpotify();
            Startup(this);
            Log("SpotifyAB started successfully.");
        }

        // Block Spotify from running while SpotifyAB is running
        private void BlockSpotify()
        {
            var timer = new System.Timers.Timer();
            timer.Interval = 1500; // Check every 1.5 seconds
            timer.Elapsed += CheckAndKillSpotify;
            timer.Start();
        }

        private void CheckAndKillSpotify(object sender, EventArgs e)
        {
            try
            {
                var processes = Process.GetProcessesByName("Spotify");
                foreach (var process in processes.Where(p => !p.HasExited))
                {
                    process.EnableRaisingEvents = true;
                    process.Exited += (s, args) => Invoke((MethodInvoker)delegate { FlashWindow(Handle, true); });
                    process.Kill();
                    Log("Spotify closed to avoid conflicts.");
                }
            }
            catch (Exception ex)
            {
                ShowError(this, $"Error: {ex.Message}");
            }
        }

        public  void Startup(Dashboard dashboard)
        {
            Log("Starting SpotifyAB");

            dashboard.toolTip1 = new ToolTip();
            dashboard.toolTip1.SetToolTip(dashboard.linkLabel1, "Visit SpotifyAB's GitHub Repository");

            if (IsSpotifyInstalled())
            {
                Log("Spotify is installed.");
                var currentVersion = GetSpotifyVersion();
                var savedVersion = GetRegistryKey("SpotifyVersion");
                if (string.IsNullOrEmpty(savedVersion))
                {
                    CheckSpotifyABInstallation(dashboard);
                }
                else if (currentVersion != savedVersion)
                {
                    SetRegistryKey("Installed", "False");
                    Log("Spotify version has changed. Reinstalling SpotifyAB on in this new version.");
                    if (MessageBox.Show("Spotify version has changed. Reinstall SpotifyAB?", "Update SpotifyAB", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        DownloadAndInstallSpotifyAB(dashboard).Wait();
                        Log("SpotifyAB reinstalled.");
                    }
                    else
                    {
                        CheckSpotifyABInstallation(dashboard);
                        Log("SpotifyAB not reinstalled.");
                    }
                }
                else
                {
                    CheckSpotifyABInstallation(dashboard);
                }
            }
            else
            {
                HandleSpotifyNotInstalled(dashboard);
            }
        }

        private  string GetRegistryKey(string keyName)
        {
            using var key = Registry.CurrentUser.OpenSubKey("Software\\SpotifyAB");
            return key?.GetValue(keyName)?.ToString();
        }

        private  bool IsSpotifyInstalled() =>
            File.Exists($@"C:\Users\{Environment.UserName}\AppData\Roaming\Spotify\Spotify.exe");

        private  void CheckSpotifyABInstallation(Dashboard dashboard)
        {
            var installed = IsSpotifyABInstalled();
            if (installed) SetRegistryKey("SpotifyVersion", GetSpotifyVersion());
            dashboard.installBtn.Enabled = !installed;
            dashboard.uninstallBtn.Enabled = installed;
            Log(installed ? "SpotifyAB is installed." : "SpotifyAB is not installed.");
        }

        private  bool IsSpotifyABInstalled() =>
            Registry.CurrentUser.OpenSubKey("Software\\SpotifyAB")?.GetValue("Installed")?.ToString() == "True";

        private  void HandleSpotifyNotInstalled(Dashboard dashboard)
        {
            Log("Spotify is not installed.");
            ShowError(dashboard, "Please install Spotify first. SpotifyAB only works with the desktop version.");
            if (MessageBox.Show("Open Spotify download page?", "Download Spotify", MessageBoxButtons.YesNo) == DialogResult.Yes)
                OpenUrl("https://www.spotify.com/download/windows/#download-cdn");

            SetRegistryKey("Installed", "False");
            DisableButtons(dashboard);
        }

        private  void SetRegistryKey(string keyName, string value)
        {
            try
            {
                using var key = Registry.CurrentUser.CreateSubKey("Software\\SpotifyAB");
                key.SetValue(keyName, value);
            }
            catch (Exception ex)
            {
                ShowError(null, $"Error saving to registry: {ex.Message}");
                Log($"Registry error: {ex.InnerException}");
            }
        }

        private  void DisableButtons(Dashboard dashboard)
        {
            dashboard.installBtn.Enabled = false;
            dashboard.uninstallBtn.Enabled = false;
            dashboard.devbtn.Enabled = false;
        }

        public  void Log(string message)
        {
            if (logBox.Lines.Length > 1000) logBox.Clear();
            logBox.AppendText($"[{DateTime.Now:yyyy-MM-dd HH:mm:ss}] - {message}\r\n");
        }

        private  void ShowError(Dashboard dashboard, string message)
        {
            if (dashboard != null)
            {
                dashboard.Invoke((MethodInvoker)delegate { MessageBox.Show(message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); });
            }
            else
            {
                MessageBox.Show(message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private  void OpenUrl(string url)
        {
            try
            {
                Process.Start(new ProcessStartInfo { FileName = url, UseShellExecute = true });
            }
            catch (Exception ex)
            {
                ShowError(null, $"Error opening URL: {ex.Message}");
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) =>
            OpenUrl("https://www.github.com/An0n-00/SpotifyAB");

        private async void installBtn_Click(object sender, EventArgs e)
        {
            if (!IsSpotifyInstalledProperly())
            {
                ShowError(this, "Spotify is installed strangely. I cannot find the XPUI file.");
                Log("Error: Cannot find the XPUI file");
                return;
            }

            await DownloadAndInstallSpotifyAB(this);
            installBtn.Enabled = false;
            uninstallBtn.Enabled = true;
        }

        private bool IsSpotifyInstalledProperly()
        {
            if (File.Exists($@"{Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData)}\Spotify\Apps\xpui.spa"))
            {
                return true;
            }
            else
            {
                if (File.Exists($@"{Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData)}\Spotify\Apps\xpui-original.spa"))
                {
                    File.Move($@"{Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData)}\Spotify\Apps\xpui-original.spa", $@"{Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData)}\Spotify\Apps\xpui.spa");
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }

        private  async Task DownloadAndInstallSpotifyAB(Dashboard dashboard)
        {
            var fileUrl = "https://github.com/An0n-00/SpotifyAB/releases/latest/download/xpui.spa";
            var downloadPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "xpui.spa");
            var destinationPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "Spotify\\Apps\\xpui.spa");

            BackupOriginalFile(destinationPath);

            try
            {
                int success = 0;

                try
                {
                    using (var client = new HttpClient())
                    {
                        using (var response = await client.GetAsync(fileUrl, HttpCompletionOption.ResponseHeadersRead))
                        {
                            // Disable all controls in the current form
                            dashboard.Enabled = false;

                            // Create a new form with a progress bar
                            // Create a new form with a progress bar
                            var progressForm = new Form
                            {
                                Size = new Size(399, 110), // Set the initial size
                                MinimumSize = new Size(399, 109), // Set the minimum size
                                MaximumSize = new Size(400, 110), // Set the maximum size
                                StartPosition = FormStartPosition.CenterScreen, // Set the start position
                                Text = "Installing AB" // Set the title
                            };

                            var progressBar = new ProgressBar
                            { Style = ProgressBarStyle.Continuous, Dock = DockStyle.Fill };
                            progressForm.Controls.Add(progressBar);
                            progressForm.Show();

                            var contentLength = response.Content.Headers.ContentLength.GetValueOrDefault();
                            var totalBytes = 0L;

                            using (var stream = new FileStream(downloadPath, FileMode.Create, FileAccess.Write, FileShare.None))
                            {
                                var buffer = new byte[8192];
                                var length = 0;

                                while ((length = await response.Content.ReadAsStreamAsync().Result.ReadAsync(buffer, 0, buffer.Length)) > 0)
                                {
                                    await stream.WriteAsync(buffer, 0, length);
                                    totalBytes += length;

                                    // Update the progress bar
                                    progressBar.Value = (int)((double)totalBytes / contentLength * 100);
                                }
                            }

                            // Close the progress form and enable all controls in the current form
                            progressForm.Close();
                            dashboard.Enabled = true;
                        }
                    }
                }
                catch (Exception d)
                {
                    ShowError(dashboard, $"An error occurred: {d.Message}");
                    Log("An error occurred while downloading the file.");
                    Log(d.InnerException.ToString());
                    success = 1;
                    return;
                }

                // Move the downloaded file to the Spotify directory
                try
                {
                    if (success == 1)  {
                        File.Delete(destinationPath);
                        Log("An error occurred while downloading the file.");
                        throw new Exception("An error occurred while downloading the file.");
                    }

                    File.Move(downloadPath, destinationPath);

                    // Unzip the file
                    try
                    {
                        using (var stream = File.OpenRead(destinationPath))
                        using (var reader = ReaderFactory.Open(stream))
                        {
                            while (reader.MoveToNextEntry())
                            {
                                if (!reader.Entry.IsDirectory)
                                {
                                    reader.WriteEntryToDirectory(Path.GetDirectoryName(destinationPath), new ExtractionOptions() { ExtractFullPath = true, Overwrite = true });
                                }
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        ShowError(dashboard, $"An error occurred while unzipping the file: {ex.Message}");
                        Log("An error occurred while unzipping the file.");
                        Log(ex.InnerException.ToString());
                        throw new Exception("An error occurred while unzipping the file.");
                    }
                }
                catch (Exception m)
                {
                    ShowError(dashboard, $"An error occurred: {m.Message}");
                    Log("An error occurred while moving the file.");
                    Log(m.InnerException.ToString());
                    throw new Exception("An error occurred while moving the file.");
                }

                SetRegistryKey("Installed", "True");
                
                Log("SpotifyAB installed successfully.");
                ShowSuccess("SpotifyAB installed successfully.");
            }
            catch (Exception f)
            {
                ShowError(dashboard, $"An error occurred: {f.Message}");
            }
            // Save the Spotify version in the registry
            var spotifyVersion = GetSpotifyVersion();
            SetRegistryKey("SpotifyVersion", spotifyVersion);
            SetRegistryKey("Installed", "True");
        }

        private  string GetSpotifyVersion()
        {
            var spotifyExecutable = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "Spotify\\Spotify.exe");
            return File.Exists(spotifyExecutable) ? FileVersionInfo.GetVersionInfo(spotifyExecutable).FileVersion : string.Empty;
        }

        private  void BackupOriginalFile(string destinationPath)
        {
            if (File.Exists(destinationPath) && !IsSpotifyABInstalled())
            {
                File.Move(destinationPath, destinationPath.Replace(".spa", "-original.spa"));
            }
            Thread.Sleep(1000);
        }

        private void ShowSuccess(string message)
        {
            MessageBox.Show(message, "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Log(message);
        }

        private void issuebtn_Click(object sender, EventArgs e) =>
            OpenUrl("https://www.github.com/An0n-00/SpotifyAB/issues");

        private async void devbtn_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Enable Developer Tools for Spotify?", "Enable Developer Tools", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                var success = await DownloadAndRunScript();
                Log(success == 0 ? "Developer Tools enabled succesfully." : "Error enabling Developer Tools.");
            }
            else
            {
                Log("Developer Tools enable cancelled.");
            }
        }

        private async Task<int> DownloadAndRunScript()
        {
            try
            {
                var scriptUrl = "https://raw.githubusercontent.com/An0n-00/SpotifyAB/refs/heads/main/analyze-tools/dev-tools/Enable-Dev-Tools-for-spotify.ps1";
                var scriptPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "addons", "enable-dev.ps1");

                Directory.CreateDirectory(Path.GetDirectoryName(scriptPath));
                using var client = new HttpClient();
                var content = await client.GetByteArrayAsync(scriptUrl);
                await File.WriteAllBytesAsync(scriptPath, content);

                return RunPowerShellScript(scriptPath);
            }
            catch (Exception ex)
            {
                ShowError(this, $"Error: {ex.Message}");
                return 1;
            }
        }

        private int RunPowerShellScript(string scriptPath)
        {
            var process = new Process
            {
                StartInfo = new ProcessStartInfo
                {
                    FileName = "powershell.exe",
                    Arguments = $"-ExecutionPolicy Bypass -File \"{scriptPath}\"",
                    UseShellExecute = false,
                    CreateNoWindow = true,
                    RedirectStandardOutput = true
                }
            };

            process.Start();
            process.WaitForExit();
            return process.ExitCode;
        }

        private void uninstallABbtn_Click(object sender, EventArgs e)
        {
            if (!IsSpotifyABInstalled())
            {
                ShowError(this, "SpotifyAB is not installed.");
                return;
            }

            DeleteSpotifyABFiles();
            ShowSuccess("SpotifyAB uninstalled successfully.");
            installBtn.Enabled = true;
            uninstallBtn.Enabled = false;
            SetRegistryKey("Installed", "False");
        }

        private  void DeleteSpotifyABFiles()
        {
            var appDataPath = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
            var xpuiPath = Path.Combine(appDataPath, "Spotify\\Apps\\xpui.spa");
            var xpuiOriginalPath = Path.Combine(appDataPath, "Spotify\\Apps\\xpui-original.spa");

            if (File.Exists(xpuiPath)) File.Delete(xpuiPath);
            if (Directory.Exists(Path.Combine(appDataPath, "Spotify\\Apps\\xpui"))) Directory.Delete(Path.Combine(appDataPath, "Spotify\\Apps\\xpui"), true);
            if (File.Exists(xpuiOriginalPath)) File.Move(xpuiOriginalPath, xpuiPath);
        }
    }
}