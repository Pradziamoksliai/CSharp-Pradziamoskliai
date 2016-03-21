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

namespace irasymasIsTextBox
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        //Variables

        string nr;



        public MainWindow()
        {
            InitializeComponent();
        }

        private void textBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            TextBox textBox = sender as TextBox;

        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            TextBox textBox = sender as TextBox;
            nr = textBox.Text;
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            var Sarasas = new Sarasas();
            Sarasas.Show();
        }
    }
}
