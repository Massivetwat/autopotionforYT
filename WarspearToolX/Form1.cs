using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Memory;
using WarspearToolX;


namespace WarspearToolX
{
    public partial class Form1 : Form
    {
        [DllImport("user32.dll")]
        public static extern IntPtr FindWindow(string lpClassName, string lpWindowName);

        [DllImport("user32.dll")]
        private static extern IntPtr GetForegroundWindow();

        [DllImport("user32.dll")]
        static extern short GetAsyncKeyState(Keys vKey);

        Mem m = new Mem();

        Random rand = new Random();

        public Form1()
        {
            InitializeComponent();
            CheckForIllegalCrossThreadCalls = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            

            int PID = m.GetProcIdFromName("warspear");
            if (PID > 0)
            {
                m.OpenProcess(PID);
                Thread h2 = new Thread(H2) { IsBackground = true };
                h2.Start();
                Thread h3 = new Thread(H3) { IsBackground = true };
                h3.Start();
                Thread h4 = new Thread(killswitch) { IsBackground = true };
                h4.Start();
                variables.startGold = m.ReadInt(variables.goldAddress);
                this.BackColor = Properties.Settings.Default.Setting;
                textBox1.Text = Properties.Settings.Default.addy;

            }

        }

        
        private void H3()
        {
            while (true)
            {
                
                variables.health = m.ReadInt(variables.healthAddress);
                variables.energy = m.ReadInt(variables.energyAddress);

                if (isGameActive() && checkBox2.Checked && variables.health > 700 && variables.energy > 99)
                {
                    variables.token = true;
                    Thread.Sleep(5000);
                    navigation.NAVIENEMY();
                    while (variables.token == true && isGameActive())
                    {
                        variables.id = m.ReadInt(variables.targetID);
                        if (variables.id == 14)
                        {
                            SendKeys.SendWait("2");
                            Thread.Sleep(rand.Next(150,200));
                            SendKeys.SendWait("{ENTER}");
                            Thread.Sleep(rand.Next(100, 150));
                            navigation.NAVIBACK();
                            
                            SendKeys.SendWait("{UP}");
                            Thread.Sleep(rand.Next(150, 200));
                            while (variables.token == true && isGameActive())
                            {
                                variables.id = m.ReadInt(textBox1.Text);
                                Properties.Settings.Default.addy = textBox1.Text;
                                Properties.Settings.Default.Save();
                                if (variables.id > 1 && variables.id < 900)
                                {
                                    navigation.fight();
                                }
                                else if (variables.id == 0)
                                {
                                    navigation.takeloot();
                                    variables.token = false;
                                }
                                Thread.Sleep(1);
                            }
                            Thread.Sleep(1);
                        }
                        Thread.Sleep(1);
                    }


                    Thread.Sleep(1);


                }
                Thread.Sleep(1);
            }
        }
        
        private void killswitch()
        {
           while (true)
            {
                if (GetAsyncKeyState(Keys.Escape)<0)
                {
                    variables.token = false;
                    Application.Exit();
                    
                }
                Thread.Sleep(100);
            }
        }
        
        
        private void H2()
        {
            while (true)
            {
                Thread.Sleep(250);
                try
                {
                    label2.Text = m.ReadInt(variables.goldAddress).ToString();

                    label5.Text = m.ReadInt(variables.healthAddress).ToString();

                    variables.f1 = variables.startGold;
                     variables.f2 = m.ReadInt(variables.goldAddress);
                     variables.result = variables.f2 - variables.f1;
                    label3.Text = variables.result.ToString();
                    label7.Text = m.ReadInt(variables.energyAddress).ToString();
                    Thread.Sleep(250);

                } catch
                {

                }
                Thread.Sleep(100);
            }
        }
            
        bool isGameActive()
        {
            variables.MWhandle = FindWindow(null, "Warspear Online");
            variables.CWhandle = GetForegroundWindow();
            return variables.MWhandle == variables.CWhandle ? true : false;
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ColorDialog cp = new ColorDialog();
            if (cp.ShowDialog() == DialogResult.OK)
            {
                this.BackColor = cp.Color;
                Properties.Settings.Default.Setting = this.BackColor;
                Properties.Settings.Default.Save();
            }
        }

        

        

        
    }
}
