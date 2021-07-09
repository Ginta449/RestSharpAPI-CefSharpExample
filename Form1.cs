using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RestSharp;
using RestSharp.Serialization.Json;
using System.Text.RegularExpressions;
using System.Windows.Forms.DataVisualization.Charting;
using CefSharp;
using CefSharp.WinForms;

namespace TopLocationByGintaDeirdreLouise
{
    public partial class TopLocation : Form
    {
        public ChromiumWebBrowser chromeBrowser;
        Regex validateStrings = new Regex("^[a-z]|[A-Z]|[0-9]|[ ]$");
        public TopLocation()
        {
            InitializeComponent();
            InitializeChromium();
        }

        public void InitializeChromium()
        {
            CefSettings settings = new CefSettings();
            Cef.Initialize(settings);
            chromeBrowser = new ChromiumWebBrowser("http://maps.google.com/maps?q=&#8221");
            chromeBrowser.Dock = DockStyle.Fill;
            this.Controls.Add(chromeBrowser);
        }
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Cef.Shutdown();
        }
        private void TopLocation_Load(object sender, EventArgs e)
        {

            lblSelectCity.Visible = false;
            comboBoxSelectCity.Visible = false;
            
            var client = new RestClient("http://battuta.medunes.net/api/country/all/?key=a750f370acfa1a65250fa8a4fb57125a");
            client.Timeout = -1;
            var request = new RestRequest(Method.GET);
            request.AlwaysMultipartFormData = true;
            IRestResponse response = client.Execute(request);

            JsonDeserializer deserializer = new JsonDeserializer();
           
            var temp = new List<Country1>();

            temp = deserializer.Deserialize<List<Country1>>(response);

            foreach (Country1 Country in temp)
            {
                comboBoxSelectCountry.Items.Add(Country.name);
            }
            
        }

        private void btnSelectCity_Click(object sender, EventArgs e)
        {
            comboBoxSelectCity.Items.Clear();

            string selectedCountry = this.comboBoxSelectCountry.GetItemText(this.comboBoxSelectCountry.SelectedItem);
            string selectedCity = this.comboBoxSelectCity.GetItemText(this.comboBoxSelectCity.SelectedItem);
            string search = txtSearch.Text;

            var clienturl = "https://andruxnet-world-cities-v1.p.rapidapi.com/?query=";
            clienturl += selectedCountry;
            var client = new RestClient(clienturl);
            var request = new RestRequest(Method.GET);
            request.AddHeader("x-rapidapi-key", "3d4be43107msh53bb4b4a9d8b26ap142dd7jsn0192ad0635fb");
            request.AddHeader("x-rapidapi-host", "andruxnet-world-cities-v1.p.rapidapi.com");
            IRestResponse response = client.Execute(request);
            JsonDeserializer deserializer = new JsonDeserializer();
            var temp = new List<City>();
            temp = deserializer.Deserialize<List<City>>(response);
            foreach (City c in temp)
            {
                comboBoxSelectCity.Items.Add(c.city);
            }

            lblSelectCity.Visible = true;
            comboBoxSelectCity.Visible = true;
            btnSelectCity.Visible = false;
        }

