using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace Resources
{
    /// <summary>
    /// Interaction logic for DynamicResource.xaml
    /// </summary>

    public partial class DynamicResource : System.Windows.Window
    {

        public DynamicResource()
        {
            InitializeComponent();
        }

        private void cmdChange_Click(object sender, RoutedEventArgs e)
        {
            // modificarea se face doar la resursa dinamica
            //this.Resources["TileBrush"] = new SolidColorBrush(Colors.LightBlue);

            // modificarea se face la resursa dinamica  + statica
            ImageBrush brush = (ImageBrush)this.Resources["TileBrush"];
            brush.Viewport = new Rect(0, 0, 16, 16);
        }
    }
}