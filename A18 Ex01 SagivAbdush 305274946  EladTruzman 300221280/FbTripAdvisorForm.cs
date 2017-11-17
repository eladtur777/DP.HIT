using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Windows.Forms;
using System.Web;
using System.IO;
using Newtonsoft.Json;
using A18_Ex01_SagivAbdush_305274946__EladTruzman_300221280.FbTripAdvisorLogic;

namespace A18_Ex01_SagivAbdush_305274946__EladTruzman_300221280
{
    public partial class FbTripAdvisorForm : Form
    {
        delegate void SetComboBoxResultsCallback(List<string> placesList, bool m_IsComboBoxNeedToClear);
        // private AutoCompleteStringCollection m_Collection = new AutoCompleteStringCollection();
        private List<Label> lblForScreen = new List<Label>();
        private List<string> placesList;
        private string m_PlaceToSearch = string.Empty;
        private StringBuilder googleMapsUrl;
        private string m_statusCode = string.Empty;
        TripAdvisorWF tripAdvisorWF = new TripAdvisorWF();
        Dictionary<string, Image> m_FriendsPlaces = new Dictionary<string, Image>();

        public FbTripAdvisorForm()
        {
            InitializeComponent();
            FacebookWrapper.FacebookService.s_CollectionLimit = 50;
            this.txtBoxSearch.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            this.txtBoxSearch.AutoCompleteSource = AutoCompleteSource.CustomSource;
            googleMapsUrl = new StringBuilder();
            placesList = new List<string>();
        }


    private void pictureBox1_Click(object sender, EventArgs e)
        {
            if(txtBoxSearch.Text != "")
            {
                     m_PlaceToSearch = txtBoxSearch.Text.ToString();
                    string myApiToken = "AIzaSyAUhEKEjfh9B6lVRa5bRt6tD5yOe9QjYxo";
                    string queryURl = string.Format("https://maps.googleapis.com/maps/api/place/autocomplete/json?input={0}&types=(regions)&key={1}", m_PlaceToSearch, myApiToken);

                    HttpWebRequest webRequest = WebRequest.Create(@queryURl) as HttpWebRequest;
                    //@"https://maps.googleapis.com/maps/api/place/search/json?location=-33.8670522,151.1957362&radius=7500&types=library&sensor=false&key=AIzaSyD3jfeMZK1SWfRFDgMfxn_zrGRSjE7S8Vg"
                    webRequest.Timeout = 20000;
                    webRequest.Method = "GET";

                IAsyncResult Asyncresult = webRequest.BeginGetResponse(new AsyncCallback(RequestCompleted), webRequest);
                //wait 10 sec for method RequestCompleted to finish
                bool success = Asyncresult.AsyncWaitHandle.WaitOne(10 * 1000);
            }
        }

        private void RequestCompleted(IAsyncResult result)
        {
           
            var resp = "";
            var request = (HttpWebRequest)result.AsyncState;
            var response = (HttpWebResponse)request.EndGetResponse(result);
            using (var stream = response.GetResponseStream())
            {
                var r = new StreamReader(stream);
                 resp = r.ReadToEnd();         
            }

            GoogleLocations.RootObject RootObject = new GoogleLocations.RootObject();
            RootObject = Newtonsoft.Json.JsonConvert.DeserializeObject<GoogleLocations.RootObject>(resp);

      
            
           

            m_statusCode = response.StatusCode.ToString();
            if (m_statusCode == "OK" && RootObject.status != "ZERO_RESULTS")
            {
                placesList = RootObject.predictions.Select(x => x.description).ToList();
               
                SetCollection(placesList,false);

            }
            else
            {

                SetCollection(placesList,true);
              
            }
     

        }

        private void SetCollection(List<string> i_Collection, bool i_IsComboBoxNeedToClear)
        {
            // InvokeRequired required compares the thread ID of the
            // calling thread to the thread ID of the creating thread.
            // If these threads are different, it returns true.
         
            if (this.comboBoxSearchResults.InvokeRequired)
            {
                SetComboBoxResultsCallback d = new SetComboBoxResultsCallback(SetCollection);
                this.Invoke(d, new object[] { i_Collection, i_IsComboBoxNeedToClear });
            }
            else
            {
           
                //m_Collection.AddRange(placesList.ToArray());
               // comboBoxSearchResults.Items.Add(placesList);
        
                if (i_IsComboBoxNeedToClear)
                {
                    //comboBoxSearchResults.Items.Clear();
                    BindingSource bs = new BindingSource();
                   // bs.DataSource = placesList;
                    comboBoxSearchResults.DataSource = bs;
                }
                else
                {

                    BindingSource bs = new BindingSource();
                    bs.DataSource = placesList;
                    comboBoxSearchResults.DataSource = bs;

                }
                // this.txtBoxSearch.AutoCompleteCustomSource = m_Collection;
                // m_Collection.Clear();

            }

        }

   
        private void comboBoxSearch_TextChanged(object sender, EventArgs e)
        {
  
            //string myApiToken = "AIzaSyD1Mj-YGmoIHWJXD8ZHVJfHs1Hlju4VsBw";
            //string queryURl = string.Format("https://maps.googleapis.com/maps/api/place/autocomplete/json?input={0}&types=geocode&key={1}", m_PlaceToSearch, myApiToken);
            ////@"https://maps.googleapis.com/maps/api/place/search/json?location=-33.8670522,151.1957362&radius=7500&types=library&sensor=false&key=AIzaSyD3jfeMZK1SWfRFDgMfxn_zrGRSjE7S8Vg"
        
        }

