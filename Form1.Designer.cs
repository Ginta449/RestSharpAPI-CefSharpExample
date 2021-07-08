namespace TopLocationByGintaDeirdreLouise
{
    partial class TopLocation
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.tabControlTopLocation = new System.Windows.Forms.TabControl();
            this.tabPageSearchLoation = new System.Windows.Forms.TabPage();
            this.btnSelectedWeb = new System.Windows.Forms.Button();
            this.btnSelectCity = new System.Windows.Forms.Button();
            this.listViewDisplayLocationDetails = new System.Windows.Forms.ListView();
            this.columnHeaderID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderAddress = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderWebsite = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderLatitue = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderLongitude = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.buttonGenerateResults = new System.Windows.Forms.Button();
            this.comboBoxSelectCity = new System.Windows.Forms.ComboBox();
            this.lblSelectCity = new System.Windows.Forms.Label();
            this.comboBoxSelectCountry = new System.Windows.Forms.ComboBox();
            this.lblSelectCountry = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.lblSearch = new System.Windows.Forms.Label();
            this.tabPageWeather = new System.Windows.Forms.TabPage();
            this.btnWeatherWebsite = new System.Windows.Forms.Button();
            this.lblGetPressure = new System.Windows.Forms.Label();
            this.lblGetWindSpeed = new System.Windows.Forms.Label();
            this.lblGetCloudiness = new System.Windows.Forms.Label();
            this.lblGetHumidity = new System.Windows.Forms.Label();
            this.lblGetTemperature = new System.Windows.Forms.Label();
            this.lblPressure = new System.Windows.Forms.Label();
            this.lblWindSpeed = new System.Windows.Forms.Label();
            this.lblCloudiness = new System.Windows.Forms.Label();
            this.lblHumidity = new System.Windows.Forms.Label();
            this.lblTemperature = new System.Windows.Forms.Label();
            this.lblSearchLon = new System.Windows.Forms.Label();
            this.lblLon = new System.Windows.Forms.Label();
            this.lblSearchLat = new System.Windows.Forms.Label();
            this.lblLat = new System.Windows.Forms.Label();
            this.lblSearchAddress = new System.Windows.Forms.Label();
            this.lblAddress = new System.Windows.Forms.Label();
            this.lblSearchName = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.tabPageCovid = new System.Windows.Forms.TabPage();
            this.btnCovidMap = new System.Windows.Forms.Button();
            this.lblCovidCountry = new System.Windows.Forms.Label();
            this.chartCovid = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.lblDsiplayRecovered = new System.Windows.Forms.Label();
            this.lblRecovered = new System.Windows.Forms.Label();
            this.lblDisplayConfirmed = new System.Windows.Forms.Label();
            this.lblConfirmed = new System.Windows.Forms.Label();
            this.lblDisplayDeaths = new System.Windows.Forms.Label();
            this.lblDeaths = new System.Windows.Forms.Label();
            this.lblLocation = new System.Windows.Forms.Label();
            this.tabControlTopLocation.SuspendLayout();
            this.tabPageSearchLoation.SuspendLayout();
            this.tabPageWeather.SuspendLayout();
            this.tabPageCovid.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartCovid)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControlTopLocation
            // 
            this.tabControlTopLocation.Controls.Add(this.tabPageSearchLoation);
            this.tabControlTopLocation.Controls.Add(this.tabPageWeather);
            this.tabControlTopLocation.Controls.Add(this.tabPageCovid);
            this.tabControlTopLocation.Location = new System.Drawing.Point(588, 12);
            this.tabControlTopLocation.Name = "tabControlTopLocation";
            this.tabControlTopLocation.SelectedIndex = 0;
            this.tabControlTopLocation.Size = new System.Drawing.Size(800, 254);
            this.tabControlTopLocation.TabIndex = 0;
            // 
            // tabPageSearchLoation
            // 
            this.tabPageSearchLoation.BackColor = System.Drawing.Color.White;
            this.tabPageSearchLoation.BackgroundImage = global::TopLocationByGintaDeirdreLouise.Properties.Resources.back2;
            this.tabPageSearchLoation.Controls.Add(this.btnSelectedWeb);
            this.tabPageSearchLoation.Controls.Add(this.btnSelectCity);
            this.tabPageSearchLoation.Controls.Add(this.listViewDisplayLocationDetails);
            this.tabPageSearchLoation.Controls.Add(this.buttonGenerateResults);
            this.tabPageSearchLoation.Controls.Add(this.comboBoxSelectCity);
            this.tabPageSearchLoation.Controls.Add(this.lblSelectCity);
            this.tabPageSearchLoation.Controls.Add(this.comboBoxSelectCountry);
            this.tabPageSearchLoation.Controls.Add(this.lblSelectCountry);
            this.tabPageSearchLoation.Controls.Add(this.txtSearch);
            this.tabPageSearchLoation.Controls.Add(this.lblSearch);
            this.tabPageSearchLoation.Location = new System.Drawing.Point(4, 22);
            this.tabPageSearchLoation.Name = "tabPageSearchLoation";
            this.tabPageSearchLoation.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageSearchLoation.Size = new System.Drawing.Size(792, 228);
            this.tabPageSearchLoation.TabIndex = 0;
            this.tabPageSearchLoation.Text = "Search Location";
            // 
            // btnSelectedWeb
            // 
            this.btnSelectedWeb.Location = new System.Drawing.Point(270, 177);
            this.btnSelectedWeb.Name = "btnSelectedWeb";
            this.btnSelectedWeb.Size = new System.Drawing.Size(150, 23);
            this.btnSelectedWeb.TabIndex = 12;
            this.btnSelectedWeb.Text = "Get Selected Website";
            this.btnSelectedWeb.UseVisualStyleBackColor = true;
            this.btnSelectedWeb.Click += new System.EventHandler(this.btnSelectedWeb_Click);
            // 
            // btnSelectCity
            // 
            this.btnSelectCity.Location = new System.Drawing.Point(137, 83);
            this.btnSelectCity.Name = "btnSelectCity";
            this.btnSelectCity.Size = new System.Drawing.Size(121, 23);
            this.btnSelectCity.TabIndex = 10;
            this.btnSelectCity.Text = "Select City (Optional)";
            this.btnSelectCity.UseVisualStyleBackColor = true;
            this.btnSelectCity.Click += new System.EventHandler(this.btnSelectCity_Click);
            // 
            // listViewDisplayLocationDetails
            // 
            this.listViewDisplayLocationDetails.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeaderID,
            this.columnHeaderName,
            this.columnHeaderAddress,
            this.columnHeaderWebsite,
            this.columnHeaderLatitue,
            this.columnHeaderLongitude});
            this.listViewDisplayLocationDetails.HideSelection = false;
            this.listViewDisplayLocationDetails.Location = new System.Drawing.Point(270, 0);
            this.listViewDisplayLocationDetails.Name = "listViewDisplayLocationDetails";
            this.listViewDisplayLocationDetails.Size = new System.Drawing.Size(519, 171);
            this.listViewDisplayLocationDetails.TabIndex = 8;
            this.listViewDisplayLocationDetails.UseCompatibleStateImageBehavior = false;
            this.listViewDisplayLocationDetails.View = System.Windows.Forms.View.Details;
            this.listViewDisplayLocationDetails.SelectedIndexChanged += new System.EventHandler(this.listViewDisplayLocationDetails_SelectedIndexChanged);
            // 
            // columnHeaderID
            // 
            this.columnHeaderID.Text = "ID";
            this.columnHeaderID.Width = 30;
            // 
            // columnHeaderName
            // 
            this.columnHeaderName.Text = "Name";
            this.columnHeaderName.Width = 100;
            // 
            // columnHeaderAddress
            // 
            this.columnHeaderAddress.Text = "Address";
            this.columnHeaderAddress.Width = 100;
            // 
            // columnHeaderWebsite
            // 
            this.columnHeaderWebsite.Text = "Website";
            this.columnHeaderWebsite.Width = 150;
            // 
            // columnHeaderLatitue
            // 
            this.columnHeaderLatitue.Text = "Latitude";
            // 
            // columnHeaderLongitude
            // 
            this.columnHeaderLongitude.Text = "Longitude";
            // 
            // buttonGenerateResults
            // 
            this.buttonGenerateResults.BackColor = System.Drawing.Color.PowderBlue;
            this.buttonGenerateResults.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonGenerateResults.Location = new System.Drawing.Point(137, 122);
            this.buttonGenerateResults.Name = "buttonGenerateResults";
            this.buttonGenerateResults.Size = new System.Drawing.Size(121, 49);
            this.buttonGenerateResults.TabIndex = 7;
            this.buttonGenerateResults.Text = "Generate Results";
            this.buttonGenerateResults.UseVisualStyleBackColor = false;
            this.buttonGenerateResults.Click += new System.EventHandler(this.buttonGenerateResults_Click);
            // 
            // comboBoxSelectCity
            // 
            this.comboBoxSelectCity.FormattingEnabled = true;
            this.comboBoxSelectCity.Location = new System.Drawing.Point(137, 82);
            this.comboBoxSelectCity.Name = "comboBoxSelectCity";
            this.comboBoxSelectCity.Size = new System.Drawing.Size(121, 21);
            this.comboBoxSelectCity.TabIndex = 6;
            // 
            // lblSelectCity
            // 
            this.lblSelectCity.AutoSize = true;
            this.lblSelectCity.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSelectCity.Location = new System.Drawing.Point(6, 83);
            this.lblSelectCity.Name = "lblSelectCity";
            this.lblSelectCity.Size = new System.Drawing.Size(100, 20);
            this.lblSelectCity.TabIndex = 5;
            this.lblSelectCity.Text = "Select City:";
            // 
            // comboBoxSelectCountry
            // 
            this.comboBoxSelectCountry.FormattingEnabled = true;
            this.comboBoxSelectCountry.Location = new System.Drawing.Point(137, 42);
            this.comboBoxSelectCountry.Name = "comboBoxSelectCountry";
            this.comboBoxSelectCountry.Size = new System.Drawing.Size(121, 21);
            this.comboBoxSelectCountry.TabIndex = 3;
            // 
            // lblSelectCountry
            // 
            this.lblSelectCountry.AutoSize = true;
            this.lblSelectCountry.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSelectCountry.Location = new System.Drawing.Point(3, 40);
            this.lblSelectCountry.Name = "lblSelectCountry";
            this.lblSelectCountry.Size = new System.Drawing.Size(132, 20);
            this.lblSelectCountry.TabIndex = 2;
            this.lblSelectCountry.Text = "Select Country:";
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(137, 5);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(121, 20);
            this.txtSearch.TabIndex = 1;
            // 
            // lblSearch
            // 
            this.lblSearch.AutoSize = true;
            this.lblSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSearch.Location = new System.Drawing.Point(3, 3);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(76, 20);
            this.lblSearch.TabIndex = 0;
            this.lblSearch.Text = "Search: ";
            // 
            // tabPageWeather
            // 
            this.tabPageWeather.BackgroundImage = global::TopLocationByGintaDeirdreLouise.Properties.Resources.back2;
            this.tabPageWeather.Controls.Add(this.btnWeatherWebsite);
            this.tabPageWeather.Controls.Add(this.lblGetPressure);
            this.tabPageWeather.Controls.Add(this.lblGetWindSpeed);
            this.tabPageWeather.Controls.Add(this.lblGetCloudiness);
            this.tabPageWeather.Controls.Add(this.lblGetHumidity);
            this.tabPageWeather.Controls.Add(this.lblGetTemperature);
            this.tabPageWeather.Controls.Add(this.lblPressure);
            this.tabPageWeather.Controls.Add(this.lblWindSpeed);
            this.tabPageWeather.Controls.Add(this.lblCloudiness);
            this.tabPageWeather.Controls.Add(this.lblHumidity);
            this.tabPageWeather.Controls.Add(this.lblTemperature);
            this.tabPageWeather.Controls.Add(this.lblSearchLon);
            this.tabPageWeather.Controls.Add(this.lblLon);
            this.tabPageWeather.Controls.Add(this.lblSearchLat);
            this.tabPageWeather.Controls.Add(this.lblLat);
            this.tabPageWeather.Controls.Add(this.lblSearchAddress);
            this.tabPageWeather.Controls.Add(this.lblAddress);
            this.tabPageWeather.Controls.Add(this.lblSearchName);
            this.tabPageWeather.Controls.Add(this.lblName);
            this.tabPageWeather.Location = new System.Drawing.Point(4, 22);
            this.tabPageWeather.Name = "tabPageWeather";
            this.tabPageWeather.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageWeather.Size = new System.Drawing.Size(792, 228);
            this.tabPageWeather.TabIndex = 1;
            this.tabPageWeather.Text = "Weather";
            this.tabPageWeather.UseVisualStyleBackColor = true;
            // 
            // btnWeatherWebsite
            // 
            this.btnWeatherWebsite.Location = new System.Drawing.Point(194, 186);
            this.btnWeatherWebsite.Name = "btnWeatherWebsite";
            this.btnWeatherWebsite.Size = new System.Drawing.Size(180, 23);
            this.btnWeatherWebsite.TabIndex = 21;
            this.btnWeatherWebsite.Text = "Display Weather Website";
            this.btnWeatherWebsite.UseVisualStyleBackColor = true;
            this.btnWeatherWebsite.Click += new System.EventHandler(this.btnWeatherWebsite_Click);
            // 
            // lblGetPressure
            // 
            this.lblGetPressure.AutoSize = true;
            this.lblGetPressure.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGetPressure.Location = new System.Drawing.Point(524, 164);
            this.lblGetPressure.Name = "lblGetPressure";
            this.lblGetPressure.Size = new System.Drawing.Size(0, 20);
            this.lblGetPressure.TabIndex = 19;
            // 
            // lblGetWindSpeed
            // 
            this.lblGetWindSpeed.AutoSize = true;
            this.lblGetWindSpeed.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGetWindSpeed.Location = new System.Drawing.Point(545, 131);
            this.lblGetWindSpeed.Name = "lblGetWindSpeed";
            this.lblGetWindSpeed.Size = new System.Drawing.Size(0, 20);
            this.lblGetWindSpeed.TabIndex = 18;
            // 
            // lblGetCloudiness
            // 
            this.lblGetCloudiness.AutoSize = true;
            this.lblGetCloudiness.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGetCloudiness.Location = new System.Drawing.Point(539, 95);
            this.lblGetCloudiness.Name = "lblGetCloudiness";
            this.lblGetCloudiness.Size = new System.Drawing.Size(0, 20);
            this.lblGetCloudiness.TabIndex = 17;
            // 
            // lblGetHumidity
            // 
            this.lblGetHumidity.AutoSize = true;
            this.lblGetHumidity.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGetHumidity.Location = new System.Drawing.Point(539, 64);
            this.lblGetHumidity.Name = "lblGetHumidity";
            this.lblGetHumidity.Size = new System.Drawing.Size(0, 20);
            this.lblGetHumidity.TabIndex = 16;
            // 
            // lblGetTemperature
            // 
            this.lblGetTemperature.AutoSize = true;
            this.lblGetTemperature.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGetTemperature.Location = new System.Drawing.Point(555, 29);
            this.lblGetTemperature.Name = "lblGetTemperature";
            this.lblGetTemperature.Size = new System.Drawing.Size(0, 20);
            this.lblGetTemperature.TabIndex = 15;
            // 
            // lblPressure
            // 
            this.lblPressure.AutoSize = true;
            this.lblPressure.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPressure.Location = new System.Drawing.Point(428, 164);
            this.lblPressure.Name = "lblPressure";
            this.lblPressure.Size = new System.Drawing.Size(90, 20);
            this.lblPressure.TabIndex = 13;
            this.lblPressure.Text = "Pressure: ";
            // 
            // lblWindSpeed
            // 
            this.lblWindSpeed.AutoSize = true;
            this.lblWindSpeed.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWindSpeed.Location = new System.Drawing.Point(428, 130);
            this.lblWindSpeed.Name = "lblWindSpeed";
            this.lblWindSpeed.Size = new System.Drawing.Size(116, 20);
            this.lblWindSpeed.TabIndex = 12;
            this.lblWindSpeed.Text = "Wind Speed: ";
            // 
            // lblCloudiness
            // 
            this.lblCloudiness.AutoSize = true;
            this.lblCloudiness.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCloudiness.Location = new System.Drawing.Point(428, 95);
            this.lblCloudiness.Name = "lblCloudiness";
            this.lblCloudiness.Size = new System.Drawing.Size(107, 20);
            this.lblCloudiness.TabIndex = 11;
            this.lblCloudiness.Text = "Cloudiness: ";
            // 
            // lblHumidity
            // 
            this.lblHumidity.AutoSize = true;
            this.lblHumidity.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHumidity.Location = new System.Drawing.Point(428, 64);
            this.lblHumidity.Name = "lblHumidity";
            this.lblHumidity.Size = new System.Drawing.Size(88, 20);
            this.lblHumidity.TabIndex = 10;
            this.lblHumidity.Text = "Humidity: ";
            // 
            // lblTemperature
            // 
            this.lblTemperature.AutoSize = true;
            this.lblTemperature.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTemperature.Location = new System.Drawing.Point(428, 29);
            this.lblTemperature.Name = "lblTemperature";
            this.lblTemperature.Size = new System.Drawing.Size(121, 20);
            this.lblTemperature.TabIndex = 9;
            this.lblTemperature.Text = "Temperature: ";
            // 
            // lblSearchLon
            // 
            this.lblSearchLon.AutoSize = true;
            this.lblSearchLon.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSearchLon.Location = new System.Drawing.Point(140, 129);
            this.lblSearchLon.Name = "lblSearchLon";
            this.lblSearchLon.Size = new System.Drawing.Size(0, 20);
            this.lblSearchLon.TabIndex = 7;
            // 
            // lblLon
            // 
            this.lblLon.AutoSize = true;
            this.lblLon.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLon.Location = new System.Drawing.Point(35, 129);
            this.lblLon.Name = "lblLon";
            this.lblLon.Size = new System.Drawing.Size(99, 20);
            this.lblLon.TabIndex = 6;
            this.lblLon.Text = "Longitude: ";
            // 
            // lblSearchLat
            // 
            this.lblSearchLat.AutoSize = true;
            this.lblSearchLat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSearchLat.Location = new System.Drawing.Point(126, 94);
            this.lblSearchLat.Name = "lblSearchLat";
            this.lblSearchLat.Size = new System.Drawing.Size(0, 20);
            this.lblSearchLat.TabIndex = 5;
            // 
            // lblLat
            // 
            this.lblLat.AutoSize = true;
            this.lblLat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLat.Location = new System.Drawing.Point(35, 94);
            this.lblLat.Name = "lblLat";
            this.lblLat.Size = new System.Drawing.Size(85, 20);
            this.lblLat.TabIndex = 4;
            this.lblLat.Text = "Latitude: ";
            // 
            // lblSearchAddress
            // 
            this.lblSearchAddress.AutoSize = true;
            this.lblSearchAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSearchAddress.Location = new System.Drawing.Point(121, 63);
            this.lblSearchAddress.Name = "lblSearchAddress";
            this.lblSearchAddress.Size = new System.Drawing.Size(0, 20);
            this.lblSearchAddress.TabIndex = 3;
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddress.Location = new System.Drawing.Point(35, 63);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(80, 20);
            this.lblAddress.TabIndex = 2;
            this.lblAddress.Text = "Address:";
            // 
            // lblSearchName
            // 
            this.lblSearchName.AutoSize = true;
            this.lblSearchName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSearchName.Location = new System.Drawing.Point(101, 29);
            this.lblSearchName.Name = "lblSearchName";
            this.lblSearchName.Size = new System.Drawing.Size(0, 20);
            this.lblSearchName.TabIndex = 1;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(35, 29);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(60, 20);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "Name:";
            // 
            // tabPageCovid
            // 
            this.tabPageCovid.BackgroundImage = global::TopLocationByGintaDeirdreLouise.Properties.Resources.back2;
            this.tabPageCovid.Controls.Add(this.btnCovidMap);
            this.tabPageCovid.Controls.Add(this.lblCovidCountry);
            this.tabPageCovid.Controls.Add(this.chartCovid);
            this.tabPageCovid.Controls.Add(this.lblDsiplayRecovered);
            this.tabPageCovid.Controls.Add(this.lblRecovered);
            this.tabPageCovid.Controls.Add(this.lblDisplayConfirmed);
            this.tabPageCovid.Controls.Add(this.lblConfirmed);
            this.tabPageCovid.Controls.Add(this.lblDisplayDeaths);
            this.tabPageCovid.Controls.Add(this.lblDeaths);
            this.tabPageCovid.Controls.Add(this.lblLocation);
            this.tabPageCovid.Location = new System.Drawing.Point(4, 22);
            this.tabPageCovid.Name = "tabPageCovid";
            this.tabPageCovid.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageCovid.Size = new System.Drawing.Size(792, 228);
            this.tabPageCovid.TabIndex = 2;
            this.tabPageCovid.Text = "Covid-19";
            this.tabPageCovid.UseVisualStyleBackColor = true;
            this.tabPageCovid.Click += new System.EventHandler(this.tabPageCovid_Click);
            // 
            // btnCovidMap
            // 
            this.btnCovidMap.Location = new System.Drawing.Point(18, 195);
            this.btnCovidMap.Name = "btnCovidMap";
            this.btnCovidMap.Size = new System.Drawing.Size(170, 23);
            this.btnCovidMap.TabIndex = 10;
            this.btnCovidMap.Text = "Display Covid-19 Map";
            this.btnCovidMap.UseVisualStyleBackColor = true;
            this.btnCovidMap.Click += new System.EventHandler(this.btnCovidMap_Click);
            // 
            // lblCovidCountry
            // 
            this.lblCovidCountry.AutoSize = true;
            this.lblCovidCountry.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCovidCountry.Location = new System.Drawing.Point(31, 137);
            this.lblCovidCountry.Name = "lblCovidCountry";
            this.lblCovidCountry.Size = new System.Drawing.Size(57, 20);
            this.lblCovidCountry.TabIndex = 9;
            this.lblCovidCountry.Text = "label1";
            // 
            // chartCovid
            // 
            chartArea1.Name = "ChartArea1";
            this.chartCovid.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chartCovid.Legends.Add(legend1);
            this.chartCovid.Location = new System.Drawing.Point(331, 6);
            this.chartCovid.Name = "chartCovid";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Covid-19";
            this.chartCovid.Series.Add(series1);
            this.chartCovid.Size = new System.Drawing.Size(455, 212);
            this.chartCovid.TabIndex = 7;
            this.chartCovid.Text = "Covid-19";
            // 
            // lblDsiplayRecovered
            // 
            this.lblDsiplayRecovered.AutoSize = true;
            this.lblDsiplayRecovered.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDsiplayRecovered.Location = new System.Drawing.Point(156, 94);
            this.lblDsiplayRecovered.Name = "lblDsiplayRecovered";
            this.lblDsiplayRecovered.Size = new System.Drawing.Size(0, 20);
            this.lblDsiplayRecovered.TabIndex = 6;
            // 
            // lblRecovered
            // 
            this.lblRecovered.AutoSize = true;
            this.lblRecovered.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRecovered.Location = new System.Drawing.Point(26, 103);
            this.lblRecovered.Name = "lblRecovered";
            this.lblRecovered.Size = new System.Drawing.Size(105, 20);
            this.lblRecovered.TabIndex = 5;
            this.lblRecovered.Text = "Recovered: ";
            // 
            // lblDisplayConfirmed
            // 
            this.lblDisplayConfirmed.AutoSize = true;
            this.lblDisplayConfirmed.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDisplayConfirmed.Location = new System.Drawing.Point(146, 58);
            this.lblDisplayConfirmed.Name = "lblDisplayConfirmed";
            this.lblDisplayConfirmed.Size = new System.Drawing.Size(0, 20);
            this.lblDisplayConfirmed.TabIndex = 4;
            // 
            // lblConfirmed
            // 
            this.lblConfirmed.AutoSize = true;
            this.lblConfirmed.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConfirmed.Location = new System.Drawing.Point(26, 61);
            this.lblConfirmed.Name = "lblConfirmed";
            this.lblConfirmed.Size = new System.Drawing.Size(101, 20);
            this.lblConfirmed.TabIndex = 3;
            this.lblConfirmed.Text = "Confirmed: ";
            // 
            // lblDisplayDeaths
            // 
            this.lblDisplayDeaths.AutoSize = true;
            this.lblDisplayDeaths.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDisplayDeaths.Location = new System.Drawing.Point(131, 22);
            this.lblDisplayDeaths.Name = "lblDisplayDeaths";
            this.lblDisplayDeaths.Size = new System.Drawing.Size(0, 20);
            this.lblDisplayDeaths.TabIndex = 2;
            // 
            // lblDeaths
            // 
            this.lblDeaths.AutoSize = true;
            this.lblDeaths.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDeaths.Location = new System.Drawing.Point(26, 22);
            this.lblDeaths.Name = "lblDeaths";
            this.lblDeaths.Size = new System.Drawing.Size(77, 20);
            this.lblDeaths.TabIndex = 1;
            this.lblDeaths.Text = "Deaths: ";
            // 
            // lblLocation
            // 
            this.lblLocation.AutoSize = true;
            this.lblLocation.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLocation.Location = new System.Drawing.Point(558, 32);
            this.lblLocation.Name = "lblLocation";
            this.lblLocation.Size = new System.Drawing.Size(0, 33);
            this.lblLocation.TabIndex = 0;
            // 
            // TopLocation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1400, 650);
            this.Controls.Add(this.tabControlTopLocation);
            this.Name = "TopLocation";
            this.Text = "TopLocation";
            this.Load += new System.EventHandler(this.TopLocation_Load);
            this.tabControlTopLocation.ResumeLayout(false);
            this.tabPageSearchLoation.ResumeLayout(false);
            this.tabPageSearchLoation.PerformLayout();
            this.tabPageWeather.ResumeLayout(false);
            this.tabPageWeather.PerformLayout();
            this.tabPageCovid.ResumeLayout(false);
            this.tabPageCovid.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartCovid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControlTopLocation;
        private System.Windows.Forms.TabPage tabPageSearchLoation;
        private System.Windows.Forms.Button buttonGenerateResults;
        private System.Windows.Forms.ComboBox comboBoxSelectCity;
        private System.Windows.Forms.Label lblSelectCity;
        private System.Windows.Forms.ComboBox comboBoxSelectCountry;
        private System.Windows.Forms.Label lblSelectCountry;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.TabPage tabPageWeather;
        private System.Windows.Forms.ListView listViewDisplayLocationDetails;
        private System.Windows.Forms.ColumnHeader columnHeaderID;
        private System.Windows.Forms.ColumnHeader columnHeaderName;
        private System.Windows.Forms.ColumnHeader columnHeaderAddress;
        private System.Windows.Forms.ColumnHeader columnHeaderWebsite;
        private System.Windows.Forms.ColumnHeader columnHeaderLatitue;
        private System.Windows.Forms.ColumnHeader columnHeaderLongitude;
        private System.Windows.Forms.Button btnSelectCity;
        private System.Windows.Forms.Label lblSearchLon;
        private System.Windows.Forms.Label lblLon;
        private System.Windows.Forms.Label lblSearchLat;
        private System.Windows.Forms.Label lblLat;
        private System.Windows.Forms.Label lblSearchAddress;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.Label lblSearchName;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TabPage tabPageCovid;
        private System.Windows.Forms.Label lblDsiplayRecovered;
        private System.Windows.Forms.Label lblRecovered;
        private System.Windows.Forms.Label lblDisplayConfirmed;
        private System.Windows.Forms.Label lblConfirmed;
        private System.Windows.Forms.Label lblDisplayDeaths;
        private System.Windows.Forms.Label lblDeaths;
        private System.Windows.Forms.Label lblLocation;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartCovid;
        private System.Windows.Forms.Label lblGetPressure;
        private System.Windows.Forms.Label lblGetWindSpeed;
        private System.Windows.Forms.Label lblGetCloudiness;
        private System.Windows.Forms.Label lblGetHumidity;
        private System.Windows.Forms.Label lblGetTemperature;
        private System.Windows.Forms.Label lblPressure;
        private System.Windows.Forms.Label lblWindSpeed;
        private System.Windows.Forms.Label lblCloudiness;
        private System.Windows.Forms.Label lblHumidity;
        private System.Windows.Forms.Label lblTemperature;
        private System.Windows.Forms.Label lblCovidCountry;
        private System.Windows.Forms.Button btnCovidMap;
        private System.Windows.Forms.Button btnWeatherWebsite;
        private System.Windows.Forms.Button btnSelectedWeb;
    }
}

