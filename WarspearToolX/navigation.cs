using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WarspearToolX
{
    class navigation
    {
        static Random rand = new Random();
        public static void fight()
        {
            SendKeys.SendWait("{ENTER}");
            Thread.Sleep(rand.Next(100, 150));
            SendKeys.SendWait("{1}");
            Thread.Sleep(rand.Next(100, 150));
            SendKeys.SendWait("{3}");
            Thread.Sleep(rand.Next(100, 150));
        }
        public static void NAVINEW()
        {
            SendKeys.SendWait("{DOWN}");
            Thread.Sleep(rand.Next(150, 200));
            SendKeys.SendWait("{DOWN}");
            Thread.Sleep(rand.Next(150, 200));
            SendKeys.SendWait("{DOWN}");
            Thread.Sleep(rand.Next(150, 200));
            SendKeys.SendWait("{DOWN}");
            Thread.Sleep(rand.Next(150, 200));
            SendKeys.SendWait("{DOWN}");
            Thread.Sleep(rand.Next(150, 200));
            SendKeys.SendWait("{DOWN}");
            Thread.Sleep(rand.Next(150, 200));
        }
        public static void NAVIBACKNEW()
        {
            SendKeys.SendWait("{UP}");
            Thread.Sleep(rand.Next(150, 200));
            SendKeys.SendWait("{UP}");
            Thread.Sleep(rand.Next(150, 200));
            SendKeys.SendWait("{UP}");
            Thread.Sleep(rand.Next(150, 200));
            SendKeys.SendWait("{UP}");
            Thread.Sleep(rand.Next(150, 200));
            SendKeys.SendWait("{UP}");
            Thread.Sleep(rand.Next(150, 200));
            SendKeys.SendWait("{UP}");
            Thread.Sleep(rand.Next(2000, 2500));
            SendKeys.SendWait("{ENTER}");
            Thread.Sleep(rand.Next(2000, 2500));

        }






        public static void takeloot()
        {
            Thread.Sleep(rand.Next(3000, 4500));
            SendKeys.SendWait("{ENTER}");
            Thread.Sleep(rand.Next(400, 500));
            SendKeys.SendWait("{ENTER}");
            Thread.Sleep(rand.Next(400, 500));
            SendKeys.SendWait("{ENTER}");
            Thread.Sleep(rand.Next(400, 500));
            SendKeys.SendWait("{ENTER}");
            Thread.Sleep(rand.Next(400, 500));
            SendKeys.SendWait("{DOWN}");
            Thread.Sleep(rand.Next(400, 500));
            SendKeys.SendWait("{ENTER}");
            Thread.Sleep(rand.Next(400, 500));
            SendKeys.SendWait("{ENTER}");
            Thread.Sleep(rand.Next(400, 500));
        }
        public static void NAVIBACK()
        {
            Thread.Sleep(rand.Next(150, 200));
            SendKeys.SendWait("{DOWN}");
            Thread.Sleep(rand.Next(150, 200));
            SendKeys.SendWait("{LEFT}");
            Thread.Sleep(rand.Next(150, 200));
            SendKeys.SendWait("{LEFT}");
            Thread.Sleep(rand.Next(150, 200));
            SendKeys.SendWait("{LEFT}");
            Thread.Sleep(rand.Next(150, 200));
            SendKeys.SendWait("{LEFT}");
            Thread.Sleep(rand.Next(150, 200));
            SendKeys.SendWait("{LEFT}");
            Thread.Sleep(rand.Next(150, 200));
            SendKeys.SendWait("{DOWN}");
            Thread.Sleep(rand.Next(2000, 2599));
            SendKeys.SendWait("{ENTER}");
            Thread.Sleep(rand.Next(150, 200));
        }

        public static void NAVIENEMY()
        {
            Thread.Sleep(rand.Next(150, 200));
            SendKeys.SendWait("{UP}");
            Thread.Sleep(rand.Next(150, 200));
            SendKeys.SendWait("{RIGHT}");
            Thread.Sleep(rand.Next(150, 200));
            SendKeys.SendWait("{RIGHT}");
            Thread.Sleep(rand.Next(150, 200));
            SendKeys.SendWait("{RIGHT}");
            Thread.Sleep(rand.Next(150, 200));
            SendKeys.SendWait("{RIGHT}");
            Thread.Sleep(rand.Next(150, 200));
            SendKeys.SendWait("{RIGHT}");
            Thread.Sleep(rand.Next(150, 200));
            SendKeys.SendWait("{UP}");

        }

    }
}
