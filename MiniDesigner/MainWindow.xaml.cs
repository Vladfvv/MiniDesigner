using Microsoft.Win32;
using System.Collections.ObjectModel;
using System.IO;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using Xceed.Wpf.Toolkit;



namespace MiniDesigner
{
   
    public partial class MainWindow : Window
    {

        private bool isDrawing = false;
        private Point startPoint;
        private List<Shape> shapes = new List<Shape>();
        private string currentFileName = null;
        public Color myColorPicker { get; set; }
        MySelectColor mySelectColor;


        private Point currentMousePosition;        
        public SelectShapeDialog selectShapeDialog;
        private Color lineColor;
        private Color bgColor = Colors.White;
        private double lineThickness = 1.0;
        private bool fileExists = false;
        private string fileName = "";
       // ObservableCollection<ColorItem> ColorList;
        public MainWindow()
        {
            InitializeComponent();
            
           /* CommandBinding saveCommandBinding = new CommandBinding(ApplicationCommands.Save);
            saveCommandBinding.Executed += Save_Executed;
            saveCommandBinding.CanExecute += Save_CanExecute;
            CommandBindings.Add(saveCommandBinding);*/
        }

        private void Canvas_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            Point clickPoint = e.GetPosition(myCanvas);
            Console.Write(myColorPicker.R);
            DrawStar(clickPoint, myColorPicker);
            UpdateStatusBarText(clickPoint);
            UpdateBottomStatusBar(clickPoint);
            //myStatusBar.DataContext = clickPoint;
        }

        private void DrawStar(Point startPoint, Color myColorPicker)
        {


            // Реализация рисования звезды            
            //startPoint = e.GetPosition(myCanvas);
            Polygon myPolygon = new Polygon();
            myPolygon.Points = new PointCollection();            
            myPolygon.Points.Add(new Point(startPoint.X, startPoint.Y - 10));
            myPolygon.Points.Add(new Point(startPoint.X + 10, startPoint.Y));
            myPolygon.Points.Add(new Point(startPoint.X, startPoint.Y+10));
            myPolygon.Points.Add(new Point(startPoint.X-10, startPoint.Y));
            myPolygon.StrokeThickness = 5;
            if(myColorPicker.R == 0 && myColorPicker.G == 0 && myColorPicker.B == 0)  myPolygon.Stroke = Brushes.Black;
            else
            {
                SolidColorBrush mySolidColorBrush = new SolidColorBrush(myColorPicker);                
                myPolygon.Stroke = mySolidColorBrush;
            }
            //myPolygon.Stroke = Brushes.Black;
            myPolygon.Fill = Brushes.Yellow;
            myCanvas.Children.Add(myPolygon);
            shapes.Add(myPolygon);
            startPoint = new Point(0, 0);








        }

        private void UpdateStatusBarText(Point mousePosition)
        {
           // myStatusBar.Content = $"Mouse Position: X={mousePosition.X}, Y={mousePosition.Y}";
            myKoordinates.Content = "X:" + (int)mousePosition.X + "\tY:" + (int)mousePosition.Y;
        }

        private void UpdateBottomStatusBar(Point mousePosition)
        {
            // myStatusBar.Content = $"Mouse Position: X={mousePosition.X}, Y={mousePosition.Y}";
            statusTest.Text = "X:" + (int)mousePosition.X + "\tY:" + (int)mousePosition.Y;
        }




        private void MenuItem_About_Click(object sender, RoutedEventArgs e)
        {
            System.Windows.MessageBox.Show("First Mini Designer\nVersion 1.0\nCreated by Vlad/&Co");
        }

        private void Button_Save(object sender, RoutedEventArgs e)
        {
            /*SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Data Files (*.dat)|*.dat|All Files (*.*)|*.*";
            if (saveFileDialog.ShowDialog() == true)
            {               
            }*/

            if (shapes.Count == 0)
            {
                System.Windows.MessageBox.Show("There are no shapes for saving.");
                return;
            }

            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*";

            if (saveFileDialog.ShowDialog() == true)
            {
                using (StreamWriter writer = new StreamWriter(saveFileDialog.FileName))
                {
                    foreach (Shape shape in shapes)
                    {
                        writer.WriteLine($"Id:{shape.Uid}, Width:{shape.ActualWidth}, Height:{shape.ActualHeight}, Thickness:{((Polygon)shape).StrokeThickness}, Stroke:{((SolidColorBrush)((Polygon)shape).Stroke).Color}, Background{shape.Fill}");
                    }
                }
                fileName = saveFileDialog.FileName;
                //UpdateWindowTitle();
            }

        }

        private void Button_Save_As(object sender, RoutedEventArgs e)
        {
            //open new Window save as
        }

        private void Button_New_File(object sender, RoutedEventArgs e)
        {

        }

        private void Button_Edit_Shape(object sender, RoutedEventArgs e)
        {
           // SelectShapeDialog selectShapeDialog = new SelectShapeDialog();

           
        }
        private void Button_Open_File(object sender, RoutedEventArgs e)
        {

        }

        private void SelectLineColor(object sender, RoutedEventArgs e)
        {
           
        }

        private void LineThickness_Click(object sender, RoutedEventArgs e)
        {
          
        }




        private void ColorPicker_ColorChanged(object sender, RoutedPropertyChangedEventArgs<Color> e)
        {

        }

        private void Button_Select_Color(object sender, RoutedEventArgs e)
        {

           /* Window1 window1 = new Window1();
            window1.Show();*/
            // Создаем экземпляр окна выбора цвета
            ColorPickerWindow colorPickerWindow = new ColorPickerWindow();

            // Открываем окно как диалоговое
            if (colorPickerWindow.ShowDialog() == true)
            {
                // Получаем выбранный цвет из окна выбора цвета
                string selectedColor = colorPickerWindow.SelectedColor;
                System.Windows.MessageBox.Show(selectedColor);
               // myColorPicker.ScA() = selectedColor.ElementAt<ColorContext>;
                myColorPicker = colorPickerWindow.myColor;
                SolidColorBrush mySolidColorBrush = new SolidColorBrush(myColorPicker);
                mySelectColor.myR = mySolidColorBrush.Color.R;
                System.Windows.MessageBox.Show(selectedColor.ToString());
                //myColorPicker = new ColorPicker(selectedColor); //
                // Используем выбранный цвет в основной программе
                System.Windows.MessageBox.Show("Selected Color: " + myColorPicker.A);
            }

        }
        
    }
}