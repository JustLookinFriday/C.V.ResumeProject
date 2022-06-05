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
    /// Логика взаимодействия для ExperiencePage.xaml
    /// </summary>
    public partial class ExperiencePage : Page
    {
        //Вывод страницы и подключение к базе
        Core db = new Core();

        //List<Experience> arrayExp;

        public ExperiencePage()
        {
            InitializeComponent();
            //arrayExp = db.context.Experience.ToList();
            //YourIDGrid.DataContext = arrayExp;
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
            if((LastPost_TBox.Text == "") || (Organization_TBox.Text == ""))
            {
                MessageBox.Show("And healthy again. We had some disagreements, but on the next page, aren't you going to make me sympathize with you?", "Seriously???", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            else
            {
                try
                {
                    Experience experience = new Experience()
                    {
                        Hire = Hire_DPicker.SelectedDate.Value,
                        Fire = Fire_DPicker.SelectedDate.Value,
                        LastPost = LastPost_TBox.Text,
                        FullEmployment = (bool)FullEmployment_ChBox.IsChecked,
                        Organization = Organization_TBox.Text,
                        ResponsibilitiesAndAchievements = ResAndAch_TBox.Text
                    };
                    db.context.Experience.Add(experience);
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
            Button btn = sender as Button;
            Experience experience = btn.DataContext as Experience;
            NavigationService.Navigate(new ExperienceUpdatePage());
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
