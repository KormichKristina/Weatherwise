using System;
using System.Windows.Forms;

namespace Weatherwise
{
    public partial class HourlyForecastForm : Form
    {
        public float Lon { get; }
        public float Lat { get; }
        
        public HourlyForecastForm(float lon, float lat)
        {
            InitializeComponent();
            Lon = lon;
            Lat = lat;
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            new Form1().Show();
            Hide();
        }

        private void HourlyForecastForm_Load(object sender, EventArgs e)
        {
            airPollutionControl1.Visible = false;

            hourlyWeatherShowControl1.Lat = Lat;
            hourlyWeatherShowControl1.Lon = Lon;
            hourlyWeatherShowControl1.MakeARequest();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            airPollutionControl1.Visible = false;
            hourlyWeatherShowControl1.Visible = true;
            guna2HtmlLabel1.Text = "3 day  forecast";
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            airPollutionControl1.Visible = true;
            hourlyWeatherShowControl1.Visible = false;
            guna2HtmlLabel1.Text = "Air pollution";
        }
    }
}
