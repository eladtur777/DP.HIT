using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using FacebookWrapper.ObjectModel;
using FacebookWrapper;

namespace A18_Ex01_SagivAbdush_305274946__EladTruzman_300221280
{
    public partial class Form1 : Form
    {
        public enum E_TabType { music = 1, television, movies, books };


        public Form1()
        {
            InitializeComponent();
            FacebookWrapper.FacebookService.s_CollectionLimit = 200;
            FacebookWrapper.FacebookService.s_FbApiVersion = 2.8f;
        }

        private void fillTabs()
        {
            string tt = E_TabType.music.ToString();
            FacebookObjectCollection<Page> music = FacebookService.GetCollection<Page>(tt);
            dynamic actionsData = FacebookService.GetDynamicData(tt);
            dataGridViewMusic.DataSource = music;

            // m_LoggedInUser = result.LoggedInUser;


            //if (m_LoggedInUser.FriendLists.Count > 0)
            //{
            //    for(int i =0;i< m_LoggedInUser.FriendLists.Count;i++)
            //    {
            //        string rr = m_LoggedInUser.FriendLists[0].Name;
            //    }
            //    // textBoxLatestPost.Text = m_LoggedInUser.Posts[0].Message;
            //}

            //            FB.api(
            //    '/me',
            //    'GET',
            //  { "fields":"friends{name,tagged_places{place}}"},
            //  function(response) {
            //                // Insert your code here
            //            }
            //);
            // string ff = "i_Fields:friends{name,tagged_places{place}";
            // FacebookObjectCollection<User> friends = FacebookService.GetCollection<User>(ff);

            // for (int i=0; i< friends.Count; i++)
            // {

            //     if (friends[i].PhotosTaggedIn[i].Place.Location.State == "Israel")
            //     {
            //         string hh = friends[i].PhotosTaggedIn[i].Place.Location.State;
            //     }
            // }
            //// dynamic friendsList = FacebookService.GetDynamicData(ff);
            ///// int ttt = 0;




        }



        private void loadUserDetailsLabelsToScreen()
        {
            userImageProfile.LoadAsync(UserSingleTonSession.Instance.m_LoggedInUser.PictureNormalURL);
            lblUserFirstName.Text = UserSingleTonSession.Instance.m_LoggedInUser.FirstName;
            lblUserLastName.Text = UserSingleTonSession.Instance.m_LoggedInUser.LastName;
            lblUserBirthDate.Text = UserSingleTonSession.Instance.m_LoggedInUser.Birthday;
            lblUserGender.Text = UserSingleTonSession.Instance.m_LoggedInUser.Gender.ToString();
            lblUserReligion.Text = UserSingleTonSession.Instance.m_LoggedInUser.Religion;
            lblUserEmail.Text = UserSingleTonSession.Instance.m_LoggedInUser.Email;

            label1.Visible = true;
            label2.Visible = true;
            label3.Visible = true;
            label4.Visible = true;
            label5.Visible = true;
            label6.Visible = true;

            lblUserFirstName.Visible = true;
            lblUserLastName.Visible = true;
            lblUserBirthDate.Visible = true;
            lblUserEmail.Visible = true;
            lblUserGender.Visible = true;
            lblUserReligion.Visible = true;
        }


        private void listViewUserDetails_SelectedIndexChanged(object sender, EventArgs e)
        {

        }



        private void loginBtn_Click(object sender, EventArgs e)
        {
            UserSingleTonSession.Instance.initializeFaceBookLoginPermissions();
            if (UserSingleTonSession.Instance.m_LoggedInUser != null && UserSingleTonSession.Instance.m_LoggedInUser.Id != null)
            {
                loadUserDetailsLabelsToScreen();
                fillTabs();
            }

            if (!string.IsNullOrEmpty(UserSingleTonSession.Instance.ErrorMessageResult))
            {
                MessageBox.Show(UserSingleTonSession.Instance.ErrorMessageResult);
            }
        }
    }
}
