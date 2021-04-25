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
    /// Interaction logic for Button.xaml
    /// </summary>
    public partial class KKButton : UserControl
    {
        public static DependencyProperty IsPressedProperty =
            DependencyProperty.RegisterAttached(nameof(IsPressed), typeof(bool),
            typeof(KKButton), new PropertyMetadata(false));
        public bool IsPressed
        {
            get { return (bool)GetValue(IsPressedProperty); }
            set { SetValue(IsPressedProperty, value); }
        }

        public KKButton()
        {
            InitializeComponent();
        }

        private void Border_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (!IsPressed)
            {
                IsPressed = true;
            kkbutton.Background = new SolidColorBrush(Colors.Red);
            }
            else
            {
                kkbutton.Background = new SolidColorBrush(Colors.Black);
                IsPressed = false;
            }
        }
    }
}
