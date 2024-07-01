using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Weatherwise.Classes;

namespace Weatherwise
{
    public partial class CityControl : UserControl
    {

        public string CityName { get; set; }

        public CityControl()
        {
            InitializeComponent();
        }

        private void CityControl_Load(object sender, EventArgs e)
        {
            guna2HtmlLabel1.Text = CityName;
        }

        private void guna2Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void removeButton_Click(object sender, EventArgs e)
        {
            if (CitiesClass.CitiesNames.Count==1)
            {
                MessageBox.Show("you cant delete last city");
            }
            else
            {
                new WarningForm() { CurrentCityName = CityName }.Show();
                ParentForm.Hide();
            }

        }

        private void selectButton_Click(object sender, EventArgs e)
        {
            if (CitiesClass.CurrentCityName==CityName)
            {
                MessageBox.Show("this city has already been selected");
            }
            else
            {
                CitiesClass.CurrentCityName= CityName;
                ((Form1)ParentForm).UpdateCurrentWeather();
            }
        }
    }
}