        private void buttonGenerateResults_Click(object sender, EventArgs e)
        {
            chromeBrowser.Dispose();
            foreach (var series in chartCovid.Series)
            {
                series.Points.Clear();
            }

            string selectedCity = this.comboBoxSelectCity.GetItemText(this.comboBoxSelectCity.SelectedItem);
            string selectedCountry = this.comboBoxSelectCountry.GetItemText(this.comboBoxSelectCountry.SelectedItem);
            string search = txtSearch.Text;
            lblSelectCity.Visible = false;
            comboBoxSelectCity.Visible = false;
            btnSelectCity.Visible = true;
            comboBoxSelectCountry.ResetText();
            comboBoxSelectCity.ResetText();

            if (validateStrings.IsMatch(txtSearch.Text) || validateStrings.IsMatch(selectedCity) || validateStrings.IsMatch(selectedCountry))
            {
              
                var clienturl = "https://trueway-places.p.rapidapi.com/FindPlaceByText?text=";
                clienturl += selectedCountry;
                clienturl += selectedCity;
                clienturl += search;
                clienturl += "&language = en";
                var client = new RestClient(clienturl);
                var request = new RestRequest(Method.GET);
                request.AddHeader("x-rapidapi-key", "3d4be43107msh53bb4b4a9d8b26ap142dd7jsn0192ad0635fb");
                request.AddHeader("x-rapidapi-host", "trueway-places.p.rapidapi.com");
                IRestResponse response = client.Execute(request);
                JsonDeserializer deserializer = new JsonDeserializer();
                
                var temp = new Root();
                temp = deserializer.Deserialize<Root>(response);


                foreach (Result r in temp.results)
                {
                    ListViewItem results = new ListViewItem(r.id);
                    results.SubItems.Add(r.name);
                    results.SubItems.Add(r.address);
                    results.SubItems.Add(r.website);
                    listViewDisplayLocationDetails.Items.Add(results);
                    lblSearchName.Text = r.name;
                    lblSearchAddress.Text = r.address;
                }

                var clienturl5 = "https://community-open-weather-map.p.rapidapi.com/weather?q=";
                clienturl5 += selectedCountry;
                clienturl5 += "&lat=0&lon=0&lang=null&units=%22metric%22%20or%20%22imperial%22";
                var client5 = new RestClient(clienturl5);
                var request5 = new RestRequest(Method.GET);
                request5.AddHeader("x-rapidapi-key", "3d4be43107msh53bb4b4a9d8b26ap142dd7jsn0192ad0635fb");
                request5.AddHeader("x-rapidapi-host", "community-open-weather-map.p.rapidapi.com");
                IRestResponse response5 = client5.Execute(request5);
                JsonDeserializer deserializer5 = new JsonDeserializer();
            
                var temp5 = new Rootobject5();

                temp5 = deserializer5.Deserialize<Rootobject5>(response5);
                foreach (Main m in temp5.main)
                {
                    lblGetTemperature.Text = m.temp.ToString();
                    lblGetHumidity.Text = m.humidity.ToString();
                    lblGetPressure.Text = m.pressure.ToString();
                }
                foreach (Wind w in temp5.wind)
                {
                    lblGetWindSpeed.Text = w.speed.ToString();
                }
                foreach (Clouds c in temp5.clouds)
                {
                    lblGetCloudiness.Text = c.all.ToString();
                }
                foreach (Coord co in temp5.coord)
                {
                    lblSearchLat.Text = co.lat.ToString();
                    lblSearchLon.Text = co.lon.ToString();
                }
            }
            else
            {
                MessageBox.Show("Please enter values to display search results!");
            }


            if (comboBoxSelectCountry.SelectedIndex != 0)
            {
                string country = "http://maps.google.com/maps?q=";
                country += selectedCountry;
                chromeBrowser = new ChromiumWebBrowser(country);
                chromeBrowser.Dock = DockStyle.Fill;
                this.Controls.Add(chromeBrowser);
            }
            else if (comboBoxSelectCountry.SelectedIndex > 0 && comboBoxSelectCity.SelectedIndex != 0)
            {
                string city = "http://maps.google.com/maps?q=";
                city += selectedCity;
                chromeBrowser = new ChromiumWebBrowser(city);
                chromeBrowser.Dock = DockStyle.Fill;
                this.Controls.Add(chromeBrowser);
            }
            else
            {
                string search2 = "https://www.google.com/search?q=";
                search2 += txtSearch.Text;
                chromeBrowser = new ChromiumWebBrowser(search2);
                chromeBrowser.Dock = DockStyle.Fill;
                this.Controls.Add(chromeBrowser);
            }

            
            var clienturl2 = "https://covid-19-coronavirus-statistics.p.rapidapi.com/v1/total?country=";
            clienturl2 += selectedCountry;
            var client2 = new RestClient(clienturl2);
            var request2 = new RestRequest(Method.GET);
            request2.AddHeader("x-rapidapi-key", "3d4be43107msh53bb4b4a9d8b26ap142dd7jsn0192ad0635fb");
            request2.AddHeader("x-rapidapi-host", "covid-19-coronavirus-statistics.p.rapidapi.com");
            IRestResponse response2 = client2.Execute(request2);
            JsonDeserializer deserializer2 = new JsonDeserializer();
            
            var temp2 = new Rootobject2();
            temp2 = deserializer2.Deserialize<Rootobject2>(response2);
            foreach (Data d in temp2.data)
            {
                lblDisplayDeaths.Text = d.deaths.ToString();
                lblDisplayConfirmed.Text = d.confirmed.ToString();
                lblDsiplayRecovered.Text = d.recovered.ToString();
                lblCovidCountry.Text = d.location.ToString();

                chartCovid.Series["Covid-19"].Points.AddXY("Deaths", d.deaths);
                chartCovid.Series["Covid-19"].Points.AddXY("Confirmed", d.confirmed);
                chartCovid.Series["Covid-19"].Points.AddXY("Recovered", d.recovered);

            }

            comboBoxSelectCountry.SelectedItem = null; 
            comboBoxSelectCity.SelectedItem = null;
            txtSearch.Clear();
        }

       

