using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Weatherwise.Classes;

namespace Weatherwise
{
    public partial class HourlyWeatherShowControl : UserControl
    {
        public float Lat { get; set; }
        public float Lon { get; set; }
        public DailyWeatherForecastInfo Info { get => info; }
        DailyWeatherForecastInfo info;
        public HourlyWeatherShowControl()
        {
            InitializeComponent();
            
        }

        private void HourlyWeatherShowControl_Load(object sender, EventArgs e)
        {
            
            
        }
        public void MakeARequest()
        {
            string units = "units=default";
            if (SettingsClass.TempDegrees==Degrees.C)
            {
                units = "units=metric";
            }
            else if(SettingsClass.TempDegrees == Degrees.F)
            {
                units = "units=imperial";
            }


            string url = $"https://api.openweathermap.org/data/2.5/forecast?lat={Lat}&cnt=24&lon={Lon}&{units}&appid=77b5a128015397b907c53af6d6c1fa01";

            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
            HttpWebResponse response = (HttpWebResponse)request.GetResponse();

            string myResponse;

            using (StreamReader streamReader = new StreamReader(response.GetResponseStream()))
            {
                myResponse = streamReader.ReadToEnd();
            }
            info = JsonConvert.DeserializeObject<DailyWeatherForecastInfo>(myResponse);

            Color myColor;
            const int width = 131;
            for(int i=0;i<info.List.Count;i++)
            {
                if (i%2==0)
                {
                    myColor = Color.White;
                }
                else
                {
                    myColor = Color.PaleTurquoise;
                }
                HourlyWeatherControl control = new HourlyWeatherControl(myColor, info.List[i]);
                control.Location = new Point(i * width, 25);
                panel1.Controls.Add(control);
            }
        }
    }
}
