using System;
using System.Collections.Generic;
using System.Windows.Forms;
using FacebookWrapper;
using A18_Ex01_SagivAbdush_305274946__EladTruzman_300221280.MainFormLogic;
using System.ComponentModel;
using System.Threading;
using System.Threading.Tasks;

namespace A18_Ex01_SagivAbdush_305274946__EladTruzman_300221280
{
    public partial class MainForm : Form
    {
        private MainFormWF MainFormWF;
        private Dictionary<GeneralEnum.eUserBasicDetails, string> m_UserBasicDetails;
        
        public MainForm()
        {
            InitializeComponent();
            MainFormWF = new MainFormWF();
            m_UserBasicDetails = new Dictionary<GeneralEnum.eUserBasicDetails, string>();
            FacebookService.s_CollectionLimit = 50;
            FacebookService.s_FbApiVersion = 2.8f;
            chooseAppId();
             
        }
        private void chooseAppId()
        {
            ////personal App ID
            comboBoxAppID.Items.Add("175713159647920");
            ////Desig Pattern App ID
            comboBoxAppID.Items.Add("1450160541956417");
            comboBoxAppID.SelectedIndex = 0;
        }

        private void fillTabs()
        {
            dataGridViewMusic.DataSource = MainFormWF.GetUserMusic();
            for (int i = 7; i < dataGridViewMusic.Columns.Count; i++)
            {
                dataGridViewMusic.Columns[i].Visible = false;
            }

            dataGridViewBooks.DataSource = MainFormWF.GetUserBooks();          
            dataGridViewMovies.DataSource = MainFormWF.GetUserMovies();
            dataGridViewFriends.DataSource = MainFormWF.GetUserFriends();
        }

        private void loadUserDetailsLabelsToScreen()
        {
            m_UserBasicDetails = MainFormWF.GetUserBasicDetails();
            string name = Enum.GetName(typeof(GeneralEnum.eUserBasicDetails),
            GeneralEnum.eUserBasicDetails.UserImage);

            foreach (var key in m_UserBasicDetails.Keys)
            {
                switch (key)
                {
                    case GeneralEnum.eUserBasicDetails.UserImage:
                        userImageProfile.LoadAsync(m_UserBasicDetails[key]);
                        break;
                    case GeneralEnum.eUserBasicDetails.FirstName:
                        lblUserFirstName.Text = m_UserBasicDetails[key];
                        break;
                    case GeneralEnum.eUserBasicDetails.LastName:
                        lblUserLastName.Text = m_UserBasicDetails[key];
                        break;
                    case GeneralEnum.eUserBasicDetails.Birthday:
                        lblUserBirthDate.Text = m_UserBasicDetails[key];
                        break;
                    case GeneralEnum.eUserBasicDetails.Gender:
                        lblUserGender.Text = m_UserBasicDetails[key];
                        break;
                    case GeneralEnum.eUserBasicDetails.Religion:
                        lblUserReligion.Text = m_UserBasicDetails[key];
                        break;
                    case GeneralEnum.eUserBasicDetails.Email:
                        lblUserEmail.Text = m_UserBasicDetails[key];
                        break;
                    case GeneralEnum.eUserBasicDetails.PostMessage:
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
            btnClipSearch.Enabled = true;
            btnTripAdvisor.Enabled = true;
           // loginBtn.Enabled = false;
        }

        public void RunProgressBar()
        {                
            if (!backgroundWorker.IsBusy)
            {
                  loginBtn.Enabled = false;
                backgroundWorker.RunWorkerAsync();
                backgroundWorker.WorkerReportsProgress = true;
                backgroundWorker.DoWork += new DoWorkEventHandler(backgroundWorker_DoWork);
                backgroundWorker.ProgressChanged += new ProgressChangedEventHandler(backgroundWorker_ProgressChanged);
            }
        }


        private void loginBtn_Click(object sender, EventArgs e)
        {       
            if (!string.IsNullOrEmpty(comboBoxAppID.SelectedText))
            {
                RunProgressBar();
                string result = MainFormWF.InitializeFaceBookLogin(comboBoxAppID.SelectedText);
                if (string.IsNullOrEmpty(result))
                {
                    loadUserDetailsLabelsToScreen();
                    fillTabs();
                }
                else
                {
                    MessageBox.Show(result);
                }
            }
            else
            {
                
                MessageBox.Show("Please select App Id");
                loginBtn.Enabled = true;
            }
        }

        private void resetForm()
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
            btnClipSearch.Enabled = false;
            btnTripAdvisor.Enabled = false;
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
            FbTripAdvisorForm tripAdvisorForm = new FbTripAdvisorForm();
            tripAdvisorForm.ShowDialog();
        }

        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (UserLoginInstance.LoggedInUser != null)
            {
                try
                {
                    progressBar.Visible = true;
                    loginBtn.Enabled = true;
                    FacebookService.Logout(null);
                 
                }
                catch (Exception)
                {
                    MessageBox.Show("LogOut problem, please Exit from App");
                }
            }
        }

        private void successLogOut()
        {
            // MessageBox.Show("Successfuly Logout from App");
            resetForm();
        }
  
        private void btnClipSearch_Click(object sender, EventArgs e)
        {
            FbClipSearch m_clipSearchForm = new FbClipSearch();
            m_clipSearchForm.ShowDialog();         
        }

        private void logOutBtn_Click(object sender, EventArgs e)
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
                        FacebookService.Logout(successLogOut);
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("LogOut problem, please Exit from App");
                    }
                }
            }
        }

        private void logOutBtn_MouseHover(object sender, EventArgs e)
        {
            ToolTip toolTipForLogOutImgBtn = new ToolTip();
            toolTipForLogOutImgBtn.SetToolTip(this.LogOutBtn, "Log-Out");
        }

        private void backgroundWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            backgroundWorker.DoWork -= new DoWorkEventHandler(backgroundWorker_DoWork);
            backgroundWorker.ProgressChanged -= new ProgressChangedEventHandler(backgroundWorker_ProgressChanged);

            for (int i = 0; i < 100 ; i++)
            {
                backgroundWorker.ReportProgress(i);
                Thread.Sleep(10);
            }

        }

        private void backgroundWorker_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            if (e.ProgressPercentage < 100)
            {
                progressBar.Value = e.ProgressPercentage;
            }
            else
            {
                progressBar.Value = 0;
            }

        }

        private void backgroundWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            progressBar.Value = 100;
            Thread.Sleep(100);
            progressBar.Visible = false;
        }
    }
}