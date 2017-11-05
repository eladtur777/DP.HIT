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
        public enum E_TabType { music = 1, television, movies, books, friends };


        public Form1()
        {
            InitializeComponent();
            FacebookWrapper.FacebookService.s_CollectionLimit = 200;
            FacebookWrapper.FacebookService.s_FbApiVersion = 2.8f;
        }

        private void fillTabs()
        {
            FacebookObjectCollection<Page> music = FacebookService.GetCollection<Page>(E_TabType.music.ToString());
            dynamic actionsDataMusic = FacebookService.GetDynamicData(E_TabType.music.ToString());
            dataGridViewMusic.DataSource = music;

            for(int i = 7 ; i < dataGridViewMusic.Columns.Count; i++)
            {
                dataGridViewMusic.Columns[i].Visible = false;
            }

            FacebookObjectCollection<Page> books = FacebookService.GetCollection<Page>(E_TabType.books.ToString());
            dynamic actionsDataBooks = FacebookService.GetDynamicData(E_TabType.books.ToString());
            dataGridViewBooks.DataSource = books;

            //for (int i = 7; i < dataGridViewBooks.Columns.Count; i++)
            //{
            //    dataGridViewBooks.Columns[i].Visible = false;
            //}

            FacebookObjectCollection<Page> movies = FacebookService.GetCollection<Page>(E_TabType.movies.ToString());
            dynamic actionsDataMovies = FacebookService.GetDynamicData(E_TabType.movies.ToString());
            dataGridViewMovies.DataSource = movies;

            //for (int i = 7; i < dataGridViewMovies.Columns.Count; i++)
            //{
            //    dataGridViewMovies.Columns[i].Visible = false;
            //}

            FacebookObjectCollection<Page> friends = FacebookService.GetCollection<Page>(E_TabType.friends.ToString());
            dynamic actionsDataFriends = FacebookService.GetDynamicData(E_TabType.friends.ToString());
            dataGridViewFriends.DataSource = friends;

            //for (int i = 7; i < dataGridViewFriends.Columns.Count; i++)
            //{
            //    dataGridViewFriends.Columns[i].Visible = false;
            //}

      
           

          
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
            btnPostPublish.Enabled = true;
            textBoxPostPublish.Enabled = true;
            lblUserFirstName.Text = UserSingleTonSession.Instance.m_LoggedInUser.FirstName;
            lblUserLastName.Text = UserSingleTonSession.Instance.m_LoggedInUser.LastName;
            lblUserBirthDate.Text = UserSingleTonSession.Instance.m_LoggedInUser.Birthday;
            lblUserGender.Text = UserSingleTonSession.Instance.m_LoggedInUser.Gender.ToString();
            lblUserReligion.Text = UserSingleTonSession.Instance.m_LoggedInUser.Religion;
            lblUserEmail.Text = UserSingleTonSession.Instance.m_LoggedInUser.Email;
            lblLatestPost.Text = UserSingleTonSession.Instance.m_LoggedInUser.Posts[0].Message;

            label1.Visible = true;
            label2.Visible = true;
            label3.Visible = true;
            label4.Visible = true;
            label5.Visible = true;
            label6.Visible = true;
            label7.Visible = true;

            lblUserFirstName.Visible = true;
            lblUserLastName.Visible = true;
            lblUserBirthDate.Visible = true;
            lblUserEmail.Visible = true;
            lblUserGender.Visible = true;
            lblUserReligion.Visible = true;
            lblLatestPost.Visible = true;
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

        private void LogOutBtn_Click(object sender, EventArgs e)
        {
            DialogResult resultFromLogoutDialog = MessageBox.Show("Are you sure you want to LogOut and Exit?",
           "Important Question",
            MessageBoxButtons.YesNo);

            if (resultFromLogoutDialog == DialogResult.Yes)
            {
                UserSingleTonSession.Instance.logOut();
                ResetForm();
                Close();
            }

      
        }

        private void ResetForm()
        {
            userImageProfile.LoadAsync();
            textBoxPostPublish.Enabled = false;
            lblUserFirstName.Text = string.Empty;
            lblUserLastName.Text = string.Empty;
            lblUserBirthDate.Text = string.Empty;
            lblUserGender.Text = string.Empty;
            lblUserReligion.Text = string.Empty;
            lblUserEmail.Text = string.Empty;
            lblLatestPost.Text = string.Empty;
            label1.Visible = false;
            label2.Visible = false;
            label3.Visible = false;
            label4.Visible = false;
            label5.Visible = false;
            label6.Visible = false;
            label7.Visible = false;
            lblUserFirstName.Visible = false;
            lblUserLastName.Visible = false;
            lblUserBirthDate.Visible = false;
            lblUserEmail.Visible = false;
            lblUserGender.Visible = false;
            lblUserReligion.Visible = false;
            lblLatestPost.Visible = false;
            btnPostPublish.Enabled = false;
            dataGridViewMusic.DataSource = null;
        }

        private void LogOutBtn_MouseHover(object sender, EventArgs e)
        {
          
            ToolTip toolTipForLogOutImgBtn = new ToolTip();
            toolTipForLogOutImgBtn.SetToolTip(this.LogOutBtn, "Log-Out");
        }

        private void btnPostPublish_Click(object sender, EventArgs e)
        {
            if (textBoxPostPublish.Text != string.Empty)
            {
                try
                {
                    UserSingleTonSession.Instance.m_LoggedInUser.PostStatus(textBoxPostPublish.Text);
                    MessageBox.Show("successfully Posted to your wall on FaceBook");
                    lblLatestPost.Text = textBoxPostPublish.Text; 
                }
                catch (Exception ePost)
                {
                    MessageBox.Show(string.Format("Faild on Post to your wall:{0}", ePost.Message));
                }
            }

        }
    }
}
