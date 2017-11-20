using System.Drawing;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using FacebookWrapper.ObjectModel;
using FacebookWrapper;

namespace A18_Ex01_SagivAbdush_305274946__EladTruzman_300221280.FbTripAdvisorLogic
{
    public class TripAdvisorDAL
    {
        private FriendPosts FriendPostsToFill;
        private List<PictureBox> m_FriendsImageList = new List<PictureBox>();
        private List<Point> points = new List<Point>();
        private Dictionary<int, FriendPosts> m_FriendPostsList = new Dictionary<int, FriendPosts>(50);
        private PictureBox m_SingleImage = new PictureBox();
        private Dictionary<int, Image> m_FriendsPhotosTaggedIn = new Dictionary<int, Image>();
        private Dictionary<string, Image> m_FriendsPlacesPictures;

        public Dictionary<string, Image> FriendsPlacesPictures
        {
            get { return m_FriendsPlacesPictures; }
        }

        public Dictionary<int, Image> FriendsPhotosTaggedIn
        {
            get { return m_FriendsPhotosTaggedIn; }
        }

        public Dictionary<int, FriendPosts> FriendPostsList
        {
            get { return m_FriendPostsList; }
        }

        public Dictionary<string, Image> FriendsPlacesBySpecificLocation(LocationSearch i_LocationList)
        {
            m_FriendsPlacesPictures = new Dictionary<string, Image>();
            FacebookObjectCollection<Page> friends = FacebookService.GetCollection<Page>(GeneralEnum.eMainTabType.friends.ToString());
            dynamic actionsDataFriends = FacebookService.GetDynamicData(GeneralEnum.eMainTabType.friends.ToString());
            FacebookObjectCollection<Post> friendsPost;
            m_FriendPostsList.Clear();
            int innerIndex = 0;

            try
            {
                for (int i = 0; i < friends.Count; i++)
                {
                    friendsPost = friends[i].Posts;
                    bool isAllreadyIn = true;
                    string locationPlace = i_LocationList.General;
                    List<string> WordsList = new List<string>();
                    char[] delimiterChars = { ' ', ',', '.', '\t', '-', '_' };
                    string[] words = locationPlace.Split(delimiterChars);
                    for (int j = 0; j < friendsPost.Count; j++)
                    {
                        if (friendsPost[j].Place != null)
                        {
                            for (int k = 0; k < words.Length && isAllreadyIn; k++)
                            {
                                if (!string.IsNullOrEmpty(words[k]))
                                {
                                    if (friendsPost[j].Place.Name.ToUpper().Contains(words[k].ToUpper()))
                                    {
                                        isAllreadyIn = false;
                                        ////Fill friends profile image list 
                                        m_FriendsPlacesPictures.Add(friends[i].Name, friends[i].ImageSquare);
                                        FriendPostsToFill = new FriendPosts();
                                        FriendPostsToFill.FriendId = friends[i].Id;
                                        FriendPostsToFill.FriendComments = friendsPost[j].Comments;
                                        FriendPostsToFill.LikedBy = friendsPost[j].LikedBy;
                                        FriendPostsToFill.Message = friendsPost[j].Message;
                                        FriendPostsToFill.Name = friendsPost[j].Name;
                                        FriendPostsToFill.PictureUrl = friendsPost[j].PictureURL;
                                        FriendPostsToFill.Place = friendsPost[j].Place.Name;
                                        FriendPostsToFill.PostDescription = friendsPost[j].Description;
                                        FriendPostsToFill.PostedDateTime = friendsPost[j].CreatedTime.Value;
                                        m_FriendPostsList.Add(innerIndex, FriendPostsToFill);
                                        innerIndex++;
                                    }
                                }
                            }
                        }
                    }
                }
            }
            catch (Exception)
            {
                m_FriendsPlacesPictures = null;             
                return m_FriendsPlacesPictures;
            }
            
            return m_FriendsPlacesPictures;
        }
        }
}