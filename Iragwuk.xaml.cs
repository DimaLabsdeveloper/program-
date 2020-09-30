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

namespace applernnewwords
{
    /// <summary>
    /// Логика взаимодействия для Iragwuk.xaml
    /// </summary>
    public partial class Iragwuk : Window
    {
        public Iragwuk()
        {
            InitializeComponent();
        }

        private void Golowna1_Click(object sender, RoutedEventArgs e)
        {
            MainWindow b = new MainWindow();
            this.Close();
            b.Show();
        }

        private void Neww2_Click(object sender, RoutedEventArgs e)
        {
            Enwords y = new Enwords();
            this.Close();
            y.Show();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Settp k = new Settp();
            this.Close();
            k.Show();
        }

        private void Iregn_Click(object sender, RoutedEventArgs e)
        {
            Iragwen i = new Iragwen();
            this.Close();
            i.Show();
        }
    }
}
