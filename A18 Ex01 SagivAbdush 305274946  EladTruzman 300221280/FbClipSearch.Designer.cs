namespace A18_Ex01_SagivAbdush_305274946__EladTruzman_300221280
{
    public partial class FbClipSearch
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
            this.FriendName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClipDescription = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FriendImage = new System.Windows.Forms.DataGridViewImageColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.lblFaceBookCleepSearch = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblDate = new System.Windows.Forms.Label();
            this.lbl_Likes = new System.Windows.Forms.Label();
            this.lbl_PostDateToFill = new System.Windows.Forms.Label();
            this.lbl_LikesToFill = new System.Windows.Forms.Label();
            this.lbl_PostMoreDetails = new System.Windows.Forms.Label();
            this.dataGridViewPostComments = new System.Windows.Forms.DataGridView();
            this.CommentPostDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CommentDescription = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LikesCountingComment = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lbl_PostDescription = new System.Windows.Forms.Label();
            this.lbl_PostDescriptionToFill = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFriends)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPostComments)).BeginInit();
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
            this.splitContainer1.Panel2.Controls.Add(this.panel1);
            this.splitContainer1.Panel2.Controls.Add(this.webBrowser1);
            this.splitContainer1.Size = new System.Drawing.Size(788, 305);
            this.splitContainer1.SplitterDistance = 346;
            this.splitContainer1.TabIndex = 2;
            // 
            // dataGridViewFriends
            // 
            this.dataGridViewFriends.AllowUserToAddRows = false;
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
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(444, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(234, 305);
            this.panel1.TabIndex = 6;
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
            // lblFaceBookCleepSearch
            // 
            this.lblFaceBookCleepSearch.AutoSize = true;
            this.lblFaceBookCleepSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFaceBookCleepSearch.ForeColor = System.Drawing.Color.White;
            this.lblFaceBookCleepSearch.Location = new System.Drawing.Point(349, 9);
            this.lblFaceBookCleepSearch.Name = "lblFaceBookCleepSearch";
            this.lblFaceBookCleepSearch.Size = new System.Drawing.Size(313, 31);
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
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.SlateGray;
            this.panel2.Controls.Add(this.lbl_PostDescriptionToFill);
            this.panel2.Controls.Add(this.lbl_PostDescription);
            this.panel2.Controls.Add(this.dataGridViewPostComments);
            this.panel2.Controls.Add(this.lbl_PostMoreDetails);
            this.panel2.Controls.Add(this.lbl_LikesToFill);
            this.panel2.Controls.Add(this.lbl_PostDateToFill);
            this.panel2.Controls.Add(this.lbl_Likes);
            this.panel2.Controls.Add(this.lblDate);
            this.panel2.Location = new System.Drawing.Point(791, 166);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(354, 305);
            this.panel2.TabIndex = 6;
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Location = new System.Drawing.Point(15, 49);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(57, 13);
            this.lblDate.TabIndex = 7;
            this.lblDate.Text = "Post Date:";
            // 
            // lbl_Likes
            // 
            this.lbl_Likes.AutoSize = true;
            this.lbl_Likes.Location = new System.Drawing.Point(239, 49);
            this.lbl_Likes.Margin = new System.Windows.Forms.Padding(2, 0, 3, 0);
            this.lbl_Likes.Name = "lbl_Likes";
            this.lbl_Likes.Size = new System.Drawing.Size(69, 13);
            this.lbl_Likes.TabIndex = 7;
            this.lbl_Likes.Text = "Likes(Count):";
            // 
            // lbl_PostDateToFill
            // 
            this.lbl_PostDateToFill.AutoSize = true;
            this.lbl_PostDateToFill.Location = new System.Drawing.Point(89, 49);
            this.lbl_PostDateToFill.Margin = new System.Windows.Forms.Padding(2, 0, 3, 0);
            this.lbl_PostDateToFill.Name = "lbl_PostDateToFill";
            this.lbl_PostDateToFill.Size = new System.Drawing.Size(0, 13);
            this.lbl_PostDateToFill.TabIndex = 7;
            // 
            // lbl_LikesToFill
            // 
            this.lbl_LikesToFill.AutoSize = true;
            this.lbl_LikesToFill.Location = new System.Drawing.Point(313, 49);
            this.lbl_LikesToFill.Margin = new System.Windows.Forms.Padding(2, 0, 3, 0);
            this.lbl_LikesToFill.Name = "lbl_LikesToFill";
            this.lbl_LikesToFill.Size = new System.Drawing.Size(0, 13);
            this.lbl_LikesToFill.TabIndex = 8;
            // 
            // lbl_PostMoreDetails
            // 
            this.lbl_PostMoreDetails.AutoSize = true;
            this.lbl_PostMoreDetails.Font = new System.Drawing.Font("Microsoft YaHei", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_PostMoreDetails.ForeColor = System.Drawing.SystemColors.Control;
            this.lbl_PostMoreDetails.Location = new System.Drawing.Point(116, 16);
            this.lbl_PostMoreDetails.Name = "lbl_PostMoreDetails";
            this.lbl_PostMoreDetails.Size = new System.Drawing.Size(171, 25);
            this.lbl_PostMoreDetails.TabIndex = 1;
            this.lbl_PostMoreDetails.Text = "Post More Details";
            // 
            // dataGridViewPostComments
            // 
            this.dataGridViewPostComments.AllowUserToAddRows = false;
            this.dataGridViewPostComments.AllowUserToDeleteRows = false;
            this.dataGridViewPostComments.BackgroundColor = System.Drawing.Color.DimGray;
            this.dataGridViewPostComments.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPostComments.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CommentPostDate,
            this.CommentDescription,
            this.LikesCountingComment});
            this.dataGridViewPostComments.Location = new System.Drawing.Point(0, 146);
            this.dataGridViewPostComments.Name = "dataGridViewPostComments";
            this.dataGridViewPostComments.ReadOnly = true;
            this.dataGridViewPostComments.Size = new System.Drawing.Size(351, 156);
            this.dataGridViewPostComments.TabIndex = 9;
            this.dataGridViewPostComments.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewPostComments_CellContentClick);
            // 
            // CommentPostDate
            // 
            this.CommentPostDate.HeaderText = "Comment Post Date";
            this.CommentPostDate.Name = "CommentPostDate";
            this.CommentPostDate.ReadOnly = true;
            this.CommentPostDate.Width = 130;
            // 
            // CommentDescription
            // 
            this.CommentDescription.HeaderText = "Comment";
            this.CommentDescription.Name = "CommentDescription";
            this.CommentDescription.ReadOnly = true;
            // 
            // LikesCountingComment
            // 
            this.LikesCountingComment.HeaderText = "Likes(Count)";
            this.LikesCountingComment.Name = "LikesCountingComment";
            this.LikesCountingComment.ReadOnly = true;
            this.LikesCountingComment.Width = 80;
            // 
            // lbl_PostDescription
            // 
            this.lbl_PostDescription.AutoSize = true;
            this.lbl_PostDescription.Location = new System.Drawing.Point(15, 73);
            this.lbl_PostDescription.Name = "lbl_PostDescription";
            this.lbl_PostDescription.Size = new System.Drawing.Size(87, 13);
            this.lbl_PostDescription.TabIndex = 10;
            this.lbl_PostDescription.Text = "Post Description:";
            // 
            // lbl_PostDescriptionToFill
            // 
            this.lbl_PostDescriptionToFill.AutoSize = true;
            this.lbl_PostDescriptionToFill.Location = new System.Drawing.Point(15, 95);
            this.lbl_PostDescriptionToFill.Name = "lbl_PostDescriptionToFill";
            this.lbl_PostDescriptionToFill.Size = new System.Drawing.Size(0, 13);
            this.lbl_PostDescriptionToFill.TabIndex = 11;
            // 
            // FbClipSearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(1157, 473);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblFaceBookCleepSearch);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btnClipSearch);
            this.Name = "FbClipSearch";
            this.Text = "FbClipSearch";
            this.Load += new System.EventHandler(this.FbClipSearch_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFriends)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPostComments)).EndInit();
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
        private System.Windows.Forms.Label lblFaceBookCleepSearch;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lbl_LikesToFill;
        private System.Windows.Forms.Label lbl_PostDateToFill;
        private System.Windows.Forms.Label lbl_Likes;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.DataGridView dataGridViewPostComments;
        private System.Windows.Forms.Label lbl_PostMoreDetails;
        private System.Windows.Forms.DataGridViewTextBoxColumn CommentPostDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn CommentDescription;
        private System.Windows.Forms.DataGridViewTextBoxColumn LikesCountingComment;
        private System.Windows.Forms.Label lbl_PostDescriptionToFill;
        private System.Windows.Forms.Label lbl_PostDescription;
    }
}