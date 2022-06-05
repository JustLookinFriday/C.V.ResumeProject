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
    /// Логика взаимодействия для ForeignLanguagesAndComputerSkillsUpdatePage.xaml
    /// </summary>
    public partial class ForeignLanguagesAndComputerSkillsUpdatePage : Page
    {
        //Подключение к базе
        Core db = new Core();
        public ForeignLanguagesAndComputerSkillsUpdatePage()
        {
            InitializeComponent();
        }
        private void ExpButton_Click(object sender, RoutedEventArgs e)
        {
            if (OtherOwn_TBox.Visibility == Visibility.Collapsed)
            {
                ExpButton.Content = "Click here to hidden expand";
                OtherOwn_TBox.Visibility = Visibility.Visible;
            }
            else
            {
                ExpButton.Content = "Click here to expand";
                OtherOwn_TBox.ClearValue(TextBox.TextProperty);
                OtherOwn_TBox.Visibility = Visibility.Collapsed;
            }
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
            try
            {
                ITSkills skills = new ITSkills()
                {
                    LanguageKnowledge = Languages_TBox.Text,
                    Documents = (bool)Doc_ChBox.IsChecked,
                    Internet = (bool)Internet_ChBox.IsChecked,
                    Email = (bool)Email_ChBox.IsChecked,
                    MSWord = (bool)MSW_ChBox.IsChecked,
                    MSExcel = (bool)MSE_ChBox.IsChecked,
                    MSPowerPoint = (bool)MSPP_ChBox.IsChecked,
                    Other = OtherOwn_TBox.Text
                };
                db.context.ITSkills.Add(skills);
                db.context.SaveChanges();
                MessageBox.Show("I'M PROUD OF YOU THAT YOU WERE ABLE TO FILL OUT EVERYTHING CORRECTLY AND PRESS THIS FUCKING ENGLISH BUTTON", "YOU DID IT!", MessageBoxButton.OK, MessageBoxImage.Information);
            }
            catch
            {
                MessageBox.Show("YOUR MOTHER IS A COLLEGE STUDENT AND YOUR FATHER IS A WHORE! HOW DID YOU MANAGE TO CAUSE THIS ERROR AT ALL? SCREWED UP?", "WHAT HAVE YOU DONE?!", MessageBoxButton.OK, MessageBoxImage.Warning);
            }
        }

        private void ReturnSpecialButton_Click(object sender, RoutedEventArgs e)
        {
            Separator.Visibility = Visibility.Visible;
            SpecialButton.Visibility = Visibility.Visible;
            AddBaseButton.Visibility = Visibility.Hidden;
            ReturnSpecialButton.Visibility = Visibility.Hidden;
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (sender is TextBox tBox)
            {
                tBox.Text = new string(tBox.Text.Where(ch => (ch >= '0' && ch <= '5')).ToArray());
            }
            else
            {
                MessageBox.Show("Are you a fool? Do you really not understand at all what is written in black and gray? Damn, I thought you were smarter than my mom..", "You're my cute piece of shit:3", MessageBoxButton.OK, MessageBoxImage.Warning);
            }
        }
    }
}
