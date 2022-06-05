using C.V.ResumeWPF.Model;
using C.V.ResumeWPF.View.UpdateView;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
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
    /// Логика взаимодействия для AdditionalInfoPage.xaml
    /// </summary>
    public partial class AdditionalInfoPage : Page
    {
        //Вывод страниц и подключение к базе
        Core db = new Core();

        //List<AdditionalInfo> arrayAdditional;

        public AdditionalInfoPage()
        {
            InitializeComponent();
            //arrayAdditional = db.context.AdditionalInfo.ToList();
            //YourIDGrid.DataContext = arrayAdditional;
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
            try
            {
                AdditionalInfo additional = new AdditionalInfo()
                {
                    MilitaryService = (bool)Military_ChBox.IsChecked,
                    Recommendations = Rec_TBox.Text,
                    Hobby = Hobby_TBox.Text,
                    PersonalQualities = Qualities_TBox.Text
                };
                CategoriesTable categories = new CategoriesTable()
                {
                    A = (bool)A_ChBox.IsChecked,
                    B = (bool)B_ChBox.IsChecked,
                    BE = (bool)BE_ChBox.IsChecked,
                    C = (bool)C_ChBox.IsChecked,
                    CE = (bool)CE_ChBox.IsChecked,
                    D = (bool)D_ChBox.IsChecked,
                    DE = (bool)DE_ChBox.IsChecked,
                    M = (bool)M_ChBox.IsChecked,
                    TM = (bool)TM_ChBox.IsChecked,
                    TB = (bool)TB_ChBox.IsChecked,
                };
                SubcategoriesTable subcategories = new SubcategoriesTable()
                {
                    A1 = (bool)A1_ChBox.IsChecked,
                    B1 = (bool)B1_ChBox.IsChecked,
                    C1 = (bool)C1_ChBox.IsChecked,
                    C1E = (bool)C1E_ChBox.IsChecked,
                    D1 = (bool)D1_ChBox.IsChecked,
                    D1E = (bool)D1E_ChBox.IsChecked
                };
                db.context.AdditionalInfo.Add(additional);
                db.context.CategoriesTable.Add(categories);
                db.context.SubcategoriesTable.Add(subcategories);
                db.context.SaveChanges();
                MessageBox.Show("I'M PROUD OF YOU THAT YOU WERE ABLE TO FILL OUT EVERYTHING CORRECTLY AND PRESS THIS FUCKING ENGLISH BUTTON", "YOU DID IT!", MessageBoxButton.OK, MessageBoxImage.Information);
            }
            catch
            {
                MessageBox.Show("YOUR MOTHER IS A COLLEGE STUDENT AND YOUR FATHER IS A WHORE! HOW DID YOU MANAGE TO CAUSE THIS ERROR AT ALL? SCREWED UP?", "WHAT HAVE YOU DONE?!", MessageBoxButton.OK, MessageBoxImage.Warning);
            }
        }

        private void EditBaseButton_Click(object sender, RoutedEventArgs e)
        {
            Button btn = sender as Button;
            AdditionalInfo item = btn.DataContext as AdditionalInfo;
            NavigationService.Navigate(new AdditionalInfoUpdatePage());
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
