using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FacebookWrapper.ObjectModel;

namespace A18_Ex01_SagivAbdush_305274946__EladTruzman_300221280.FbClipSearchLogic
{
    public class ClipSearchWF
    {
        public Dictionary<int, FriendPost> FriendsClipPostSResults(string i_TitleToSearch)
        {
            ClipSearchDAL FriendsClipPost = new ClipSearchDAL();
            return FriendsClipPost.GetRelatedPosts(i_TitleToSearch);
        }
    }
}
