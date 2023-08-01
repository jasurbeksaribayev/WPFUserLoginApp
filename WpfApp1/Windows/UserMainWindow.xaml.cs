using System.Linq;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using WpfApp1.Controllers;
using WpfApp1.Data.GenericRepositories;
using WpfApp1.Domain.Entities;
using WpfApp1.Pages;

namespace WpfApp1.Windows
{
    /// <summary>
    /// Interaction logic for UserMainWindow.xaml
    /// </summary>
    public partial class UserMainWindow : Window
    {
        private readonly GenericRepository<Market> marketRepository;
        private readonly MarketUpdatePage marketUpdatePage;

        public UserMainWindow()
        {
            InitializeComponent();
            marketRepository = new GenericRepository<Market>();
            marketUpdatePage = new MarketUpdatePage();
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            LoadWindow();
        }

        private void LoadWindow()
        {
            var markets = marketRepository.
                                       GetAll();
            ControllerOfMarkets.Items.Clear();

            foreach (var market in markets)
            {
                MarketsController marketsController = new MarketsController();

                marketsController.Id = market.Id;
                marketsController.MarketNameTxt.Text = market.Name;

                Button button = new Button()
                {
                    Height = 120,
                    Width = 190,
                    Background = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#FDFBFD")),
                    Padding = new Thickness(-3, -1, 2, 2),
                    BorderBrush = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#FF5800")),
                    BorderThickness = new Thickness(2),
                    Margin = new Thickness(2)
                };

                button.Content = marketsController;

                button.Click += MarketControllerBtn_Click;

                ControllerOfMarkets.Items.Add(button);
            }
        }
        private async void MarketControllerBtn_Click(object sender, RoutedEventArgs e)
        {
            var marketInfo = (sender as Button).Content as MarketsController;

            var market = await marketRepository.GetAsync(marketInfo.Id);
            if (market != null)
            {
                marketUpdatePage.MarketId.Text = marketInfo.Id.ToString();
                marketUpdatePage.MarketName.Text = market.Name ;
                marketUpdatePage.MarketCreationTime.Text = market.CreatedTime.ToString();
                if (market.LastModifiesTime != null)
                    marketUpdatePage.MarketUpdatedTime.Text = market.LastModifiesTime.ToString();
                else

                    marketUpdatePage.MarketUpdatedTime.Text = "not updated yet";

                    marketPageFrame.Content = marketUpdatePage;
            }
            else
            {
                marketPageFrame.NavigationService.Navigate(null);

                MessageBox.Show("Nothing found. Please, Press 'Refresh' button");
            }
        }

        private void openMarketAddPageBtn_Click(object sender, RoutedEventArgs e)
        {
            marketPageFrame.Content = new MarketAddPage();
        }

        private void RefreshBtn_Click(object sender, RoutedEventArgs e)
        {
            LoadWindow();
        }
    }
}