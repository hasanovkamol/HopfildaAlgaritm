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

namespace UIProject
{
    /// <summary>
    /// Interaction logic for CheckChar.xaml
    /// </summary>
    public partial class CheckChar : Window
    {
        public CheckChar()
        {
            InitializeComponent();
        }

        private void tbaddchar_Click(object sender, RoutedEventArgs e)
        {
            AddArrayChar add = new AddArrayChar();
            add.ShowDialog();

        }

        private void btClear_Click(object sender, RoutedEventArgs e)
        {
            tb1.Clear();
            tb2.Clear();
        }
    }
}
