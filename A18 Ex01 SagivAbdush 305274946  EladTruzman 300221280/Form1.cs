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
        public Form1()
        {
            InitializeComponent();
            FacebookWrapper.FacebookService.s_CollectionLimit = 200;
            FacebookWrapper.FacebookService.s_FbApiVersion = 2.8f;
        }

        User m_LoggedInUser;

        private void initializeFaceBookLoginScreen()
        {
            /// Owner: design.patterns

            /// Use the FacebookService.Login method to display the login form to any user who wish to use this application.
            /// You can then save the result.AccessToken for future auto-connect to this user:
            LoginResult result = FacebookService.Login("1450160541956417", /// (desig patter's "Design Patterns Course App 2.4" app)
                "public_profile",
                "user_education_history",
                "user_birthday",
                "user_actions.video",
                "user_actions.news",
                "user_actions.music",
                "user_actions.fitness",
                "user_actions.books",
                "user_about_me",
                "user_friends",
                "publish_actions",
                "user_events",
                "user_games_activity",
                //"user_groups" (This permission is only available for apps using Graph API version v2.3 or older.)
                "user_hometown",
                "user_likes",
                "user_location",
                "user_managed_groups",
                "user_photos",
                "user_posts",
                "user_relationships",
                "user_relationship_details",
                "user_religion_politics",

                //"user_status" (This permission is only available for apps using Graph API version v2.3 or older.)
                "user_tagged_places",
                "user_videos",
                "user_website",
                "user_work_history",
                "read_custom_friendlists",

                // "read_mailbox", (This permission is only available for apps using Graph API version v2.3 or older.)
                "read_page_mailboxes",
                // "read_stream", (This permission is only available for apps using Graph API version v2.3 or older.)
                // "manage_notifications", (This permission is only available for apps using Graph API version v2.3 or older.)
                "manage_pages",
                "publish_pages",
                "publish_actions",

                "rsvp_event"
                );
            // These are NOT the complete list of permissions. Other permissions for example:
            // "user_birthday", "user_education_history", "user_hometown", "user_likes","user_location","user_relationships","user_relationship_details","user_religion_politics", "user_videos", "user_website", "user_work_history", "email","read_insights","rsvp_event","manage_pages"
            // The documentation regarding facebook login and permissions can be found here: 
            // https://developers.facebook.com/docs/facebook-login/permissions#reference


            if (!string.IsNullOrEmpty(result.AccessToken))
            {
                m_LoggedInUser = result.LoggedInUser;
                userImageProfile.LoadAsync(m_LoggedInUser.PictureNormalURL);
                if (m_LoggedInUser.Posts.Count > 0)
                {
                    textBoxLatestPost.Text = m_LoggedInUser.Posts[0].Message;
                }

                loadUserDetailsLabelsToScreen();
                fillTabs();
                
               // FacebookObjectCollection<Page> actions = FacebookService.GetCollection<Page>(actionType);
               // dynamic actionsData = FacebookService.GetDynamicData(actionType);
               // listViewUserDetails.Items = actions;
               


            }
            else
            {
                MessageBox.Show(result.ErrorMessage);
            }


        }

        public enum E_TabType { music = 1, television, movies, books};
            
        

        


        private void fillTabs()
        {
            string tt = E_TabType.music.ToString();
            FacebookObjectCollection<Page> actions = FacebookService.GetCollection<Page>(tt);
            dynamic actionsData = FacebookService.GetDynamicData(tt);
            dataGridViewMusic.DataSource = actions;

        }



        private void loadUserDetailsLabelsToScreen()
        {
            lblUserFirstName.Text = m_LoggedInUser.FirstName;
            lblUserLastName.Text = m_LoggedInUser.LastName;
            lblUserBirthDate.Text = m_LoggedInUser.Birthday;
            lblUserGender.Text = m_LoggedInUser.Gender.ToString();
            lblUserReligion.Text = m_LoggedInUser.Religion;
            lblUserEmail.Text = m_LoggedInUser.Email;

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


        private void loginBtn_Click(object sender, EventArgs e)
        {
            initializeFaceBookLoginScreen();
        }

        private void userImageProfile_Click(object sender, EventArgs e)
        {

        }

        private void listViewUserDetails_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
