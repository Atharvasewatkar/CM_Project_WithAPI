using AllOperationsLibrary.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Json;
using System.Net.NetworkInformation;
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

namespace CM_Project_WithAPI
{
    /// <summary>
    /// Interaction logic for newWindow.xaml
    /// </summary>
    public partial class newWindow : Window
    {
        HttpClient httpClient;
        public newWindow()
        {
            InitializeComponent();
         httpClient = new HttpClient();
        }

        private void AddPackage(object sender, RoutedEventArgs e)
        {

           PackageEntity pe = new PackageEntity();

            pe.PACKAGE = package.Text;
            pe.PACKAGEPRICE =int.Parse(price.Text);

            var result = httpClient.PostAsJsonAsync("https://localhost:44393/api/Package", pe);

            reply.Content = result;
        }
    }
}
