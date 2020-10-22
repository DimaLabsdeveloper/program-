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
using System.Data.SqlClient;
using MySql.Data.MySqlClient;
using System.Data;
using System.Data.SQLite;

namespace applernnewwords
{
    /// <summary>
    /// Логика взаимодействия для Lernuk.xaml
    /// </summary>
    public partial class Lernuk : Window
    {
        public Lernuk()
        {
            InitializeComponent();
            englbutton.Visibility = Visibility.Hidden;
        }

        private void home_Click(object sender, RoutedEventArgs e)
        {
            MainWindow o = new MainWindow();
            o.Show();
            this.Close();
        }

        private void ireg_Click(object sender, RoutedEventArgs e)
        {

            Iragwen q = new Iragwen();
            this.Close();
            q.Show();
        }

        private void myword_Click(object sender, RoutedEventArgs e)
        {
            Myword k = new Myword();
            k.Show();
            this.Close();
        }




        int uk =0;
        private void R1_Click(object sender, RoutedEventArgs e)
        {
            englbutton.Visibility = Visibility.Visible;
            text.Content = "натисніть на слово щоб побатити переклад";

            string cs = @"Data Source=./coolword.db";
            //foreach (row in collection)
            //{
            //    Console.WriteLine($"Element #{row}");
            //}
            string fileName = "myfile.ext";
            string path1 = @"coolword.db";
            string path2 = @"\coolword.db";
            string fullPath;

            fullPath = System.IO.Path.GetFullPath(path1);
            
            fullPath = System.IO.Path.GetFullPath(fileName);
           

            fullPath = System.IO.Path.GetFullPath(path2);
           
            
                englbutton.Visibility = Visibility.Visible;
                text.Content = "click on a word to see the translation";
                ukrlabel.Content = "";
            uk++;
                //try
                //{
                    using (SQLiteConnection cn = new SQLiteConnection(fullPath))
                    {



                        using (SQLiteCommand cmd = new SQLiteCommand("SELECT * FROM word WHERE id= " + uk, cn))
                        {

                            cn.Open();

                            using (SQLiteDataReader dataReader = cmd.ExecuteReader())
                            {

                                if (dataReader.HasRows)
                                {

                                    while (dataReader.Read())
                                    {

                                        englbutton.Content = (dataReader.GetString(1));

                                    }

                                }
                            }
                        }
                    }
                //}
                //catch
                //{
                //    englbutton.Visibility = Visibility.Hidden;
                //    MessageBox.Show("Ой, виникла якась проблема");
                //}
            
           

        }

        private void newword_Click(object sender, RoutedEventArgs e)
        {
            Enwords h = new Enwords();
            h.Show();
            this.Close();
        }

        private void proprog_Click(object sender, RoutedEventArgs e)
        {
            Proprog j = new Proprog();
            this.Close();
            j.Show();
        }

        private void sett_Click(object sender, RoutedEventArgs e)
        {
            Settp p = new Settp();
            this.Close();
            p.Show();
        }
        int id = 0;
        private void englbutton_Click(object sender, RoutedEventArgs e)
        {

            string cs = @"Data Source=coolword.db";

            string fileName = "coolword.db";
            string path1 = @"coolword.db";
            string path2 = @"\coolword.db";
            string fullPath;

            fullPath = System.IO.Path.GetFullPath(path1);
            Console.WriteLine("GetFullPath('{0}') returns '{1}'",
                path1, fullPath);

            fullPath = System.IO.Path.GetFullPath(fileName);
            Console.WriteLine("GetFullPath('{0}') returns '{1}'",
                fileName, fullPath);

            fullPath = System.IO.Path.GetFullPath(path2);
            Console.WriteLine("GetFullPath('{0}') returns '{1}'",
                path2, fullPath);
            //try
            //{
            using (SQLiteConnection cn = new SQLiteConnection(cs))
            {



                using (SQLiteCommand cmd = new SQLiteCommand("SELECT * FROM word WHERE id= " + uk, cn))
                {

                    cn.Open();

                    using (SQLiteDataReader dataReader = cmd.ExecuteReader())
                    {

                        if (dataReader.HasRows)
                        {

                            while (dataReader.Read())
                            {

                                ukrlabel.Content = (dataReader.GetString(2));

                            }

                        }
                    }
                }
            }
            //}

            //catch {

            //    MessageBox.Show("Ой, виникла якась проблема");
            //}    

        }
    }
}
