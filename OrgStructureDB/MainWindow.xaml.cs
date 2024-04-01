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

namespace OrgStructureDB
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void ToggleButton_Click(object sender, RoutedEventArgs e)
        {
            if (sender == Button1)
            {
                if (AdditionalInfoText1.Visibility == Visibility.Collapsed)
                {
                    AdditionalInfoText1.Visibility = Visibility.Visible;
                }
                else
                {
                    AdditionalInfoText1.Visibility = Visibility.Collapsed;
                }
            }
            else if (sender == Button2)
            {
                if (AdditionalInfoText2.Visibility == Visibility.Collapsed)
                {
                    AdditionalInfoText2.Visibility = Visibility.Visible;
                }
                else
                {
                    AdditionalInfoText2.Visibility = Visibility.Collapsed;
                }
            }
            else if (sender == Button3)
            {
                if (AdditionalInfoText3.Visibility == Visibility.Collapsed)
                {
                    AdditionalInfoText3.Visibility = Visibility.Visible;
                }
                else
                {
                    AdditionalInfoText3.Visibility = Visibility.Collapsed;
                }
            }
            else if (sender == Button4)
            {
                if (AdditionalInfoText4.Visibility == Visibility.Collapsed)
                {
                    AdditionalInfoText4.Visibility = Visibility.Visible;
                }
                else
                {
                    AdditionalInfoText4.Visibility = Visibility.Collapsed;
                }
            }
        }
    }
}
