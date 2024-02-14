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

namespace Practos1_2
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Random rand = new Random();
        Button[] knopki;
        public MainWindow()
        {
            InitializeComponent();
            knopki = new Button[] { knopka1, knopka2, knopka3, knopka4, knopka5, knopka6, knopka7, knopka8, knopka9};
        }


        public void knopka1_Click(object sender, RoutedEventArgs e)
        {
            (sender as Button).Content = "X";
            (sender as Button).IsEnabled = false;
            int knopka = rand.Next(knopki.Length);
            while (knopki[knopka].IsEnabled == false)
                knopka = rand.Next(knopki.Length);
                knopki[knopka].Content = "0";
                knopki[knopka].IsEnabled = false;

            if ((knopka1 as Button).Content == "X" && (knopka2 as Button).Content == "X" && (knopka3 as Button).Content == "X")
            {
                MessageBox.Show("Крестики выиграли");
            }
            if ((knopka4 as Button).Content == "X" && (knopka5 as Button).Content == "X" && (knopka6 as Button).Content == "X")
            {
                MessageBox.Show("Крестики выиграли");
            }
            if ((knopka7 as Button).Content == "X" && (knopka8 as Button).Content == "X" && (knopka9 as Button).Content == "X")
            {
                MessageBox.Show("Крестики выиграли");
            }
            if ((knopka1 as Button).Content == "X" && (knopka4 as Button).Content == "X" && (knopka7 as Button).Content == "X")
            {
                MessageBox.Show("Крестики выиграли");
            }
            if ((knopka2 as Button).Content == "X" && (knopka5 as Button).Content == "X" && (knopka8 as Button).Content == "X")
            {
                MessageBox.Show("Крестики выиграли");
            }
            if ((knopka3 as Button).Content == "X" && (knopka6 as Button).Content == "X" && (knopka9 as Button).Content == "X")
            {
                MessageBox.Show("Крестики выиграли");
            }
            if ((knopka1 as Button).Content == "X" && (knopka5 as Button).Content == "X" && (knopka9 as Button).Content == "X")
            {
                MessageBox.Show("Крестики выиграли");
            }
            if ((knopka3 as Button).Content == "X" && (knopka5 as Button).Content == "X" && (knopka7 as Button).Content == "X")
            {
                MessageBox.Show("Крестики выиграли");
            }
            if ((knopka1 as Button).Content == "0" && (knopka2 as Button).Content == "0" && (knopka3 as Button).Content == "0")
            {
                MessageBox.Show("Крестики выиграли");
            }
            if ((knopka4 as Button).Content == "0" && (knopka5 as Button).Content == "0" && (knopka6 as Button).Content == "0")
            {
                MessageBox.Show("Крестики выиграли");
            }
            if ((knopka7 as Button).Content == "0" && (knopka8 as Button).Content == "0" && (knopka9 as Button).Content == "0")
            {
                MessageBox.Show("Крестики выиграли");
            }
            if ((knopka1 as Button).Content == "0" && (knopka4 as Button).Content == "0" && (knopka7 as Button).Content == "0")
            {
                MessageBox.Show("Крестики выиграли");
            }
            if ((knopka2 as Button).Content == "0" && (knopka5 as Button).Content == "0" && (knopka8 as Button).Content == "0")
            {
                MessageBox.Show("Крестики выиграли");
            }
            if ((knopka3 as Button).Content == "0" && (knopka6 as Button).Content == "0" && (knopka9 as Button).Content == "0")
            {
                MessageBox.Show("Крестики выиграли");
            }
            if ((knopka1 as Button).Content == "0" && (knopka5 as Button).Content == "0" && (knopka9 as Button).Content == "0")
            {
                MessageBox.Show("Крестики выиграли");
            }
            if ((knopka3 as Button).Content == "0" && (knopka5 as Button).Content == "0" && (knopka7 as Button).Content == "0")
            {
                MessageBox.Show("Крестики выиграли");
            }
        }

        private void knopka10_Click(object sender, RoutedEventArgs e)
        {
            (knopka1 as Button).Content = "";
            (knopka1 as Button).IsEnabled = true;
            (knopka2 as Button).Content = "";
            (knopka2 as Button).IsEnabled = true;
            (knopka3 as Button).Content = "";
            (knopka3 as Button).IsEnabled = true;
            (knopka4 as Button).Content = "";
            (knopka4 as Button).IsEnabled = true;
            (knopka5 as Button).Content = "";
            (knopka5 as Button).IsEnabled = true;
            (knopka6 as Button).Content = "";
            (knopka6 as Button).IsEnabled = true;
            (knopka7 as Button).Content = "";
            (knopka7 as Button).IsEnabled = true;
            (knopka8 as Button).Content = "";
            (knopka8 as Button).IsEnabled = true;
            (knopka9 as Button).Content = "";
            (knopka9 as Button).IsEnabled = true;
        }
    }
}
