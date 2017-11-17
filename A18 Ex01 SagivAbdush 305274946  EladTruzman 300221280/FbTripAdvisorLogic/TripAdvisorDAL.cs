using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using FacebookWrapper.ObjectModel;
using FacebookWrapper;
using System.Drawing;


namespace A18_Ex01_SagivAbdush_305274946__EladTruzman_300221280.FbTripAdvisorLogic
{
    public class TripAdvisorDAL
    {
        private FriendPosts FriendPostsToFill;
        private List<PictureBox> m_FriendsImageList = new List<PictureBox>();
        List<Point> points = new List<Point>();
        private Dictionary<int,FriendPosts> m_FriendPostsList = new Dictionary<int,FriendPosts>(50);
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
        public Dictionary<int,FriendPosts> FriendPostsList
        {
            get { return m_FriendPostsList; }
        }

        public Dictionary<string, Image> FriendsPlacesBySpecificLocation(LocationSearch i_LocationList)
        {

            m_FriendsPlacesPictures = new Dictionary<string, Image>();
            FacebookObjectCollection<Page> friends = FacebookService.GetCollection<Page>(GeneralEnum.E_MainTabType.friends.ToString());
            dynamic actionsDataFriends = FacebookService.GetDynamicData(GeneralEnum.E_MainTabType.friends.ToString());
            FacebookObjectCollection<Post> friendPost;
            m_FriendPostsList.Clear();
            int innerIndex = 0;
      
            FacebookObjectCollection<Photo> photosTagedIn = new FacebookObjectCollection<Photo>();
            for (int i = 0; i < friends.Count; i++)
            {

                photosTagedIn.Add(friends[i].PhotosTaggedIn[i]);
                friendPost = friends[i].Posts;
                Boolean isAllreadyIn = true;
                string LocationPlace = i_LocationList.General;
                List<string> WordsList = new List<string>();
                char[] delimiterChars = {' ', ',', '.', '\t','-','_' };
                string[] words = LocationPlace.Split(delimiterChars);
                for (int j = 0; j < friendPost.Count; j++)
                {
                    if (friendPost[j].Place != null)
                    {
                        for(int k = 0; k < words.Length && isAllreadyIn ; k++) 
                        {
                            if (!string.IsNullOrEmpty(words[k]))
                            {
                                if (friendPost[j].Place.Name.ToUpper().Contains(words[k].ToUpper()))
                                {
                                    isAllreadyIn = false;
                                    //Fill friends profile image list 
                                    m_FriendsPlacesPictures.Add(friends[i].Name, friends[i].ImageSquare);
                                    FriendPostsToFill = new FriendPosts();
                                    FriendPostsToFill.FriendId = friends[i].Id;
                                    FriendPostsToFill.FriendComments = friendPost[j].Comments;
                                    FriendPostsToFill.LikedBy = friendPost[j].LikedBy;
                                    FriendPostsToFill.Message = friendPost[j].Message;
                                    FriendPostsToFill.Name = friendPost[j].Name;
                                    FriendPostsToFill.PictureUrl = friendPost[j].PictureURL;
                                    FriendPostsToFill.Place = friendPost[j].Place.Name;
                                    FriendPostsToFill.PostDescription = friendPost[j].Description;
                                    FriendPostsToFill.PostedDateTime = friendPost[j].CreatedTime.Value;
                                    m_FriendPostsList.Add(innerIndex, FriendPostsToFill);
                                    innerIndex++;

                                }
                            }
                        }
                    }
                }
             }
            
            return m_FriendsPlacesPictures;
        }


        public List<Point> CalculateCoordinatesByRadius(Point i_Point,int i_Radius)
        {
            for (int i = 0; i < i_Radius; i++)
            {
                double angle = Math.PI * i / 180.0;
                double sinAngle = Math.Sin(angle);
                double cosAngle = Math.Cos(angle);

               // i = pi * i / 180;     // convert to radians.
               
                Point p = new Point();
                p.X = Convert.ToInt32(i_Point.X + i_Radius * sinAngle);
                p.Y = Convert.ToInt32(i_Point.Y - i_Radius * cosAngle);
                points.Add(p);
            }



            
            return points;
        }


        }
}
