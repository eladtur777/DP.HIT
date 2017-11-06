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
       
        private List<PictureBox> m_FriendsImageList = new List<PictureBox>();
        private PictureBox m_SingleImage = new PictureBox();
        private Dictionary<int, Image> m_FriendsPhotosTaggedIn = new Dictionary<int, Image>();
        private Dictionary<string, List<PictureBox>> m_FriendsPlaces;
        public Dictionary<string, List<PictureBox>> FriendsPlaces
        {
            get { return m_FriendsPlaces; }
        }
        public Dictionary<int, Image> FriendsPhotosTaggedIn
        {
            get { return m_FriendsPhotosTaggedIn; }
        }

        public Dictionary<string, List<PictureBox>> GetFriendsPlacesBySpecificLocation(LocationSearch i_LocationList)
        {
            m_FriendsPlaces = new Dictionary<string, List<PictureBox>>();
           
            FacebookObjectCollection<Page> friends = FacebookService.GetCollection<Page>(GeneralEnum.E_MainTabType.friends.ToString());
            dynamic actionsDataFriends = FacebookService.GetDynamicData(GeneralEnum.E_MainTabType.friends.ToString());

            for (int i = 0; i < friends.Count; i++)
            {
                if (!string.IsNullOrEmpty(i_LocationList.State))
                { 
                    if (friends[i].PhotosTaggedIn[i].Place.Location.State == i_LocationList.State)
                    {
                        m_SingleImage.Image = friends[i].PhotosTaggedIn[i].ImageNormal;
                        ToolTip toolTipForFriendImage = new ToolTip();
                        toolTipForFriendImage.SetToolTip(m_SingleImage, friends[i].PhotosTaggedIn[i].Place.Name);
                        m_FriendsImageList.Add(m_SingleImage);
                        m_FriendsPlaces.Add(i_LocationList.State, m_FriendsImageList);
                    }
                    //Mandatory field
                    else if (friends[i].PhotosTaggedIn[i].Place.Location.City == i_LocationList.City &&
                        friends[i].PhotosTaggedIn[i].Place.Location.Country == i_LocationList.Country)
                    {
                        m_FriendsPhotosTaggedIn.Add(i, friends[i].PhotosTaggedIn[i].ImageNormal);
                        m_SingleImage.Image = friends[i].PhotosTaggedIn[i].ImageNormal;
                        ToolTip toolTipForFriendImage = new ToolTip();
                        toolTipForFriendImage.SetToolTip(m_SingleImage, friends[i].PhotosTaggedIn[i].Place.Name);
                       // m_SingleImage.Click +=;
                        m_FriendsImageList.Add(m_SingleImage);
                        m_FriendsPlaces.Add(i_LocationList.State, m_FriendsImageList);
                    }
                    //Mandatory field
                    else if (friends[i].PhotosTaggedIn[i].Place.Location.Country == i_LocationList.Country)
                    {
                        m_SingleImage.Image = friends[i].PhotosTaggedIn[i].ImageNormal;
                        ToolTip toolTipForFriendImage = new ToolTip();
                        toolTipForFriendImage.SetToolTip(m_SingleImage, friends[i].PhotosTaggedIn[i].Place.Name);
                        m_FriendsImageList.Add(m_SingleImage);
                        m_FriendsPlaces.Add(i_LocationList.State, m_FriendsImageList);
                    }
                }

            }


            return FriendsPlaces;
        }
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
}
