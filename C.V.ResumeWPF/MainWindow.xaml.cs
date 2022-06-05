using C.V.ResumeWPF.View;
using System.Collections.Generic;
using System.Linq;
using System.Windows;
using System.Windows.Controls;

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

            //Индекс страниц и они сами
            this.Pages = new List<Page>();
            index = 0;

            //Перечень страниц для того чтобы не создавались новые
            Pages.Add(new OpenPage());
            Pages.Add(new BasicInfoPage());
            Pages.Add(new PersonalInfoPage());
            Pages.Add(new ExperiencePage());
            Pages.Add(new EducationPage());
            Pages.Add(new CoursesAndTrainingsPage());
            Pages.Add(new ForeignLanguagesAndComputerSkillsPage());
            Pages.Add(new AdditionalInfoPage());
            Pages.Add(new EndPage());
        }

        private void OpenningButton_Click(object sender, RoutedEventArgs e)
        {
            OpenningText.Visibility = Visibility.Collapsed;
            MainFrame.Content = Pages[0];
            ControlButton.Visibility = Visibility.Visible; 
        }

        private void SubsequentButton_Click(object sender, RoutedEventArgs e)
        {
            if (MainFrame.Content == null)
            {
                MainFrame.Content = Pages.ElementAtOrDefault(index);
            }
            else
            {
                index++;
                if (index < Pages.Count)
                {
                    MainFrame.Content = Pages.ElementAtOrDefault(index);
                }
                else
                {
                    index--;
                }
            }
        }

        private void PreviousButton_Click(object sender, RoutedEventArgs e)
        {
            if (MainFrame.Content != null && index != 0)
            {
                index--;
                MainFrame.Content = Pages.ElementAtOrDefault(index);
            }
        }
    }
}
