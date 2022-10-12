using AllOperationsLibrary.Entities;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO.Packaging;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Json;
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

namespace CM_Project_WithAPI
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        HttpClient httpClient;

        public MainWindow()
        {
            InitializeComponent();
            httpClient = new HttpClient();

        }
        private void AddButton_Click(object sender, RoutedEventArgs e)
        {
            CustomerEntity pe = new CustomerEntity();

            pe.NAME=name.Text;
            pe.ADDRESS=address.Text;     
            pe.CONTACT=contact.Text;
            pe.DATE_OF_BIRTH=dob.Text;         
            pe.CITYID=cityId.Text;
            pe.PACKAGEID=packageId.Text;
            pe.GROUPID=groupId.Text;
            pe.USER_ID=userId.Text;
            pe.PASSWORD=password.Text;
           

            var result = httpClient.PostAsJsonAsync("https://localhost:44393/api/Customer", pe);


        }
    }
}
