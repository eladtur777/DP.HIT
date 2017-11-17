using FacebookWrapper;
using FacebookWrapper.ObjectModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace A18_Ex01_SagivAbdush_305274946__EladTruzman_300221280.FbClipSearchLogic
{
//    struct friendPost
//    {
//        public Page m_Friend;
//        public Post m_FriendPost;

//        public friendPost(Page i_Friend, Post i_FriendPost)
//        {
//            m_Friend = i_Friend;
//            m_FriendPost = i_FriendPost;
//        }
//    }

   

   public class ClipSearchDAL
    {
        private FriendPosts m_FriendPosts;
        private Dictionary<int, Post> m_FriendPostsList = new Dictionary<int, Post>(50);
        private Dictionary<Page, Post> friendPostDictionary = new Dictionary<Page, Post>();
        public Dictionary<int, Post> FriendPostsList
        {
            get { return m_FriendPostsList; }
        }

        private void FullMatch(string[] i_WordsToCheck, FacebookObjectCollection<Page> i_Friends)
        {
           // List<friendPost> friendPosts = new List<friendPost>();
            bool isFullyMatchd;

            foreach (Page friend in i_Friends)
            {
                foreach (Post post in friend.WallPosts)
                {
                    if (post.Type == Post.eType.video)
                    {
                        isFullyMatchd = true;
                        foreach (string word in i_WordsToCheck)
                        {
                            if (!post.Name.Contains(word) && !post.Name.ToUpper().Contains(word.ToUpper()))
                            {
                                isFullyMatchd = false;
                                break;
                            }
                        }

                        if (isFullyMatchd)
                        {
                        friendPostDictionary.Add(friend, post);
                            //friendPosts.Add(new friendPost(friend, post));
                        }
                    }
                }
            }

           // return friendPostDictionary;

        }

        private void partiallyMatch(string[] i_WordsToCheck, FacebookObjectCollection<Page> i_Friends)
        {
           // List<friendPost> friendPosts = new List<friendPost>();
            int totalWordsToCheck = i_WordsToCheck.Length / 2 + 1;
            int counterOfMatchWords;

            foreach (Page friend in i_Friends)
            {
                foreach (Post post in friend.WallPosts)
                {
                    counterOfMatchWords = 0;
                    if (post.Type == Post.eType.video && !string.IsNullOrEmpty(post.Name))
                    {
                        foreach (string word in i_WordsToCheck)
                        {
                            if (post.Name.Contains(word) || post.Name.ToUpper().Contains(word.ToUpper()))
                            {
                                counterOfMatchWords++;
                            }
                        }
                    }

                    if (counterOfMatchWords >= totalWordsToCheck)
                    {
                      //  friendPosts.Add(new friendPost(friend, post));
                    friendPostDictionary.Add(friend, post);
                   }
                }

               // return friendPosts;
            }

           // return friendPosts;
        }

        public Dictionary<Page,Post> GetRelatedPosts(string i_TitleToSearch)
        {
            string[] titleSeperatedToWords;
            FacebookObjectCollection<Page> friends = FacebookService.GetCollection<Page>(GeneralEnum.E_MainTabType.friends.ToString());

            titleSeperatedToWords = i_TitleToSearch.Split(',', ' ', '.', '\t');
            partiallyMatch(titleSeperatedToWords, friends);

            return friendPostDictionary;
        }
    }
}
