using Newtonsoft.Json;
using System;
using System.IO;
using System.Net;
using System.Windows.Forms;
using Weatherwise.Classes;

namespace Weatherwise
{
    public partial class AirPollutionControl : UserControl
    {
        public float Lat { get; set; }
        public float Lon { get; set; }
        public AirPollutionControl()
        {
            InitializeComponent();
        }

        private void AirPollutionControl_Load(object sender, EventArgs e)
        {
            string url = $"http://api.openweathermap.org/data/2.5/air_pollution?lat={Lat}&lon={Lon}&appid=77b5a128015397b907c53af6d6c1fa01";
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
            HttpWebResponse response = (HttpWebResponse)request.GetResponse();

            string myResponse;

            using (StreamReader streamReader = new StreamReader(response.GetResponseStream()))
            {
                myResponse = streamReader.ReadToEnd();
            }
            AirPollutionList data = JsonConvert.DeserializeObject<AirPollutionList>(myResponse);
            coLabel.Text += ": " + data[0].Components.Co;
            no2Label.Text+= ": " + data[0].Components.No2;
            noLabel.Text+=": " + data[0].Components.No;
            nh3Label.Text+= ": " + data[0].Components.Nh3;
            o3Label.Text+= ": " + data[0].Components.O3;
            so2Label.Text+= ": " + data[0].Components.So2;
            pm10Label.Text+= ": " + data[0].Components.Pm10;
            pm25Label.Text+= ": " + data[0].Components.Pm2_5;

            airQualityIndexLabel.Text += ": " + data[0].Main.Aqi + " (" +data[0].Main.Aqi.GetAqiStr()+ ")";



        }
    }
}