        private void comboBoxSearchResults_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (comboBoxSearchResults.SelectedValue != null)
            {
                LocationSearch locationSearch = new LocationSearch();
                locationSearch.General = comboBoxSearchResults.SelectedValue.ToString();
                m_FriendsPlaces = tripAdvisorWF.FindFriendsPlacesBySpecificLocation(locationSearch);

                int i = 0;
                this.dataGridViewLocationsFriends.Rows.Clear();
                PictureBox Pb;
                if (m_FriendsPlaces.Count > 0)
                    foreach (var key in m_FriendsPlaces.Keys)
                    {
                        if (m_FriendsPlaces[key] != null)
                        {
                            Pb = new PictureBox();
                            Pb.Image = m_FriendsPlaces[key];
                            this.dataGridViewLocationsFriends.Rows.Insert(i, key, key, Pb.Image);
                            i++;
                        }
                    }

                foreach (DataGridViewRow row in dataGridViewLocationsFriends.Rows)
                {
                    row.Height = 52;
                }

            }

            else
            {
                MessageBox.Show("Please select your location from the list options");

            }

            //else if (!string.IsNullOrEmpty(txtBoxSearch.Text))
            //{
              
            //    LocationSearch locationSearch = new LocationSearch();
            //    locationSearch.General = txtBoxSearch.Text;
            
            //    m_FriendsPlaces = tripAdvisorWF.FindFriendsPlacesBySpecificLocation(locationSearch);

            //    int i = 0;
            //    this.dataGridViewLocationsFriends.Rows.Clear();
            //    PictureBox Pb;
            //    if (m_FriendsPlaces.Count > 0)
            //        foreach (var key in m_FriendsPlaces.Keys)
            //        {
            //            if (m_FriendsPlaces[key] != null)
            //            {
            //                Pb = new PictureBox();
            //                Pb.Image = m_FriendsPlaces[key];
            //                this.dataGridViewLocationsFriends.Rows.Insert(i, key, key, Pb.Image);
            //                i++;
            //            }
            //        }

            //    foreach (DataGridViewRow row in dataGridViewLocationsFriends.Rows)
            //    {
            //        row.Height = 52;
            //    }
            //}
        
            }



        


        private void Pb_Click(object sender, EventArgs e)
        {
      
        }
        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        //On cell click
      private void dataGridViewLocationsFriends_CellContentClick(object sender, DataGridViewCellEventArgs e)
      {
            //dataGridViewFriendsComments.Rows.Clear();
            int row = e.RowIndex;
            Dictionary<int, FriendPosts> m_FriendPostsList = new Dictionary<int, FriendPosts>(50);
            m_FriendPostsList = tripAdvisorWF.FriendPostsList();

        if (m_FriendPostsList.Count > 0)
         { 
            if (m_FriendPostsList[row].Message != null)
            {
                label2.Text = m_FriendPostsList[row].Message;
            }
            if (m_FriendPostsList[row].Place != null)
            {
                label3.Text = m_FriendPostsList[row].Place;
            }
            if (m_FriendPostsList[row].PostDescription != null)
            {
                label4.Text = m_FriendPostsList[row].PostDescription;
            }
            if (m_FriendPostsList[row].PostedDateTime != null)
            {
                label5.Text = m_FriendPostsList[row].PostedDateTime.ToShortDateString();
            }
            if (m_FriendPostsList[row].PictureUrl != null)
            {
                pictureBox3.Load(m_FriendPostsList[row].PictureUrl);
            }



                if (m_FriendPostsList[row].FriendComments.Count > 0)
                {
                    for (int i=0 ; i< m_FriendPostsList[row].FriendComments.Count; i++)
                    {
                        if (!string.IsNullOrEmpty(m_FriendPostsList[row].FriendComments[i].Message))
                        {
                            Label lb = new Label();
                            lb.Text = m_FriendPostsList[row].FriendComments[i].Message.ToString();

                            DataGridViewRow newRowToAdd = (DataGridViewRow)dataGridViewFriendsComments.Rows[0].Clone();
                            newRowToAdd.Cells[0].Value = lb.Text;
                            dataGridViewFriendsComments.Rows.Add(newRowToAdd);

                           // dataGridViewFriendsComments.Rows[i].Cells[0].Value = lb.Text;
                           // lblForScreen.Add(lb);
                        }
                      
                    }
                }
              //  List<string> liststrings = new List<string>();

               // for (int i = 0; i< liststrings.Count; i++)
               // {
                 //   liststrings.Add(lblForScreen[i].Text);
                

               // }

              //  for(int i = 0 ; i < lblForScreen.Count ; i++)
               // {
                    
                //    dataGridViewFriendsComments.Rows[i].Cells[0].Value = liststrings[i].;
               // }

                  //  dataGridViewFriendsComments.DataSource = lblForScreen;
                //foreach (var item in lblForScreen)
                //{
                //    if (!string.IsNullOrEmpty(m_FriendPostsList[row].FriendComments[1].Message))
                //    {
                //        label8.Text = m_FriendPostsList[row].FriendComments[1].Message.ToString();
                //    }
                //    if (!string.IsNullOrEmpty(m_FriendPostsList[row].FriendComments[1].Message))
                //    {
                //        label9.Text = m_FriendPostsList[row].FriendComments[1].Message.ToString();
                //    }
                //    if (!string.IsNullOrEmpty(m_FriendPostsList[row].FriendComments[2].Message))
                //    {
                //        label10.Text = m_FriendPostsList[row].FriendComments[2].Message.ToString();
                //    }
                //    if (!string.IsNullOrEmpty(m_FriendPostsList[row].FriendComments[3].Message))
                //    {
                //        label11.Text = m_FriendPostsList[row].FriendComments[3].Message.ToString();
                //    }
                //}
            }
          
        }

    }

    

}
