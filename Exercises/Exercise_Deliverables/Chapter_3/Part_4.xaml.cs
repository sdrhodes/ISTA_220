using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace Programming_Exercise_01_CS
{

    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
        }

        private void text1_SelectionChanged(object sender, RoutedEventArgs e)
        {

        }
        public void calcQuad()
        {
            double coefQuadA = double.Parse(textBoxQuadA.Text);
            double coefQuadB = double.Parse(textBoxQuadB.Text);
            double coefQuadC = double.Parse(textBoxQuadC.Text);
            bool coefABool = coefQuadA.Equals(0);


            if (coefABool == true)
            {
                resultQuadPos.Text = "Invalid";
                resultQuadNeg.Text = "Invalid";
                return;
            }
            else if ((coefQuadB * coefQuadB) - (4 * coefQuadA * coefQuadC) < 0)
            {
                resultQuadPos.Text = "Invalid";
                resultQuadNeg.Text = "Invalid";
                return;
            }
            else if (coefABool == false && ((coefQuadB * coefQuadB) - (4 * coefQuadA * coefQuadC) > 0))
            {
                double outcomeQuadNeg =
                    ((-1) * coefQuadB - (Math.Sqrt((coefQuadB * coefQuadB) - (4 * coefQuadA * coefQuadC)))) / (2 * coefQuadA);
                resultQuadNeg.Text = outcomeQuadNeg.ToString();

                double outcomeQuadPos =
                    ((-1) * coefQuadB + (Math.Sqrt((coefQuadB * coefQuadB) - (4 * coefQuadA * coefQuadC)))) / (2 * coefQuadA);
                resultQuadPos.Text = outcomeQuadPos.ToString();
            }
            else
            {
                throw new FormatException();
            }
        }

        public void clickQuad(object sender, RoutedEventArgs e)
        {

            try
            {
                calcQuad();
            }

            catch (Exception caught)
            {
                resultQuadNeg.Text = caught.Message;
            }
            finally
            {
                resultTri.Text = ":^)";
            }
        }
    }
}
