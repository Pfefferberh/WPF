using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows;
using System.Windows.Controls;

namespace Calclator
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class Calc : Window
    {
        bool check = true;
        bool firstNo_zirro = true;
        bool restart = true;
        bool kostul = true;
        double res = 0;
        public Calc()
        {
            InitializeComponent();
        }
        List<double> bank_num = new List<double>();
        List<char> bank_math = new List<char>();
        private void CE_Click(object sender, RoutedEventArgs e)
        {
            Re_star("");
            EnterExample.Content = "0";
        }
        private void C_Click(object sender, RoutedEventArgs e)
        {
            char perev = EnterExample.Content.ToString().Last();
            if (perev != '+' && perev != '-' && perev != '*' && perev != '/')
                bank_num.RemoveAt(bank_num.Count - 1);
            else
            {
                bank_math.RemoveAt(bank_math.Count - 1);
                kostul = false;
            }
            if (EnterExample.Content.ToString().Length > 1)
            {
                EnterExample.Content = EnterExample.Content.ToString().Substring(0, EnterExample.Content.ToString().Length - 1);

            }
            else
                EnterExample.Content = "0";
            EnterNum.Content = "0";
        }
        private void Del_Click(object sender, RoutedEventArgs e)
        {
            if (EnterNum.Content.ToString().Length > 1) EnterNum.Content = EnterNum.Content.ToString().Substring(0, EnterNum.Content.ToString().Length - 1);
            else EnterNum.Content = "0";
        }
        private void Math_Click(object sender, RoutedEventArgs e)
        {
            if (!restart) Re_star("math");
            EnterExample.Content = string.Empty;
            Button button = sender as Button;
            if (check && kostul)
            {
                bank_num.Add(Convert.ToDouble(EnterNum.Content));
                bank_math.Add(Convert.ToChar(button.Content));
            }
            else
            {
                if (kostul) bank_math.RemoveAt(bank_math.Count - 1);
                else bank_num[bank_num.Count - 1] = Convert.ToDouble(bank_num[bank_num.Count - 1].ToString() + EnterNum.Content);
                bank_math.Add(Convert.ToChar(button.Content));
                kostul = true;
            }
            for (int i = 0; i < bank_num.Count; i++)
            {
                EnterExample.Content = EnterExample.Content.ToString() + bank_num[i].ToString() + bank_math[i].ToString();

            }
            check = false;
            firstNo_zirro = true;
            kostul = true;
            EnterNum.Content = "0";
        }
        private void Num_Click(object sender, RoutedEventArgs e)
        {
            if (!restart) Re_star("");
            Button button = sender as Button;
            if (firstNo_zirro && EnterNum.Content.ToString().Last() != ',')
            {
                EnterNum.Content = button.Content;
                firstNo_zirro = false;
            }
            else
                EnterNum.Content = EnterNum.Content.ToString() + button.Content;
            check = true;
        }
        private void Poin_Click(object sender, RoutedEventArgs e)
        {
            if (!EnterNum.Content.ToString().Contains(","))
            {
                if (!kostul && bank_num[bank_num.Count - 1].ToString().Contains(","))
                    MessageBox.Show("last digir have \",\"");
                else
                    EnterNum.Content = EnterNum.Content.ToString() + ",";

                firstNo_zirro = false;
            }
        }
        private void Resal_Click(object sender, RoutedEventArgs e)
        {
            int j = 0;
            int o = 0;
            List<double> vs = new List<double>();
            bank_num.Add(Convert.ToDouble(EnterNum.Content));
            bank_math.Add('=');
            for (int i = 0; i < bank_math.Count; i++)
            {
                if (bank_math[i] == '*')
                {
                    if (bank_math[i + 1] == '+' || bank_math[i + 1] == '-' || bank_math[i + 1] == '=')
                    {
                        vs.Add(bank_num[j] * bank_num[j + 1]);
                        bank_num[j] = vs[o];
                        bank_num.RemoveAt(j + 1);
                        bank_math.RemoveAt(i);
                        i = -1;
                        j = -1;
                        o++;
                    }
                }
                else if (bank_math[i] == '/')
                {
                    if (bank_math[i + 1] == '+' || bank_math[i + 1] == '-' || bank_math[i + 1] == '=')
                    {
                        vs.Add(bank_num[j] / bank_num[j + 1]);
                        bank_num[j] = vs[o];
                        bank_num.RemoveAt(j + 1);
                        bank_math.RemoveAt(i);
                        i = -1;
                        j = -1;
                        o++;
                    }
                }
                j++;
            }
            j = 0;
            for (int i = 0; i < bank_math.Count - 1; i++)
            {
                switch (bank_math[i])
                {
                    case '+':
                        res = bank_num[j] + bank_num[j + 1];
                        break;
                    case '-':
                        res = bank_num[j] - bank_num[j + 1];
                        break;
                    default:
                        break;
                }
                j += 2;
            }
            EnterExample.Content = "";
            EnterNum.Content = "0";
            EnterExample.Content = "Ans= " + res.ToString();
            restart = false;
        }
        private void Re_star(string choise)
        {
            bank_num.Clear();
            bank_math.Clear();
            if (choise == "math")
                EnterNum.Content = res.ToString();
            EnterExample.Content = "0";
            res = 0;
            check = true;
            firstNo_zirro = true;
            restart = true;
        }
    }
}
