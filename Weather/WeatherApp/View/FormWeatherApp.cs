using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WeatherApp.Presenter;

namespace WeatherApp.View
{
    public partial class FormWeatherApp : Form
    {
        enum LastFunc { TODAY = 1, TOMORROW, FIVE, FIVEH }
        public static int test = 0, labelindex = 0;
        static string sub = null;
        static int iter = 0;


        public WeatherPresenter WeatherPresenter { get; set; }

        public void StartApplication()
        {
            Application.Run((Form)this);

        }

        public FormWeatherApp(WeatherPresenter weatherPresenter)
        {
            InitializeComponent();
            WeatherPresenter = weatherPresenter;
            //WeatherPresenter weatherPresenter = new WeatherPresenter();
        }

        // Единицы измерения +
        public void RadioButtonsUnitSet()
        {
            if (radioButtonCelsius.Checked)
            {
                WeatherPresenter.UnitsSet("metric");
            }
            else if (radioButtonFahrenheit.Checked)
            {
                WeatherPresenter.UnitsSet("imperial");
            }
            else if (radioButtonKelvin.Checked)
            {
                WeatherPresenter.UnitsSet("default");
            }
        }

        public void TemperatureUnits()
        {
            if (Options.Units == "metric")
                txtResult.Text += " °С\n";
            else if (Options.Units == "imperial")
                txtResult.Text += " °F\n";
            else
                txtResult.Text += " K\n";
        }

        public void TemperatureUnits(Label label)
        {
            if (Options.Units == "metric")
                label.Text += " °С\n";
            else if (Options.Units == "imperial")
                label.Text += " °F\n";
            else
                label.Text += " K\n";
        }

        public void SpeedUnits()
        {
            if (Options.Units == "imperial")
                txtResult.Text += " км/ч\n";
            else
                txtResult.Text += " м/с\n";
        }

        public void SpeedUnits(Label label)
        {
            if (Options.Units == "imperial")
                label.Text += " км/ч\n";
            else
                label.Text += " м/с\n";
        }

        // Вывод погоды
        public void WeatherToday()
        {
            WeatherPresenter.TodayWeatherSet();
            txtCityDay.Text = "Город: " + WeatherModel.City + '\n';
            DateTime dateValue = DateTime.Now;
            txtCityDay.Text += dateValue.Day + "." + dateValue.Month.ToString("00") + "." + dateValue.Year + "\n";
            txtCityDay.Text += dateValue.DayOfWeek.ToString() + "\n";
            txtResult.Text = "Погодные условия: " + WeatherModel.Description + " \n";
            txtResult.Text += "Температура: " + WeatherModel.Temperature;
            TemperatureUnits();
            txtResult.Text += "Мин. температура: " + WeatherModel.MinTemperature;
            TemperatureUnits();
            txtResult.Text += "Макс. температура: " + WeatherModel.MaxTemperature;
            TemperatureUnits();
            txtResult.Text += "Скорость ветра: " + WeatherModel.Speed;
            SpeedUnits();
            txtResult.Text += "Облачность: " + WeatherModel.Clouds + " %\n";
            txtResult.Text += "Давление: " + WeatherModel.Pressure + " Па\n";
            txtResult.Text += "Влажность: " + WeatherModel.Humidity + " %\n";

            this.BackgroundImage = Background.ChangeBackground();
            string picture = WeatherModel.Picture;
            pictureBox1.Load($"http://openweathermap.org/img/w/{picture}.png");
        }

        public void TomorrowShow()
        {
            txtResult.Text += "Погодные условия: " + WeatherModel.Description + '\n';
            txtResult.Text += "Температура: " + WeatherModel.Temperature;
            TemperatureUnits();
            txtResult.Text += "Скорость ветра: " + WeatherModel.Speed;
            SpeedUnits();
            txtResult.Text += "Облачность: " + WeatherModel.Clouds + " %\n";
            txtResult.Text += "Давление: " + WeatherModel.Pressure + " Па\n";
            txtResult.Text += "Влажность: " + WeatherModel.Humidity + " %\n";
          
                        this.BackgroundImage = Background.ChangeBackground();

           // ChangeBackground(WeatherModel.TommorowShowIndex);
            string picture = WeatherModel.Picture;
            pictureBox1.Load($"http://openweathermap.org/img/w/{picture}.png");
        }

        public void WeatherTomorrow()
        {
            txtCityDay.Text = "Город: " + WeatherModel.City + '\n';
            DateTime dateValue = DateTime.Now.AddDays(1);
            txtCityDay.Text += dateValue.Day + "." + dateValue.Month.ToString("00") + "." + dateValue.Year + "\n";
            txtCityDay.Text += dateValue.DayOfWeek.ToString() + "\n";

            txtResult.Text = "Мин. температура: " + WeatherModel.MinTemperature;
            TemperatureUnits();
            txtResult.Text += "Макс. температура: " + WeatherModel.MaxTemperature;
            TemperatureUnits();
            txtResult.Text += "\n";

            TomorrowShow();

        }

           

