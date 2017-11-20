using System.Collections.Generic;
using FacebookWrapper.ObjectModel;

namespace A18_Ex01_SagivAbdush_305274946__EladTruzman_300221280.MainFormLogic
{
    public class MainFormWF
    {
        private MainFormDAL MainFormDAL = new MainFormDAL();

        public FacebookObjectCollection<Page> GetUserBooks()
        {
            return MainFormDAL.GetUserBooks();
        }

        public FacebookObjectCollection<Page> GetUserMusic()
        {
            return MainFormDAL.GetUserMusic();
        }

        public FacebookObjectCollection<Page> GetUserMovies()
        {
            return MainFormDAL.GetUserMovies();
        }

        public FacebookObjectCollection<Page> GetUserFriends()
        {
            return MainFormDAL.GetUserFriends();
        }

        public Dictionary<GeneralEnum.eUserBasicDetails, string> GetUserBasicDetails()
        {
            return MainFormDAL.GetUserBasicDetails();
        }

        public string InitializeFaceBookLogin(string i_AppId)
        {
            return MainFormDAL.InitializeFaceBookLogin(i_AppId);
        }

        public string PublishPost(string i_PostToPublish)
        {
            return MainFormDAL.PublishPostOnWall(i_PostToPublish);
        }
    }
}