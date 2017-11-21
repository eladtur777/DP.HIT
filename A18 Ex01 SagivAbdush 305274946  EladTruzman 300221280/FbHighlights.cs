using FacebookWrapper;
using FacebookWrapper.ObjectModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace A18_Ex01_SagivAbdush_305274946__EladTruzman_300221280
{
    public partial class FbHighlights : Form
    {
        FacebookObjectCollection<Page> m_Friends;
        FacebookObjectCollection<Photo> m_Photos;
        FacebookObjectCollection<PhotoTag> m_PhotosTaggedIn;
        
        public FbHighlights()
        {
            InitializeComponent();
            m_Photos = FacebookService.GetCollection<Photo>(GeneralEnum.E_MainTabType.books.ToString());
            m_Friends = FacebookService.GetCollection<Page>(GeneralEnum.E_MainTabType.friends.ToString());
           // m_PhotosTaggedIn = FacebookService.GetCollection<PhotoTag>(GeneralEnum.E_MainTabType.PhotosTaggedIn.ToString());
            int max = -1;
            List<Image> img = new List<Image>();
            foreach (Photo photo in m_Photos)
            {
                if(photo.LikedBy.Count > max)
                {
                    max = photo.LikedBy.Count;
                    img.Clear();
                    img.Add(photo.ImageNormal);
                }
                else if(photo.LikedBy.Count == max)
                {
                    img.Add(photo.ImageNormal);
                }
            }
            this.picbox_MostLikedPhoto.Image = img[0];
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void cbk_TaggedPhotos_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void FbHighlights_Load(object sender, EventArgs e)
        {

        }

        private void lbl_FriendPhotosLike_Click(object sender, EventArgs e)
        {

        }
    }
}
