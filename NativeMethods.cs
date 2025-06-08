using System;
using System.Runtime.InteropServices;

namespace AlfredAutoClick.Core
{
    /// <summary>
    /// Provides native methods to simulate mouse input.
    /// </summary>
    public static class NativeMethods
    {
        /// <summary>
        /// Structure used to define input for SendInput.
        /// </summary>
        [StructLayout(LayoutKind.Sequential)]
        private struct INPUT
        {
            public uint type;
            public MOUSEINPUT mi;
        }

        /// <summary>
        /// Structure representing mouse-specific input data.
        /// </summary>
        [StructLayout(LayoutKind.Sequential)]
        private struct MOUSEINPUT
        {
            public int dx;
            public int dy;
            public uint mouseData;
            public uint dwFlags;
            public uint time;
            public IntPtr dwExtraInfo;
        }

        /// <summary>
        /// Constant to identify mouse input.
        /// </summary>
        private const int INPUT_MOUSE = 0;

        /// <summary>
        /// Flags to simulate specific mouse actions.
        /// </summary>
        private const uint MOUSEEVENTF_LEFTDOWN = 0x0002;
        private const uint MOUSEEVENTF_LEFTUP = 0x0004;
        private const uint MOUSEEVENTF_RIGHTDOWN = 0x0008;
        private const uint MOUSEEVENTF_RIGHTUP = 0x0010;
        private const uint MOUSEEVENTF_MIDDLEDOWN = 0x0020;
        private const uint MOUSEEVENTF_MIDDLEUP = 0x0040;

        /// <summary>
        /// Calls the Windows API to simulate input.
        /// </summary>
        [DllImport("user32.dll", SetLastError = true)]
        private static extern uint SendInput(uint nInputs, INPUT[] pInputs, int cbSize);

        /// <summary>
        /// Simulates a full click (down then up) using the specified button.
        /// </summary>
        public static void MouseClick(ClickType button)
        {
            // press the mouse button
            MouseDown(button);

            // release the mouse button
            MouseUp(button);
        }

        /// <summary>
        /// Simulates pressing down a mouse button.
        /// </summary>
        public static void MouseDown(ClickType button)
        {
            // send the down flag input
            SendMouseInput(GetDownFlag(button));
        }

        /// <summary>
        /// Simulates releasing a mouse button.
        /// </summary>
        public static void MouseUp(ClickType button)
        {
            // send the up flag input
            SendMouseInput(GetUpFlag(button));
        }

        /// <summary>
        /// Sends a mouse input with the given flag.
        /// </summary>
        private static void SendMouseInput(uint flags)
        {
            // prepare input structure
            var input = new INPUT
            {
                type = INPUT_MOUSE,
                mi = new MOUSEINPUT
                {
                    dx = 0,
                    dy = 0,
                    mouseData = 0,
                    dwFlags = flags,
                    time = 0,
                    dwExtraInfo = IntPtr.Zero
                }
            };

            // send the input
            SendInput(1, new INPUT[] { input }, Marshal.SizeOf(typeof(INPUT)));
        }

        /// <summary>
        /// Returns the appropriate flag to simulate mouse down for a given button.
        /// </summary>
        private static uint GetDownFlag(ClickType button)
        {
            // check which button was selected
            if (button == ClickType.Left) return MOUSEEVENTF_LEFTDOWN;
            if (button == ClickType.Right) return MOUSEEVENTF_RIGHTDOWN;
            return MOUSEEVENTF_MIDDLEDOWN;
        }

        /// <summary>
        /// Returns the appropriate flag to simulate mouse up for a given button.
        /// </summary>
        private static uint GetUpFlag(ClickType button)
        {
            // check which button was selected
            if (button == ClickType.Left) return MOUSEEVENTF_LEFTUP;
            if (button == ClickType.Right) return MOUSEEVENTF_RIGHTUP;
            return MOUSEEVENTF_MIDDLEUP;
        }
    }
}
