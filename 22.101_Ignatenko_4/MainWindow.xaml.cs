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

namespace _22._101_Ignatenko_4
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

        private void tbComplete_Click(object sender, RoutedEventArgs e)
        {
            string input = tbInput.Text;
            lbOutput.Items.Clear();
            lbOutput.Items.Add(Task(input));
        }

        public string Task(string input)
        {
            try
            {
                string[] words = input.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

                for (int i = 0; i < words.Length; i++)
                {
                    char[] chars = words[i].ToCharArray();

                    string help = "";

                    for (int j = 0; j < chars.Length; j++) 
                    { 
                        if (j == 0 || j == chars.Length - 1)
                        {
                            chars[j] = char.ToUpper(chars[j]);
                            help += chars[j];
                        }
                        else
                        {
                            chars[j] = char.ToLower(chars[j]);
                            help += chars[j]; 
                        }
                    } 

                    words[i] = help;
                }

                string result = string.Join("«это_пробел»", words);

                return result;
            }
            catch 
            { 
                return "Произошла ошибка";
            }
        }
    }
}
