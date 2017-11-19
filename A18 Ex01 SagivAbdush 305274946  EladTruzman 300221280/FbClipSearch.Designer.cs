namespace A18_Ex01_SagivAbdush_305274946__EladTruzman_300221280
{
    partial class FbClipSearch
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
            this.btnClipSearch = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.dataGridViewFriends = new System.Windows.Forms.DataGridView();
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.FriendName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClipDescription = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FriendImage = new System.Windows.Forms.DataGridViewImageColumn();
            this.dataGridViewMoreDetails = new System.Windows.Forms.DataGridView();
            this.lblFaceBookCleepSearch = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.DatePost = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LikesCounting = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFriends)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMoreDetails)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnClipSearch
            // 
            this.btnClipSearch.BackColor = System.Drawing.Color.MediumAquamarine;
            this.btnClipSearch.Location = new System.Drawing.Point(298, 92);
            this.btnClipSearch.Name = "btnClipSearch";
            this.btnClipSearch.Size = new System.Drawing.Size(75, 23);
            this.btnClipSearch.TabIndex = 0;
            this.btnClipSearch.Text = "GO!";
            this.btnClipSearch.UseVisualStyleBackColor = false;
            this.btnClipSearch.Click += new System.EventHandler(this.btnClipSearch_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(375, 94);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(390, 20);
            this.textBox1.TabIndex = 1;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Location = new System.Drawing.Point(-3, 166);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.dataGridViewFriends);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.webBrowser1);
            this.splitContainer1.Size = new System.Drawing.Size(788, 305);
            this.splitContainer1.SplitterDistance = 346;
            this.splitContainer1.TabIndex = 2;
            // 
            // dataGridViewFriends
            // 
            this.dataGridViewFriends.AllowUserToDeleteRows = false;
            this.dataGridViewFriends.BackgroundColor = System.Drawing.Color.SlateGray;
            this.dataGridViewFriends.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewFriends.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.FriendName,
            this.ClipDescription,
            this.FriendImage});
            this.dataGridViewFriends.Location = new System.Drawing.Point(3, 3);
            this.dataGridViewFriends.Name = "dataGridViewFriends";
            this.dataGridViewFriends.ReadOnly = true;
            this.dataGridViewFriends.Size = new System.Drawing.Size(341, 302);
            this.dataGridViewFriends.TabIndex = 0;
            this.dataGridViewFriends.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewFriends_CellContentClick);
            // 
            // webBrowser1
            // 
            this.webBrowser1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.webBrowser1.Location = new System.Drawing.Point(0, 0);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.Size = new System.Drawing.Size(438, 305);
            this.webBrowser1.TabIndex = 0;
            this.webBrowser1.DocumentCompleted += new System.Windows.Forms.WebBrowserDocumentCompletedEventHandler(this.webBrowser1_DocumentCompleted);
            // 
            // FriendName
            // 
            this.FriendName.HeaderText = "FriendName";
            this.FriendName.Name = "FriendName";
            this.FriendName.ReadOnly = true;
            // 
            // ClipDescription
            // 
            this.ClipDescription.HeaderText = "ClipDescription";
            this.ClipDescription.Name = "ClipDescription";
            this.ClipDescription.ReadOnly = true;
            // 
            // FriendImage
            // 
            this.FriendImage.HeaderText = "FriendImage";
            this.FriendImage.Name = "FriendImage";
            this.FriendImage.ReadOnly = true;
            // 
            // dataGridViewMoreDetails
            // 
            this.dataGridViewMoreDetails.BackgroundColor = System.Drawing.Color.SlateGray;
            this.dataGridViewMoreDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewMoreDetails.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.DatePost,
            this.LikesCounting});
            this.dataGridViewMoreDetails.Location = new System.Drawing.Point(791, 169);
            this.dataGridViewMoreDetails.Name = "dataGridViewMoreDetails";
            this.dataGridViewMoreDetails.Size = new System.Drawing.Size(366, 302);
            this.dataGridViewMoreDetails.TabIndex = 3;
            // 
            // lblFaceBookCleepSearch
            // 
            this.lblFaceBookCleepSearch.AutoSize = true;
            this.lblFaceBookCleepSearch.Font = new System.Drawing.Font("Vani", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFaceBookCleepSearch.ForeColor = System.Drawing.Color.White;
            this.lblFaceBookCleepSearch.Location = new System.Drawing.Point(349, 9);
            this.lblFaceBookCleepSearch.Name = "lblFaceBookCleepSearch";
            this.lblFaceBookCleepSearch.Size = new System.Drawing.Size(327, 49);
            this.lblFaceBookCleepSearch.TabIndex = 4;
            this.lblFaceBookCleepSearch.Text = "FaceBookCleepSearch";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::A18_Ex01_SagivAbdush_305274946__EladTruzman_300221280.Properties.Resources.ClipSearch2;
            this.pictureBox1.Location = new System.Drawing.Point(665, 8);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(60, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // DatePost
            // 
            this.DatePost.HeaderText = "Date Post";
            this.DatePost.Name = "DatePost";
            this.DatePost.ReadOnly = true;
            // 
            // LikesCounting
            // 
            this.LikesCounting.HeaderText = "Likes(number)";
            this.LikesCounting.Name = "LikesCounting";
            this.LikesCounting.ReadOnly = true;
            // 
            // FbClipSearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(1157, 473);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblFaceBookCleepSearch);
            this.Controls.Add(this.dataGridViewMoreDetails);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btnClipSearch);
            this.Name = "FbClipSearch";
            this.Text = "FbClipSearch";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFriends)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMoreDetails)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnClipSearch;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.WebBrowser webBrowser1;
        private System.Windows.Forms.DataGridView dataGridViewFriends;
        private System.Windows.Forms.DataGridViewTextBoxColumn FriendName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClipDescription;
        private System.Windows.Forms.DataGridViewImageColumn FriendImage;
        private System.Windows.Forms.DataGridView dataGridViewMoreDetails;
        private System.Windows.Forms.Label lblFaceBookCleepSearch;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridViewTextBoxColumn DatePost;
        private System.Windows.Forms.DataGridViewTextBoxColumn LikesCounting;
    }
}