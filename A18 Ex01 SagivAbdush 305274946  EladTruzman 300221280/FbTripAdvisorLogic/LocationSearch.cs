using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace A18_Ex01_SagivAbdush_305274946__EladTruzman_300221280.FbTripAdvisorLogic
{
    public class LocationSearch
    {
        private string m_City = string.Empty;
        private string m_Country = string.Empty;
        private string m_State = string.Empty;
        private string m_Street = string.Empty;
        private string m_Zip = string.Empty;
        private string m_General = string.Empty;

        //public LocationSearch(string m_City, string m_Country, string m_State, string m_Street, string m_Zip)
        //{
        //    this.m_City = m_City;
        //    this.m_Country = m_Country;
        //    this.m_State = m_State;
        //    this.m_Street = m_Street;
        //    this.m_Zip = m_Zip;
        //}

        public string City { get => m_City; set => m_City = value; }
        public string Country { get => m_Country; set => m_Country = value; }
        public string State { get => m_State; set => m_State = value; }
        public string Street { get => m_Street; set => m_Street = value; }
        public string Zip { get => m_Zip; set => m_Zip = value; }
        public string General { get => m_General; set => m_General = value; }
    }
}
