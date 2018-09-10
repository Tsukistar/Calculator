using System.Windows;
using System;
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
        private enum Operator { none,add,reduce,cheng,chu,Mod,cifang };//运算类型
        private double Result;                              //保存计算结果
        private double Ans;
        private Operator Last = Operator.none;              //最后一次的运算符号
        private bool islastoperator = false;                //最后的输入是否为运算符
        private bool isbutton = false;                      //是否输入过运算符
        private bool isper = false;                         //是否使用百分号
        private bool isdengyu = false;                      //是否使用等于号
        private bool iszeropoint = false;                   //是否为0.
        //输入
        private void Point_Click(object sender, RoutedEventArgs e)
        {
            if (isper)
            {
                Put.Text = "0";
                isper = false;
            }
            else if (isbutton)
            {
                Put.Text = "0.";
            }
            else if (isdengyu)
            {
                Put.Text = "0";
                isdengyu = false;
            }
            else Put.Text += ".";
            if (Put.Text == "0.") iszeropoint = true;
            islastoperator = false;
        }

        private void Zero_Click(object sender, RoutedEventArgs e)
        {
            if (isper)
            {
                Put.Text = "0";
                isper = false;
            }
            else if (iszeropoint)
            {
                Put.Text += "0";
                islastoperator = false;
                return;
            }
            else if (isbutton)
            {
                Put.Text = "0";
            }
            else if (isdengyu)
            {
                Put.Text = "0";
                isdengyu = false;
            }
            if ((string)Put.Text == "0") return;
            else Put.Text += "0";
            islastoperator = false;
        }

        private void one_Click(object sender, RoutedEventArgs e)
        {
            if (isper)
            {
                Put.Text = "0";
                isper = false;
            }
            else if (string.Compare((string)Put.Text, ((string)Put.Text).Length, ".", 0, 1) == 0)
            {
                if (string.Compare((string)Put.Text, ((string)Put.Text).Length - 2, "0.", 0, 2) == 0)
                {
                    Put.Text += "1";
                    islastoperator = false;
                    return;
                }
                Put.Text += "1";
                islastoperator = false;
                return;
            }
            else if (isbutton)
            {
                Put.Text = "0";
            }
            else if (isdengyu)
            {
                Put.Text = "0";
                isdengyu = false;
            }
            if ((string)Put.Text == "0")
            {
                Put.Text = "1";
                isbutton = false;
            }
            else Put.Text += "1";
            islastoperator = false;
        }

        private void two_Click(object sender, RoutedEventArgs e)
        {
            if (isper)
            {
                Put.Text = "0";
                isper = false;
            }
            else if (iszeropoint)
            {
                Put.Text += "2";
                islastoperator = false;
                return;
            }
            else if (isbutton)
            {
                Put.Text = "0";
            }
            else if (isdengyu)
            {
                Put.Text = "0";
                isdengyu = false;
            }
            if ((string)Put.Text == "0")
            {
                Put.Text = "2";
                isbutton = false;
            }
            else Put.Text += "2";
            islastoperator = false;
        }

        private void three_Click(object sender, RoutedEventArgs e)
        {
            if (isper)
            {
                Put.Text = "0";
                isper = false;
            }
            else if (iszeropoint)
            {
                if (string.Compare((string)Put.Text, ((string)Put.Text).Length - 2, "0.", 0, 2) == 0)
                {
                    Put.Text += "3";
                    islastoperator = false;
                    return;
                }
                Put.Text += "3";
                islastoperator = false;
                return;
            }
            else if (isbutton)
            {
                Put.Text = "0";
            }
            else if (isdengyu)
            {
                Put.Text = "0";
                isdengyu = false;
            }
            if ((string)Put.Text == "0")
            {
                Put.Text = "3";
                isbutton = false;
            }
            else Put.Text += "3";
            islastoperator = false;
        }

        private void four_Click(object sender, RoutedEventArgs e)
        {
            if (isper)
            {
                Put.Text = "0";
                isper = false;
            }
            else if (iszeropoint)
            {
                if (string.Compare((string)Put.Text, ((string)Put.Text).Length - 2, "0.", 0, 2) == 0)
                {
                    Put.Text += "4";
                    islastoperator = false;
                    return;
                }
                Put.Text += "4";
                islastoperator = false;
                return;
            }
            else if (isbutton)
            {
                Put.Text = "0";
            }
            else if (isdengyu)
            {
                Put.Text = "0";
                isdengyu = false;
            }
            if ((string)Put.Text == "0")
            {
                Put.Text = "4";
                isbutton = false;
            }
            else Put.Text += "4";
            islastoperator = false;
        }

        private void five_Click(object sender, RoutedEventArgs e)
        {
            if (isper)
            {
                Put.Text = "0";
                isper = false;
            }
            else if (iszeropoint)
            {
                if (string.Compare((string)Put.Text, ((string)Put.Text).Length - 2, "0.", 0, 2) == 0)
                {
                    Put.Text += "5";
                    islastoperator = false;
                    return;
                }
                Put.Text += "5";
                islastoperator = false;
                return;
            }
            else if (isbutton)
            {
                Put.Text = "0";
            }
            else if (isdengyu)
            {
                Put.Text = "0";
                isdengyu = false;
            }
            if ((string)Put.Text == "0")
            {
                Put.Text = "5";
                isbutton = false;
            }
            else Put.Text += "5";
            islastoperator = false;
        }

        private void six_Click(object sender, RoutedEventArgs e)
        {
            if (isper)
            {
                Put.Text = "0";
                isper = false;
            }
            else if (iszeropoint)
            {
                if (string.Compare((string)Put.Text, ((string)Put.Text).Length - 2, "0.", 0, 2) == 0)
                {
                    Put.Text += "6";
                    islastoperator = false;
                    return;
                }
                Put.Text += "6";
                islastoperator = false;
                return;
            }
            else if (isbutton)
            {
                Put.Text = "0";
            }
            else if (isdengyu)
            {
                Put.Text = "0";
                isdengyu = false;
            }
            if ((string)Put.Text == "0")
            {
                Put.Text = "6";
                isbutton = false;
            }
            else Put.Text += "6";
            islastoperator = false;
        }

        private void seven_Click(object sender, RoutedEventArgs e)
        {
            if (isper)
            {
                Put.Text = "0";
                isper = false;
            }
            else if (iszeropoint)
            {
                if (string.Compare((string)Put.Text, ((string)Put.Text).Length - 2, "0.", 0, 2) == 0)
                {
                    Put.Text += "7";
                    islastoperator = false;
                    return;
                }
                Put.Text += "7";
                islastoperator = false;
                return;
            }
            else if (isbutton)
            {
                Put.Text = "0";
            }
            else if (isdengyu)
            {
                Put.Text = "0";
                isdengyu = false;
            }
            if ((string)Put.Text == "0")
            {
                Put.Text = "7";
                isbutton = false;
            }
            else Put.Text += "7";
            islastoperator = false;
        }

        private void eight_Click(object sender, RoutedEventArgs e)
        {
            if (isper)
            {
                Put.Text = "0";
                isper = false;
            }
            else if (iszeropoint)
            {
                if (string.Compare((string)Put.Text, ((string)Put.Text).Length - 2, "0.", 0, 2) == 0)
                {
                    Put.Text += "8";
                    islastoperator = false;
                    return;
                }
                Put.Text += "8";
                islastoperator = false;
                return;
            }
            else if (isbutton)
            {
                Put.Text = "0";
            }
            else if (isdengyu)
            {
                Put.Text = "0";
                isdengyu = false;
            }
            if ((string)Put.Text == "0")
            {
                Put.Text = "8";
                isbutton = false;
            }
            else Put.Text += "8";
            islastoperator = false;
        }

        private void nine_Click(object sender, RoutedEventArgs e)
        {
            if (isper)
            {
                Put.Text = "0";
                isper = false;
            }
            else if (iszeropoint)
            {
                if (string.Compare((string)Put.Text, ((string)Put.Text).Length - 2, "0.", 0, 2) == 0)
                {
                    Put.Text += "9";
                    islastoperator = false;
                    return;
                }
                Put.Text += "9";
                islastoperator = false;
                return;
            }
            else if (isbutton)
            {
                Put.Text = "0";
            }
            else if (isdengyu)
            {
                Put.Text = "0";
                isdengyu=false;
            }
            if ((string)Put.Text == "0")
            {
                Put.Text = "9";
                isbutton = false;
            }
            else Put.Text += "9";
            islastoperator = false;
        }
        /// <summary>
        /// 其他运算符
        /// </summary>
        private void Clear_Click(object sender, RoutedEventArgs e)
        {
            Ans = Result;
            Result = 0;
            Temp.Content = "";
            Put.Text = "0";
            isper = false;
            isbutton = false;
            isdengyu = false;
            islastoperator = false;
        }      //清零操作

        private void Del_Click(object sender, RoutedEventArgs e)
        {
            if (isper) isper = false;
            else if (isdengyu) return;
            if ((string)Put.Text == "0") return;
            else
            {
                string temp = (string)Put.Text;
                temp=temp.Remove(temp.Length - 1);
                if (temp == "") temp = "0";
                Put.Text = temp;
            }
        }        //删除操作

        private void Percent_Click(object sender, RoutedEventArgs e)       //求百分数
        {
            if ((string)Temp.Content != "")
            {
                MessageBox.Show("请不要在进行其他运算时使用%运算符", "提示", MessageBoxButton.OK);
                return;
            }
            else if (isper) return;
            double a=Convert.ToDouble(Put.Text);
            a = a * 100;
            Put.Text = Convert.ToString(a) + "%";
            isper = true;
            iszeropoint = false;
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
                    Result = Plus_do(Result, (string)Put.Text);
                    Ans = Result;
                    Last = Operator.add;
                    Put.Text = Convert.ToString(Result);
                    break;
                case Operator.reduce:
                    Result=Reduce_do(Result, (string)Put.Text);
                    Ans = Result;
                    Last = Operator.reduce;
                    Put.Text = Convert.ToString(Result);
                    break;
                case Operator.cheng:
                    Result=cheng_do(Result, (string)Put.Text);
                    Ans = Result;
                    Last = Operator.cheng;
                    Put.Text = Convert.ToString(Result);
                    break;
                case Operator.chu:
                    Result=chu_do(Result, (string)Put.Text);
                    Ans = Result;
                    Last = Operator.chu;
                    Put.Text = Convert.ToString(Result);
                    break;
                case Operator.Mod:
                    Result = Math.IEEERemainder(Result, Convert.ToDouble(Put.Text));
                    if (Result < 0) Result += Convert.ToDouble(Put.Text);
                    Ans = Result;
                    Last = Operator.Mod;
                    Put.Text = Convert.ToString(Result);
                    break;
                case Operator.cifang:
                    Result = Math.Pow(Result, Convert.ToDouble(Put.Text));
                    Ans = Result;
                    Last = Operator.cifang;
                    Put.Text = Convert.ToString(Result);
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
            else if (islastoperator) return;
            else if (Last == Operator.chu && ((string)Put.Text == "0"))
            {
                MessageBox.Show("除以0是没有意义的，换个数试试？", "提示", MessageBoxButton.OK);
                return;
            }
            Temp.Content = (string)Temp.Content + Put.Text + "+";
            if (Last != Operator.none)
            {
                Getresult(Last);
                Last = Operator.add;
            }
            else
            {
                Result = Convert.ToDouble(Put.Text);
                Last = Operator.add;
            }
            isbutton = true;
            islastoperator = true;
            iszeropoint = false;
        }

        private void Reduce_Click(object sender, RoutedEventArgs e)
        {
            if (isper)
            {
                MessageBox.Show("请不要在使用%后使用其他运算符，若想进行其他运算，请清零，ans会保存之前的计算结果", "提示", MessageBoxButton.OK);
                return;
            }
            else if (islastoperator) return;
            else if (Last == Operator.chu && ((string)Put.Text == "0"))
            {
                MessageBox.Show("除以0是没有意义的，换个数试试？", "提示", MessageBoxButton.OK);
                return;
            }
            Temp.Content = (string)Temp.Content + Put.Text + "-";
            if (Last != Operator.none)
            {
                Getresult(Last);
                Last = Operator.reduce;
            }
            else
            {
                Result = Convert.ToDouble(Put.Text);
                Last = Operator.reduce;
            }
            isbutton = true;
            islastoperator = true;
            iszeropoint = false;
        }

        private void cheng_Click(object sender, RoutedEventArgs e)
        {
            if(isper)
            {
                MessageBox.Show("请不要在使用%后使用其他运算符，若想进行其他运算，请清零，ans会保存之前的计算结果", "提示", MessageBoxButton.OK);
                return;
            }
            else if (islastoperator) return;
            else if (Last == Operator.chu && ((string)Put.Text == "0"))
            {
                MessageBox.Show("除以0是没有意义的，换个数试试？", "提示", MessageBoxButton.OK);
                return;
            }
            Temp.Content = (string)Temp.Content + Put.Text + "×";
            if (Last != Operator.none)
            {
                Getresult(Last);
                Last = Operator.cheng;
            }
            else
            {
                Result = Convert.ToDouble(Put.Text);
                Last = Operator.cheng;
            }
            isbutton = true;
            islastoperator = true;
            iszeropoint = false;
        }

        private void chu_Click(object sender, RoutedEventArgs e)
        {
            if (isper)
            {
                MessageBox.Show("请不要在使用%后使用其他运算符，若想进行其他运算，请清零，ans会保存之前的计算结果", "提示", MessageBoxButton.OK);
                return;
            }
            else if (islastoperator) return;
            else if (Last == Operator.chu && ((string)Put.Text == "0"))
            {
                MessageBox.Show("除以0是没有意义的，换个数试试？", "提示", MessageBoxButton.OK);
                return;
            }
            Temp.Content = (string)Temp.Content + Put.Text + "÷";
            if (Last != Operator.none)
            {
                Getresult(Last);
                Last = Operator.chu;
            }
            else
            {
                Result = Convert.ToDouble(Put.Text);
                Last = Operator.chu;
            }
            isbutton = true;
            islastoperator = true;
            iszeropoint = false;
        }

        private void result_Click(object sender, RoutedEventArgs e)
        {
            if (Last==Operator.none) return;
            if (isper)
            {
                MessageBox.Show("请不要在使用%后使用其他运算符，若想进行其他运算，请清零，ans会保存之前的计算结果", "提示", MessageBoxButton.OK);
                return;
            }
            else if (islastoperator)
            {
                MessageBox.Show("请不要在输入运算符后使用 = ,已为你进行前面的运算", "提示", MessageBoxButton.OK);
            }
            else if (Last == Operator.chu && ((string)Put.Text == "0"))
            {
                MessageBox.Show("除以0是没有意义的，换个数试试？", "提示", MessageBoxButton.OK);
                return;
            }
            else Getresult(Last);
            Temp.Content = "";
            Last = Operator.none;
            islastoperator = false;
            isdengyu = true;
            iszeropoint = false;
        }
        //ans键
        private void ans_Click(object sender, RoutedEventArgs e)
        {
            Put.Text = Convert.ToString(Ans);
        }

        private void Mod_Click(object sender, RoutedEventArgs e)
        {
            if (isper)
            {
                MessageBox.Show("请不要在使用%后使用其他运算符，若想进行其他运算，请清零，ans会保存之前的计算结果", "提示", MessageBoxButton.OK);
                return;
            }
            else if (islastoperator) return;
            else if (Last == Operator.chu && ((string)Put.Text == "0"))
            {
                MessageBox.Show("除以0是没有意义的，换个数试试？", "提示", MessageBoxButton.OK);
                return;
            }
            Temp.Content = (string)Temp.Content + Put.Text + " mod " ;
            if (Last != Operator.none)
            {
                Getresult(Last);
                Last = Operator.Mod;
            }
            else
            {
                Result = Convert.ToDouble(Put.Text);
                Last = Operator.Mod;
            }
            isbutton = true;
            islastoperator = true;
            iszeropoint = false;
        }

        private void xxx_Click(object sender, RoutedEventArgs e)
        {
            if (isper)
            {
                MessageBox.Show("请不要在使用%后使用其他运算符，若想进行其他运算，请清零，ans会保存之前的计算结果", "提示", MessageBoxButton.OK);
                return;
            }
            Result = Convert.ToDouble(Put.Text);
            Result = Result * Result;
            Put.Text = Convert.ToString(Result);
            iszeropoint = false;
        }

        private void tan_Click(object sender, RoutedEventArgs e)
        {
            iszeropoint = false;
            if (isper)
            {
                MessageBox.Show("请不要在使用%后使用其他运算符，若想进行其他运算，请清零，ans会保存之前的计算结果", "提示", MessageBoxButton.OK);
                return;
            }
            Result = Convert.ToDouble(Put.Text);
            Result = Math.Tan(Result);
            Put.Text = Convert.ToString(Result);
            iszeropoint = false;
        }

        private void oneton_Click(object sender, RoutedEventArgs e)
        {
            if (isper)
            {
                MessageBox.Show("请不要在使用%后使用其他运算符，若想进行其他运算，请清零，ans会保存之前的计算结果", "提示", MessageBoxButton.OK);
                return;
            }
            iszeropoint = false;
            Result = Convert.ToInt16(Put.Text);
            int a = Convert.ToInt16(Put.Text);
            Result = 1;
            for (int i = 1; i <= a; i++) Result = Result * i;
            Put.Text = Convert.ToString(Result);
        }

        private void cos_Click(object sender, RoutedEventArgs e)
        {
            if (isper)
            {
                MessageBox.Show("请不要在使用%后使用其他运算符，若想进行其他运算，请清零，ans会保存之前的计算结果", "提示", MessageBoxButton.OK);
                return;
            }
            Result = Convert.ToDouble(Put.Text);
            Result = Math.Cos(Result);
            Put.Text = Convert.ToString(Result);
            iszeropoint = false;
        }

        private void sin_Click(object sender, RoutedEventArgs e)
        {
            if (isper)
            {
                MessageBox.Show("请不要在使用%后使用其他运算符，若想进行其他运算，请清零，ans会保存之前的计算结果", "提示", MessageBoxButton.OK);
                return;
            }
            Result = Convert.ToDouble(Put.Text);
            Result = Math.Sin(Result);
            Put.Text = Convert.ToString(Result);
            iszeropoint = false;
        }

        private void xciy_Click(object sender, RoutedEventArgs e)
        {
            if (isper)
            {
                MessageBox.Show("请不要在使用%后使用其他运算符，若想进行其他运算，请清零，ans会保存之前的计算结果", "提示", MessageBoxButton.OK);
                return;
            }
            else if (islastoperator) return;
            else if (Last == Operator.chu && ((string)Put.Text == "0"))
            {
                MessageBox.Show("除以0是没有意义的，换个数试试？", "提示", MessageBoxButton.OK);
                return;
            }
            iszeropoint = false;
            Temp.Content = (string)Temp.Content + Put.Text + "^";
            if (Last != Operator.none)
            {
                Getresult(Last);
                Last = Operator.cifang;
            }
            else
            {
                Result = Convert.ToDouble(Put.Text);
                Last = Operator.cifang;
            }
            isbutton = true;
            islastoperator = true;
        }

        private void Log_Click(object sender, RoutedEventArgs e)
        {
            if (isper)
            {
                MessageBox.Show("请不要在使用%后使用其他运算符，若想进行其他运算，请清零，ans会保存之前的计算结果", "提示", MessageBoxButton.OK);
                return;
            }
            if ((string)Put.Text == "0") return;
            Result = Convert.ToDouble(Put.Text);
            Result = Math.Log(Result);
            Put.Text = Convert.ToString(Result);
            iszeropoint = false;
        }

        private void Sqrt_Click(object sender, RoutedEventArgs e)
        {
            if (isper)
            {
                MessageBox.Show("请不要在使用%后使用其他运算符，若想进行其他运算，请清零，ans会保存之前的计算结果", "提示", MessageBoxButton.OK);
                return;
            }
            Result = Convert.ToDouble(Put.Text);
            Result = Math.Sqrt(Result);
            Put.Text = Convert.ToString(Result);
            iszeropoint = false;
        }

        private void pi_Click(object sender, RoutedEventArgs e)
        {
            if (isper)
            {
                return;
            }
            if (isper)
            {
                Put.Text = "0";
                isper = false;
            }
            else if ((string)Put.Text != "0")
            {
                Result = cheng_do(Convert.ToDouble(Put.Text), "3.1415926535897932384626433832795");
                Put.Text = Convert.ToString(Result);
                return;
            }
            else if (isbutton)
            {
                Put.Text = "0";
            }
            if ((string)Put.Text == "0")
            {
                Put.Text = "3.1415926535897932384626433832795";
                isbutton = false;
            }
            else Put.Text += "3.1415926535897932384626433832795";
            islastoperator = false;
            iszeropoint = false;
        }
    }
}
