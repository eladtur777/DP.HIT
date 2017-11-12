using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FacebookWrapper.ObjectModel;
using FacebookWrapper;

namespace A18_Ex01_SagivAbdush_305274946__EladTruzman_300221280.FbTripAdvisorLogic
{
   public class FriendPosts
    {

        private string m_FriendId;
        private string m_PictureUrl;
        private string m_PostDescription;
        private string m_Place;
        private string m_Name;
        private string m_Message;
        private FacebookObjectCollection<Comment> m_FriendComments;
        private DateTime m_PostedDateTime;
        private FacebookObjectCollection<User> m_LikedBy;

        public FriendPosts()
        {
            m_FriendId = string.Empty;
            m_PictureUrl = string.Empty;
            m_Place = string.Empty;
            m_PostDescription = string.Empty;
            m_Name = string.Empty;
            m_Message = string.Empty;
            m_FriendComments = new FacebookObjectCollection<Comment>();
            m_LikedBy = new FacebookObjectCollection<User>();
       
       
        }

        public string PictureUrl { get => m_PictureUrl; set => m_PictureUrl = value; }
        public string PostDescription { get => m_PostDescription; set => m_PostDescription = value; }
        public string Place { get => m_Place; set => m_Place = value; }
        public string Name { get => m_Name; set => m_Name = value; }
        public string Message { get => m_Message; set => m_Message = value; }
        public string FriendId { get => m_FriendId; set => m_FriendId = value; }
        public FacebookObjectCollection<Comment> FriendComments { get => m_FriendComments; set => m_FriendComments = value; }
        public DateTime PostedDateTime { get => m_PostedDateTime; set => m_PostedDateTime = value; }
        public FacebookObjectCollection<User> LikedBy { get => m_LikedBy; set => m_LikedBy = value; }
    }
}
