using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CmdLauncher
{
	public partial class OptionsForm1 : Form
	{
		private string _options;
		public OptionsForm1()
		{
			InitializeComponent();
			this.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			_options = System.String.Empty;
		}

		private void btn_exit_Click(object sender, EventArgs e)
		{
			_options = GetOptions();
			this.DialogResult = System.Windows.Forms.DialogResult.OK;
			this.Close();
		}
		private string GetOptions()
		{
			string retval = System.String.Empty;
			System.Windows.Forms.CheckBox cb;
			foreach (System.Windows.Forms.Control cc in panel1.Controls)
			{
				cb = (System.Windows.Forms.CheckBox)cc;
				if (cb.Checked)
				{
					retval += " " + cb.Text.Substring(0, cb.Text.IndexOf(" "));
				}
			}
			return retval;
		}
		public string Options
		{
			set { _options = value; }
			get { return _options; }
		}

		private void cb_option1_CheckedChanged(object sender, EventArgs e)
		{
			if(cb_option1.Checked)
			{
				cb_option2.Checked = false;
			}
		}

		private void cb_option2_CheckedChanged(object sender, EventArgs e)
		{
			if (cb_option2.Checked)
			{
				cb_option1.Checked = false;
			}
		}

		private void cb_option5_CheckedChanged(object sender, EventArgs e)
		{
			if (cb_option5.Checked)
			{
				cb_option6.Checked = false;
			}
		}

		private void cb_option6_CheckedChanged(object sender, EventArgs e)
		{
			if (cb_option6.Checked)
			{
				cb_option5.Checked = false;
			}
		}

		private void cb_option7_CheckedChanged(object sender, EventArgs e)
		{
			if (cb_option7.Checked)
			{
				cb_option8.Checked = false;
			}
		}

		private void cb_option8_CheckedChanged(object sender, EventArgs e)
		{
			if (cb_option8.Checked)
			{
				cb_option7.Checked = false;
			}
		}

		private void cb_option9_CheckedChanged(object sender, EventArgs e)
		{
			if (cb_option9.Checked)
			{
				cb_option10.Checked = false;
			}
		}

		private void cb_option10_CheckedChanged(object sender, EventArgs e)
		{
			if (cb_option10.Checked)
			{
				cb_option9.Checked = false;
			}
		}
	}
}
