using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace A18_Ex01_SagivAbdush_305274946__EladTruzman_300221280.FbTripAdvisorLogic
{
    public class TripAdvisorWF
    {
        TripAdvisorDAL TripAdvisorDAL = new TripAdvisorDAL();
        private Dictionary<string, List<PictureBox>> m_FriendsPlaces;
        public Dictionary<string, List<PictureBox>> FriendsPlaces
        {
            get { return m_FriendsPlaces; }
        }

        public Dictionary<string, Image> FindFriendsPlacesBySpecificLocation(LocationSearch i_LocationList)
        {

            return TripAdvisorDAL.FriendsPlacesBySpecificLocation(i_LocationList);
        }

             public Dictionary<int, FriendPosts> FriendPostsList()
            {

            return TripAdvisorDAL.FriendPostsList;

             }
        
    }
}
