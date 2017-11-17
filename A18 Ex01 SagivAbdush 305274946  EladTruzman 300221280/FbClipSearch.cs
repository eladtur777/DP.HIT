using A18_Ex01_SagivAbdush_305274946__EladTruzman_300221280.FbClipSearchLogic;
using FacebookWrapper.ObjectModel;
using System;
using System.Collections.Generic;
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

        private void btnClipSearch_Click(object sender, EventArgs e)
        {
            
            Dictionary<Page, Post> results = new Dictionary<Page, Post>();
            ClipSearchWF wf = new ClipSearchWF();
            results = wf.FriendsClipPostSResults(textBox1.Text);
        }
    }
}
