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
using System.Windows.Shapes;

namespace MiniDesigner
{
    /// <summary>
    /// Interaction logic for ColorPickerWindow.xaml
    /// </summary>
    public partial class ColorPickerWindow : Window
    {
        public string SelectedColor { get; private set; }
        public Color myColor { get; set; }

        public ColorPickerWindow()
        {
            InitializeComponent();
        }

        /* private void ColorPicker_SelectedColorChanged(object sender, RoutedEventArgs e)
         {
             // Получаем выбранный цвет из ColorPicker
             // SelectedColor = colorPicker.SelectedColor.ToString();
             // Assign the selected color to a variable to use outside the popup.
             myColor = colorPicker.Color;

             // Close the Flyout.
             //colorPickerButton.Flyout.Hide();


         }*/


       
            private void Select_Click(object sender, RoutedEventArgs e)
        {
            //e.NewValue.Value.ToString();
            myColor = colorPicker.Color;
            // При нажатии кнопки "Select" закрываем окно
            /*MessageBox.Show(myColor.B.ToString());
            MessageBox.Show(myColor.G.ToString());
            MessageBox.Show(myColor.R.ToString());*/
            this.Close();
            //this.DialogResult = true;
            //return myColor;
        }

        private void ColorPicker_SelectedColorChanged(object sender, RoutedPropertyChangedEventArgs<Color> e)
        {
            myColor = colorPicker.Color;
           // myColor.ScA.ToString();
            MessageBox.Show(myColor.A.ToString());
            //this.Close();
            //this.DialogResult = true;
            //return myColor;
        }
    }
}
