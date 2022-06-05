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

namespace C.V.ResumeWPF.View
{
    /// <summary>
    /// Логика взаимодействия для OpenPage.xaml
    /// </summary>
    public partial class OpenPage : Page
    {
        int i = 1;
        public OpenPage()
        {
            InitializeComponent();
        }

        private void PreviousButton_Click(object sender, RoutedEventArgs e)
        {
            i--;
            if (i < 1)
            {
                i = 5;
            }
            Menu.Source = new BitmapImage(new Uri(@"../../Assets/Images/MenuImages/" + i + ".png", UriKind.Relative));
        }

        private void NextButton_Click(object sender, RoutedEventArgs e)
        {
            i++;
            if (i > 5)
            {
                i = 1;
            }
            Menu.Source = new BitmapImage(new Uri(@"../../Assets/Images/MenuImages/" + i + ".png", UriKind.Relative));
        }
    }
}
