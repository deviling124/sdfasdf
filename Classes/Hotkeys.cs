using System;
using System.Windows.Forms;
namespace DZEThaitro.Classes
{
	public class Hotkey
	{
		public string Name
		{
			get;
			set;
		}

		public Keys Code
		{
			get;
			set;
		}

        public Hotkey(string _name, Keys _code)
		{
			this.Name = _name;
			this.Code = _code;
		}
	}
}
