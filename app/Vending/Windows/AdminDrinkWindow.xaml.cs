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
using System.Windows.Shapes;
using Vending.ViewModel;
using Vending.Window;

namespace Vending.Windows
{
    /// <summary>
    /// Логика взаимодействия для AdminDrinkWindow.xaml
    /// </summary>
    public partial class AdminDrinkWindow : System.Windows.Window
    {
        DrinkController controller = new DrinkController();

        public AdminDrinkWindow()
        {
            InitializeComponent();

            drinkList.ItemsSource = null;
            drinkList.ItemsSource = controller.Drink;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var drink = controller.Drink.Find(x => x.Id == Convert.ToInt32((sender as Button).Tag));

            EditDrink window = new EditDrink(drink);
            window.ShowDialog();

            drinkList.ItemsSource = null;
            drinkList.ItemsSource = controller.Drink;
        }
    }
}
