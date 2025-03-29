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
using SoundOfQuality.Model;

namespace SoundOfQuality.View.Pages
{
    /// <summary>
    /// Логика взаимодействия для AddProductPage.xaml
    /// </summary>
    public partial class AddProductPage : Page
    {
        public AddProductPage()
        {
            InitializeComponent();

            DatGr.ItemsSource = App.context.Products.ToList();
        }

        private void DatGr_Loaded(object sender, RoutedEventArgs e)
        {
            DatGr.ItemsSource = App.context.Products.ToList();
        }

        private void AddProductBtn_Click(object sender, RoutedEventArgs e)
        {
            string mes = "";
            if (string.IsNullOrWhiteSpace(NameTb.Text))
            {
                mes += "Введите название\n";
            }
            if (string.IsNullOrWhiteSpace(BrandTb.Text))
            {
                mes += "Введите бренд\n";
            }
            if (string.IsNullOrWhiteSpace(ModelTb.Text))
            {
                mes += "Введите модель\n";
            }
            if (string.IsNullOrWhiteSpace(PriceTb.Text))
            {
                mes += "Введите цену\n";
            }
            if (string.IsNullOrWhiteSpace(AmountInWarehouseTb.Text))
            {
                mes += "Введите количество товара на складе\n";
            }
            if (string.IsNullOrWhiteSpace(DescriptionTb.Text))
            {
                mes += "Введите описание\n";
            }
            if (mes != "")
            {
                MessageBox.Show(mes);
                mes = "";
                return;
            }

            Products products = new Products()
            {
                Name = NameTb.Text,
                Brand = BrandTb.Text,
                Model = ModelTb.Text,
                Price = Convert.ToInt32(PriceTb.Text),
                AmountInStock = AmountInWarehouseTb.Text,
                Description = DescriptionTb.Text,
                AddDate = DateTime.Today
            };

            App.context.Products.Add(products);
            App.context.SaveChanges();
            MessageBox.Show("Товар добавлен!");
            DatGr.ItemsSource = App.context.Products.ToList();

            NameTb.Text = "";
            BrandTb.Text = "";
            ModelTb.Text = "";
            PriceTb.Text = "";
            AmountInWarehouseTb.Text = "";
            DescriptionTb.Text = "";
        }
    }
}
