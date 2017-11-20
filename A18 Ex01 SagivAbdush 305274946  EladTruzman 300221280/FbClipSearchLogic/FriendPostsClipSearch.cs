using FacebookWrapper.ObjectModel;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace A18_Ex01_SagivAbdush_305274946__EladTruzman_300221280.FbClipSearchLogic
{
    public class FriendPostsClipSearch
    {
        private string m_FriendId;
        private Image m_FriendImage;
        private string m_PostDescription;
        private string m_Name;
        private string m_Message;
        private string m_FriendName;
        private string m_ClipURL;
        private FacebookObjectCollection<Comment> m_FriendComments;
        private DateTime m_PostedDateTime;
        private FacebookObjectCollection<User> m_LikedBy;

        public FriendPostsClipSearch()
        {
            m_FriendId = string.Empty;
            m_PostDescription = string.Empty;
            m_Name = string.Empty;
            m_Message = string.Empty;
            m_FriendComments = new FacebookObjectCollection<Comment>();
            m_LikedBy = new FacebookObjectCollection<User>();
        }

        public void updateValues(string i_FriendId,
            DateTime i_DatePost,
            Image i_FriendImage,
            string i_FriendName,
            string i_PostDescription,
            string i_Name,
            string i_Message,
            string i_YoutubeURL,
            FacebookObjectCollection<Comment> i_FriendComments,
            FacebookObjectCollection<User> i_LikeBy
            )
        {
            m_PostedDateTime = i_DatePost;
            m_FriendId = i_FriendId;
            m_FriendImage = i_FriendImage;
            m_PostDescription = i_PostDescription;
            m_Name = i_Name;
            m_FriendName = i_FriendName;
            m_Message = i_Message;
            m_ClipURL = i_YoutubeURL;
            m_FriendComments = i_FriendComments;
            m_LikedBy = i_LikeBy;
        }


        public FacebookObjectCollection<Comment> FriendComments { get { return m_FriendComments; } set { m_FriendComments = value; } }
        public DateTime PostedDateTime { get { return m_PostedDateTime; } set { m_PostedDateTime = value; } }
        public FacebookObjectCollection<User> LikedBy { get { return m_LikedBy; } set { m_LikedBy = value; } }

        public FacebookObjectCollection<Comment> Comments { get { return m_FriendComments; } set { m_FriendComments = value; } }
        public Image FriendImage { get { return m_FriendImage; } set { m_FriendImage = value; } }
        public string PostDescription { get { return m_PostDescription; } set { m_PostDescription = value; } }
        public string Name { get { return m_Name; } set { m_Name = value; } }
        public string Message { get { return m_Message; } set { m_Message = value; } }
        public string FriendId { get { return m_FriendId; } set { m_FriendId = value; } }
        public string FriendName { get { return m_FriendName; } set { m_FriendName = value; } }
        public string ClipURL { get { return m_ClipURL; } set { m_ClipURL = value; } }
    }
}

