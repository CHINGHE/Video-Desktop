using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VideoDesktop.Common
{
    public class WindowPlayer : IPlayer
    {
        IntPtr _windowHandle;

        public WindowPlayer(IntPtr windowHandle)
        {
            _windowHandle = windowHandle;
        }

        public IntPtr GetHandle()
        {
            return _windowHandle;
        }

        public void SetPosition(Rectangle rect)
        {
            PInvoke.DS2_SetWindowPosition(_windowHandle, rect.ToRECT());
        }

        public void Shutdown()
        {
            _windowHandle = IntPtr.Zero;
            PInvoke.DS2_RestoreLastWindowPosition();
        }
    }
}