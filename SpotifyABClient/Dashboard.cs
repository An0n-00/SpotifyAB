using Microsoft.Win32;
using SharpCompress.Common;
using SharpCompress.Readers;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Timers;


namespace SpotifyAB;

public partial class Dashboard : Form
{
    [DllImport("user32.dll")]
    [return: MarshalAs(UnmanagedType.Bool)]
    private static extern bool FlashWindow(IntPtr hwnd, bool bInvert);
    private ToolTip toolTip1; // Declare ToolTip component

    public Dashboard()
    {
        InitializeComponent();

        BlockSpotify();

        // Call startup method
        startup();
        log("SpotifyAB has successfully started");
    }



    // Block Spotify from running while SpotifyAB is running
    private void BlockSpotify()
    {
        var timer = new System.Timers.Timer();
        timer.Interval = 1500; // Check every 1.5 seconds
        timer.Elapsed += CheckAndKillSpotify;
        timer.Start();
    }

    private void CheckAndKillSpotify(object sender, ElapsedEventArgs e)
    {
        try
        {
            var processes = Process.GetProcessesByName("Spotify");
            if (processes.Length > 0)
            {
                foreach (var process in processes)
                {
                    if (!process.HasExited)
                    {
                        process.EnableRaisingEvents = true;
                        process.Exited += (s, args) =>
                        {
                            this.Invoke((MethodInvoker)delegate
                            {
                                FlashWindow(this.Handle, true); // Flash the window in the taskbar
                            });
                        };
                        process.Kill();
                        log("Spotify has been closed in order to avoid conflicts with SpotifyAB.");
                    }
                }
            }
        }
        catch (Exception ex)
        {
            this.Invoke((MethodInvoker)delegate
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK,
                    MessageBoxIcon.Error); // Show error message if an exception occurs while checking if Spotify is running
            });
        }
    }


    public void startup()
    {
        log("Starting SpotifyAB");

        // Initialize ToolTip component
        toolTip1 = new ToolTip();

        // Associate ToolTip with LinkLabel control
        toolTip1.SetToolTip(linkLabel1, "Visit SpotifyAB's GitHub Repository"); // Tooltip message for LinkLabel

        // Check if Spotify is Installed
        if (File.Exists(@"C:\Users\" + Environment.UserName + @"\AppData\Roaming\Spotify\Spotify.exe"))
        {
            log("Spotify is installed on this machine");
            // Check if SpotifyAB is already installed
            var openSubKey = Registry.CurrentUser.OpenSubKey("Software\\SpotifyAB");
            var installed = 0;
            if (openSubKey != null)
            {
                var value = openSubKey.GetValue("Installed");
                if (value.ToString() == "True") installed = 1;
            }

            if (installed == 1)
            {
                installBtn.Enabled = false;
                uninstallABbtn.Enabled = true;
                log("It seems, that SpotifyAB is already installed.");
            }
            else
            {
                installBtn.Enabled = true;
                uninstallABbtn.Enabled = false;
                log("It seems, that SpotifyAB is not yet installed.");
            }
        }
        else
        {
            log("Spotify is not installed on this machine. Or at least not the correct version.");
            log("Install Spotify (direct link): https://download.scdn.co/SpotifySetup.exe");
            MessageBox.Show(
                "Please install Spotify first.\r\nNote: SpotifyAB works only on Windows Desktop (Microsoft store version is not supported.)",
                "Not Installed", MessageBoxButtons.OK,
                MessageBoxIcon.Error); // Show error message if Spotify is not installed
            var answer = MessageBox.Show("Do you want to open the Spotify download page?", "Download Spotify",
                               MessageBoxButtons.YesNo,
                                              MessageBoxIcon.Question); // Show confirmation message before opening the Spotify download page
            if (answer == DialogResult.Yes)
            {
                string url = "https://www.spotify.com/download/windows/#download-cdn"; // Set Spotify download page URL
                try
                {
                    // Open URL in default web browser
                    Process.Start(new ProcessStartInfo
                    {
                        FileName = url,
                        UseShellExecute = true
                    });
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK,
                                               MessageBoxIcon.Error); // Show error message if an exception occurs while opening URL
                }
            } // Open the Spotify download page
            else
            {
                log("Spotify download page has been canceled.");
            }

            // put Registry key to false
            try
            {
                var key = Registry.CurrentUser.CreateSubKey("Software\\SpotifyAB");
                key.SetValue("Installed", "False");
                key.Close();
            }
            catch (Exception r)
            {
                MessageBox.Show($"An error occurred: {r.Message}", "Error", MessageBoxButtons.OK,
                                       MessageBoxIcon.Error);
                log("An error occurred while saving success to registry (CurrentUser\\Software\\SpotifyAB)");
                log(r.InnerException.ToString());
            }

            // Disable all buttons
            installBtn.Enabled = false;
            uninstallABbtn.Enabled = false;
            devbtn.Enabled = false;
        }
    }

    public static void log(string message)
    {
        //Check if the TextBox has reached the maximum number of lines
        if (logBox.Lines.Length > 1000)
            // Clear TextBox if the maximum number of lines is reached
            logBox.Clear();

        //get the current date and time
        var dateTime = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");

        // Append message to TextBox
        logBox.AppendText($"[{dateTime}] - {message}\r\n");
    }

    private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
    {
        var url = "https://www.github.com/An0n-00/SpotifyAB"; // Set Repository URL

        try
        {
            // Open URL in default web browser
            Process.Start(new ProcessStartInfo
            {
                FileName = url,
                UseShellExecute = true
            });
        }
        catch (Exception ex)
        {
            MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK,
                MessageBoxIcon.Error); // Show error message if an exception occurs while opening URL
        }
    }

    private async void installBtn_Click(object sender, EventArgs e)
    {
        try
        {
            int success = 0;
            var fileUrl = "https://github.com/An0n-00/SpotifyAB/releases/latest/download/xpui.spa";
            var downloadPath = AppDomain.CurrentDomain.BaseDirectory + "\\xpui.spa";
            var destinationPath = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) +
                                  "\\Spotify\\Apps\\xpui.spa";

            var openSubKey = Registry.CurrentUser.OpenSubKey("Software\\SpotifyAB");
            var installed = 0;

            // Check if spotifyAB is already installed
            if (openSubKey != null)
            {
                var value = openSubKey.GetValue("Installed");
                if (value.ToString() == "True") installed = 1;
            }


            // Backup the original file
            if (File.Exists(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) +
                            "\\Spotify\\Apps\\xpui.spa") && installed != 1)
            {
                if (File.Exists(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) +
                                "\\Spotify\\Apps\\xpui-original.spa"))
                    File.Delete(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) +
                                "\\Spotify\\Apps\\xpui-original.spa");

                File.Move(destinationPath,
                    Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) +
                    "\\Spotify\\Apps\\xpui-original.spa");
            }
            else
            {
                MessageBox.Show(
                    "Spotify is not installed properly on this machine. Please reinstall Spotify first.",
                    "Broken Install", MessageBoxButtons.OK, MessageBoxIcon.Error);
                log("Spotify is not installed properly on this machine. Please reinstall Spotify first.");
                log("Install Spotify (direct link): https://download.scdn.co/SpotifySetup.exe");
                success = 1;
                return;
            }

            try
            {
                using (var client = new HttpClient())
                {
                    using (var response = await client.GetAsync(fileUrl, HttpCompletionOption.ResponseHeadersRead))
                    {
                        // Disable all controls in the current form
                        Enabled = false;

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

                        using (var stream = new FileStream(downloadPath, FileMode.Create, FileAccess.Write,
                                   FileShare.None))
                        {
                            var buffer = new byte[8192];
                            var length = 0;

                            while ((length = await response.Content.ReadAsStreamAsync().Result
                                       .ReadAsync(buffer, 0, buffer.Length)) > 0)
                            {
                                await stream.WriteAsync(buffer, 0, length);
                                totalBytes += length;

                                // Update the progress bar
                                progressBar.Value = (int)((double)totalBytes / contentLength * 100);
                            }
                        }

                        // Close the progress form and enable all controls in the current form
                        progressForm.Close();
                        Enabled = true;
                    }
                }
            }
            catch (Exception d)
            {
                MessageBox.Show($"An error occurred: {d.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                log("An error occurred while downloading the file.");
                log(d.InnerException.ToString());
                success = 1;
                return;
            }

            // Move the downloaded file to the Spotify directory
            try
            {
                if (installed == 1) File.Delete(destinationPath);
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
                    MessageBox.Show($"An error occurred while unzipping the file: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    log("An error occurred while unzipping the file.");
                    log(ex.InnerException.ToString());
                    success = 1;
                    return;
                }
            }
            catch (Exception m)
            {
                MessageBox.Show($"An error occurred: {m.Message}", "Error", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                log("An error occurred while moving the file.");
                log(m.InnerException.ToString());
                success = 1;
                return;
            }

            try
            {
                // Open the key or create it if it doesn't exist
                var key = Registry.CurrentUser.CreateSubKey("Software\\SpotifyAB");

                // Set the value
                key.SetValue("Installed", "True");

                // Close the key
                key.Close();
            }
            catch (Exception r)
            {
                MessageBox.Show($"An error occurred: {r.Message}", "Error", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                log("An error occurred while saving success to registry (CurrentUser\\Software\\SpotifyAB)");
                log(r.InnerException.ToString());
                success = 1;
            }

            if (success != 1)
            {
                MessageBox.Show("SpotifyAB has been installed successfully.\r\nEnjoy your music!", "Success",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                log("SpotifyAB has been installed successfully.");
                installBtn.Enabled = false;
                uninstallABbtn.Enabled = true;
            }
        }
        catch (Exception f)
        {
            MessageBox.Show($"An error occurred: {f.Message}", "Error", MessageBoxButtons.OK,
                MessageBoxIcon.Error);
        }
    }

    private void issuebtn_Click(object sender, EventArgs e)
    {
        var url = "https://www.github.com/An0n-00/SpotifyAB/issues"; // Set Repository URL

        try
        {
            // Open URL in default web browser
            Process.Start(new ProcessStartInfo
            {
                FileName = url,
                UseShellExecute = true
            });
        }
        catch (Exception ex)
        {
            MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK,
                MessageBoxIcon.Error); // Show error message if an exception occurs while opening URL
        }
    }

    private int DownloadAndRunScript(ref int success)
    {
        try
        {
            var scriptUrl =
                "https://raw.githubusercontent.com/An0n-00/SpotifyAB/refs/heads/main/analyze-tools/dev-tools/Enable-Dev-Tools-for-spotify.ps1";
            var installationFolder = AppDomain.CurrentDomain.BaseDirectory + "\\addons\\";
            var scriptPath = installationFolder + "enable-dev.ps1";
            if (!Directory.Exists(installationFolder)) Directory.CreateDirectory(installationFolder);
            // Download the script
            using (var client = new HttpClient())
            {
                var content = client.GetByteArrayAsync(scriptUrl).Result;
                File.WriteAllBytes(scriptPath, content);
            }
            var process = new Process();
            process.StartInfo.FileName = "powershell.exe";
            process.StartInfo.Arguments = $"-ExecutionPolicy Bypass -File \"{scriptPath}\"";
            process.StartInfo.UseShellExecute = false;
            process.StartInfo.CreateNoWindow = true;
            process.StartInfo.RedirectStandardOutput = true;
            process.Start();
            IntPtr maxWorkingSet = process.MaxWorkingSet;
            process.WaitForExit();
            int exitCode = process.ExitCode;
            if (exitCode == 0)
            {
                return success = 0;
            }
            else if (exitCode == 1)
            {
                return success = 1;
            }
            else if (exitCode == 2)
            {
                return success = 2;
            }
            else if (exitCode == 3)
            {
                return success = 3;
            }
            else if (success == 4)
            {
                return success = 4;
            }
            else if (success == 5)
            {
                return success = 5;
            }
            else
            {
                return success = 1;
            }
        }
        catch (Exception e)
        {
            MessageBox.Show($"An error occurred: {e.Message}", "Error", MessageBoxButtons.OK,
                MessageBoxIcon
                    .Error); // Show error message if an exception occurs while downloading and running the PowerShell script
            return success = 1;
            throw;
        }
    }

    private void devbtn_Click(object sender, EventArgs e)
    {
        var answer = MessageBox.Show("Are you sure you want to enable Developer Tools for Spotify?",
            "Enable Developer Tools", MessageBoxButtons.YesNo,
            MessageBoxIcon.Question); // Show confirmation message before enabling Developer Tools
        if (answer != DialogResult.Yes)
        {
            log("Enabling Developer Tools for Spotify has been canceled.");
        }
        else
        {
            var success = 0;
            DownloadAndRunScript(ref success);
            if (success == 0)
                log("Developer Tools for Spotify has been enabled successfully. Depending on the version, the dev tools will only work one time until you enable them again.");
            else if (success == 1)
                log("An unknown error occurred while enabling Developer Tools for Spotify.");
            else if (success == 2)
                log("Could not find Spotify.exe");
            else if (success == 3)
                log("Please login to Spotify first.");
            else if (success == 4)
                log("Could not find Spotify.exe");
            else if (success == 5)
                log("Please login to Spotify first.");

        }
    }

    private void uninstallABbtn_Click(object sender, EventArgs e)
    {
        var key = Registry.CurrentUser.OpenSubKey("Software\\SpotifyAB", true);
        var success = 0;

        // Check if the key exists
        if (key != null)
        {
            // Read the value
            var value = key.GetValue("Installed");

            if (value == null)
            {
                MessageBox.Show("SpotifyAB is not installed on this machine.",
                    "Not Installed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                success = 1;
            }

            // Check if the value exists
            if (value.ToString() != "True")
            {
                MessageBox.Show("SpotifyAB is not installed on this machine.",
                    "Not Installed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                success = 1;
            }
            else
            {
                try
                {
                    // Set the value
                    key.SetValue("Installed", "False");

                    // Close the key
                    key.Close();
                }
                catch (Exception r)
                {
                    MessageBox.Show($"An error occurred: {r.Message}", "Error", MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                    log($"Error: {r.Message}");
                    success = 1;
                }

                try
                {
                    // Delete the files
                    if (success == 0)
                        File.Delete(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) +
                                    "\\Spotify\\Apps\\xpui.spa");

                    if (success == 0) Directory.Delete(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) +
                                                                                                            "\\Spotify\\Apps\\xpui", true);

                    // Restore the original
                    if (success == 0 && File.Exists(
                            Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) +
                            "\\Spotify\\Apps\\xpui-original.spa"))
                        File.Move(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) +
                                  "\\Spotify\\Apps\\xpui-original.spa",
                            Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) +
                            "\\Spotify\\Apps\\xpui.spa");
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                    log($"Error: {ex.Message}");
                    success = 1;
                }

                if (success == 0)
                {
                    MessageBox.Show("SpotifyAB has been uninstalled successfully.", "Success", MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                    log("SpotifyAB has been uninstalled successfully.");
                    installBtn.Enabled = true;
                    uninstallABbtn.Enabled = false;
                }
                else
                {
                    MessageBox.Show("An error occurred while uninstalling SpotifyAB.", "Error", MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                    log("An error occurred while uninstalling SpotifyAB.");
                }
            }
        }
        else
        {
            MessageBox.Show("SpotifyAB is not installed on this machine.",
                "Not Installed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            log("SpotifyAB is not installed on this machine.");
        }
    }

    private void overri_Click(object sender, EventArgs e)
    {
        var answer = MessageBox.Show("Are you sure that you want to override SpotifyAB's behavior? You might have to do this when Spotify updates and removes the SpotifyAB files.", "Override", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

        if (answer == DialogResult.Yes)
        {
            // start overri.cs form
            log("Showing override window.");
            var form = new OverrideSpotifyAB();
            form.Show();
        }
        else
        {
            log("Overriding SpotifyAB's behavior has been canceled.");
        }
    }

    private void Dashboard_Load(object sender, EventArgs e)
    {

    }
}