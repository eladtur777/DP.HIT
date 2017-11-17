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
using A18_Ex01_SagivAbdush_305274946__EladTruzman_300221280.MainFormLogic;


namespace A18_Ex01_SagivAbdush_305274946__EladTruzman_300221280
{
    public partial class MainForm : Form
    {

        private MainFormWF MainFormWF;
        Dictionary<GeneralEnum.E_UserBasicDetails, string> m_UserBasicDetails;

        public enum E_TabType { music = 1, television, movies, books, friends };


        public MainForm()
        {
            InitializeComponent();
            MainFormWF = new MainFormWF();
            m_UserBasicDetails = new Dictionary<GeneralEnum.E_UserBasicDetails, string>();
             FacebookWrapper.FacebookService.s_CollectionLimit = 50;
            //FacebookWrapper.FacebookService.s_FbApiVersion = 2.8f;
        }

        private void fillTabs()
        {
            dataGridViewMusic.DataSource = MainFormWF.GetUserMusic();

            for (int i = 7; i < dataGridViewMusic.Columns.Count; i++)
            {
                dataGridViewMusic.Columns[i].Visible = false;
            }

            dataGridViewBooks.DataSource = MainFormWF.GetUserBooks();

            //for (int i = 7; i < dataGridViewBooks.Columns.Count; i++)
            //{
            //    dataGridViewBooks.Columns[i].Visible = false;
            //}

            dataGridViewMovies.DataSource = MainFormWF.GetUserMovies();

            //for (int i = 7; i < dataGridViewMovies.Columns.Count; i++)
            //{
            //    dataGridViewMovies.Columns[i].Visible = false;
            //}

            dataGridViewFriends.DataSource = MainFormWF.GetUserFriends();

            //for (int i = 7; i < dataGridViewFriends.Columns.Count; i++)
            //{
            //    dataGridViewFriends.Columns[i].Visible = false;
            //}
        }

        private void LoadUserDetailsLabelsToScreen()
        {
            m_UserBasicDetails = MainFormWF.GetUserBasicDetails();
            string name = Enum.GetName(typeof(GeneralEnum.E_UserBasicDetails),
            GeneralEnum.E_UserBasicDetails.UserImage);

            foreach (var key in m_UserBasicDetails.Keys)
            {
                switch (key)
                {
                    case GeneralEnum.E_UserBasicDetails.UserImage:
                        userImageProfile.LoadAsync(m_UserBasicDetails[key]);
                        break;
                    case GeneralEnum.E_UserBasicDetails.FirstName:
                        lblUserFirstName.Text = m_UserBasicDetails[key];
                        break;
                    case GeneralEnum.E_UserBasicDetails.LastName:
                        lblUserLastName.Text = m_UserBasicDetails[key];
                        break;
                    case GeneralEnum.E_UserBasicDetails.Birthday:
                        lblUserBirthDate.Text = m_UserBasicDetails[key];
                        break;
                    case GeneralEnum.E_UserBasicDetails.Gender:
                        lblUserGender.Text = m_UserBasicDetails[key];
                        break;
                    case GeneralEnum.E_UserBasicDetails.Religion:
                        lblUserReligion.Text = m_UserBasicDetails[key];
                        break;
                    case GeneralEnum.E_UserBasicDetails.Email:
                        lblUserEmail.Text = m_UserBasicDetails[key];
                        break;
                    case GeneralEnum.E_UserBasicDetails.PostMessage:
                        lblLatestPost.Text = m_UserBasicDetails[key];
                        break;
                }
            }

            btnPostPublish.Enabled = true;
            textBoxPostPublish.Enabled = true;
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
            string result = MainFormWF.InitializeFaceBookLogin();
            if (string.IsNullOrEmpty(result))
            {
                LoadUserDetailsLabelsToScreen();
                fillTabs();
            }
            else
            {
                MessageBox.Show(result);
            }
        }

        private void LogOutBtn_Click(object sender, EventArgs e)
        {
            DialogResult resultFromLogoutDialog = MessageBox.Show("Are you sure you want to LogOut and Exit?",
           "Important Question",
            MessageBoxButtons.YesNo);

            if (resultFromLogoutDialog == DialogResult.Yes)
            {


                if (UserLoginInstance.LoggedInUser != null)
                {
                    try
                    {
                        FacebookService.Logout(SuccessLogOut);
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("LogOut problem, please Exit from App");
                    }


                }




            }
        }

        private void ResetForm()
        {
            userImageProfile.Image = null;
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
                string result = MainFormWF.PublishPost(textBoxPostPublish.Text);
                if (string.IsNullOrEmpty(result))
                {
                    MessageBox.Show("successfully Posted to your wall on FaceBook");
                    lblLatestPost.Text = textBoxPostPublish.Text;
                }
                else
                {
                    MessageBox.Show(result);
                }
            }
        }

        private void btnTripAdvisor_Click(object sender, EventArgs e)
        {
            FbTripAdvisorForm ta = new FbTripAdvisorForm();
            ta.Show();
        }

        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (UserLoginInstance.LoggedInUser != null)
            {
                try
                {
                    FacebookService.Logout(null);
                }
                catch (Exception)
                {
                    MessageBox.Show("LogOut problem, please Exit from App");
                }

            }
        }

        private void SuccessLogOut()
        {
            MessageBox.Show("Succesfuly Logout from App");

        }

     

        private void button2_Click(object sender, EventArgs e)
        {
            FbClipSearch nn = new FbClipSearch();
            nn.Show();
        }
    }
}
