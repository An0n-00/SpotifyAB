namespace SpotifyAB
{
    partial class Dashboard
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dashboard));
            linkLabel1 = new LinkLabel();
            logBox = new TextBox();
            installBtn = new Button();
            issuebtn = new Button();
            devbtn = new Button();
            groupBox1 = new GroupBox();
            uninstallABbtn = new Button();
            overri = new Button();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // linkLabel1
            // 
            linkLabel1.ActiveLinkColor = Color.Lime;
            linkLabel1.AutoSize = true;
            linkLabel1.Cursor = Cursors.Help;
            linkLabel1.Font = new Font("Helvetica", 25F, FontStyle.Bold);
            linkLabel1.LinkBehavior = LinkBehavior.HoverUnderline;
            linkLabel1.LinkColor = Color.Black;
            linkLabel1.Location = new Point(16, 9);
            linkLabel1.Margin = new Padding(4, 0, 4, 0);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(268, 59);
            linkLabel1.TabIndex = 0;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "SpotifyAB";
            linkLabel1.TextAlign = ContentAlignment.MiddleCenter;
            linkLabel1.VisitedLinkColor = Color.FromArgb(64, 64, 64);
            linkLabel1.LinkClicked += linkLabel1_LinkClicked;
            // 
            // logBox
            // 
            logBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            logBox.BackColor = SystemColors.ButtonHighlight;
            logBox.BorderStyle = BorderStyle.FixedSingle;
            logBox.Font = new Font("Consolas", 10F);
            logBox.Location = new Point(12, 89);
            logBox.Margin = new Padding(4, 3, 4, 3);
            logBox.MaxLength = 1000;
            logBox.MinimumSize = new Size(926, 270);
            logBox.Multiline = true;
            logBox.Name = "logBox";
            logBox.ReadOnly = true;
            logBox.ScrollBars = ScrollBars.Vertical;
            logBox.Size = new Size(930, 270);
            logBox.TabIndex = 1;
            logBox.WordWrap = false;
            // 
            // installBtn
            // 
            installBtn.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            installBtn.Location = new Point(6, 32);
            installBtn.Name = "installBtn";
            installBtn.Size = new Size(292, 106);
            installBtn.TabIndex = 2;
            installBtn.Text = "Install AB to Spotify";
            installBtn.UseVisualStyleBackColor = true;
            installBtn.Click += installBtn_Click;
            // 
            // issuebtn
            // 
            issuebtn.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            issuebtn.Location = new Point(831, 12);
            issuebtn.MinimumSize = new Size(112, 71);
            issuebtn.Name = "issuebtn";
            issuebtn.Size = new Size(112, 71);
            issuebtn.TabIndex = 3;
            issuebtn.Text = "Report a \r\nBug";
            issuebtn.UseVisualStyleBackColor = true;
            issuebtn.Click += issuebtn_Click;
            // 
            // devbtn
            // 
            devbtn.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            devbtn.Location = new Point(642, 499);
            devbtn.Name = "devbtn";
            devbtn.Size = new Size(301, 110);
            devbtn.TabIndex = 4;
            devbtn.Text = "Enable Dev Tools";
            devbtn.UseVisualStyleBackColor = true;
            devbtn.Click += devbtn_Click;
            // 
            // groupBox1
            // 
            groupBox1.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            groupBox1.Controls.Add(uninstallABbtn);
            groupBox1.Controls.Add(installBtn);
            groupBox1.Location = new Point(12, 365);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(304, 244);
            groupBox1.TabIndex = 5;
            groupBox1.TabStop = false;
            groupBox1.Text = "SpotifyAB Management";
            // 
            // uninstallABbtn
            // 
            uninstallABbtn.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            uninstallABbtn.Location = new Point(6, 144);
            uninstallABbtn.Name = "uninstallABbtn";
            uninstallABbtn.Size = new Size(292, 94);
            uninstallABbtn.TabIndex = 6;
            uninstallABbtn.Text = "Uninstall AB from Spotify";
            uninstallABbtn.UseVisualStyleBackColor = true;
            uninstallABbtn.Click += uninstallABbtn_Click;
            // 
            // overri
            // 
            overri.Anchor = AnchorStyles.Bottom;
            overri.Location = new Point(397, 535);
            overri.Name = "overri";
            overri.Size = new Size(161, 74);
            overri.TabIndex = 6;
            overri.Text = "Override Options";
            overri.UseVisualStyleBackColor = true;
            overri.Click += overri_Click;
            // 
            // Dashboard
            // 
            AccessibleDescription = "SpotifyAB Client App. Can Block Spotify Ads and trackers.";
            AccessibleName = "SpotifyAB";
            AutoScaleDimensions = new SizeF(13F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(955, 621);
            Controls.Add(overri);
            Controls.Add(groupBox1);
            Controls.Add(devbtn);
            Controls.Add(issuebtn);
            Controls.Add(logBox);
            Controls.Add(linkLabel1);
            Font = new Font("Helvetica", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4, 3, 4, 3);
            MinimumSize = new Size(977, 677);
            Name = "Dashboard";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "SpotifyAB Dashboard";
            WindowState = FormWindowState.Maximized;
            Load += Dashboard_Load;
            groupBox1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion


        private LinkLabel linkLabel1;
        private Button installBtn;
        private Button issuebtn;
        private Button devbtn;
        private GroupBox groupBox1;
        private Button uninstallABbtn;
        private Button overri;
        private static TextBox logBox;
    }
}
