using System;
using System.Windows;
using System.Windows.Controls;
using WpfApp1.Data.GenericRepositories;
using WpfApp1.Domain.Entities;

namespace WpfApp1.Pages
{
    /// <summary>
    /// Interaction logic for MarketUpdatePage.xaml
    /// </summary>
    public partial class MarketUpdatePage : Page
    {
        private readonly GenericRepository<Market> marketRepository;
        private readonly Market market;

        public MarketUpdatePage()
        {
            InitializeComponent();
            this.marketRepository = new GenericRepository<Market>();
            market = new Market();
        }
        private async void DeleteBtn_Click(object sender, RoutedEventArgs e)
        {
            int marketId = int.Parse(MarketId.Text);

            MessageBoxResult messageBoxResult = MessageBox.Show("Do you want to delete?", "Confirmation", MessageBoxButton.YesNoCancel);


            if (messageBoxResult == MessageBoxResult.Yes)
            {
                await marketRepository.DeleteAsync(marketId);

                MessageBox.Show("Successfully deleted");

                this.NavigationService.Navigate(null);
            }
        }

        private void UpdateBtn_Click(object sender, RoutedEventArgs e)
        {
            int marketId = int.Parse(MarketId.Text);

            var market = marketRepository.GetAsync(marketId).Result;

            market.Name = MarketName.Text;
            market.LastModifiesTime = DateTime.UtcNow;

            marketRepository.UpdateAsync(market);

            MessageBox.Show("Successfully updated");

            this.NavigationService.Navigate(null);
        }
    }
}
