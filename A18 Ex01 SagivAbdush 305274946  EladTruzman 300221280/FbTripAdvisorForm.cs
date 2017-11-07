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


namespace A18_Ex01_SagivAbdush_305274946__EladTruzman_300221280
{
    public partial class FbTripAdvisorForm : Form
    {
        private List<string> placesList;
        private StringBuilder googleMapsUrl;
        private string m_statusCode = string.Empty;
        public FbTripAdvisorForm()
        {
            InitializeComponent();
            googleMapsUrl = new StringBuilder();
            placesList = new List<string>();
        }

        public void googleMap()
        {
            //const string GeoCodeUrlFormat = "http://maps.google.com/maps/geo?q={0}&output=csv&oe=utf8&sensor=false";

            //string location = "State St, Troy, NY";
            //string url = String.Format(GeoCodeUrlFormat, HttpUtility.UrlEncode(location));
            //HttpRequest request = (HttpWebRequest)HttpWebRequest.Create(url);

            //HttpResponse response = (HttpResponse)request.GetResponse(); // Can throw an exception
            //Stream responseStream = response.GetResponseStream();

            //    StreamReader reader = new StreamReader(responseStream)
           
            //    string firstLine = reader.ReadLine();

            //    string[] lineParts = firstLine.Split();

            //   GeolocationResult result = GoogleMapper.MapGeolocationResult(lineParts);
        
    }


    private void pictureBox1_Click(object sender, EventArgs e)
        {
            if(txtBoxSearch.Text != "")
            {
                //googleMapsUrl.Append("http://maps.google.com/maps?q=");
                //googleMapsUrl.Append(txtBoxSearch.Text);
                //WebBrowserOfTag.Navigate(googleMapsUrl.ToString());
                HttpWebRequest webRequest = WebRequest.Create(@"https://maps.googleapis.com/maps/api/place/autocomplete/json?input=madrid&types=geocode&key=AIzaSyD1Mj-YGmoIHWJXD8ZHVJfHs1Hlju4VsBw") as HttpWebRequest;
                //@"https://maps.googleapis.com/maps/api/place/search/json?location=-33.8670522,151.1957362&radius=7500&types=library&sensor=false&key=AIzaSyD3jfeMZK1SWfRFDgMfxn_zrGRSjE7S8Vg"
                webRequest.Timeout = 20000;
                webRequest.Method = "GET";

                webRequest.BeginGetResponse(new AsyncCallback(RequestCompleted), webRequest);

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

           placesList = RootObject.predictions.Select(x => x.description).ToList();

            m_statusCode = response.StatusCode.ToString();
           
        }
        private void txtBoxSearch_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
