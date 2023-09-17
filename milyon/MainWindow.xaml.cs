using milyon.models;
using milyon.view;
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

namespace milyon
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Phonevm viewModel;
        MobileDbContext mobileDbContext;
        public MainWindow()
        {
            InitializeComponent();
            viewModel = new Phonevm();
            mobileDbContext= new MobileDbContext();
            DataContext = viewModel;

        }

        private void Mobiles_Loaded(object sender, RoutedEventArgs e)
        {
            viewModel.LoadData(mobileDbContext.Mobiles.ToList());
        }

       

        private void loadingdata_Click(object sender, RoutedEventArgs e)
        {
            viewModel.LoadData(mobileDbContext.Mobiles.ToList());
        }

        private void TextBox_KeyUp1(object sender, KeyEventArgs e)
        {

        }

    }
}
