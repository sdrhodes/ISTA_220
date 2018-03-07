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

        public void calcCircum()
        {
            double circum = double.Parse(textBoxCircum.Text);
            {
                if (circum < 0)
                {
                    resultCircum.Text = "Invalid";
                    return;
                }
                else if (circum > 0)
                {
                    double outcomeCircum = circum * 6.28318;
                    resultCircum.Text = outcomeCircum.ToString();
                }

                else
                {
                    throw new FormatException();
                }
            }
            
        }
        public void clickCircum(object sender, RoutedEventArgs e)
        {
            try
            {
                calcCircum();
            }

            catch (Exception caught)
            {
                resultCircum.Text = caught.Message;
            }
        }

        public void calcCircArea()
        {
            double areaCirc = double.Parse(textBoxAreaCirc.Text);
            if (areaCirc < 0)
            {
                resultCircArea.Text = "Invalid";
                return;
            }
            else if (areaCirc > 0)
            {
                double outcomeAreaCirc = (areaCirc * areaCirc) * 3.14159;
                resultCircArea.Text = outcomeAreaCirc.ToString();
            }
            else
            {
                throw new FormatException();
            }

        }
        public void clickCircArea(object sender, RoutedEventArgs e)
        {

            try
            {
                calcCircArea();
            }

            catch (Exception caught)
            {
                resultCircArea.Text = caught.Message;
            }
        }

        public void calcVolHemis()
            {
                double volHemis = double.Parse(textBoxVolHemis.Text);
                if (volHemis < 0)
                {
                    resultVolHemis.Text = "Invalid";
                    return;
                }
                else if (volHemis > 0)
                {
                    double outcomeVolHemis = (volHemis * volHemis * volHemis * 0.666666666667 * Math.PI);
                    resultVolHemis.Text = outcomeVolHemis.ToString();
                }
                else
                {
                    throw new FormatException();
                }
            }

        public void clickVolHemis(object sender, RoutedEventArgs e)
            {

                try
                {
                    calcVolHemis();
                }

                catch (Exception caught)
                {
                resultVolHemis.Text = caught.Message;
                }
            
            }


        public void calcAreaTri()
        {
            double areaTriA = double.Parse(textBoxTriA.Text);
            double areaTriB = double.Parse(textBoxTriB.Text);
            double areaTriC = double.Parse(textBoxTriC.Text);
            double p = ((areaTriA + areaTriB + areaTriC) * 0.5);

            if (areaTriA < 0)
            {
                resultTri.Text = "Invalid";
                return;
            }
            else if (areaTriB < 0)
            {
                resultTri.Text = "Invalid";
                return;
            }
            else if (areaTriC < 0)
            {
                resultTri.Text = "Invalid";
                return;
            }
            else if (areaTriA > 0 && areaTriB > 0 && areaTriC > 0)
            {
                double outcomeAreaTri = Math.Sqrt(p * (p - areaTriA) * (p - areaTriB) * (p - areaTriC));
                resultTri.Text = outcomeAreaTri.ToString();
            }
            else
            {
                throw new FormatException();
            }
        }
        public void clickTri(object sender, RoutedEventArgs e)
        {

            try
            {
                calcAreaTri();
            }

            catch (Exception caught)
            {
                resultTri.Text = caught.Message;
            }

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
                checked
                {
                    try
                    {
                       double outcomeQuadNeg =
                            ((-1) * coefQuadB - (Math.Sqrt((coefQuadB * coefQuadB) - (4 * coefQuadA * coefQuadC)))) / (2 * coefQuadA);
                        resultQuadNeg.Text = outcomeQuadNeg.ToString();

                        double outcomeQuadPos =
                            ((-1) * coefQuadB + (Math.Sqrt((coefQuadB * coefQuadB) - (4 * coefQuadA * coefQuadC)))) / (2 * coefQuadA);
                        resultQuadPos.Text = outcomeQuadPos.ToString(); 
                    }
                    catch (OverflowException caught)
                    {
                        resultQuadNeg.Text = caught.Message;
                    }
                }
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
