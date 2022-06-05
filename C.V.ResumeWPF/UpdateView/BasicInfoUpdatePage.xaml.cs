using C.V.ResumeWPF.Model;
using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.IO;
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
    /// Логика взаимодействия для BasicInfoUpdatePage.xaml
    /// </summary>
    public partial class BasicInfoUpdatePage : Page
    {
        //Вывод страниц и подключение к базе
        Core db = new Core();

        List<BasicInfo> arrayBasic;

        List<BusynessTable> arrayBusyness;
        List<WorkPlanTable> arrayWorkPlan;

        string AddImage;

        public BasicInfoUpdatePage()
        {
            InitializeComponent();

            arrayBasic = db.context.BasicInfo.ToList();
            UpdateGrid.DataContext = arrayBasic;

            //Вывод таблицы BusynessTable
            arrayBusyness = db.context.BusynessTable.ToList();

            Busyness_CBox.ItemsSource = arrayBusyness;
            Busyness_CBox.SelectedValuePath = "IDBusyness";
            Busyness_CBox.DisplayMemberPath = "Busyness";
            Busyness_CBox.SelectedIndex = 0;

            //Вывод таблицы WorkPlanTable
            arrayWorkPlan = db.context.WorkPlanTable.ToList();

            WorkPlan_CBox.ItemsSource = arrayWorkPlan;
            WorkPlan_CBox.SelectedValuePath = "IDWorkPlan";
            WorkPlan_CBox.DisplayMemberPath = "WorkPlan";
            WorkPlan_CBox.SelectedIndex = 0;
        }

        private void PicButton_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            if (ofd.ShowDialog() == true)
            {
                ofd.Title = "Choose a pic!";
                ofd.Filter = "What do you think?|*.png;*.jpg;*jpeg";
                SelectedPic.ImageSource = new BitmapImage(new Uri(ofd.FileName));
                string newFileName = "\\Assets\\Images\\";
                string appFolderPath = Directory.GetCurrentDirectory().Replace("\\bin\\Debug", "");
                string imageName = System.IO.Path.GetFileName(ofd.FileName);
                newFileName = appFolderPath + newFileName + imageName;
                File.Delete(newFileName);
                File.Copy(ofd.FileName, newFileName);
                AddImage = imageName;
            }
        }

        private void SpecialButton_Click(object sender, RoutedEventArgs e)
        {
            Separator.Visibility = Visibility.Collapsed;
            SpecialButton.Visibility = Visibility.Hidden;
            AddBaseButton.Visibility = Visibility.Visible;
            BackButton.Visibility = Visibility.Visible;
            ReturnSpecialButton.Visibility = Visibility.Visible;
        }

        public void AddBaseButton_Click(object sender, RoutedEventArgs e)
        {
            if (String.IsNullOrEmpty(Surname_TBox.Text) || String.IsNullOrEmpty(Name_TBox.Text) || String.IsNullOrEmpty(Sal_TBox.Text) || String.IsNullOrEmpty(Phone_TBox.Text) || String.IsNullOrEmpty(Email_TBox.Text))
            {
                MessageBox.Show("You were supposed to be entering data into these areas, but you couldn't even do that.. I thought you weren't to blame for your parents' marriage", "Seriously?", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            else
            {
                try
                {
                    BasicInfo basic = new BasicInfo()
                    {
                        Pic = AddImage,
                        Surname = Surname_TBox.Text,
                        Name = Name_TBox.Text,
                        Patronymic = Patronymic_TBox.Text,
                        Post = Post_TBox.Text,
                        DesiredSalary = double.Parse(Sal_TBox.Text),
                        IDBusyness = (int)Busyness_CBox.SelectedValue,
                        IDWorkPlan = (int)WorkPlan_CBox.SelectedValue,
                        BusinessTrips = (bool)Trips_ChBox.IsChecked,
                        Phone = Phone_TBox.Text,
                        Email = Email_TBox.Text
                    };
                    db.context.BasicInfo.Add(basic);
                    db.context.SaveChanges();
                    MessageBox.Show("I'M PROUD OF YOU THAT YOU WERE ABLE TO FILL OUT EVERYTHING CORRECTLY AND PRESS THIS FUCKING ENGLISH BUTTON", "YOU DID IT!", MessageBoxButton.OK, MessageBoxImage.Information);
                    NavigationService.GoBack();
                }
                catch
                {
                    MessageBox.Show("YOUR MOTHER IS A COLLEGE STUDENT AND YOUR FATHER IS A WHORE! HOW DID YOU MANAGE TO CAUSE THIS ERROR AT ALL? SCREWED UP?", "WHAT HAVE YOU DONE?!", MessageBoxButton.OK, MessageBoxImage.Warning);
                }
            }
        }

        private void ReturnSpecialButton_Click(object sender, RoutedEventArgs e)
        {
            Separator.Visibility = Visibility.Visible;
            SpecialButton.Visibility = Visibility.Visible;
            AddBaseButton.Visibility = Visibility.Hidden;
            BackButton.Visibility = Visibility.Hidden;
            ReturnSpecialButton.Visibility = Visibility.Hidden;
        }

        private void BackButton_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.GoBack();
        }
    }
}
