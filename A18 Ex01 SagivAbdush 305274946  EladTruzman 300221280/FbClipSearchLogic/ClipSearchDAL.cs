using FacebookWrapper;
using FacebookWrapper.ObjectModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

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
        private Dictionary<int, FriendPostsClipSearch> m_friendPostDictionary;

        public Dictionary<int, FriendPostsClipSearch> FriendPostsDictionary
        {
            get { return m_friendPostDictionary; }
        }

        public ClipSearchDAL()
        {
            m_friendPostDictionary = new Dictionary<int, FriendPostsClipSearch>();
        }

        private void partiallyMatch(string[] i_WordsToCheck, FacebookObjectCollection<Page> i_Friends)
        {
            FriendPostsClipSearch relevantPost = new FriendPostsClipSearch();
            int totalWordsToCheck = i_WordsToCheck.Length / 2 + 1;
            int placeID = 0;
            int counterOfMatchWords;

            m_friendPostDictionary.Clear();
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
                        try
                        {
                            relevantPost = new FriendPostsClipSearch();
                            relevantPost.updateValues(
                                friend.Id,
                                post.CreatedTime.Value,
                                friend.ImageSmall,
                                friend.Name,
                                post.Description,
                                post.Name,
                                post.Message,
                                post.Link,
                                post.Comments,
                                post.LikedBy
                                );
                            m_friendPostDictionary.Add(placeID, relevantPost);
                            placeID++;
                        }
                        catch
                        {
                            throw new Exception("Couldn't find relevant posts properly");
                        }
                    }
                }
            }
        }

        public Dictionary<int, FriendPostsClipSearch> GetRelatedPosts(string i_TitleToSearch)
        {
            string[] titleSeperatedToWords;
            FacebookObjectCollection<Page> friends = FacebookService.GetCollection<Page>(GeneralEnum.E_MainTabType.friends.ToString());

            titleSeperatedToWords = i_TitleToSearch.Split(',', ' ', '.', '\t');
            partiallyMatch(titleSeperatedToWords, friends);

            return m_friendPostDictionary;
        }
    }
}
