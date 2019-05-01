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

namespace AngelSix
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

        

        private void ApplyButton_OnClick(object sender, RoutedEventArgs e)
        {
            MessageBox.Show($"The description is {this.DescriptionText.Text}");
        }

        private void ResetButton_OnClick(object sender, RoutedEventArgs e)
        {
            this.WeldCheckBox.IsChecked = this.AssemblyCheckBox.IsChecked = this.PlasmaCheckBox.IsChecked = this.LaserCheckBox.IsChecked = this.PurchaseCheckBox.IsChecked = this.LatheCheckBox.IsChecked = this.DrillCheckBox.IsChecked = this.FoldCheckBox.IsChecked = this.RollCheckBox.IsChecked = this.SawCheckBox.IsChecked = false;
        }

        private void CheckboxChecked(object sender, RoutedEventArgs e)
        {
            this.LengthText.Text += " ";
            this.LengthText.Text += ((CheckBox) sender).Content;
        }

        private void FinishComboBox_OnSelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (this.NoteText == null)
                return;
            this.NoteText.Text = (string)((ComboBoxItem)((ComboBox) sender).SelectedValue).Content;
        }

        private void MainWindow_OnLoaded(object sender, RoutedEventArgs e)
        {
            FinishComboBox_OnSelectionChanged(FinishComboBox, null);
        }
    }
}
