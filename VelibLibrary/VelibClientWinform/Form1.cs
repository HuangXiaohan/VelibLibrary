using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VelibClientWinform.ServiceReference1;

namespace VelibClientWinform
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
        }

        VelibServiceClient client = new VelibServiceClient();

        private void SearchStation_Click(object sender, EventArgs e)
        {
            string city = cityBox.Text;
            stationBox.Text = client.searchStations(city);

        }

        private void SearchBike_Click(object sender, EventArgs e)
        {
            string station = stationBox.Text;
            bikeNum.Text = client.searchBikeNum(cityBox.Text, stationName.Text);

        }

        private void helpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 form = new Form2();
            form.Show();
            form.helpText();
        }
    }
}
