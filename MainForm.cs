using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Net;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using System.Windows.Input;
using System.Management;
using System.Linq;
using DZEThaitro.Classes;
using DZEThaitro.Properties;
using Hotkeys;


namespace DZEThaitro
{
    public partial class MainForm : Form
    {
        

        protected override void WndProc(ref Message m)
        {
            bool flag = m.Msg == 786 && !this.started;
            if (flag)
            {
                this.Starting();
            }
            else
            {
                bool flag2 = m.Msg == 786 && this.started;
                if (flag2)
                {
                    this.Stopped();
                }
            }
            base.WndProc(ref m);
        }

        public MainForm()
        {
            this.InitializeComponent();
            this.SeedHotkeys();
        }
		[DllImport("kernel32.dll")]
		private static extern IntPtr OpenProcess(uint dwDesiredAccess, bool bInheritHandle, int dwProcessId);

		
		[DllImport("kernel32.dll")]
		private static extern bool VirtualProtectEx(IntPtr hProcess, IntPtr lpAddress, UIntPtr dwSize, uint flNewProtect, out uint lpflOldProtect);

	
		[DllImport("KERNEL32", CharSet = CharSet.Ansi, EntryPoint = "ReadProcessMemory", ExactSpelling = true, SetLastError = true)]
		public static extern int ReadMemoryInteger(int Handle, int Address, ref int Value, int Size, ref int BytesRead);

		
		[DllImport("kernel32", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
		private static extern int ReadProcessMemory(int int_0, int int_1, ref int int_2, int int_3, ref int int_4);

		[DllImport("kernel32.dll", SetLastError = true)]
		private static extern bool ReadProcessMemory(IntPtr hProcess, IntPtr lpBaseAddress, byte[] lpBuffer, uint dwSize, uint lpNumberOfBytesRead);

		
		[DllImport("kernel32", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
		private static extern int WriteProcessMemory(int int_0, int int_1, ref int int_2, int int_3, ref int int_4);

		
		[DllImport("kernel32.dll")]
		private static extern bool WriteProcessMemory(IntPtr hProcess, IntPtr lpBaseAddress, byte[] lpBuffer, uint nSize, uint lpNumberOfBytesWritten);

	    [DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);

		public static void ReadMemoryPointer(string ProcessName, int Pointer, ref int Value, params int[] OFFSet)
		{
			checked
			{
				try
				{
					bool flag = Process.GetProcessesByName(ProcessName).Length != 0;
					bool flag2 = flag;
					if (flag2)
					{
						int handle = (int)Process.GetProcessesByName(ProcessName)[0].Handle;
						int num2;
						for (int i = 0; i < OFFSet.Length; i++)
						{
							int num = OFFSet[i];
							num2 = 0;
							ReadMemoryInteger(handle, Pointer, ref Pointer, 4, ref num2);
							Pointer += num;
						}
						num2 = 0;
						ReadMemoryInteger(handle, Pointer, ref Value, 4, ref num2);
					}
				}
				catch
				{
				}
			}
		}
		public static void AndenGepard(string string_0, int int_0, int int_1,  int[] Offset)
		{
			checked
			{
				try
				{
					bool flag = Process.GetProcessesByName(string_0).Length != 0;
					if (flag)
					{
						int num = (int)Process.GetProcessesByName(string_0)[0].Handle;
						bool flag2 = num != 0;
						if (flag2)
						{
							int num2 = 0;
							for (int i = 0; i < Offset.Length; i++)
							{
								int num3 = Offset[i];
								int int_2 = num;
								int int_3 = int_0;
								int int_4 = 4;
								num2 = 0;
								ReadProcessMemory(int_2, int_3, ref int_0, int_4, ref num2);
								int_0 += num3;
							}
							int int_5 = num;
							int int_6 = int_0;
							int int_7 = 4;
							num2 = 0;
							WriteProcessMemory(int_5, int_6, ref int_1, int_7, ref num2);
						}
					}
				}
				catch
				{
				}
			}
		}

		
		public MainForm(int current_id)
		{
			this.processHandle = OpenProcess(2035711u, false, current_id);
		}

        public byte[] ReadByteArray(IntPtr pOffset, uint pSize)
        {
            byte[] result;
            try
            {
                uint flNewProtect;
                VirtualProtectEx(this.processHandle, pOffset, (UIntPtr)pSize, 4u, out flNewProtect);
                byte[] array = new byte[pSize];
                ReadProcessMemory(this.processHandle, pOffset, array, pSize, 0u);
                VirtualProtectEx(this.processHandle, pOffset, (UIntPtr)pSize, flNewProtect, out flNewProtect);
                result = array;
            }
            catch
            {
                result = new byte[1];
            }
            return result;
        }
		public bool WriteByteArray(IntPtr pOffset, byte[] pBytes)
		{
			bool result;
			try
			{
				uint flNewProtect;
				VirtualProtectEx(this.processHandle, pOffset, (UIntPtr)((ulong)((long)pBytes.Length)), 4u, out flNewProtect);
				bool flag =WriteProcessMemory(this.processHandle, pOffset, pBytes, (uint)pBytes.Length, 0u);
				VirtualProtectEx(this.processHandle, pOffset, (UIntPtr)((ulong)((long)pBytes.Length)), flNewProtect, out flNewProtect);
				result = flag;
			}
			catch
			{
				result = false;
			}
			return result;
		}

		public int ReadInt32(IntPtr pOffset)
		{
			int result;
			try
			{
				result = BitConverter.ToInt32(this.ReadByteArray(pOffset, 4u), 0);
			}
			catch
			{
				result = 0;
			}
			return result;
		}

		
		public float ReadFloat(IntPtr pOffset)
		{
			float result;
			try
			{
				result = BitConverter.ToSingle(this.ReadByteArray(pOffset, 4u), 0);
			}
			catch
			{
				result = 0f;
			}
			return result;
		}

		
		public bool WriteInt32(IntPtr pOffset, int pData)
		{
			bool result;
			try
			{
				result = this.WriteByteArray(pOffset, BitConverter.GetBytes(pData));
			}
			catch
			{
				result = false;
			}
			return result;
		}

		public bool WriteFloat(IntPtr pOffset, float pData)
		{
			bool result;
			try
			{
				result = this.WriteByteArray(pOffset, BitConverter.GetBytes(pData));
			}
			catch
			{
				result = false;
			}
			return result;
		}

		public int ReadMemoryPointerInt(long lpBaseAddress, int[] offsets)
		{
			for (int i = 0; i < offsets.Length; i++)
			{
				int num = offsets[i];
				lpBaseAddress = (long)this.ReadInt32((IntPtr)lpBaseAddress);
				lpBaseAddress += (long)num;
			}
			return this.ReadInt32((IntPtr)lpBaseAddress);
		}
		public float ReadMemoryPointerFloat(long lpBaseAddress, int[] offsets)
		{
			for (int i = 0; i < offsets.Length; i++)
			{
				int num = offsets[i];
				lpBaseAddress = (long)this.ReadInt32((IntPtr)lpBaseAddress);
				lpBaseAddress += (long)num;
			}
			return this.ReadFloat((IntPtr)lpBaseAddress);
		}
		public bool WriteMemoryPointerInt(long lpBaseAddress, int[] offsets, int value)
		{
			for (int i = 0; i < offsets.Length; i++)
			{
				int num = offsets[i];
				lpBaseAddress = (long)this.ReadInt32((IntPtr)lpBaseAddress);
				lpBaseAddress += (long)num;
			}
			return this.WriteInt32((IntPtr)lpBaseAddress, value);
		}
		public bool WriteMemoryPointerFloat(long lpBaseAddress, int[] offsets, float value)
		{
			for (int i = 0; i < offsets.Length; i++)
			{
				int num = offsets[i];
				lpBaseAddress = (long)this.ReadInt32((IntPtr)lpBaseAddress);
				lpBaseAddress += (long)num;
			}
			return this.WriteFloat((IntPtr)lpBaseAddress, value);
		}
		private IntPtr processHandle;
        private void SeedHotkeys()
        {
            this.GLOBAL_HOTKEY = new GlobalHotkey(0, Keys.Tab, this);
            this.GLOBAL_HOTKEY.Register();
            List<Hotkey> dataSource = new List<Hotkey>
			{
				new Hotkey("--", Keys.None),
				new Hotkey("F1", Keys.F1),
				new Hotkey("F2", Keys.F2),
				new Hotkey("F3", Keys.F3),
				new Hotkey("F4", Keys.F4),
				new Hotkey("F5", Keys.F5),
				new Hotkey("F6", Keys.F6),
				new Hotkey("F7", Keys.F7),
				new Hotkey("F8", Keys.F8),
				new Hotkey("F9", Keys.F9),
				new Hotkey("A", Keys.A),
				new Hotkey("B", Keys.B),
				new Hotkey("C", Keys.C),
				new Hotkey("D", Keys.D),
				new Hotkey("E", Keys.E),
				new Hotkey("F", Keys.F),
				new Hotkey("G", Keys.G),
				new Hotkey("H", Keys.H),
				new Hotkey("I", Keys.I),
				new Hotkey("J", Keys.J),
				new Hotkey("K", Keys.K),
				new Hotkey("L", Keys.L),
				new Hotkey("M", Keys.M),
				new Hotkey("N", Keys.N),
				new Hotkey("O", Keys.O),
				new Hotkey("P", Keys.P),
				new Hotkey("Q", Keys.Q),
				new Hotkey("R", Keys.R),
				new Hotkey("S", Keys.S),
				new Hotkey("T", Keys.T),
				new Hotkey("U", Keys.U),
				new Hotkey("V", Keys.V),
				new Hotkey("W", Keys.W),
				new Hotkey("X", Keys.X),
				new Hotkey("Y", Keys.Y),
				new Hotkey("Z", Keys.Z)
			};
            this.SpamSKILL1ComboBox.DisplayMember = "Name";
            this.SpamSKILL1ComboBox.ValueMember = "Code";
            this.SpamSKILL1ComboBox.DataSource = dataSource;
        }
        private static void Sleep(int millisecond)
        {
            Thread.Sleep(millisecond);
        }
        public void readProcess()
        {
            Process[] processesByName = Process.GetProcessesByName(this.processname);
            Process[] array = processesByName;
            checked
            {
                for (int i = 0; i < array.Length; i++)
                {
                    Process process = array[i];
                    this.hWnd = process.MainWindowHandle;

                }
                IntPtr intptr_ = this.hWnd;
                string text = "GepardBypass";
                WindowsAPI.SetWindowText(intptr_, ref text);
            }
        }

        private void Starting()
        {
            this.started = true;
            this.AutopotTimer.Enabled = true;
            this.IAutopotTimer.Enabled = true;
            this.MacroSKILLTimer.Enabled = true;
            this.StatusValueLabel.Text = "Connected";
            this.StatusValueLabel.ForeColor = Color.DarkGreen;
        }
        private void Stopped()
        {
            this.started = false;
            this.AutopotTimer.Enabled = false;
            this.IAutopotTimer.Enabled = false;
            this.MacroSKILLTimer.Enabled = false;
            this.StatusValueLabel.Text = "Disconnected";
            this.StatusValueLabel.ForeColor = Color.FromArgb(192, 0, 0);
        }
        private void AutopotCheckedChanged(object sender, EventArgs e)
        {
            CheckBox checkBox = sender as CheckBox;
            bool @checked = checkBox.Checked;
            if (@checked)
            {
                string name = checkBox.Name;
                if (!(name == "HPCheckBox"))
                {
                    if (!(name == "SPCheckBox"))
                    {
                        if (name == "StatusPlayerCheckBox")
                        {
                            this.spt = true;
                        }
                    }
                    else
                    {
                        this.sp = true;
                    }
                }
                else
                {
                    this.hp = true;
                }
            }
            else
            {
                string name2 = checkBox.Name;
                if (!(name2 == "HPCheckBox"))
                {
                    if (!(name2 == "SPCheckBox"))
                    {
                        if (name2 == "StatusPlayerCheckBox")
                        {
                            this.spt = false;
                        }
                    }
                    else
                    {
                        this.sp = false;
                    }
                }
                else
                {
                    this.hp = false;
                }
            }
        }

        private void HPHotkeyComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            int num;
            int.TryParse(this.HPHotkeyComboBox.SelectedValue.ToString(), out num);
            this.hp_keycode = num;
            this.hpindex = this.HPHotkeyComboBox.SelectedIndex;
        }
        private void SPHotkeyComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            int num;
            int.TryParse(this.SPHotkeyComboBox.SelectedValue.ToString(), out num);
            this.sp_keycode = num;
            this.spindex = this.SPHotkeyComboBox.SelectedIndex;
        }
        private void PercenValueChanged(object sender, EventArgs e)
        {
            NumericUpDown numericUpDown = sender as NumericUpDown;
            string name = numericUpDown.Name;
            if (!(name == "PerHPNumeric"))
            {
                if (name == "PerSPNumeric")
                {
                    this._persp = (int)numericUpDown.Value;
                }
            }
            else
            {
                this._perhp = (int)numericUpDown.Value;
            }
        }
        private void StatusPlayerHotkeyComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void AutopotTimer_Tick(object sender, EventArgs e)
        {
            bool flag = this.hp;
            if (flag)
            {
                bool flag2 = this.perhp <= double.Parse(this.PerHPNumeric.Value.ToString());
                if (flag2)
                {

                }
            }
            bool flag3 = this.sp;
            if (flag3)
            {
                bool flag4 = this.persp <= double.Parse(this.PerSPNumeric.Value.ToString());
                if (flag4)
                {

                }
            }
            bool flag5 = this.spt;
            if (flag5)
            {
                bool flag6 = this.sptvalue != 0;
                if (flag6)
                {
                    //		this.dze.key(this.spt_keycode, 1);
                    //		this.dze.key(this.spt_keycode, 2);
                }
            }
        }
        private void IAutopotTimer_Tick(object sender, EventArgs e)
        {
            //int HP = readInt("0x00E1392C","");
            int MaxHP = ReadInt32((IntPtr)0x00E13930);
            int SP = ReadInt32((IntPtr)0x00E13934);
            int MaxSP = ReadInt32((IntPtr)0x00E13938);
            this.sptvalue = ReadInt32((IntPtr)14831084);
           // this.HPStatsLabel.Text = string.Format("{0} / {1}", HP, MaxHP);
            this.SPStatsLabel.Text = string.Format("{0} / {1}", SP, MaxSP);
            bool flag = this.sptvalue == 0;
            if (flag)
            {
                this.StatusPlayerValueLabel.Text = "Nothing";
            }
            else
            {
                bool flag2 = this.sptvalue == 1;
                if (flag2)
                {
                    this.StatusPlayerValueLabel.Text = "Poison";
                }
                else
                {
                    bool flag3 = this.sptvalue == 2;
                    if (flag3)
                    {
                        this.StatusPlayerValueLabel.Text = "Curse";
                    }
                    else
                    {
                        bool flag4 = this.sptvalue == 4;
                        if (flag4)
                        {
                            this.StatusPlayerValueLabel.Text = "Silence";
                        }
                        else
                        {
                            bool flag5 = this.sptvalue == 16;
                            if (flag5)
                            {
                                this.StatusPlayerValueLabel.Text = "Blind";
                            }
                            else
                            {
                                bool flag6 = this.sptvalue == 64;
                                if (flag6)
                                {
                                    this.StatusPlayerValueLabel.Text = "Bleeding";
                                }
                            }
                        }
                    }
                }
            }
         //   this.perhp = (double)HP / (double)MaxHP * 100.0;
            this.persp = (double)SP / (double)MaxSP * 100.0;
            //this.HPStatsProgressBar.Value = (int)this.perhp;
            //	this.SPStatsProgressBar.Value = (int)this.persp;
        }



        public static int BASE_ADDRESS = 0xB8DEDC;

      
        private void MacroSKILLTimer_Tick(object sender, EventArgs e)
        {
            int mouse_x = ReadInt32((IntPtr)0x00C6FA30);
            int mouse_y = ReadInt32((IntPtr)0x00C6FA2C);
            int skill_ID = ReadMemoryPointerInt(BASE_ADDRESS, new int[] { 0x3F0 });
            int skilltypes = ReadMemoryPointerInt(BASE_ADDRESS, new int[] { 0x3EC });
            int skill_Lvl = ReadMemoryPointerInt(BASE_ADDRESS, new int[] { 0x3F8 });
            int aid_mouse = ReadMemoryPointerInt(BASE_ADDRESS, new int[] { 0x2EC });


            if (GetAsyncKeyState(HotkeyTypes.Hotkey1) && Setting.IsMacro1)
            {
                if (skilltypes == 1)
                {

                   WriteMemoryPointerInt(BASE_ADDRESS, new int[] { 0xCC, 0x2C, 0x4BC }, skill_ID);  //4
                    WriteMemoryPointerInt(BASE_ADDRESS, new int[] { 0xCC, 0x2C, 0x4C0 }, skill_Lvl); //4
                    WriteMemoryPointerInt(BASE_ADDRESS, new int[] { 0xCC, 0x2C, 0x4C4 }, mouse_x);  //4
                   WriteMemoryPointerInt(BASE_ADDRESS, new int[] { 0xCC, 0x2C, 0x4C8 }, mouse_y); //38
                    WriteMemoryPointerInt(BASE_ADDRESS, new int[] { 0xCC, 0x2C, 0x490 }, 4);
                }
                else if (skilltypes == 0)
                {
                    WriteMemoryPointerInt(BASE_ADDRESS, new int[] { 0xCC, 0x2C, 0x4BC }, skill_ID); // 4
                    WriteMemoryPointerInt(BASE_ADDRESS, new int[] { 0xCC, 0x2C, 0x4C0 }, skill_Lvl); // 18
                    WriteMemoryPointerInt(BASE_ADDRESS, new int[] { 0xCC, 0x2C, 0x4A8 }, 123123); // 18
                    WriteMemoryPointerInt(BASE_ADDRESS, new int[] { 0xCC, 0x2C, 0x490 }, 3);
                }
                Thread.Sleep(300);
                return;
            }
            if(GetAsyncKeyState(Keys.LButton))
            {
                WriteMemoryPointerInt(BASE_ADDRESS, new int[] { 0xCC, 0x2C, 0x4BC }, 0); // 18
                WriteMemoryPointerInt(BASE_ADDRESS, new int[] { 0xCC, 0x2C, 0x4C0 }, 0); // 18
                WriteMemoryPointerInt(BASE_ADDRESS, new int[] { 0xCC, 0x2C, 0x4A8 }, 0);
            }
        }
          
        private void MainForm_Load(object sender, EventArgs e)
        {

        }
        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {

        }

        private GlobalHotkey GLOBAL_HOTKEY;


        private bool status;

        private bool started;


        private readonly string processname = "iPlayRO";

        private IntPtr hWnd;


        private bool hp;

        private bool sp;


        private bool spt;

        private int _perhp;


        private int _persp;


        private double perhp;


        private double persp;


        private int hp_keycode;


        private int sp_keycode;


        private int spt_keycode;


        private int hpindex;


        private int spindex;


        private int sptindex;


        private int sptvalue;



        private int mc1index;


        private int mc2index;


        private int ground = 1;

        private int enemy;

        [DllImport("User32.dll")]
        public static extern bool GetAsyncKeyState(Keys vKey);


        private void AutopotTab_Click(object sender, EventArgs e)
        {

        }

        private void FunctionsTab_Click(object sender, EventArgs e)
        {

        }

        private void statusStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            MacroSKILLTimer.Enabled = true;
            IAutopotTimer.Enabled = true;
            Starting();
            readProcess();
        }

        private void SpamSKILL1ComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            HotkeyTypes.Hotkey1 = (Keys)this.SpamSKILL1ComboBox.SelectedValue;
            Setting.IsMacro1Hotkey = (Keys)this.SpamSKILL1ComboBox.SelectedValue;
        }

        private void SpamSKILL1CheckBox_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox checkBox = sender as CheckBox;
            CheckState checkState = checkBox.CheckState;
            if (checkState != CheckState.Unchecked)
            {
                if (checkState == CheckState.Checked)
                {
                    this.SpamSKILL1ComboBox.Enabled = checkBox.Checked;
                    
                }
            }
            else
            {
                this.SpamSKILL1ComboBox.Enabled = checkBox.Checked;
               
            }
            Setting.IsMacro1 = checkBox.Checked;
        }
        const int PROCESS_WM_READ = 0x0010;

        [DllImport("kernel32.dll")]
        public static extern IntPtr OpenProcess(int dwDesiredAccess, bool bInheritHandle, int dwProcessId);

        [DllImport("kernel32.dll")]
        public static extern bool ReadProcessMemory(int hProcess,
        Int64 lpBaseAddress, byte[] lpBuffer, int dwSize, ref int lpNumberOfBytesRead);

        private void button2_Click(object sender, EventArgs e)
        {

 
        }
    }
}