        // Кнопки
        private void BtnLocation_Click(object sender, EventArgs e)
        {
            txtCityName.Text = WeatherPresenter.DetermineLocation();
        }

        private void BtnTodayWeather_Click(object sender, EventArgs e)
        {
            Size = new System.Drawing.Size(500, 460);
            txtRes.Text = "";

            WeatherModel.Last =(int)LastFunc.TODAY;
            WeatherModel.TommorowShowIndex = 5; // 5-12
            WeatherModel.FiveDaysShowIndex = 1; // 1-5
            WeatherModel.FiveDaysHShowIndex = 1; // 1-5
            WeatherModel.IndexFiveDays = 0;
            WeatherModel.Index = 0;

            if (txtCityName.Text.Any())
            {
                try
                {
                    RadioButtonsUnitSet();
                    WeatherModel.City = txtCityName.Text;

                    WeatherPresenter.TodayWeatherSet();
                    WeatherToday();
                }
                catch
                {
                    txtRes.Text = null;
                    txtResult.Text = "Некорректное название города";
                }
            }
            else txtResult.Text = "Введите название города";

            try
            {
                txtResult.Text = Translating.TranslateResult(txtResult.Text);
                txtRes.Text = Translating.TranslateResult(txtRes.Text);
                txtCityDay.Text = Translating.TranslateResult(txtCityDay.Text);
            }
            catch { }
        }

        private void BtnTomorrowWeather_Click(object sender, EventArgs e)
        {
            Size = new System.Drawing.Size(500, 460);

            txtRes.Text = "";
            WeatherModel.Last = (int)LastFunc.TOMORROW;
            WeatherModel.FiveDaysShowIndex = 1; // 1-5
            WeatherModel.FiveDaysHShowIndex = 1; // 1-5
 
            WeatherModel.Index = 0;

            if (txtCityName.Text.Any())
            {
                try
                {
                    RadioButtonsUnitSet();
                    WeatherModel.City = txtCityName.Text;

                    WeatherModel.MinTemperature = 99999;
                    WeatherModel.MaxTemperature = -99999;
                    WeatherPresenter.TommorowWeatherSet();
                    WeatherTomorrow();
                }
                catch {
                    txtRes.Text = null;
                    txtResult.Text = "Некорректное название города";
                }
            }
            else txtResult.Text = "Введите название города";

            try
            {
                txtResult.Text = Translating.TranslateResult(txtResult.Text);
                txtRes.Text = Translating.TranslateResult(txtRes.Text);
                txtCityDay.Text = Translating.TranslateResult(txtCityDay.Text);
            }
            catch { }
        }
    
       

  

        // Меню +
       

        private void ExitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        // Замена переведенных кнопок +
        public void TextChange(List<string> texts)
        {
            exitToolStripMenuItem.Text = texts[1];
            lblEnterCity.Text = texts[2];
            btnLocation.Text = texts[3];
            btnToday.Text = texts[4];
            btnTomorrow.Text = texts[5];   
            radioButtonCelsius.Text = texts[8];
            radioButtonFahrenheit.Text = texts[9];
            radioButtonKelvin.Text = texts[10];
        }

        // Перевод кнопок + 
        static List<string> buttons = new List<string>();

        private void FormWeatherApp_Load(object sender, EventArgs e)
        {

        }

        private void PictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void TxtRes_Click(object sender, EventArgs e)
        {

        }

        private void TxtResult_Click(object sender, EventArgs e)
        {

        }

        public void WebClient()
        {
            using (WebClient wc = new WebClient())
            {
                wc.Encoding = Encoding.UTF8;

                buttons = new List<string>
                {
                    exitToolStripMenuItem.Text,
                    lblEnterCity.Text,
                    btnLocation.Text,
                    btnToday.Text,
                    btnTomorrow.Text,       
                    radioButtonCelsius.Text,
                    radioButtonFahrenheit.Text,
                    radioButtonKelvin.Text, 
                };


                for (int item = 0; item < 13; item++)
                {
                    var result = wc.DownloadString($"https://translate.yandex.net/api/v1.5/tr.json/translate?key=trnsl.1.1.20180519T085039Z.2c50b69f58c34887.7d37dc64e412a4142605130cdb6705d8e840df03&%20&text={buttons[item]}&lang={Languages.Language}");
                    var data = JObject.Parse(result);
                    buttons[item] = (string)data["text"][0];
                }

                TextChange(buttons);
            }
        }

    }
}
