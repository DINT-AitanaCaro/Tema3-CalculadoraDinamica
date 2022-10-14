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

namespace Tema3_CalculadoraDinamica
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            int num = 1;

            for (int i = 1; i < 4; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Button b = new Button();
                    Viewbox vb = new Viewbox();
                    TextBlock tb = new TextBlock();
                    tb.Text = num.ToString();
                    b.Tag = num.ToString();
                    vb.Child = tb;
                    b.Content = vb;
                    Grid.SetRow(b, i);
                    Grid.SetColumn(b, j);
                    contenedorGrid.Children.Add(b);
                    num++;
                }
            }
            /*
             * 1     2     3
             (1,0) (1,1) (1,2)
               4     5     6
             (2,0) (2,1) (2,2)
             (3,0) (3,1) (3,2)
             */
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Button b = (Button)sender;
            numeros.Text += b.Tag.ToString();
        }
    }
}
