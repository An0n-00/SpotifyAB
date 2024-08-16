namespace SpotifyAB
{
    partial class OverrideSpotifyAB
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OverrideSpotifyAB));
            isAlreadyInstalled = new Button();
            isNotInstalled = new Button();
            Back = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // isAlreadyInstalled
            // 
            isAlreadyInstalled.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            isAlreadyInstalled.Location = new Point(12, 78);
            isAlreadyInstalled.Name = "isAlreadyInstalled";
            isAlreadyInstalled.Size = new Size(161, 133);
            isAlreadyInstalled.TabIndex = 0;
            isAlreadyInstalled.Text = "SpotifyAB is already installed in Spotify.";
            isAlreadyInstalled.UseVisualStyleBackColor = true;
            isAlreadyInstalled.Click += isAlreadyInstalled_Click;
            // 
            // isNotInstalled
            // 
            isNotInstalled.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            isNotInstalled.ImeMode = ImeMode.NoControl;
            isNotInstalled.Location = new Point(246, 78);
            isNotInstalled.Name = "isNotInstalled";
            isNotInstalled.Size = new Size(161, 133);
            isNotInstalled.TabIndex = 1;
            isNotInstalled.Text = "SpotifyAB is NOT installed in Spotify.";
            isNotInstalled.UseVisualStyleBackColor = true;
            isNotInstalled.Click += isNotInstalled_Click;
            // 
            // Back
            // 
            Back.Location = new Point(12, 217);
            Back.Name = "Back";
            Back.Size = new Size(395, 114);
            Back.TabIndex = 2;
            Back.Text = "I was just playing around...\r\n(Back)";
            Back.UseVisualStyleBackColor = true;
            Back.Click += Back_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11F);
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(150, 30);
            label1.TabIndex = 1;
            label1.Text = "I am sure that:";
            // 
            // OverrideSpotifyAB
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(419, 343);
            Controls.Add(label1);
            Controls.Add(Back);
            Controls.Add(isNotInstalled);
            Controls.Add(isAlreadyInstalled);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximumSize = new Size(441, 399);
            MinimumSize = new Size(441, 399);
            Name = "OverrideSpotifyAB";
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "OverrideSpotifyAB";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button isAlreadyInstalled;
        private Button isNotInstalled;
        private Button Back;
        private Label label1;
    }
}