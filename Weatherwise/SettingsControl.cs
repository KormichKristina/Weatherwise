using System;
using System.Windows.Forms;
using Weatherwise.Classes;

namespace Weatherwise
{
    public partial class SettingsControl : UserControl
    {
        public CurrentWeatherControl CurrentWeather { get; set; }
        public SettingsControl()
        {
            InitializeComponent();
        }
        

        private void SettingsControl_Load(object sender, EventArgs e)
        {
            ResetAllSettings();

        }
        public void ResetAllSettings()
        {
            tempComboBox.Text = SettingsClass.TempDegrees.GetStrDeg();
            windComboBox.Text = SettingsClass.Wind.GetStrWindSpeed();
            pressureComboBox.Text = SettingsClass.MyPressure.GetStrPressure();
            utcTimeCheckBox.Checked = SettingsClass.UseUtc;
        }

        private void applyButton_Click(object sender, EventArgs e)
        {
            SettingsClass.Wind = windComboBox.Text.GetWindSpeed();
            SettingsClass.MyPressure = pressureComboBox.Text.GetMyPressure();
            SettingsClass.TempDegrees = tempComboBox.Text.GetDegrees();
            SettingsClass.UseUtc= utcTimeCheckBox.Checked;
            SettingsClass.ChangeSettings();
            CurrentWeather.InitializeForm();
            
        }

        private void resetButton_Click(object sender, EventArgs e)
        {
            SettingsClass.Wind = WindSpeed.M_C;
            SettingsClass.MyPressure = Pressure.HPA;
            SettingsClass.TempDegrees = Degrees.K;
            SettingsClass.UseUtc = false;
            ResetAllSettings();
            SettingsClass.ChangeSettings();
            CurrentWeather.InitializeForm();
        }
    }
}
