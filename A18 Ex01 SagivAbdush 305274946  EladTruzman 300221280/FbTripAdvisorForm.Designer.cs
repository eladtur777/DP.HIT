namespace A18_Ex01_SagivAbdush_305274946__EladTruzman_300221280
{
    partial class FbTripAdvisorForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.dataGridViewLocationsFriends = new System.Windows.Forms.DataGridView();
            this.Location = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FriendsPlaces = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtBoxSearch = new System.Windows.Forms.TextBox();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.WebBrowserOfTag = new System.Windows.Forms.WebBrowser();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewLocationsFriends)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(162, 97);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(556, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Insert your trip location/s and found out the hottest places by your friends on F" +
    "aceBook";
            // 
            // dataGridViewLocationsFriends
            // 
            this.dataGridViewLocationsFriends.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewLocationsFriends.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Location,
            this.FriendsPlaces});
            this.dataGridViewLocationsFriends.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewLocationsFriends.Name = "dataGridViewLocationsFriends";
            this.dataGridViewLocationsFriends.Size = new System.Drawing.Size(505, 319);
            this.dataGridViewLocationsFriends.TabIndex = 6;
            // 
            // Location
            // 
            this.Location.HeaderText = "Location";
            this.Location.Name = "Location";
            // 
            // FriendsPlaces
            // 
            this.FriendsPlaces.HeaderText = "FriendsPlaces";
            this.FriendsPlaces.Name = "FriendsPlaces";
            // 
            // txtBoxSearch
            // 
            this.txtBoxSearch.Location = new System.Drawing.Point(249, 60);
            this.txtBoxSearch.Name = "txtBoxSearch";
            this.txtBoxSearch.Size = new System.Drawing.Size(402, 20);
            this.txtBoxSearch.TabIndex = 8;
            this.txtBoxSearch.TextChanged += new System.EventHandler(this.txtBoxSearch_TextChanged);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Location = new System.Drawing.Point(1, 193);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.dataGridViewLocationsFriends);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.WebBrowserOfTag);
            this.splitContainer1.Size = new System.Drawing.Size(891, 319);
            this.splitContainer1.SplitterDistance = 507;
            this.splitContainer1.TabIndex = 10;
            // 
            // WebBrowserOfTag
            // 
            this.WebBrowserOfTag.Dock = System.Windows.Forms.DockStyle.Fill;
            this.WebBrowserOfTag.Location = new System.Drawing.Point(0, 0);
            this.WebBrowserOfTag.MinimumSize = new System.Drawing.Size(20, 20);
            this.WebBrowserOfTag.Name = "WebBrowserOfTag";
            this.WebBrowserOfTag.Size = new System.Drawing.Size(380, 319);
            this.WebBrowserOfTag.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::A18_Ex01_SagivAbdush_305274946__EladTruzman_300221280.Properties.Resources.SearchIcon;
            this.pictureBox1.Location = new System.Drawing.Point(208, 55);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(38, 39);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // FbTripAdvisorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(892, 513);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.txtBoxSearch);
            this.Controls.Add(this.label1);
            this.Name = "FbTripAdvisorForm";
            this.Text = "FaceBook Trip Advisor";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewLocationsFriends)).EndInit();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.DataGridView dataGridViewLocationsFriends;
        private System.Windows.Forms.DataGridViewTextBoxColumn Location;
        private System.Windows.Forms.DataGridViewTextBoxColumn FriendsPlaces;
        private System.Windows.Forms.TextBox txtBoxSearch;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.WebBrowser WebBrowserOfTag;
    }
}