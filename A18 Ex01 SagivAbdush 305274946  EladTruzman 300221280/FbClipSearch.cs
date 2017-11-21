using System.Collections.Generic;
using System;
using System.Drawing;
using System.Windows.Forms;
using FacebookWrapper.ObjectModel;
using A18_Ex01_SagivAbdush_305274946__EladTruzman_300221280.FbClipSearchLogic;

namespace A18_Ex01_SagivAbdush_305274946__EladTruzman_300221280
{
    public partial class FbClipSearch : Form
    {
        private Dictionary<int, FriendPost> Clipresults;

        public FbClipSearch()
        {
            InitializeComponent();
            Clipresults = new Dictionary<int, FriendPost>();
        }

        private void button1_Click(object sender, EventArgs e)
        {
        }

        private void btnClipSearch_Click(object sender, EventArgs e)
        {        
            ClipSearchWF wf = new ClipSearchWF();
            Clipresults = wf.FriendsClipPostSResults(textBox1.Text);
            int i = 0;
            Image pb_ProfilePicture;

            dataGridViewFriends.Rows.Clear();
            dataGridViewPostComments.Rows.Clear();
            if (Clipresults.Count > 0)
            {
                foreach (int key in Clipresults.Keys)
                {
                    if (!string.IsNullOrEmpty(Clipresults[key].FriendName) &&
                        !string.IsNullOrEmpty(Clipresults[key].Name))
                    {
                        if (Clipresults[key].FriendImage != null)
                        {
                            pb_ProfilePicture = Clipresults[key].FriendImage;
                            dataGridViewFriends.Rows.Insert(i, Clipresults[key].FriendName, Clipresults[key].Name, pb_ProfilePicture);
                        }
                        else
                        {
                            dataGridViewFriends.Rows.Insert(i, Clipresults[key].FriendName, Clipresults[key].Name, null);
                        }

                    i++;
                    }
                }
            }

            foreach (DataGridViewRow row in dataGridViewFriends.Rows)
            {
                row.Height = 52;
            }
        }

        private void dataGridViewFriends_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int row = e.RowIndex;
            int i = 0;
            int lineBreaking = 60;
            Uri clipLinkToPlay = new Uri(Clipresults[row].ClipURL);

            webBrowser1.Url = clipLinkToPlay;
            if (Clipresults[row].PostedDateTime != null)
            {
                lbl_PostDateToFill.Text = Clipresults[row].PostedDateTime.ToString();
            }

            if (Clipresults[row].LikedBy != null)
            {
                lbl_LikesToFill.Text = Clipresults[row].LikedBy.Count.ToString();
            }

            if (Clipresults[row].PostDescription != null)
            {
                while (lineBreaking < Clipresults[row].PostDescription.Length)
                {
                    Clipresults[row].PostDescription = Clipresults[row].PostDescription.Insert(lineBreaking, Environment.NewLine);
                    lineBreaking += 60;
                }

                lbl_PostDescriptionToFill.Text = Clipresults[row].PostDescription;
            }

            foreach (Comment comment in Clipresults[row].Comments)
            {
                if(comment != null)
                {
                    dataGridViewPostComments.Rows.Insert(i, comment.CreatedTime, comment.Message, comment.LikedBy.Count);
                    i++;
                }
            }
        }

        private void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
        }

        private void FbClipSearch_Load(object sender, EventArgs e)
        {
        }

        private void dataGridViewPostComments_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }
    }
}
