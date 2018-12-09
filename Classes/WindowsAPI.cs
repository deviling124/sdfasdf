using System;
using System.Runtime.InteropServices;
using System.Threading;
using System.Windows.Forms;

namespace DZEThaitro.Classes
{
    public class WindowsAPI
    {
        [DllImport("user32.dll", SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool PostMessage(IntPtr hWnd, uint msg, UIntPtr wParam, UIntPtr lParam);

        [DllImport("user32", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern bool SetWindowText(IntPtr intptr_0, [MarshalAs(UnmanagedType.VBByRefStr)] ref string string_0);

        [DllImport("user32.dll")]
        private static extern void mouse_event(uint dwFlags, int dx, int dy, uint dwData, UIntPtr dwExtraInfo);


        [DllImport("user32")]
        public static extern uint MapVirtualKey(uint key, TranslationTypes translation);


        [DllImport("User32.dll")]
        public static extern bool GetAsyncKeyState(Keys vKey);


        public WindowsAPI(IntPtr handle)
        {
            this.Handle = handle;
        }


        public static uint MapVirtualKey(Keys key, TranslationTypes translation)
        {
            return WindowsAPI.MapVirtualKey((uint)key, translation);
        }

        private UIntPtr MakeKeyParameter(Keys key, bool keyUp)
        {
            return this.MakeKeyParameter(key, false, false, 1u, false, false);
        }

        private UIntPtr MakeKeyParameter(Keys key, bool keyUp, bool fRepeat, uint cRepeat, bool altDown, bool fExtended)
        {
            uint num = cRepeat | WindowsAPI.MapVirtualKey(key, TranslationTypes.VirtualKeyToScanCode) << 16;
            if (fExtended)
            {
                num |= 16777216u;
            }
            if (altDown)
            {
                num |= 536870912u;
            }
            if (fRepeat)
            {
                num |= 1073741824u;
            }
            if (keyUp)
            {
                num |= 2147483648u;
            }
            return new UIntPtr(num);
        }

        public void Press(Keys key)
        {
            WindowsAPI.PostMessage(this.Handle, 260u, new UIntPtr((uint)key), UIntPtr.Zero);
        }


        public void Release(Keys key)
        {
            WindowsAPI.PostMessage(this.Handle, 261u, new UIntPtr((uint)key), UIntPtr.Zero);
        }


        public void ControlSend(Keys key)
        {
            this.Press(key);
            Thread.Sleep(10);
            this.Release(key);
        }


        public void ClickLeft()
        {
            WindowsAPI.mouse_event(2u, 0, 0, 0u, UIntPtr.Zero);
            Thread.Sleep(100);
            WindowsAPI.mouse_event(4u, 0, 0, 0u, UIntPtr.Zero);
        }


        private IntPtr Handle;


        private const uint MOUSEEVENTF_LEFTDOWN = 2u;


        private const uint MOUSEEVENTF_LEFTUP = 4u;
    }
}
