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

namespace WPFSpinner
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            DataContext = this;
            //Paragraph para = new Paragraph();
              
            //para.Inlines.Add(new Run("Please wait for flush to complete!"));
            //para.TextAlignment = TextAlignment.Center;
            //MainText.Document.Blocks.Remove(MainText.Document.Blocks.FirstBlock);
            //MainText.Document.Blocks.Add(para);
        }
        public double Temp { get; set; } = 15;
        private void Slider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            var sldr = (Slider)sender;
            ARC1.EndAngle = sldr.Value*36;
            ProgressBarLabel.Content = $"{sldr.Value}s";
            MyControl.RaiseMyEvent(grid);
        }

        private void grid_SourceUpdated(object sender, DataTransferEventArgs e)
        {

        }
    }
  
}
