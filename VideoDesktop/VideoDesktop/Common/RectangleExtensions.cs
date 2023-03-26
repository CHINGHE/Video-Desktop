using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VideoDesktop.Common
{
    public static class RectangleExtensions
    {
        public static RECT ToRECT(this Rectangle @this)
        {
            RECT rect;
            rect.left = @this.Left;
            rect.top = @this.Top;
            rect.right = @this.Right;
            rect.bottom = @this.Bottom;
            return rect;
        }
    }
}
