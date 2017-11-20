using System;
using A18_Ex01_SagivAbdush_305274946__EladTruzman_300221280.FbClipSearchLogic;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using FacebookWrapper.ObjectModel;

namespace A18_Ex01_SagivAbdush_305274946__EladTruzman_300221280
{
    public partial class FbClipSearch : Form
    {
        private Dictionary<int, FriendPostsClipSearch> Clipresults;

        public FbClipSearch()
        {
            InitializeComponent();
            Clipresults = new Dictionary<int, FriendPostsClipSearch>();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
        }

        private void btnClipSearch_Click(object sender, EventArgs e)
        {        
            ClipSearchWF wf = new ClipSearchWF();
            Clipresults = wf.FriendsClipPostSResults(textBox1.Text);
            int i = 0;
            int lineBreaking = 60;
            Image pb_ProfilePicture;

            dataGridViewFriends.Rows.Clear();
            dataGridViewPostComments.Rows.Clear();
            if (Clipresults.Count > 0)
            {
                foreach (int key in Clipresults.Keys)
                {

                    if (!string.IsNullOrEmpty(Clipresults[key].FriendName))
                    {
                        pb_ProfilePicture = Clipresults[key].FriendImage;
                       // pb_ProfilePicture.Image = Clipresults[key].FriendImage;
                       dataGridViewFriends.Rows.Insert(i, Clipresults[key].FriendName, Clipresults[key].Name, pb_ProfilePicture);
                        lbl_PostDateToFill.Text = Clipresults[key].PostedDateTime.ToString();
                        lbl_LikesToFill.Text = Clipresults[key].LikedBy.Count.ToString();
                        while(lineBreaking < Clipresults[key].PostDescription.Length)
                        {
                            Clipresults[key].PostDescription = Clipresults[key].PostDescription.Insert(lineBreaking, Environment.NewLine);
                            lineBreaking += 60;
                        }
                        lbl_PostDescriptionToFill.Text = Clipresults[key].PostDescription;
                        //dataGridViewMoreDetails.Rows.Insert(i, Clipresults[key].PostedDateTime, Clipresults[key].LikedBy.Count);
                        i++;
                        // Uri uu = new Uri(Clipresults[key].ClipURL);
                        //webBrowser1.Url = uu;
                    }
                    if (!string.IsNullOrEmpty(Clipresults[key].Name))
                    {

                        // Uri uu = new Uri(Clipresults[key].ClipURL);
                        //webBrowser1.Url = uu;
                    }
                    if (Clipresults[key].FriendImage != null)
                    {

                        // Uri uu = new Uri(Clipresults[key].ClipURL);
                        //webBrowser1.Url = uu;
                    }


                }
                foreach (DataGridViewRow row in dataGridViewFriends.Rows)
                {
                    row.Height = 52;
                }


            }
        }

        private void dataGridViewFriends_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int row = e.RowIndex;
            int i = 0;
            Uri uu = new Uri(Clipresults[row].ClipURL);

            webBrowser1.Url = uu;
            lbl_PostDateToFill.Text = Clipresults[row].PostedDateTime.ToString();
            lbl_LikesToFill.Text = Clipresults[row].LikedBy.Count.ToString();
            foreach(Comment comment in Clipresults[row].Comments)
            {
                if(comment != null)
                {
                    dataGridViewPostComments.Rows.Insert(i, comment.CreatedTime, comment.Message, comment.LikedBy.Count);
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
