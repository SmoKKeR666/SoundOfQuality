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
using System.Windows.Media.Media3D;
using System.Windows.Navigation;
using System.Windows.Shapes;
using SoundOfQuality.Model;

namespace SoundOfQuality.View.Pages
{
    /// <summary>
    /// Логика взаимодействия для MakeOrderPage.xaml
    /// </summary>
    public partial class MakeOrderPage : Page
    {
        public MakeOrderPage()
        {
            InitializeComponent();

            DatGr.ItemsSource = App.context.Orders.ToList();

            CustomerCmb.SelectedValue = "ID";
            CustomerCmb.DisplayMemberPath = "FullName";
            CustomerCmb.ItemsSource = App.context.Customers.ToList();

            ProductCmb.SelectedValue = "ID";
            ProductCmb.DisplayMemberPath = "Name";
            ProductCmb.ItemsSource = App.context.Products.ToList();
        }

        private void DatGr_Loaded(object sender, RoutedEventArgs e)
        {
            DatGr.ItemsSource = App.context.Orders.ToList();
        }
        private void MakeOrderBtn_Click(object sender, RoutedEventArgs e)
        {
            string mes = "";
            if (string.IsNullOrWhiteSpace(CustomerCmb.Text))
            {
                mes += "Выберите клиента\n";
            }
            if (string.IsNullOrWhiteSpace(ProductCmb.Text))
            {
                mes += "Выберите товар\n";
            }
            if (string.IsNullOrWhiteSpace(AmountTb.Text))
            {
                mes += "Введите количество\n";
            }
            if (mes != "")
            {
                MessageBox.Show(mes);
                mes = "";
                return;
            }

            Orders orders = new Orders()
            {
                Customers = CustomerCmb.SelectedItem as Customers,
                Products = ProductCmb.SelectedItem as Products,
                TotalAmount = AmountTb.Text,
                OrderDate = DateTime.Today
            };

            App.context.Orders.Add(orders);
            App.context.SaveChanges();
            MessageBox.Show("Заказ добавлен!");
            DatGr.ItemsSource = App.context.Orders.ToList();

            CustomerCmb.Text = "";
            ProductCmb.Text = "";
            AmountTb.Text = "";
        }
    }
}
