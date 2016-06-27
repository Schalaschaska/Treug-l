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

namespace C4
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        public bool Flag;
        public bool Flag_2;
        private void button_Click(object sender, RoutedEventArgs e)
        {
            if (radioButton.IsChecked == false && radioButton1.IsChecked == false)
            {
                MessageBox.Show("Не выбрано действие", "Ошибка");
            }
            else
            {
                if (radioButton.IsChecked == true)
                {

                    Treugоl T = new Treugоl();
                    textBox.Text = Convert.ToString(T.rez_a());
                    textBox1.Text = Convert.ToString(T.rez_b());
                    textBox2.Text = Convert.ToString(T.rez_c());
                    if (Flag==true)
                    {
                        int a_g, b_g, c_g;
                        a_g = Convert.ToInt32(textBox.Text);
                        b_g = Convert.ToInt32(textBox1.Text);
                        c_g = Convert.ToInt32(textBox2.Text);
                        textBox9.Text = Convert.ToString(T.ger(a_g, b_g, c_g));
                    }
                    if(Flag_2==true)
                    {
                        double a_p, b_p, c_p;
                        a_p = Convert.ToInt32(textBox.Text);
                        b_p = Convert.ToInt32(textBox1.Text);
                        c_p = Convert.ToInt32(textBox2.Text);
                        textBox9.Text = Convert.ToString(T.perim(a_p,b_p, c_p));
                    }
                }
                if (radioButton1.IsChecked == true)
                {
                    if (textBox3.Text == "" || textBox4.Text == "" || textBox5.Text == "" || textBox6.Text == "" || textBox6.Text == "" || textBox7.Text == "" || textBox8.Text == "")
                    {
                        MessageBox.Show("Не введены данные", "Ошибка");
                    }
                    else
                    {
                        int x1, y1, x2, y2, x3, y3;
                        x1 = Convert.ToInt32(textBox3.Text);
                        y1 = Convert.ToInt32(textBox4.Text);
                        x2 = Convert.ToInt32(textBox5.Text);
                        y2 = Convert.ToInt32(textBox6.Text);
                        x3 = Convert.ToInt32(textBox7.Text); 
                        y3 = Convert.ToInt32(textBox8.Text);
                        Treugоl T_g = new Treugоl();
                        textBox.Text = Convert.ToString(T_g.rez_d(x1, y1, x2, y2, x3, y3));
                        textBox1.Text = Convert.ToString(T_g.rez_e(x1, y1, x2, y2, x3, y3));
                        textBox2.Text = Convert.ToString(T_g.rez_f(x1, y1, x2, y2, x3, y3));
                        if (Flag==true)
                        {
                            double a_2_g, b_2_g, c_2_g;
                            a_2_g = Convert.ToDouble(textBox.Text);
                            b_2_g = Convert.ToDouble(textBox1.Text);
                            c_2_g = Convert.ToDouble(textBox2.Text);
                            textBox9.Text = Convert.ToString(T_g.ger(a_2_g, b_2_g, c_2_g));
                        }
                        if(Flag_2==true)
                        {
                            double a_2_p, b_2_p, c_2_p;
                            a_2_p = Convert.ToDouble(textBox.Text);
                            b_2_p = Convert.ToDouble(textBox1.Text);
                            c_2_p = Convert.ToDouble(textBox2.Text);
                            textBox9.Text = Convert.ToString(T_g.perim(a_2_p, b_2_p, c_2_p));
                        }

                    }
                }
            }
        }

      
        private void button_ex(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void radioButton1_Checked(object sender, RoutedEventArgs e)
        {
            textBox.IsEnabled = false;
            textBox1.IsEnabled = false;
            textBox2.IsEnabled = false;
            textBox3.IsEnabled = true;
            textBox4.IsEnabled = true;
            textBox5.IsEnabled = true;
            textBox6.IsEnabled = true;
            textBox7.IsEnabled = true;
            textBox8.IsEnabled = true;
        }

        private void radioButton_Checked(object sender, RoutedEventArgs e)
        {
            textBox3.IsEnabled = false;
            textBox4.IsEnabled = false;
            textBox5.IsEnabled = false;
            textBox6.IsEnabled = false;
            textBox7.IsEnabled = false;
            textBox8.IsEnabled = false;
            textBox.IsEnabled = true;
            textBox1.IsEnabled = true;
            textBox2.IsEnabled = true;
        }
        private void button_ger(object sender, RoutedEventArgs e)
        {
            Flag = true;
            Flag_2 = false;
            label9.Content = "Площадь";
        }
        private void button_per(object sender, RoutedEventArgs e) 
        {
            Flag = false;
            Flag_2 = true;
            label9.Content = "Периметр";
        }
        private void button1_Click(object sender, RoutedEventArgs e)
        {
            textBox.Text = "";
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
            textBox6.Text = "";
            textBox7.Text = "";
            textBox8.Text = "";
            textBox9.Text = "";
            label9.Content = "";
            radioButton.IsChecked = false;
            radioButton1.IsChecked = false;
        }
    }
            }
        
    

