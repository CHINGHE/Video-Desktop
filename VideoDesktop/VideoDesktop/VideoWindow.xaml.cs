using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Interop;
using System.Windows.Media;
using System.Windows.Media.Imaging; 
using VideoDesktop.Common;

namespace VideoDesktop
{
    /// <summary>
    /// VideoWindow.xaml 的交互逻辑
    /// </summary>
    public partial class VideoWindow : Window, IPlayer, IPlayerControl
    {
        public VideoWindow()
        {
            InitializeComponent();
        }

        public IntPtr GetHandle()
        {
            WindowInteropHelper windowInteropHelper = new WindowInteropHelper(this);
            return windowInteropHelper.Handle;
        }

        public void SetPosition(Rectangle rect)
        {
            this.WindowStyle = WindowStyle.None;
            this.ResizeMode = ResizeMode.NoResize;
            this.Left = rect.Left;
            this.Top = rect.Top;
            this.Width = rect.Width;
            this.Height = rect.Height;
        }

        public void Shutdown()
        {
            this.Close();
        }

        public bool IsPlaying { get; private set; }

        public Uri Source
        {
            get => mediaElement.Source;
            set => mediaElement.Source = value;
        }

        public double Volume
        {
            get => mediaElement.Volume;
            set => mediaElement.Volume = value;
        }

        public bool IsMuted
        {
            get => mediaElement.IsMuted;
            set => mediaElement.IsMuted = value;
        }

        public void Play()
        {
            mediaElement.Play();
            IsPlaying = true;
        }

        public void Pause()
        {
            mediaElement.Pause();
            IsPlaying = false;
        }

        private void mediaElement_MediaEnded(object sender, RoutedEventArgs e)
        {
            mediaElement.Position = TimeSpan.Zero;
            mediaElement.Play();
        }

        protected override void OnClosed(EventArgs e)
        {
            mediaElement.Close();
            mediaElement = null;
            base.OnClosed(e);
        }
    }
}

