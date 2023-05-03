using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.InteropServices;
using System.Drawing;

namespace ProbeMedic.Controles
{
    public class NativeMethods
    {
        [DllImport("user32.dll")]
        internal static extern bool GetWindowRect(IntPtr hWnd, ref RECT rect);
        [DllImport("user32.dll", CharSet = CharSet.Auto, ExactSpelling = true)]
        internal static extern short GetKeyState(int virtualKeyCode);

        [StructLayout(LayoutKind.Sequential)]
        internal struct RECT
        {
            public int Left, Top, Right, Bottom;
            public RECT(Rectangle bounds)
            {
                this.Left = bounds.Left;
                this.Top = bounds.Top;
                this.Right = bounds.Right;
                this.Bottom = bounds.Bottom;
            }
            public void Inflate(int x, int y)
            {
                this.Left -= x;
                this.Top -= y;
                this.Right += x;
                this.Bottom += y;
            }
            public Rectangle ToRectangle()
            {
                return Rectangle.FromLTRB(Left, Top, Right, Bottom);
            }
            public int Height
            {
                get { return this.Bottom - this.Top; }
            }
            public int Width
            {
                get { return this.Right - this.Left; }
            }
        }

        internal const int WM_SETFOCUS = 0x0007;
        internal const int WM_KEYDOWN = 0x0100;
        internal const int WM_KEYUP = 0x0101;
        internal const int WM_LBUTTONDBLCLK = 0x0203;
        internal const int WM_LBUTTONDOWN = 0x0201;
        internal const int WM_RBUTTONUP = 0x0205;

        // virtual keys
        internal const int VK_RETURN = 0x0D;    // ENTER key
        internal const int VK_TAB = 0x09;       // TAB key
        internal const int VK_SHIFT = 0x10;     // SHIFT key
        internal const int VK_LEFT = 0x25;      // LEFT ARROW key
        internal const int VK_RIGHT = 0x27;     // RIGHT ARROW key
    }
}
