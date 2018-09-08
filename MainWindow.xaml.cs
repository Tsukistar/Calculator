using System.Windows;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace 计算器
{
    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        //辅助变量
        private enum Operator { none,add,reduce,cheng,chu };//运算类型
        private double Result;                              //保存计算结果
        private Operator Last = Operator.none;              //最后一次的运算符号
        private bool isbutton = false;                        //是否输入过运算符
        private bool isper = false;                         //是否使用百分号
        private bool isdengyu = false;                      //是否使用等于号
        //输入
        private void Point_Click(object sender, RoutedEventArgs e)
        {
            if (isper)
            {
                Put.Content = "0";
                isper = false;
            }
            else if (isbutton)
            {
                Put.Content = "0.";
            }
            Put.Content += ".";
        }

        private void Zero_Click(object sender, RoutedEventArgs e)
        {
            if (isper)
            {
                Put.Content = "0";
                isper = false;
            }
            else if (isbutton)
            {
                Put.Content = "0";
            }
            if ((string)Put.Content == "0") return;
            else Put.Content += "0";
        }

        private void one_Click(object sender, RoutedEventArgs e)
        {
            if (isper)
            {
                Put.Content = "0";
                isper = false;
            }
            else if (isbutton)
            {
                Put.Content = "0";
            }
            if ((string)Put.Content == "0") Put.Content = "1";
            else Put.Content += "1";
        }

        private void two_Click(object sender, RoutedEventArgs e)
        {
            if (isper)
            {
                Put.Content = "0";
                isper = false;
            }
            else if (isbutton)
            {
                Put.Content = "0";
            }
            if ((string)Put.Content == "0") Put.Content = "2";
            else Put.Content += "2";
        }

        private void three_Click(object sender, RoutedEventArgs e)
        {
            if (isper)
            {
                Put.Content = "0";
                isper = false;
            }
            else if (isbutton)
            {
                Put.Content = "0";
            }
            if ((string)Put.Content == "0") Put.Content = "3";
            else Put.Content += "3";
        }

        private void four_Click(object sender, RoutedEventArgs e)
        {
            if (isper)
            {
                Put.Content = "0";
                isper = false;
            }
            else if (isbutton)
            {
                Put.Content = "0";
            }
            if ((string)Put.Content == "0") Put.Content = "4";
            else Put.Content += "4";
        }

        private void five_Click(object sender, RoutedEventArgs e)
        {
            if (isper)
            {
                Put.Content = "0";
                isper = false;
            }
            else if (isbutton)
            {
                Put.Content = "0";
            }
            if ((string)Put.Content == "0") Put.Content = "5";
            else Put.Content += "5";
        }

        private void six_Click(object sender, RoutedEventArgs e)
        {
            if (isper)
            {
                Put.Content = "0";
                isper = false;
            }
            else if (isbutton)
            {
                Put.Content = "0";
            }
            if ((string)Put.Content == "0") Put.Content = "6";
            else Put.Content += "6";
        }

        private void seven_Click(object sender, RoutedEventArgs e)
        {
            if (isper)
            {
                Put.Content = "0";
                isper = false;
            }
            else if (isbutton)
            {
                Put.Content = "0";
            }
            if ((string)Put.Content == "0") Put.Content = "7";
            else Put.Content += "7";
        }

        private void eight_Click(object sender, RoutedEventArgs e)
        {
            if (isper)
            {
                Put.Content = "0";
                isper = false;
            }
            else if (isbutton)
            {
                Put.Content = "0";
            }
            if ((string)Put.Content == "0") Put.Content = "8";
            else Put.Content += "8";
        }

        private void nine_Click(object sender, RoutedEventArgs e)
        {
            if (isper)
            {
                Put.Content = "0";
                isper = false;
            }
            else if (isbutton)
            {
                Put.Content = "0";
            }
            if ((string)Put.Content == "0") Put.Content = "9";
            else Put.Content += "9";
        }
        //清零操作
        private void Clear_Click(object sender, RoutedEventArgs e)
        {
            Temp.Content = "";
            Put.Content = "0";
            isper = false;
            isbutton = false;
            isdengyu = false;
        }
        //删除操作
        private void Del_Click(object sender, RoutedEventArgs e)
        {
            if (isdengyu) return;
            else if (isper) isper = false;
            if ((string)Put.Content == "0") return;
            else
            {
                string temp = (string)Put.Content;
                temp=temp.Remove(temp.Length - 1);
                if (temp == "") temp = "0";
                Put.Content = temp;
            }
        }
        //求百分数
        private void Percent_Click(object sender, RoutedEventArgs e)
        {
            if ((string)Temp.Content != "")
            {
                MessageBox.Show("请不要在进行其他运算时使用%运算符","提示",MessageBoxButton.OK);
                return;
            }
            double a=Convert.ToDouble(Put.Content);
            a = a * 100;
            Put.Content = Convert.ToString(a) + "%";
            isper = true;
            return;
        }
        //运算函数
        private double Plus_do(double result,string put)
        {
            result = result + Convert.ToDouble(put);
            return result;
        }

        private double Reduce_do(double result, string put)
        {
            result = result - Convert.ToDouble(put);            
            return result;
        }

        private double cheng_do(double result, string put)
        {
            result = result * Convert.ToDouble(put);
            return result;
        }

        private double chu_do(double result, string put)
        {
            result = result / Convert.ToDouble(put);
            return result;
        }
        //判断运算符
        private void Getresult(Operator last)
        {
            switch (Last)
            {
                case Operator.add:
                    Result = Plus_do(Result, (string)Put.Content);
                    Last = Operator.add;
                    Put.Content = Result;
                    break;
                case Operator.reduce:
                    Result=Reduce_do(Result, (string)Put.Content);
                    Last = Operator.reduce;
                    Put.Content = Result;
                    break;
                case Operator.cheng:
                    Result=cheng_do(Result, (string)Put.Content);
                    Last = Operator.cheng;
                    Put.Content = Result;
                    break;
                case Operator.chu:
                    Result=chu_do(Result, (string)Put.Content);
                    Last = Operator.chu;
                    Put.Content = Result;
                    break;
            }
        }
        //运算符按钮
        private void Plus_Click(object sender, RoutedEventArgs e)
        {
            if (isper)
            {
                MessageBox.Show("请不要在使用%后使用其他运算符，若想进行其他运算，请清零，ans会保存之前的计算结果", "提示", MessageBoxButton.OK);
                return;
            }
            else if (Last == Operator.chu && ((string)Put.Content == "0"))
            {
                MessageBox.Show("除以0是没有意义的，换个数试试？", "提示", MessageBoxButton.OK);
                return;
            }
            Temp.Content = (string)Temp.Content + Put.Content + "+";
            if (Last != Operator.none)
            {
                Getresult(Last);
                Last = Operator.add;
            }
            else
            {
                Result = Convert.ToDouble(Put.Content);
                Last = Operator.add;
            }
            isbutton = true;
        }

        private void Reduce_Click(object sender, RoutedEventArgs e)
        {
            if (isper)
            {
                MessageBox.Show("请不要在使用%后使用其他运算符，若想进行其他运算，请清零，ans会保存之前的计算结果", "提示", MessageBoxButton.OK);
                return;
            }
            else if (Last == Operator.chu && ((string)Put.Content == "0"))
            {
                MessageBox.Show("除以0是没有意义的，换个数试试？", "提示", MessageBoxButton.OK);
                return;
            }
            Temp.Content = (string)Temp.Content + Put.Content + "-";
            if (Last != Operator.none)
            {
                Getresult(Last);
                Last = Operator.reduce;
            }
            else
            {
                Result = Convert.ToDouble(Put.Content);
                Last = Operator.reduce;
            }
            isbutton = true;
        }

        private void cheng_Click(object sender, RoutedEventArgs e)
        {
            if(isper)
            {
                MessageBox.Show("请不要在使用%后使用其他运算符，若想进行其他运算，请清零，ans会保存之前的计算结果", "提示", MessageBoxButton.OK);
                return;
            }
            else if (Last == Operator.chu && ((string)Put.Content == "0"))
            {
                MessageBox.Show("除以0是没有意义的，换个数试试？", "提示", MessageBoxButton.OK);
                return;
            }
            Temp.Content = (string)Temp.Content + Put.Content + "×";
            if (Last != Operator.none)
            {
                Getresult(Last);
                Last = Operator.cheng;
            }
            else
            {
                Result = Convert.ToDouble(Put.Content);
                Last = Operator.cheng;
            }
            isbutton = true;
        }

        private void chu_Click(object sender, RoutedEventArgs e)
        {
            if (isper)
            {
                MessageBox.Show("请不要在使用%后使用其他运算符，若想进行其他运算，请清零，ans会保存之前的计算结果", "提示", MessageBoxButton.OK);
                return;
            }
            else if (Last == Operator.chu && ((string)Put.Content == "0"))
            {
                MessageBox.Show("除以0是没有意义的，换个数试试？", "提示", MessageBoxButton.OK);
                return;
            }
            Temp.Content = (string)Temp.Content + Put.Content + "÷";
            if (Last != Operator.none)
            {
                Getresult(Last);
                Last = Operator.chu;
            }
            else
            {
                Result = Convert.ToDouble(Put.Content);
                Last = Operator.chu;
            }
            isbutton = true;
        }

        private void result_Click(object sender, RoutedEventArgs e)
        {
            if (!isbutton) return;
            if (isper)
            {
                MessageBox.Show("请不要在使用%后使用其他运算符，若想进行其他运算，请清零，ans会保存之前的计算结果", "提示", MessageBoxButton.OK);
                return;
            }
            else if (Last == Operator.chu && ((string)Put.Content == "0"))
            {
                MessageBox.Show("除以0是没有意义的，换个数试试？", "提示", MessageBoxButton.OK);
                return;
            }
            else Getresult(Last);
            Temp.Content = "";
            Last = Operator.none;
        }
        //ans键
        private void ans_Click(object sender, RoutedEventArgs e)
        {
            Put.Content = Result;
        }
    }
}
