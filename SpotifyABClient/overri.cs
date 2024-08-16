using Microsoft.Win32;

namespace SpotifyAB
{
    public partial class OverrideSpotifyAB : Form
    {
        public OverrideSpotifyAB()
        {
            InitializeComponent();
        }

        private void Back_Click(object sender, EventArgs e)
        {
            // Close the form
            Dashboard.log("Override SpotifyAB form closed with no changes");
            this.Close();
        }

        private void isAlreadyInstalled_Click(object sender, EventArgs e)
        {
            var answer = MessageBox.Show("Are you sure that you want to override the current analysis of SpotifyAB?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (answer == DialogResult.No)
            {
                return;
            }
            else if (answer == DialogResult.Yes)
            {
                try
                {
                    // Open the key or create it if it doesn't exist
                    var key = Registry.CurrentUser.CreateSubKey("Software\\SpotifyAB");

                    // Set the value
                    key.SetValue("Installed", "True");

                    // Close the key
                    key.Close();

                    Dashboard.log("Change: SpotifyAB is already installed in Spotify");
                    Dashboard.log("Note: Restart SpotifyAB for the changes to take effect");

                    MessageBox.Show("Please Restart SpotifyAB for the changes to take effect.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception r)
                {
                    MessageBox.Show($"An error occurred while Overriding: {r.Message}", "Error", MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }
            }
        }

        private void isNotInstalled_Click(object sender, EventArgs e)
        {
            var answer = MessageBox.Show("Are you sure that you want to override the current analysis of SpotifyAB?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (answer == DialogResult.No)
            {
                return;
            }
            else if (answer == DialogResult.Yes)
            {
                try
                {
                    // Open the key or create it if it doesn't exist
                    var key = Registry.CurrentUser.CreateSubKey("Software\\SpotifyAB");

                    // Set the value
                    key.SetValue("Installed", "False");

                    // Close the key
                    key.Close();


                    Dashboard.log("Change: SpotifyAB is NOT installed in Spotify");
                    Dashboard.log("Note: Restart SpotifyAB for the changes to take effect");

                    MessageBox.Show("Please Restart SpotifyAB for the changes to take effect.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception r)
                {
                    MessageBox.Show($"An error occurred while Overriding: {r.Message}", "Error", MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }
            }
        }
    }
}
