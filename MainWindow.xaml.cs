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

namespace dvirtest
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        string d1, d2, d3, d4, d5, d6, d7, d8, checkDigit;
        string[] arryId = new string[8];
        int tempId = 0;
        int sum = 0;
        int countDigits = 0;
        int tempD = 0;
        int id, temp, tempNum1, tempNum2, tempNum3;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            d1 = D1.Text;
            d2 = D2.Text;
            d3 = D3.Text;
            d4 = D4.Text;
            d5 = D5.Text;
            d6 = D6.Text;
            d7 = D7.Text;
            d8 = D8.Text;
            checkDigit = CheckD.Text;
            arryId[0] = d1;
            arryId[1] = d2;
            arryId[2] = d3;
            arryId[3] = d4;
            arryId[4] = d5;
            arryId[5] = d6;
            arryId[6] = d7;
            arryId[7] = d8;



            for (int i = 0; i < 8; i++)
            {



                if ((i + 1) % 2 == 0)
                {

                    tempNum1 = (int.Parse(arryId[i]) * 2);
                    tempNum2 = tempNum1 / 10;
                    tempNum1 = tempNum1 % 10;
                    tempNum3 = tempNum1 + tempNum2;

                    sum += tempNum3;

                }



                else
                {
                    sum += int.Parse(arryId[i]);


                }
                tempNum1 = 0;
                tempNum2 = 0;


            }
            Console.WriteLine(sum);
            if (sum > 10)
            {
                sum = sum % 10;
                if (((sum==0) &&(sum==(int.Parse(checkDigit))))||((10 - sum) == int.Parse(checkDigit)))
                {

                    MessageBox.Show("YOU ENTER  A CORRECT ID");

                    App.Current.MainWindow.Background =  
                        Brushes.Green;



                }
                else
                {
                    MessageBox.Show("YOU ENTER  A WORNG ID");
                    App.Current.MainWindow.Background =
                        Brushes.Red;

                }

            }

            else
            {
                MessageBox.Show("YOU ENTER  A WORNG ID");
                App.Current.MainWindow.Background =
                        Brushes.Red;
            }














        }
    }
}
