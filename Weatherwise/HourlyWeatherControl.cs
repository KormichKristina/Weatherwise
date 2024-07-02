using System;
using System.Drawing;
using System.Windows.Forms;
using Weatherwise.Classes;

namespace Weatherwise
{
    public partial class HourlyWeatherControl : UserControl
    {
        public HourlyForecastInfo Info { get; }
        public HourlyWeatherControl(Color color,HourlyForecastInfo info)
        {
            InitializeComponent();
            BackColor = color;
            Info = info;
        }

        private void HourlyWeatherControl_Load(object sender, EventArgs e)
        {
            pictureBox1.Image = Info.Weather[0].Icon.GetWeatherImage();
            degLabel.Text = Math.Round(Info.Main.Temp).ToString() + $" {SettingsClass.TempDegrees.GetStrDeg()}";
            
            timeLabel.Text = Info.Dt_txt;
            

            
        }

        
    }
}
