using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WarspearToolX
{
    class variables
    {
        public static string healthAddress = "warspear.exe+0x005770F0,0,10,30,f4";
        public static string targetID = "warspear.exe+0x001E5EAC,42C";
        public static string goldAddress = "warspear.exe+0x005770F0,0,148,0,4,14";
        public static string energyAddress = "warspear.exe+0x005770F0,0,10,FC";

        public static int startGold;
        public static IntPtr MWhandle;
        public static IntPtr CWhandle;
        public static bool token = true;
        public static int id;
        public static int f1;
        public static int f2;
        public static int result;
        public static int health;
        public static int energy;

        public const UInt32 WM_KEYDOWN = 0x0100;
        public const int VK_E = 0x45;



    }
}
