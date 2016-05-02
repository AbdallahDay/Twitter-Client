namespace Twitter_Client
{
    partial class frmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.grpPostTweet = new System.Windows.Forms.GroupBox();
            this.lblCharsLeft = new System.Windows.Forms.Label();
            this.btnPublish = new System.Windows.Forms.Button();
            this.txtPost = new System.Windows.Forms.TextBox();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.panelTop = new System.Windows.Forms.Panel();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnSignOut = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabTimeline = new System.Windows.Forms.TabPage();
            this.lboTimeline = new System.Windows.Forms.ListBox();
            this.tabMentions = new System.Windows.Forms.TabPage();
            this.lboMentions = new System.Windows.Forms.ListBox();
            this.grpPostTweet.SuspendLayout();
            this.panelTop.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabTimeline.SuspendLayout();
            this.tabMentions.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpPostTweet
            // 
            this.grpPostTweet.Controls.Add(this.lblCharsLeft);
            this.grpPostTweet.Controls.Add(this.btnPublish);
            this.grpPostTweet.Controls.Add(this.txtPost);
            this.grpPostTweet.Location = new System.Drawing.Point(12, 39);
            this.grpPostTweet.Name = "grpPostTweet";
            this.grpPostTweet.Size = new System.Drawing.Size(210, 115);
            this.grpPostTweet.TabIndex = 0;
            this.grpPostTweet.TabStop = false;
            this.grpPostTweet.Text = "&Compose a Tweet:";
            // 
            // lblCharsLeft
            // 
            this.lblCharsLeft.AutoSize = true;
            this.lblCharsLeft.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblCharsLeft.Location = new System.Drawing.Point(98, 91);
            this.lblCharsLeft.Name = "lblCharsLeft";
            this.lblCharsLeft.Size = new System.Drawing.Size(25, 13);
            this.lblCharsLeft.TabIndex = 3;
            this.lblCharsLeft.Text = "140";
            this.lblCharsLeft.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnPublish
            // 
            this.btnPublish.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPublish.Location = new System.Drawing.Point(129, 86);
            this.btnPublish.Name = "btnPublish";
            this.btnPublish.Size = new System.Drawing.Size(75, 23);
            this.btnPublish.TabIndex = 2;
            this.btnPublish.Text = "&Publish";
            this.btnPublish.UseVisualStyleBackColor = true;
            this.btnPublish.Click += new System.EventHandler(this.btnPublish_Click);
            // 
            // txtPost
            // 
            this.txtPost.AcceptsReturn = true;
            this.txtPost.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPost.Location = new System.Drawing.Point(7, 20);
            this.txtPost.Multiline = true;
            this.txtPost.Name = "txtPost";
            this.txtPost.Size = new System.Drawing.Size(197, 60);
            this.txtPost.TabIndex = 0;
            this.txtPost.TextChanged += new System.EventHandler(this.txtPost_TextChanged);
            // 
            // txtSearch
            // 
            this.txtSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.txtSearch.Location = new System.Drawing.Point(12, 5);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(210, 22);
            this.txtSearch.TabIndex = 0;
            this.txtSearch.Text = "Find People";
            this.txtSearch.Enter += new System.EventHandler(this.txtSearch_Enter);
            this.txtSearch.Leave += new System.EventHandler(this.txtSearch_Leave);
            // 
            // btnSearch
            // 
            this.btnSearch.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSearch.BackgroundImage")));
            this.btnSearch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnSearch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSearch.FlatAppearance.BorderColor = System.Drawing.Color.MediumTurquoise;
            this.btnSearch.FlatAppearance.BorderSize = 0;
            this.btnSearch.FlatAppearance.MouseDownBackColor = System.Drawing.Color.MediumTurquoise;
            this.btnSearch.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MediumTurquoise;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Location = new System.Drawing.Point(223, 6);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(22, 22);
            this.btnSearch.TabIndex = 1;
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // panelTop
            // 
            this.panelTop.BackColor = System.Drawing.Color.MediumTurquoise;
            this.panelTop.Controls.Add(this.btnRefresh);
            this.panelTop.Controls.Add(this.txtSearch);
            this.panelTop.Controls.Add(this.btnSearch);
            this.panelTop.Controls.Add(this.btnSignOut);
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.Location = new System.Drawing.Point(0, 0);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(734, 33);
            this.panelTop.TabIndex = 2;
            // 
            // btnRefresh
            // 
            this.btnRefresh.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRefresh.Location = new System.Drawing.Point(580, 5);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(75, 23);
            this.btnRefresh.TabIndex = 5;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.frmMain_Load);
            // 
            // btnSignOut
            // 
            this.btnSignOut.AutoSize = true;
            this.btnSignOut.BackColor = System.Drawing.Color.MediumTurquoise;
            this.btnSignOut.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnSignOut.FlatAppearance.BorderColor = System.Drawing.Color.MediumTurquoise;
            this.btnSignOut.FlatAppearance.BorderSize = 0;
            this.btnSignOut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSignOut.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSignOut.ForeColor = System.Drawing.Color.Navy;
            this.btnSignOut.Location = new System.Drawing.Point(658, 0);
            this.btnSignOut.Margin = new System.Windows.Forms.Padding(0);
            this.btnSignOut.Name = "btnSignOut";
            this.btnSignOut.Size = new System.Drawing.Size(76, 33);
            this.btnSignOut.TabIndex = 4;
            this.btnSignOut.Text = "Sign Out";
            this.btnSignOut.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSignOut.UseVisualStyleBackColor = false;
            this.btnSignOut.Click += new System.EventHandler(this.btnSignOut_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabTimeline);
            this.tabControl1.Controls.Add(this.tabMentions);
            this.tabControl1.Location = new System.Drawing.Point(228, 39);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(506, 425);
            this.tabControl1.TabIndex = 3;
            // 
            // tabTimeline
            // 
            this.tabTimeline.Controls.Add(this.lboTimeline);
            this.tabTimeline.Location = new System.Drawing.Point(4, 22);
            this.tabTimeline.Name = "tabTimeline";
            this.tabTimeline.Padding = new System.Windows.Forms.Padding(3);
            this.tabTimeline.Size = new System.Drawing.Size(498, 399);
            this.tabTimeline.TabIndex = 0;
            this.tabTimeline.Text = "Timeline";
            this.tabTimeline.UseVisualStyleBackColor = true;
            // 
            // lboTimeline
            // 
            this.lboTimeline.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lboTimeline.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lboTimeline.HorizontalScrollbar = true;
            this.lboTimeline.ItemHeight = 18;
            this.lboTimeline.Location = new System.Drawing.Point(3, 3);
            this.lboTimeline.Name = "lboTimeline";
            this.lboTimeline.Size = new System.Drawing.Size(492, 393);
            this.lboTimeline.TabIndex = 4;
            // 
            // tabMentions
            // 
            this.tabMentions.Controls.Add(this.lboMentions);
            this.tabMentions.Location = new System.Drawing.Point(4, 22);
            this.tabMentions.Name = "tabMentions";
            this.tabMentions.Padding = new System.Windows.Forms.Padding(3);
            this.tabMentions.Size = new System.Drawing.Size(498, 399);
            this.tabMentions.TabIndex = 1;
            this.tabMentions.Text = "Mentions";
            this.tabMentions.UseVisualStyleBackColor = true;
            // 
            // lboMentions
            // 
            this.lboMentions.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lboMentions.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lboMentions.HorizontalScrollbar = true;
            this.lboMentions.ItemHeight = 18;
            this.lboMentions.Location = new System.Drawing.Point(3, 3);
            this.lboMentions.Name = "lboMentions";
            this.lboMentions.Size = new System.Drawing.Size(492, 393);
            this.lboMentions.TabIndex = 5;
            // 
            // frmMain
            // 
            this.AcceptButton = this.btnSearch;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Azure;
            this.ClientSize = new System.Drawing.Size(734, 462);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.panelTop);
            this.Controls.Add(this.grpPostTweet);
            this.MinimumSize = new System.Drawing.Size(750, 500);
            this.Name = "frmMain";
            this.Text = "Twitter Client";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.grpPostTweet.ResumeLayout(false);
            this.grpPostTweet.PerformLayout();
            this.panelTop.ResumeLayout(false);
            this.panelTop.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabTimeline.ResumeLayout(false);
            this.tabMentions.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpPostTweet;
        private System.Windows.Forms.Label lblCharsLeft;
        private System.Windows.Forms.Button btnPublish;
        private System.Windows.Forms.TextBox txtPost;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.Button btnSignOut;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabTimeline;
        private System.Windows.Forms.ListBox lboTimeline;
        private System.Windows.Forms.TabPage tabMentions;
        private System.Windows.Forms.ListBox lboMentions;

    }
}

