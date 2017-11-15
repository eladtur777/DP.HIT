using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace A18_Ex01_SagivAbdush_305274946__EladTruzman_300221280
{
    public partial class FbClipSearch : Form
    {
        public FbClipSearch()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Uri uu = new Uri("https://www.youtube.com/watch?v=DV55unut3oI&feature=share");
            webBrowser1.Url = uu;//("https://www.youtube.com/watch?v=DV55unut3oI&feature=share");
        }
    }
}
