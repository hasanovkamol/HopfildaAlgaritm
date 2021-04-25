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
    /// Interaction logic for AddArrayChar.xaml
    /// </summary>
    public partial class AddArrayChar : Window
    {
       
        public AddArrayChar()
        {
            InitializeComponent();
        }
        private void tbOK_Click(object sender, RoutedEventArgs e)
        {
            if (tbChar != null)
            {
                tbchar.Array();

            }
        }

        private void tbCencel_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
