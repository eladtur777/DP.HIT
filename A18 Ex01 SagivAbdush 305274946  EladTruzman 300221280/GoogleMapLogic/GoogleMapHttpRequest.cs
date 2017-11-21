using System.Collections.Generic;
using System.IO;
using System.Net;
using Newtonsoft.Json;

namespace A18_Ex01_SagivAbdush_305274946__EladTruzman_300221280.GoogleMapLogic
{
    public class GoogleMapHttpRequest
    {
        private RootObject m_RootObject = new RootObject();
        private string m_StatusCode = string.Empty;
        private List<string> m_PlacesList = new List<string>();

        public List<string> CreateHttpGetConnection(string i_PlaceToSearch)
        {
            string myApiToken = "AIzaSyAUhEKEjfh9B6lVRa5bRt6tD5yOe9QjYxo";
            string queryURl = string.Format("https://maps.googleapis.com/maps/api/place/autocomplete/json?input={0}&types=(regions)&key={1}", i_PlaceToSearch, myApiToken);
            HttpWebRequest webRequest = WebRequest.Create(@queryURl) as HttpWebRequest;
            webRequest.Timeout = 20000;
            webRequest.Method = "GET";
            requestCompleted(webRequest);
            return m_PlacesList;
        }

        private void requestCompleted(HttpWebRequest i_WebRequest)
        {
            var resp = string.Empty;
            var request = i_WebRequest;
            var response = (HttpWebResponse)request.GetResponse();
        
            using (var stream = response.GetResponseStream())
            {
                var r = new StreamReader(stream);
                resp = r.ReadToEnd();
            }

            m_RootObject = JsonConvert.DeserializeObject<RootObject>(resp);
            m_StatusCode = response.StatusCode.ToString();
            if (m_StatusCode == "OK" && m_RootObject.status != "ZERO_RESULTS")
            {
                // placesList = RootObject.predictions.Select(x => x.description).ToList();
                for (int i = 0; i < m_RootObject.predictions.Count; i++)
                {
                    m_PlacesList.Add(m_RootObject.predictions[i].description);
                }
            }
        }
    }
}
