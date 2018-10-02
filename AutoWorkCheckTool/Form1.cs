using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using WindowsInput.Native;
using WindowsInput;

namespace AutoWorkCheckTool
{
    public partial class Form1 : Form
    {
        //This is a replacement for Cursor.Position in WinForms
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        static extern bool SetCursorPos(int x, int y);

        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern void mouse_event(int dwFlags, int dx, int dy, int cButtons, int dwExtraInfo);

        public const int MOUSEEVENTF_LEFTDOWN = 0x02;
        public const int MOUSEEVENTF_LEFTUP = 0x04;

        public Form1()
        {
            InitializeComponent();
        }

        protected override void OnShown(EventArgs e)
        {
            base.OnShown(e);

            //1. Wait First Web Page Open
            WaitWebPageLoadingEnd();

            //2. Ask Continue Process
            DialogResult messageBoxResult = MessageBox.Show("정말로 출/퇴근 처리를 하시겠습니까?", "경고", MessageBoxButtons.YesNoCancel);
            if (messageBoxResult == DialogResult.Yes)
            {
                Thread.Sleep(50);

                //3. Login Web Page
                InputSimulator sim = new InputSimulator();
                string[] getAccount = AccountTextBox.Text.Split(new string[]{"/", "\n"}, StringSplitOptions.None);

                //3-1. Input ID & Password
                int count = 0;
                foreach (string keyword in getAccount)
                {
                    Thread.Sleep(50);
                    LeftMouseClick(this.Location.X + 350, this.Location.Y + 420 + (count * 50));

                    char[] words = keyword.ToCharArray();

                    foreach (char word in words)
                    {
                        sim.Keyboard.TextEntry(word).Sleep(1);
                    }
                    count += 1;
                }
                //3-2. Click Login Button
                Thread.Sleep(50);
                LeftMouseClick(this.Location.X + 50, this.Location.Y + 420);
                WaitWebPageLoadingEnd();

                //4. Move Web Page To Click  
                Thread.Sleep(50);
                LeftMouseClick(this.Location.X + 150, this.Location.Y + 420);
                WaitWebPageLoadingEnd();

                //5. Click Work Check Button
                Thread.Sleep(50);
                LeftMouseClick(this.Location.X + 200, this.Location.Y + 420);
                WaitWebPageLoadingEnd();
            }
            else
            {
                //End
            }

            /*
            WebBrowserView.Navigate(new Uri("http://www.naver.com"));
            while (WebBrowserView.ReadyState != WebBrowserReadyState.Complete)
            {
                Application.DoEvents();
            }
            */
        }

        private void WaitWebPageLoadingEnd()
        {
            while (WebBrowserView.ReadyState != WebBrowserReadyState.Complete)
            {
                Application.DoEvents();
            }
        }

        private void ClickButton_Click(object sender, EventArgs e)
        {
            //LeftMouseClick(350, 420);
        }

        //This simulates a left mouse click
        public static void LeftMouseClick(int xpos, int ypos)
        {
            SetCursorPos(xpos, ypos);
            mouse_event(MOUSEEVENTF_LEFTDOWN, xpos, ypos, 0, 0);
            mouse_event(MOUSEEVENTF_LEFTUP, xpos, ypos, 0, 0);
        }

        private void ShutdownButton_Click(object sender, EventArgs e)
        {
            //Turn Off Program & Windows System
        }
    }
}
