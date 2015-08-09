using System;
using System.Collections.Generic;
using System.Diagnostics;
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

namespace WPF_Game
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public Game TheGame { get; set; }

        public MainWindow()
        {
            InitializeComponent();
            TheGame = new Game();
        }


        private void BtnStart_Click(object sender, RoutedEventArgs e)
        {

            TheGame.CounterC = 0;
            CScoreTextBox.Text = TheGame.CounterC.ToString();
            TheGame.CounterP = 0;
            ScoreTextBox.Text = TheGame.CounterP.ToString();
        }


        private void BtnDeal_Click(object sender, RoutedEventArgs e)
        {
            int p = TheGame.CreatePlayerNumbers();
            int c = TheGame.CreateComputerNumbers();

            if (p < c)
            {
                TheGame.CounterC ++;
            }
            else if (p > c)
            {
                TheGame.CounterP ++;
            }
            else
            {
                TheGame.CounterC ++;
                TheGame.CounterP ++;
            }

            ScoreTextBox.Text = TheGame.CounterP.ToString();
            CScoreTextBox.Text = TheGame.CounterC.ToString();
           

            BitmapImage b = new BitmapImage();
            BitmapImage d = new BitmapImage();

            b.BeginInit();
            b.UriSource = new Uri(@"H:\VisualStudio Katarina\WPF_Game\WPF_Game\Images\dice" +p+ ".png");
            ImageP.Source = b;
            b.EndInit();

            d.BeginInit();
            d.UriSource = new Uri(@"H:\VisualStudio Katarina\WPF_Game\WPF_Game\Images\dice" +c+ ".png");
            ImageC.Source = d;
            d.EndInit();

            if (TheGame.CounterP == 10 || TheGame.CounterC == 10)
            {
                MessageBox.Show("Game over, click start to start over");
            }


        }
       
           
    }
}
