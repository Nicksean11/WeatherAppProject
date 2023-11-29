//Nikiwile Shaun Tibane
//GitHub project
using Newtonsoft.Json;
using System;
using System.Net;
using System.Windows.Forms;

namespace Weather_ApplicationProject
{
    public partial class CfrmMain : Form
    {
        public CfrmMain()
        {
            InitializeComponent();
        } 
        
        string APIkey = "8b737931398121d5c24681e8e9f409ef";

        private void btnSearch_Click(object sender, EventArgs e)
        {
            GetWeather();
        }
        void GetWeather()
        {
            using (WebClient webClient = new WebClient())
            {

                string Url = string.Format("https://api.openweathermap.org/data/2.5/weather?q={0}&appid={1}", lblCity.Text, APIkey);

                //string Url = string.Format("https://api.openweathermap.org/data/2.5/weather?lat={0}&lon={1}&appid={2}", -29.116442, 26.175291/*, txtBoxCity.Text*/, APIkey);
                try
                {
                    //problem
                    var json = webClient.DownloadString(Url);
                    CInfoWeather.root infoWeather = JsonConvert.DeserializeObject<CInfoWeather.root>(json);
                    picIcon.ImageLocation = "https://openweathermap.org/img/w/03d.png" + infoWeather.lstWeather[0].sIcon + "png";

                    lblCondition.Text = infoWeather.lstWeather[0].sMain;
                    lblDetails.Text = infoWeather.lstWeather[0].sDescription;
                    lblSunrise.Text = infoWeather.system.sunrise.ToString();
                    lblSunset.Text = infoWeather.system.sunset.ToString();

                    lblWindSpeed.Text = infoWeather.wind.speed.ToString();
                    lblPreasure.Text = infoWeather.main.pressure.ToString();

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error from the weather API" + ex.Message);
                }

            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
