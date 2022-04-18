using C.V.ResumeWPF.View;
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
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace C.V.ResumeWPF
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        List<Page> Pages = new List<Page>();
        int index;
        public MainWindow()
        {
            InitializeComponent();
            //this.Pages = new List<Page>();
            //index = 0;
            ////Перечень страниц
            //Pages.Add(new OpenPage());
        }
        private void OpenningButton_Click(object sender, RoutedEventArgs e)
        {
            MainFrame.Content = (new OpenPage());
        }

        private void SubsequentButton_Click(object sender, RoutedEventArgs e)
        {
            if (MainFrame.Content == null)
            {
                MainFrame.Content = Pages[index].Content;
            }
            else
            {
                index++;
                if (index < Pages.Count)
                {
                    MainFrame.Content = Pages.ElementAt(index);
                }
            }
        }

        private void PreviousButton_Click(object sender, RoutedEventArgs e)
        {
            if (MainFrame.Content != null && index != 0)
            {
                index--;
                MainFrame.Content = Pages[index];
            }
        }
    }
}
