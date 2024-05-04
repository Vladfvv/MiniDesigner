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
    /// Interaction logic for SelectShapeDialog.xaml
    /// </summary>
    public partial class SelectShapeDialog : Window
    {
       
        private Color lineColor { get; set; }
        private Color bgColor { get; set; }
        private double lineThickness { get; set; }



        public SelectShapeDialog()
        {
            InitializeComponent();
        }


        public SelectShapeDialog(Color lineColor, Color bgColor, double lineThickness)
        {
            InitializeComponent();
            this.lineColor = lineColor;
            this.bgColor = bgColor;
            this.lineThickness = lineThickness;
        }


        private void Accept_Click(object sender, RoutedEventArgs e)
        {
            this.DialogResult = true;
        }

        private void Cancel_Click(object sender, RoutedEventArgs e)
        {
            this.DialogResult = false;
        }
    }
}
