using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Memory;


namespace WarspearToolX
{
    public partial class Form1 : Form
    {
        [DllImport("user32.dll", EntryPoint = "FindWindow")]
        private static extern int FindWindow(string sClass, string sWindow);

        [DllImport("user32.dll")]
        private static extern IntPtr GetForegroundWindow();

        Mem m = new Mem();

        string healthAddress = "warspear.exe+0x005770F0,0,10,30,f4";
        IntPtr MWhandle;
        IntPtr CWhandle;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            

            int PID = m.GetProcIdFromName("warspear");
            if (PID > 0)
            {
                m.OpenProcess(PID);
                Thread h1 = new Thread(H1) { IsBackground = true };
                h1.Start();
            }

        }
            
        bool isGameActive()
        {
            MWhandle = (IntPtr)FindWindow(null, "Warspear Online");
            CWhandle = GetForegroundWindow();
            return MWhandle == CWhandle ? true : false;
            
        }

        private void H1()
        {
            while (true)
            {
                if (checkBox1.Checked && isGameActive())
                {

                    int health = m.ReadInt(healthAddress);
                    if (health < 361)// max * 0.4 = 361  give or take
                    {
                        SendKeys.SendWait("w"); // our hotkey 
                        Thread.Sleep(1000);
                        
                    }
                    Thread.Sleep(100);
                }
                Thread.Sleep(10);
            }
        }
    }
}
