using System;
using System.Windows.Forms;

namespace Weatherwise
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            currentWeatherControl1.Visible = true;
            settingsControl1.Visible = false;
            exploreControl1.Visible = false;
            settingsControl1.CurrentWeather = currentWeatherControl1;
            
        }

        private void currentWeatherButton_Click(object sender, EventArgs e)
        {
            currentWeatherControl1.Visible = true;
            settingsControl1.Visible = false;
            exploreControl1.Visible = false;
            settingsControl1.ResetAllSettings();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
            Hide();
        }
        public void UpdateCurrentWeather()
        {
            currentWeatherControl1.InitializeForm();
        }

        private void settingsButton_Click(object sender, EventArgs e)
        {
            currentWeatherControl1.Visible = false;
            settingsControl1.Visible = true;
            exploreControl1.Visible = false;
        }

        private void exploreButton_Click(object sender, EventArgs e)
        {
            currentWeatherControl1.Visible = false;
            settingsControl1.Visible = false;
            exploreControl1.Visible = true;
            settingsControl1.ResetAllSettings();
        }
    }
}