        private void listViewDisplayLocationDetails_SelectedIndexChanged(object sender, EventArgs e)
        {


        }


        private void btnWeatherWebsite_Click(object sender, EventArgs e)
        {
            chromeBrowser.Dispose();
            string countryWeather = "https://www.timeanddate.com/weather/";
            countryWeather += lblSearchName.Text;
            chromeBrowser = new ChromiumWebBrowser(countryWeather);
            chromeBrowser.Dock = DockStyle.Fill;
            this.Controls.Add(chromeBrowser);
        }

        private void btnCovidMap_Click(object sender, EventArgs e)
        {
            chromeBrowser.Dispose();
            chromeBrowser = new ChromiumWebBrowser("https://www.nytimes.com/interactive/2020/world/coronavirus-maps.html");
            chromeBrowser.Dock = DockStyle.Fill;
            this.Controls.Add(chromeBrowser);
        }


        private void btnSelectedWeb_Click(object sender, EventArgs e)
        {
            listViewDisplayLocationDetails.HotTracking = true;
            for (int i = 0; i < listViewDisplayLocationDetails.SelectedItems.Count; i++)
            {
                System.Diagnostics.Process.Start(listViewDisplayLocationDetails.SelectedItems[i].SubItems[3].Text);
            }
           
        }

        //-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
    }
}
public class Rootobject
{
    public Country1[] Property1 { get; set; }

    public City[] Property2 { get; set; }

    public Result[] Property3 { get; set; }
}

public class Country1
{
    public string name { get; set; }
    public string code { get; set; }
}

public class City
{
    public string city { get; set; }
}



public class Root
{
    public List<Result> results { get; set; }
    public List<Location> location { get; set; }
}

public class Result
{
    public string id { get; set; }
    public string name { get; set; }
    public string address { get; set; }
    public string website { get; set; }
    public Location location { get; set; }
    public List<string> types { get; set; }
}

public class Location
{
    public float lat { get; set; }
    public float lng { get; set; }
}

public class Rootobject2
{
    public bool error { get; set; }
    public int statusCode { get; set; }
    public string message { get; set; }
    public List<Data> data { get; set; }
}

public class Data
{
    public int recovered { get; set; }
    public int deaths { get; set; }
    public int confirmed { get; set; }
    public DateTime lastChecked { get; set; }
    public DateTime lastReported { get; set; }
    public string location { get; set; }
}

public class Rootobject5
{
    public List<Coord> coord { get; set; }
    public List<Weather> weather { get; set; }
    public string _base { get; set; }
    public List<Main> main { get; set; }
    public int visibility { get; set; }
    public List<Wind> wind { get; set; }
    public List<Clouds> clouds { get; set; }
    public int dt { get; set; }
    public List<Sys> sys { get; set; }
    public int timezone { get; set; }
    public int id { get; set; }
    public string name { get; set; }
    public int cod { get; set; }
}

public class Coord
{
    public float lon { get; set; }
    public float lat { get; set; }
}

public class Main
{
    public float temp { get; set; }
    public float feels_like { get; set; }
    public float temp_min { get; set; }
    public float temp_max { get; set; }
    public int pressure { get; set; }
    public int humidity { get; set; }
}

public class Wind
{
    public float speed { get; set; }
    public int deg { get; set; }
}

public class Clouds
{
    public int all { get; set; }
}

public class Sys
{
    public int type { get; set; }
    public int id { get; set; }
    public string country { get; set; }
    public int sunrise { get; set; }
    public int sunset { get; set; }
}

public class Weather
{
    public int id { get; set; }
    public string main { get; set; }
    public string description { get; set; }
    public string icon { get; set; }
}
