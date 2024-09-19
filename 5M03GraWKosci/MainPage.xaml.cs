namespace _5M03GraWKosci
{
    public partial class MainPage : ContentPage
    {
        int sumaGra = 0;

        public MainPage()
        {
            InitializeComponent();
        }

        private void btnRzutClicked(object sender, EventArgs e)
        {
            Random r = new Random();
            int los;
            int sumaRzut = 0;

            los = r.Next(1, 7);
            sumaRzut += los;
            imgKosc1.Source = "kosc" + los.ToString() + ".png";

            los = r.Next(1, 7);
            sumaRzut += los;
            imgKosc2.Source = "kosc" + los.ToString() + ".png";

            lblWynikLos.Text = sumaRzut.ToString();
            sumaGra += sumaRzut;
            lblWynikGra.Text = sumaGra.ToString();
        }
        private void btnResetGraClicked(object sender, EventArgs e)
        {
            lblWynikGra.Text = "Zrób:\nustaw wsztstkie kostki na symbol?\n" +
                "ustaw sumaRzut na 0 i etykietę na 0\n" +
                "ustaw sumaGra na 0 i etykiete na 0";
        }
    }

}
