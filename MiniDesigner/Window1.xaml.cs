using MaterialDesignThemes.Wpf;
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
    /// Interaction logic for Window1.xaml
    /// </summary>
    public partial class Window1 : Window
    {
        public string SelectedColor { get; private set; }
        public Window1()
        {
            InitializeComponent();

/*
            string messageBoxText = "Do you want to save changes?";
            string caption = "Word Processor";
            MessageBoxButton button = MessageBoxButton.YesNoCancel;
            MessageBoxImage icon = MessageBoxImage.Warning;
            MessageBoxResult result;
            myColorPicker = new ColorPicker();
            //myColorPicker.SelectedColorChanged += MyColorPicker_SelectedColorChanged;

            result = MessageBox.Show(messageBoxText, caption, button, icon, MessageBoxResult.Yes);
*/

        }

        private void ColorPicker_SelectedColorChanged(object sender, RoutedEventArgs e)
        {
            // Получаем выбранный цвет из ColorPicker
           // SelectedColor = colorPicker.SelectedColor.ToString();
        }

        private void Select_Click(object sender, RoutedEventArgs e)
        {
            // При нажатии кнопки "Select" закрываем окно
            this.Close();
        }

        /*   private void MyColorPicker_SelectedColorChanged(object sender, RoutedPropertyChangedEventArgs<Color?> e)
           { 

               throw new NotImplementedException();
           }*/

    }
}
