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
    /// Логика взаимодействия для PersonalInfoPage.xaml
    /// </summary>
    public partial class PersonalInfoPage : Page
    {
        //Вывод страниц и подключение к базе
        Core db = new Core();

        //List<PersonalInfo> arrayPersonal;
        List<MovementTable> arrayMovementTable;
        List<SexTable> arraySexTable;
        List<FamilyStatusTable> arrayFamilyStatusTable;
        List<LearningTable> arrayLearningTable;

        public PersonalInfoPage()
        {
            InitializeComponent();
            //arrayPersonal = db.context.PersonalInfo.ToList();
            //YourIDGrid.DataContext = arrayPersonal;

            //Вывод таблицы MovementTable
            arrayMovementTable = db.context.MovementTable.ToList();

            Movement_CBox.ItemsSource = arrayMovementTable;
            Movement_CBox.SelectedValuePath = "IDMovement";
            Movement_CBox.DisplayMemberPath = "Movement";
            Movement_CBox.SelectedIndex = 0;

            //Вывод таблицы SexTable
            arraySexTable = db.context.SexTable.ToList();

            Sex_CBox.ItemsSource = arraySexTable;
            Sex_CBox.SelectedValuePath = "IDSex";
            Sex_CBox.DisplayMemberPath = "Sex";
            Sex_CBox.SelectedIndex = 0;

            //Вывод таблицы FamilyStatusTable
            arrayFamilyStatusTable = db.context.FamilyStatusTable.ToList();

            FamilyStatus_CBox.ItemsSource = arrayFamilyStatusTable;
            FamilyStatus_CBox.SelectedValuePath = "IDFamilyStatus";
            FamilyStatus_CBox.DisplayMemberPath = "FamilyStatus";
            FamilyStatus_CBox.SelectedIndex = 0;

            //Вывод таблицы LearningTable
            arrayLearningTable = db.context.LearningTable.ToList();

            Learning_CBox.ItemsSource = arrayLearningTable;
            Learning_CBox.SelectedValuePath = "IDLearning";
            Learning_CBox.DisplayMemberPath = "Learning";
            Learning_CBox.SelectedIndex = 0;
           
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
            if((ResCity_TBox.Text == "") || (Citiz_TBox.Text == ""))
            {
                MessageBox.Show("Twice in the same place, yeah? You don't seem to be the girl who hit me on the spot", "Seriously??", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            else
            {
                try
                {
                    PersonalInfo personal = new PersonalInfo()
                    {
                        CityOfResidence = ResCity_TBox.Text,
                        IDMovement = (int)Movement_CBox.SelectedValue,
                        Citizenship = Citiz_TBox.Text,
                        Birthday = Birhday_DPicker.SelectedDate.Value,
                        IDSex = (int)Sex_CBox.SelectedValue,
                        IDFamilyStatus = (int)FamilyStatus_CBox.SelectedValue,
                        Kids = (bool)Kids_ChBox.IsChecked,
                        IDLearning = (int)Learning_CBox.SelectedValue

                    };
                    db.context.PersonalInfo.Add(personal);
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
            PersonalInfoPage personal = btn.DataContext as PersonalInfoPage;
            NavigationService.Navigate(new PersonalInfoUpdatePage());
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
