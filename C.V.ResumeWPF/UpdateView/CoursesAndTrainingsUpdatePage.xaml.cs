using C.V.ResumeWPF.Model;
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

namespace C.V.ResumeWPF.View.UpdateView
{
    /// <summary>
    /// Логика взаимодействия для CoursesAndTrainingsUpdatePage.xaml
    /// </summary>
    public partial class CoursesAndTrainingsUpdatePage : Page
    {
        //Вывод страниц и подключение к базе
        Core db = new Core();

        List<YearOfGraduationTable> arrayYearOfGraduation;

        public CoursesAndTrainingsUpdatePage()
        {
            InitializeComponent();

            //Вывод таблицы YearOfGraduationTable
            arrayYearOfGraduation = db.context.YearOfGraduationTable.ToList();

            YearOfGraduation_CBox.ItemsSource = arrayYearOfGraduation;
            YearOfGraduation_CBox.SelectedValuePath = "IDYearOfGraduation";
            YearOfGraduation_CBox.DisplayMemberPath = "YearOfGraduation";
            YearOfGraduation_CBox.SelectedIndex = 0;
        }

        private void SpecialButton_Click(object sender, RoutedEventArgs e)
        {
            Separator.Visibility = Visibility.Collapsed;
            SpecialButton.Visibility = Visibility.Hidden;
            AddBaseButton.Visibility = Visibility.Visible;
            ReturnSpecialButton.Visibility = Visibility.Visible;
        }

        private void AddBaseButton_Click(object sender, RoutedEventArgs e)
        {
            if ((Course_TBox.Text == "") || (Institution_CBox.Text == ""))
            {
                MessageBox.Show("Congratulations to you, because this may be the last mistake in your life!", "Seriously?????", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            else
            {
                try
                {
                    CousersAndTrainings cousers = new CousersAndTrainings()
                    {
                        Course = Course_TBox.Text,
                        Institution = Institution_CBox.Text,
                        IDYearOfGraduction = (int)YearOfGraduation_CBox.SelectedValue,
                        Duration = Duration_TBox.Text
                    };
                    db.context.CousersAndTrainings.Add(cousers);
                    db.context.SaveChanges();
                    MessageBox.Show("I'M PROUD OF YOU THAT YOU WERE ABLE TO FILL OUT EVERYTHING CORRECTLY AND PRESS THIS FUCKING ENGLISH BUTTON", "YOU DID IT!", MessageBoxButton.OK, MessageBoxImage.Information);
                }
                catch
                {
                    MessageBox.Show("YOUR MOTHER IS A COLLEGE STUDENT AND YOUR FATHER IS A WHORE! HOW DID YOU MANAGE TO CAUSE THIS ERROR AT ALL? SCREWED UP?", "WHAT HAVE YOU DONE?!", MessageBoxButton.OK, MessageBoxImage.Warning);
                }
            }
        }

        private void BackButton_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.GoBack();
        }

        private void ReturnSpecialButton_Click(object sender, RoutedEventArgs e)
        {
            Separator.Visibility = Visibility.Visible;
            SpecialButton.Visibility = Visibility.Visible;
            AddBaseButton.Visibility = Visibility.Hidden;
            ReturnSpecialButton.Visibility = Visibility.Hidden;
        }
    }
}
