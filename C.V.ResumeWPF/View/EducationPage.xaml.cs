using C.V.ResumeWPF.Model;
using C.V.ResumeWPF.View.UpdateView;
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

namespace C.V.ResumeWPF.View
{
    /// <summary>
    /// Логика взаимодействия для EducationPage.xaml
    /// </summary>
    public partial class EducationPage : Page
    {
        //Вывод страниц и подключение к базе
        Core db = new Core();

        //List<Education> arrayEdu;
        List<YearOfGraduationTable> arrayYearOfGraduation;
        List<EducationFormTable> arrayEducationForm;
        public EducationPage()
        {
            InitializeComponent();
            //arrayEdu = db.context.Education.ToList();
            //YourIDGrid.DataContext = arrayEdu;

            //Вывод таблицы YearOfGraduationTable
            arrayYearOfGraduation = db.context.YearOfGraduationTable.ToList();

            YearOfGraduation_CBox.ItemsSource = arrayYearOfGraduation;
            YearOfGraduation_CBox.SelectedValuePath = "IDYearOfGraduation";
            YearOfGraduation_CBox.DisplayMemberPath = "YearOfGraduation";
            YearOfGraduation_CBox.SelectedIndex = 0;

            //Вывод таблицы EducationFormTable
            arrayEducationForm = db.context.EducationFormTable.ToList();

            EducationForm_CBox.ItemsSource = arrayEducationForm;
            EducationForm_CBox.SelectedValuePath = "IDEducationForm";
            EducationForm_CBox.DisplayMemberPath = "EducationForm";
            EducationForm_CBox.SelectedIndex = 0;
        }

        private void SpecialButton_Click(object sender, RoutedEventArgs e)
        {
            Separator.Visibility = Visibility.Collapsed;
            SpecialButton.Visibility = Visibility.Hidden;
            AddBaseButton.Visibility = Visibility.Visible;
            EditBaseButton.Visibility = Visibility.Visible;
            ReturnSpecialButton.Visibility = Visibility.Visible;
        }

        private void AddBaseButton_Click(object sender, RoutedEventArgs e)
        {
            if((EducationalInstitution_TBox.Text == "") || (Faculty_CBox.Text == ""))
            {
                MessageBox.Show("The day of the lesson is a wonderful day, so my mother told me.. And then I met you and wanted to read 'War and Peace'", "Seriously????", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            else
            {
                try
                {
                    Education education = new Education()
                    {
                        EducationalInstitution = string.Concat(EducationalInstitution_TBox.Text),
                        Faculty = string.Concat(Faculty_CBox.Text),
                        Specialization = string.Concat(Specialization_TBox.Text),
                        IDYearOfGraduation = (int)YearOfGraduation_CBox.SelectedValue,
                        IDEducationalForm = (int)EducationForm_CBox.SelectedValue
                    };
                    db.context.Education.Add(education);
                    db.context.SaveChanges();

                    MessageBox.Show("I'M PROUD OF YOU THAT YOU WERE ABLE TO FILL OUT EVERYTHING CORRECTLY AND PRESS THIS FUCKING ENGLISH BUTTON", "YOU DID IT!", MessageBoxButton.OK, MessageBoxImage.Information);
                }
                catch
                {
                    MessageBox.Show("YOUR MOTHER IS A COLLEGE STUDENT AND YOUR FATHER IS A WHORE! HOW DID YOU MANAGE TO CAUSE THIS ERROR AT ALL? SCREWED UP?", "WHAT HAVE YOU DONE?!", MessageBoxButton.OK, MessageBoxImage.Warning);
                }
            }     
        }

        private void EditBaseButton_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new EducationUpdatePage());
        }

        private void ReturnSpecialButton_Click(object sender, RoutedEventArgs e)
        {
            Separator.Visibility = Visibility.Visible;
            SpecialButton.Visibility = Visibility.Visible;
            AddBaseButton.Visibility = Visibility.Hidden;
            EditBaseButton.Visibility = Visibility.Hidden;
            ReturnSpecialButton.Visibility = Visibility.Hidden;
        }
    }
}
