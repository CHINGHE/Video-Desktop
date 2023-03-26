using SCREEN_CAPTURE;
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

namespace VideoDesktop
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }


        private void Grid_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            this.DragMove();
        }

        private void Window_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
             _pressedPosition=e.GetPosition(this);
        }

        private void Window_PreviewMouseMove(object sender, MouseEventArgs e)
        {
            if (Mouse.LeftButton == MouseButtonState.Pressed)
            {
                _isDrageMoved = true;
                DragMove();
            }
        }

        private void Window_PreviewMouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            if (_isDrageMoved)
            { 
                _isDrageMoved=false;
                e.Handled = true;
            }
            if ((sender as Button)!=null&&(sender as Button).Name == "button")
            {
                DesktopSetting dst = new DesktopSetting();

                dst.Show();
            }
        }
        Point _pressedPosition;
        bool _isDrageMoved = false;

        private void Image_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            this.DragMove();
        }

        

        private void button_Click(object sender, RoutedEventArgs e)
        {
            DesktopSetting dst = new DesktopSetting();
            
            dst.Show();
        }

        private void SvgViewbox_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            App.Current.Shutdown();
        }

        private void btn_Capture_Click(object sender, RoutedEventArgs e)
        {
            FrmCapture m_frmCapture = new FrmCapture();
            m_frmCapture.IsCaptureCursor = true;
            m_frmCapture.IsFromClipBoard = true;
            m_frmCapture.Show();
        }

        private void btn_Exit_Click(object sender, RoutedEventArgs e)
        {
            App.Current.Shutdown();
        }
    }
}
