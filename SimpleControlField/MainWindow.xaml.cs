using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
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
using SimpleControlField.Models;

namespace SimpleControlField
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }


        private void ResetButtonClick(object sender, RoutedEventArgs e)
        {
            var cbList = FindVisualChildren<CheckBox>(MainWindow1);
            foreach (CheckBox checkBox in cbList)
            {
                checkBox.IsChecked = false;
            }

            var txtboxList = FindVisualChildren<TextBox>(MainWindow1);
            foreach (TextBox textBox in txtboxList)
            {
                textBox.Text = "";
            }
        }

        private void AddButtonOnClick(object sender, RoutedEventArgs e)
        {
            var someth = new Something();

            someth.Description = Description.Text;
            someth.Length = Length.Text;
            someth.PartNumber = PartNumber.Text;
            someth.Revision = Revision.Text;
            someth.Status = Status.Text;
            someth.SupplierCode = SupplierCode.Text;
            someth.SupplierName = SupplierName.Text;
            someth.Weight = Weight.Text;
            someth.Weld = CkDrill.IsChecked;
            someth.Assembly = CkDrill.IsChecked;
            someth.Plasma = CkDrill.IsChecked;
            someth.Laser = CkDrill.IsChecked;
            someth.Purchase = CkDrill.IsChecked;
            someth.Lathe = CkDrill.IsChecked;
            someth.Drill = CkDrill.IsChecked;
            someth.Fold = CkDrill.IsChecked;
            someth.Roll = CkDrill.IsChecked;
            someth.Saw = CkDrill.IsChecked;
        }

        public static IEnumerable<T> FindVisualChildren<T>(DependencyObject depObj) where T : DependencyObject
        {
            if (depObj != null)
            {
                for (int i = 0; i < VisualTreeHelper.GetChildrenCount(depObj); i++)
                {
                    DependencyObject child = VisualTreeHelper.GetChild(depObj, i);
                    if (child != null && child is T)
                    {
                        yield return (T)child;
                    }

                    foreach (T childOfChild in FindVisualChildren<T>(child))
                    {
                        yield return childOfChild;
                    }
                }
            }
        }


        
    }
}
