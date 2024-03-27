using NoobsMuc.Coinmarketcap.Client;

namespace BitcoinPriceMonitor
{
    public partial class MainPage : ContentPage
    {
        int count = 0;

        //Timer vTimer = new Timer();

        public MainPage()
        {
            InitializeComponent();
        }

        private void OnCounterClicked(object sender, EventArgs e)
        {
            // Substitua <YourApiKey> pela sua chave de API do CoinMarketCap
            ICoinmarketcapClient client = new CoinmarketcapClient("e9add20c-e332-4b84-9b11-2beae8194516");
            Currency currency = client.GetCurrencyBySlug("bitcoin");

            decimal price = currency.Price;
            CounterBtn.Text = "$" + price.ToString("#.00") + "";
            SemanticScreenReader.Announce(CounterBtn.Text);

            //while (true)
            //{
            //    try
            //    {

            //    }
            //    catch (Exception ex)
            //    {
            //    }

            //    Thread.Sleep(3000);
            //}

        }
    }

}
