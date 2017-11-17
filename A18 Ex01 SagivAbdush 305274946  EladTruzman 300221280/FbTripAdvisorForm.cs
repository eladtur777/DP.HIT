using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using A18_Ex01_SagivAbdush_305274946__EladTruzman_300221280.FbTripAdvisorLogic;
using A18_Ex01_SagivAbdush_305274946__EladTruzman_300221280.GoogleMapLogic;

namespace A18_Ex01_SagivAbdush_305274946__EladTruzman_300221280
{
    public partial class FbTripAdvisorForm : Form
    {
        private TripAdvisorWF tripAdvisorWF;
        private Dictionary<string, Image> m_FriendsPlaces;

        public FbTripAdvisorForm()
        {
            InitializeComponent();
            FacebookWrapper.FacebookService.s_CollectionLimit = 50;
            this.txtBoxSearch.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            this.txtBoxSearch.AutoCompleteSource = AutoCompleteSource.CustomSource;
            m_FriendsPlaces = new Dictionary<string, Image>();
            tripAdvisorWF = new TripAdvisorWF();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (txtBoxSearch.Text != "")
            {         
                GoogleMapHttpRequest m_GoogleMapHttpRequest = new GoogleMapHttpRequest();
                BindingSource bs = new BindingSource();
                bs.DataSource = m_GoogleMapHttpRequest.CreateHttpGetConnection(txtBoxSearch.Text.ToString());
                comboBoxSearchResults.DataSource = bs;
            }
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
        }

        //On cell click
        private void dataGridViewLocationsFriends_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
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
                    for (int i = 0; i < m_FriendPostsList[row].FriendComments.Count; i++)
                    {
                        if (!string.IsNullOrEmpty(m_FriendPostsList[row].FriendComments[i].Message))
                        {
                            Label lb = new Label();
                            lb.Text = m_FriendPostsList[row].FriendComments[i].Message.ToString();

                            DataGridViewRow newRowToAdd = (DataGridViewRow)dataGridViewFriendsComments.Rows[0].Clone();
                            newRowToAdd.Cells[0].Value = lb.Text;
                            dataGridViewFriendsComments.Rows.Add(newRowToAdd);
                        }
                    }
                }
            }
        }

        private void btnFreeText_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtBoxFreeText.Text))
            {
                LocationSearch locationSearch = new LocationSearch();
                locationSearch.General = txtBoxFreeText.Text;
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
                MessageBox.Show("Please insert location or place name");
            }
        }

        private void checkBoxSearchFromList_CheckedChanged(object sender, EventArgs e)
        {
            checkBoxFreeTextSearch.Checked = !checkBoxSearchFromList.Checked;
        }

        private void checkBoxFreeTextSearch_CheckedChanged(object sender, EventArgs e)
        {
            checkBoxSearchFromList.Checked = !checkBoxFreeTextSearch.Checked;
        }
    }
}
