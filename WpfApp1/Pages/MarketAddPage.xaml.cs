using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using WpfApp1.Data.GenericRepositories;
using WpfApp1.Domain.Entities;

namespace WpfApp1.Pages
{
    /// <summary>
    /// Interaction logic for MarketAddPage.xaml
    /// </summary>
    public partial class MarketAddPage : Page
    {
        Market market;
        private readonly GenericRepository<Market> marketRepository;

        public MarketAddPage()
        {
            InitializeComponent();
            market = new Market();
            this.marketRepository = new GenericRepository<Market>();
        }

        private async void mealAddBtn_Click(object sender, RoutedEventArgs e)
        {
            market.Name = AddMarketName.Text;

            await marketRepository.AddAsync(market);

            MessageBox.Show("Successfully added");

            this.NavigationService.Navigate(null);
        } 
    }
}
