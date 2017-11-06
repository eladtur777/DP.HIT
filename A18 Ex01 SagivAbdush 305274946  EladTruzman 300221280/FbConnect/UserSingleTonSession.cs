﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FacebookWrapper.ObjectModel;
using FacebookWrapper;

namespace A18_Ex01_SagivAbdush_305274946__EladTruzman_300221280
{
    public class UserSingleTonSession
    {
        
        public User m_LoggedInUser;
        private static UserSingleTonSession m_Instance;
        private string m_ErrorMessageResult = string.Empty;
        public string ErrorMessageResult
        {
            get
            {
                return this.m_ErrorMessageResult;
            }
            set
            {
                this.m_ErrorMessageResult = value;
            }
        }

        private UserSingleTonSession()
        { }

        public static UserSingleTonSession Instance
        {
            get
            {
                if (m_Instance == null)
                {
                    m_Instance = new UserSingleTonSession();
                }

                return m_Instance;
            }
        }

        public LoginResult LogInResult { get; set; }
        public void initializeFaceBookLoginPermissions()
        {
            /// Owner: design.patterns

            /// Use the FacebookService.Login method to display the login form to any user who wish to use this application.
            /// You can then save the result.AccessToken for future auto-connect to this user:
             LogInResult = FacebookService.Login("175713159647920", /// (desig patter's "Design Patterns Course App 2.4" app)
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


            if (!string.IsNullOrEmpty(LogInResult.AccessToken))
            {
               
                m_LoggedInUser = LogInResult.LoggedInUser;
            }
            if(!string.IsNullOrEmpty(LogInResult.ErrorMessage) && LogInResult.ErrorMessage != " ()")
            {
                ErrorMessageResult =  LogInResult.ErrorMessage;
            }
          
        }

    }
}
