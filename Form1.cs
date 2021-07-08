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
using CefSharp;//after a bit of research came across this one to use chrome instead of IE
using CefSharp.WinForms;

//This part of the code done by Ginta Kivite

namespace TopLocationByGintaDeirdreLouise
{
    public partial class TopLocation : Form
    {
        public ChromiumWebBrowser chromeBrowser;
        Regex validateStrings = new Regex("^[a-z]|[A-Z]|[0-9]|[ ]$");//valiadting strings made sure to allow spacing for the search box
        public TopLocation()
        {
            InitializeComponent();
            InitializeChromium();
        }

        public void InitializeChromium()
        {
            CefSettings settings = new CefSettings();//all of this code was taken from several websites
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
            //chromeBrowser = new ChromiumWebBrowser("http://maps.google.com/maps?q=&#8221"); 
            // StringBuilder location = new StringBuilder("http://maps.google.com/maps?q=&#8221");//// code taken from https://medium.com/@nipunadilhara/adding-google-maps-into-windows-form-application-in-c-46be1aec2981
            //System.Diagnostics.Process.Start("chrome", location.ToString());//attempting to force browser to open in chrome (it works just opens the web window not inside the form)



            lblSelectCity.Visible = false;
            comboBoxSelectCity.Visible = false;

            //followwing code first 5 lines were produced by documentation
            var client = new RestClient("http://battuta.medunes.net/api/country/all/?key=a750f370acfa1a65250fa8a4fb57125a");
            client.Timeout = -1;
            var request = new RestRequest(Method.GET);//all the code up until   IResponse was provvided by the API website
            request.AlwaysMultipartFormData = true;
            IRestResponse response = client.Execute(request);

            JsonDeserializer deserializer = new JsonDeserializer();
            //MessageBox.Show(response.Content);
            var temp = new List<Country1>();

            temp = deserializer.Deserialize<List<Country1>>(response);

            foreach (Country1 Country in temp)
            {
                comboBoxSelectCountry.Items.Add(Country.name);
            }
            //comboBoxSelectCountry.Items.Add("Australia"); //used for testing purposes only
            //comboBoxSelectCountry.Items.Add("Italy");
        }

