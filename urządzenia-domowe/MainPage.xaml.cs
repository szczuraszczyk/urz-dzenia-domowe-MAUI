namespace urządzenia_domowe
{
    public partial class MainPage : ContentPage
    {
        int countOdkurzacz = 0;

        public MainPage()
        {
            InitializeComponent();
        }

        private void OnClickPralka(object sender, EventArgs e)
        {

            bool czyNull = String.IsNullOrEmpty(podanyNrPrania.Text);

            if (czyNull == true)
            {
                return;
            }

            int intNrPrania = Convert.ToInt32(podanyNrPrania.Text);


            if (intNrPrania >= 1 && intNrPrania <= 12)
            {
                nrPrania.Text = $"Numer prania: {podanyNrPrania.Text}";
            } else
            {
                nrPrania.Text = "Numer prania: nie podano";
            }
        }

        private void OnClickOdkurzacz(object sender, EventArgs e)
        {
            countOdkurzacz++;

            if (countOdkurzacz % 2 == 1)
            {
                btnOdkurzacz.Text = "Wyłącz";
                czyWlaczony.Text = "Odkurzacz włączony";
            } else if (countOdkurzacz % 2 == 0)
            {
                btnOdkurzacz.Text = "Włącz";
                czyWlaczony.Text = "Odkurzacz wyłączony";
            }

            //bool isOn = (countOdkurzacz % 2) == 1;

            //czyWlaczony.Text = isOn ? "Odkurzacz włączony" : "Odkurzacz wyłączony";
            //btnOdkurzacz.Text = isOn ? "Wyłącz" : "Włącz";
        }
    }
}
