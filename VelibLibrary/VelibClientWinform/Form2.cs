using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VelibClientWinform
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        public void helpText()
        {
            textBox.Text = "This application is for searching the velib information of each city. "
                +"\n Input the name of a city then click the button search behind,"
                +"\n you'll get all the stations of this city"
                +"\n Input the name of a station in this city then click the button search behind,"
                +"\n you'll get the number of available bikes of this station";
        }

        public void errorText(string txt)
        {
            textBox.Text = txt;
        }
    }
}
