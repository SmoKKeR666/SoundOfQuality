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
    /// Логика взаимодействия для AddManagerPage.xaml
    /// </summary>
    public partial class AddManagerPage : Page
    {
        public AddManagerPage()
        {
            InitializeComponent();

            DatGr.ItemsSource = App.context.Managers.ToList();
        }
        private void DatGr_Loaded(object sender, RoutedEventArgs e)
        {
            DatGr.ItemsSource = App.context.Managers.ToList();
        }

        private void AddManagerBtn_Click(object sender, RoutedEventArgs e)
        {
            string mes = "";
            if (string.IsNullOrWhiteSpace(FullNameTb.Text))
            {
                mes += "Введите ФИО\n";
            }
            if (string.IsNullOrWhiteSpace(EmailTb.Text))
            {
                mes += "Введите почту\n";
            }
            if (string.IsNullOrWhiteSpace(PhoneTb.Text))
            {
                mes += "Введите телефон\n";
            }
            if (string.IsNullOrWhiteSpace(AddressTb.Text))
            {
                mes += "Введите адрес\n";
            }
            if (string.IsNullOrWhiteSpace(LoginTb.Text))
            {
                mes += "Введите логин\n";
            }
            if (string.IsNullOrWhiteSpace(PasswordTb.Text))
            {
                mes += "Введите пароль\n";
            }
            if (mes != "")
            {
                MessageBox.Show(mes);
                mes = "";
                return;
            }

            Managers managers = new Managers()
            {
                FullName = FullNameTb.Text,
                Email = EmailTb.Text,
                Phone = PhoneTb.Text,
                Address = AddressTb.Text,
                Login = LoginTb.Text,
                Password = PasswordTb.Text
            };

            App.context.Managers.Add(managers);
            App.context.SaveChanges();
            MessageBox.Show("Менеджер добавлен!");
            DatGr.ItemsSource = App.context.Managers.ToList();

            FullNameTb.Text = "";
            EmailTb.Text = "";
            PhoneTb.Text = "";
            AddressTb.Text = "";
        }
    }
}
