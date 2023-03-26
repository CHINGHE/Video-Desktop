using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VideoDesktop.Common
{
    public interface IPlayer
    {
        IntPtr GetHandle();
        void SetPosition(Rectangle rect);
        void Shutdown();
    }

    public interface IPlayerControl
    {
        bool IsPlaying { get; }
        Uri Source { get; set; }
        bool IsMuted { get; set; }
        double Volume { get; set; }

        void Play();
        void Pause();
    }

    public interface IPlayerInteractive
    {
        IntPtr GetMessageHandle();
    }

    public enum WindowType
    {
        None,
        Video,
        Web,
        Window
    }
}

