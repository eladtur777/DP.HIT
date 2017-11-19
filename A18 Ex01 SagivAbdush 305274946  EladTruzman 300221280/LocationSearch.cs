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
        public string City { get { return m_City; } set { m_City = value; } }
        public string Country { get { return m_Country; } set { m_Country = value; } }
        public string State { get { return m_State; } set { m_State = value; } }
        public string Stree { get { return m_Street; } set { m_Street = value; } }
        public string Zip { get { return m_Zip; } set { m_Zip = value; } }
        public string General { get { return m_General; } set { m_General = value; } }

    }
}