        private void btnSelectCity_Click(object sender, EventArgs e)
        {
            comboBoxSelectCity.Items.Clear();

            string selectedCountry = this.comboBoxSelectCountry.GetItemText(this.comboBoxSelectCountry.SelectedItem);//getting the selected item text from the comboboxes
            string selectedCity = this.comboBoxSelectCity.GetItemText(this.comboBoxSelectCity.SelectedItem);
            string search = txtSearch.Text;

            var clienturl = "https://andruxnet-world-cities-v1.p.rapidapi.com/?query=";
            clienturl += selectedCountry;//adding selected combobox item text to display cities for that specific country in another combobox
            var client = new RestClient(clienturl);
            var request = new RestRequest(Method.GET);
            request.AddHeader("x-rapidapi-key", "3d4be43107msh53bb4b4a9d8b26ap142dd7jsn0192ad0635fb");
            request.AddHeader("x-rapidapi-host", "andruxnet-world-cities-v1.p.rapidapi.com");
            IRestResponse response = client.Execute(request);
            JsonDeserializer deserializer = new JsonDeserializer();
            //MessageBox.Show(" this msg " + response.Content);
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

            string selectedCity = this.comboBoxSelectCity.GetItemText(this.comboBoxSelectCity.SelectedItem);//getting the selected item text from the comboboxes
            string selectedCountry = this.comboBoxSelectCountry.GetItemText(this.comboBoxSelectCountry.SelectedItem);
            string search = txtSearch.Text;
            lblSelectCity.Visible = false;//displaying the city combobox
            comboBoxSelectCity.Visible = false;
            btnSelectCity.Visible = true;
            comboBoxSelectCountry.ResetText();//clearing text
            comboBoxSelectCity.ResetText();

            if (validateStrings.IsMatch(txtSearch.Text) || validateStrings.IsMatch(selectedCity) || validateStrings.IsMatch(selectedCountry))
            {//regex
                //var client = new RestClient("https://trueway-places.p.rapidapi.com/FindPlaceByText?text=Ireland%20Dublin&language=en");
                var clienturl = "https://trueway-places.p.rapidapi.com/FindPlaceByText?text=";//rapidapi for searchingand displaying results
                clienturl += selectedCountry;//we opted for location search however any search can be done according to api documentation
                clienturl += selectedCity;//based on documentation adding selected item text or search textbox text into api link
                clienturl += search;
                clienturl += "&language = en";
                var client = new RestClient(clienturl);//calling that link 
                var request = new RestRequest(Method.GET);
                request.AddHeader("x-rapidapi-key", "3d4be43107msh53bb4b4a9d8b26ap142dd7jsn0192ad0635fb");
                request.AddHeader("x-rapidapi-host", "trueway-places.p.rapidapi.com");
                IRestResponse response = client.Execute(request);
                JsonDeserializer deserializer = new JsonDeserializer();
                // MessageBox.Show(response.Content);
                var temp = new Root();
                temp = deserializer.Deserialize<Root>(response);


                foreach (Result r in temp.results)
                {
                    ListViewItem results = new ListViewItem(r.id);//adding results into the listbox
                    results.SubItems.Add(r.name);
                    results.SubItems.Add(r.address);//sometimes api prints two different results on one selected item 
                    results.SubItems.Add(r.website);//does not always display a website does for some searches results always chan
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
                //MessageBox.Show(response5.Content);
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

            //StringBuilder location = new StringBuilder("http://maps.google.com/maps?q=&#8221");// code taken from https://medium.com/@nipunadilhara/adding-google-maps-into-windows-form-application-in-c-46be1aec2981
            //System.Diagnostics.Process.Start("chrome", location.ToString());

            if (comboBoxSelectCountry.SelectedIndex != 0)
            {
                string country = "http://maps.google.com/maps?q=";//evetnually got it working had to dispose of previous window to open new one
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

            //var client = new RestClient("https://covid-19-coronavirus-statistics.p.rapidapi.com/v1/total?country=Canada");
            var clienturl2 = "https://covid-19-coronavirus-statistics.p.rapidapi.com/v1/total?country=";
            clienturl2 += selectedCountry;
            var client2 = new RestClient(clienturl2);
            var request2 = new RestRequest(Method.GET);
            request2.AddHeader("x-rapidapi-key", "3d4be43107msh53bb4b4a9d8b26ap142dd7jsn0192ad0635fb");
            request2.AddHeader("x-rapidapi-host", "covid-19-coronavirus-statistics.p.rapidapi.com");
            IRestResponse response2 = client2.Execute(request2);
            JsonDeserializer deserializer2 = new JsonDeserializer();
            //MessageBox.Show(response2.Content);
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

            comboBoxSelectCountry.SelectedItem = null; //because the database kept reading the same value had to manually deselect items in combobox
            comboBoxSelectCity.SelectedItem = null;
            txtSearch.Clear();
        }

       

        private void listViewDisplayLocationDetails_SelectedIndexChanged(object sender, EventArgs e)
        {


        }

        public void Louises_API()
        {
            //var c1 = new RestClient("https://pfa.foreca.com/authorize/token.php?user=lohare0&password=ilvH9StnL8qn");
            //var r1 = new RestRequest(Method.GET);

            //var response2 = c1.Execute(r1);
            //JsonDeserializer deserializer2 = new JsonDeserializer();
            //var tokenInfo = deserializer2.Deserialize<Rootobject3>(response2);
            //string myToken = tokenInfo.access_token;

            //// MessageBox.Show(myToken.ToString());

            //var client = new RestClient("https://pfa.foreca.com/api/v1/current/102643743");
            //var request = new RestRequest(Method.GET);
            //request.AddParameter("token", myToken);
            //MessageBox.Show(response2.Content);

            ////request.AddParameter("location", "Dublin");
            ////request.AddParameter("location", txtLocation.Text);
            ////client.Authenticator = new HttpBasicAuthentication("lohare0", "ilvH9StnL8qn");
            //// var request = new RestRequest("/ api / v1 / current /:location", Method.GET);

            ////var queryResult = client.Execute(request);

            //IRestResponse response = client.Execute(request);
            //JsonDeserializer deserializer = new JsonDeserializer();

            //var temp = new RootObject();

            //temp = deserializer.Deserialize<RootObject>(response);

            ////label2.Text = string.Format("Rain " + temp.current.precipRate + " mm/hour");
            ////lbltime.Text = string.Format(temp.current.time);
            ////lblphrase.Text = string.Format(temp.current.symbolPhrase);
            ////lblhumidity.Text = string.Format(temp.current.relHumidity + "%");
            ////lblWind.Text = string.Format(temp.current.windSpeed + " mph");
            ////lblPressure.Text = string.Format("Pressure " + temp.current.pressure);
            ////lblCloud.Text = string.Format("Cloud " + temp.current.cloudiness + "%");
            ////lbltemperature.Text = string.Format(temp.current.temperature + "\u00B0" + "C");
            ////pictureBox3.Image = (temp.current.symbol);
            
        }


        private void tabPageCovid_Click(object sender, EventArgs e)
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
            chromeBrowser.Dispose();//it was working all along and now all of a sudden it stoped working, go figure
            chromeBrowser = new ChromiumWebBrowser("https://www.nytimes.com/interactive/2020/world/coronavirus-maps.html");
            chromeBrowser.Dock = DockStyle.Fill;
            this.Controls.Add(chromeBrowser);
        }


        private void btnSelectedWeb_Click(object sender, EventArgs e)
        {
            listViewDisplayLocationDetails.HotTracking = true;
            for (int i = 0; i < listViewDisplayLocationDetails.SelectedItems.Count; i++)
            {
                System.Diagnostics.Process.Start(listViewDisplayLocationDetails.SelectedItems[i].SubItems[3].Text);//getting the website from listview
            }
           
        }

        //-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
    }
}
public class Rootobject
{
    public Country1[] Property1 { get; set; }//using Tony's example set the classes into either listboxes or arrays in root object

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
//----------------------------------------------END OF GINTA'S CODE----------------------------------------------------------------------------------------
//---------------------------------------------START OF DEIRDRE'S CODE---------------------------------------------------------------------------------------
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
//--------------------------------START OF LOUISES CODE-----------------------------------------------------------------------------------------------------------
//public class Current
//{
//    public string time { get; set; }
//    public string symbol { get; set; }
//    public string symbolPhrase { get; set; }
//    public int temperature { get; set; }
//    public int feelsLikeTemp { get; set; }
//    public int relHumidity { get; set; }
//    public int dewPoint { get; set; }
//    public int windSpeed { get; set; }
//    public string windDirString { get; set; }
//    public int windGust { get; set; }
//    public int precipProb { get; set; }
//    public int precipRate { get; set; }
//    public int cloudiness { get; set; }
//    public int thunderProb { get; set; }
//    public int uvIndex { get; set; }
//    public double pressure { get; set; }
//    public int visibility { get; set; }
//}

//public class RootObject
//{
//    public Current current { get; set; }
//}


//public class Rootobject3
//{
//    public string access_token { get; set; }
//    public int expires_in { get; set; }
//    public string token_type { get; set; }
//}


//    public class Forecast
//{
//    public string date { get; set; }
//    public string symbol { get; set; }
//    public int maxTemp { get; set; }
//    public int minTemp { get; set; }
//    public double precipAccum { get; set; }
//    public int maxWindSpeed { get; set; }
//    public int windDir { get; set; }
//}

//public class Root2
//{
//    public List<Forecast> forecast { get; set; }
//}

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
