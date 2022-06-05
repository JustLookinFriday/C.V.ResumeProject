using C.V.ResumeWPF.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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

namespace C.V.ResumeWPF.View
{
    /// <summary>
    /// Логика взаимодействия для EndPage.xaml
    /// </summary>
    public partial class EndPage : Page
    {
        //Подключение к базе и вывод данных по Guest
        Core db = new Core();

        List<Guest> arrayGuests;
        public EndPage()
        {
            InitializeComponent();
            arrayGuests = db.context.Guest.ToList();
            OutputGrid.DataContext = arrayGuests;
        }

        private void SpecialButton_Click(object sender, RoutedEventArgs e)
        {
            Separator.Visibility = Visibility.Collapsed;
            SpecialButton.Visibility = Visibility.Hidden;
            PrintButton.Visibility = Visibility.Visible;
            ReturnSpecialButton.Visibility = Visibility.Visible;
        }

        private void PrintButton_Click(object sender, RoutedEventArgs e)
        {
            if (MenuButton.Visibility == Visibility.Visible)
            {
                MenuButton.Visibility = Visibility.Collapsed;
                PrintDialog printDialog = new PrintDialog();
                if (printDialog.ShowDialog() == true)
                {
                    // Увеличить размер в 5 раз
                    PrintPage.LayoutTransform = new ScaleTransform(5, 5);

                    // Определить поля
                    int pageMargin = 5;

                    // Получить размер страницы
                    Size pageSize = new Size(printDialog.PrintableAreaWidth - pageMargin * 2, printDialog.PrintableAreaHeight - 20);

                    // Инициировать установку размера элемента
                    PrintPage.Measure(pageSize);
                    PrintPage.Arrange(new Rect(pageMargin, pageMargin, pageSize.Width, pageSize.Height));

                    // Напечатать элемент
                    printDialog.PrintVisual(PrintPage, "My First Blow Job");
                    MenuButton.Visibility = Visibility.Visible;
                    MessageBox.Show("You were able to make a resume at the expense of your motherboard!", "I want children from you... and 5 puppies", MessageBoxButton.OK, MessageBoxImage.Information);
                }
                else
                {
                    MenuButton.Visibility = Visibility.Visible;
                }
            }
        }

        private void ReturnSpecialButton_Click(object sender, RoutedEventArgs e)
        {
            Separator.Visibility = Visibility.Visible;
            SpecialButton.Visibility = Visibility.Visible;
            PrintButton.Visibility = Visibility.Hidden;
            ReturnSpecialButton.Visibility = Visibility.Hidden;
        }

        private void AddIDButton_Click(object sender, RoutedEventArgs e)
        {
            if (EndingSPanel.Visibility == Visibility.Visible)
            {
                try
                {
                    Guest guest = new Guest()
                    {
                        IDBasicInfo = Convert.ToInt32(BasicID_TBox.Text),
                        IDPersonalInfo = Convert.ToInt32(PersonalID_TBox.Text),
                        IDExperience = Convert.ToInt32(ExperienceID_TBox.Text),
                        IDEducation = Convert.ToInt32(EducationID_TBox.Text),
                        IDCousersAndTrainings = Convert.ToInt32(CoursesID_TBox.Text),
                        IDITSkills = Convert.ToInt32(BasicID_TBox.Text),
                        IDAdditionalInfo = Convert.ToInt32(BasicID_TBox.Text),

                    };
                    EndingSPanel.Visibility = Visibility.Collapsed;
                    HiddenGrid.Visibility = Visibility.Visible;
                    MenuButton.Visibility = Visibility.Visible;
                    db.context.Guest.Add(guest);
                    db.context.SaveChanges();
                    MessageBox.Show("I'M PROUD OF YOU THAT YOU WERE ABLE TO FILL OUT EVERYTHING CORRECTLY AND PRESS THIS FUCKING ENGLISH BUTTON", "YOU DID IT!", MessageBoxButton.OK, MessageBoxImage.Information);
                }
                catch
                {
                    MessageBox.Show("YOUR MOTHER IS A COLLEGE STUDENT AND YOUR FATHER IS A WHORE! HOW DID YOU MANAGE TO CAUSE THIS ERROR AT ALL? SCREWED UP?", "WHAT HAVE YOU DONE?!", MessageBoxButton.OK, MessageBoxImage.Warning);
                }
            }
        }

        
    }
}
