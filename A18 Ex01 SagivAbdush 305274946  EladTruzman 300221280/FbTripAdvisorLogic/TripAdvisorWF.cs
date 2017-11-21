using System.Collections.Generic;
using System.Drawing;

namespace A18_Ex01_SagivAbdush_305274946__EladTruzman_300221280.FbTripAdvisorLogic
{
    public class TripAdvisorWF
    {
        private TripAdvisorDAL TripAdvisorDAL = new TripAdvisorDAL();

        public Dictionary<string, Image> FindFriendsPlacesBySpecificLocation(LocationSearch i_LocationList)
        {
            return TripAdvisorDAL.FriendsPlacesBySpecificLocation(i_LocationList);
        }

        public Dictionary<int, FriendPost> FriendPostsList()
        {
            return TripAdvisorDAL.FriendPostsList;
        }
    }
}