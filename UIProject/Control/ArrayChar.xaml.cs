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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace UIProject.Control
{
    /// <summary>
    /// Interaction logic for ArrayChar.xaml
    /// </summary>
    public partial class ArrayChar : UserControl
    {
        private int[,] array = new int[9, 9];
        public ArrayChar()
        {
            InitializeComponent();
        }
        public int[,] Array()
        {
            int i = 0, j = 0;
            foreach (KKButton item in tbchars.Children)
            {
                if (j == 9)
                {
                    i += 1;
                    j = 0;
                }
                if ((bool)item.GetType().GetProperty("IsPressed").GetValue(item)) array[i, j] = 1;
                else array[i, j] = -1;
                j += 1;
            }
            return array;

        }
        public void Clear()
        {
            foreach (KKButton item in tbchars.Children)
            {
                item.GetType().GetProperty("Is").SetValue(item, false);
            }
        }
    }
}
