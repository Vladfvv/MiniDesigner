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

        private void ColorPicker_SelectedColorChanged(object sender, RoutedEventArgs e)
        {
            // Получаем выбранный цвет из ColorPicker
            // SelectedColor = colorPicker.SelectedColor.ToString();
            // Assign the selected color to a variable to use outside the popup.
            myColor = colorPicker.Color;
            
            // Close the Flyout.
            //colorPickerButton.Flyout.Hide();
            

        }

        private Color Select_Click(object sender, RoutedPropertyChangedEventArgs<Color?> e)
        {
            e.NewValue.Value.ToString();
            myColor = colorPicker.Color;
            // При нажатии кнопки "Select" закрываем окно
            //this.Close();
            //this.DialogResult = true;
            return myColor;
        }
    }
}
