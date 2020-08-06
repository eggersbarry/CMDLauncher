using System;
using System.IO;
//using System.Data;
//using System.Linq;
using System.Text;
//using System.Threading.Tasks;
using System.Windows.Forms;

namespace CmdLauncher
{
	public enum FILETYPES
	{
		CMD = 0,
		BAT = 1,
		PS = 2
	}
	public partial class MainForm1 : Form
	{
		private string[] _thesefiles = { "*.cmd", "*.bat", "*.ps" };
		private int _maxparams = 10;
		private string thistxtboxname = "tbparam";
		private int borderv;
		private int borderh;


		public MainForm1()
		{
			InitializeComponent();
		}

		#region system
		private void MainForm1_Load(object sender, EventArgs e)
		{
			borderv = this.Margin.Vertical;
			borderh = this.Margin.Horizontal;
			lb_filetypes.Items.Clear();
			foreach (string ft in _thesefiles)
			{
				lb_filetypes.Items.Add(ft);
			}
			lb_filetypes.SelectedIndex = 0;
		}

		private void MainForm1_Resize(object sender, EventArgs e)
		{
			int borderv = this.Margin.Vertical;
			int borderh = this.Margin.Horizontal;
			System.Windows.Forms.TextBox[] theseboxes;
			lbl_parameters.Top = lb_files.Top;
			lbl_parameters.Left = lb_files.Left + lb_files.Width + borderh;
			UD_parameters.Top = lb_files.Top + lbl_parameters.Height + borderv;

			UD_parameters.Left = lbl_parameters.Left;
			lb_filetypes.Left = UD_parameters.Left + UD_parameters.Width + borderh;
			lb_filetypes.Top = lbl_parameters.Top;
			theseboxes = GetParameters().ToArray();
			if (theseboxes != null)
			{
				foreach (System.Windows.Forms.TextBox tb in theseboxes)
				{
					tb.Left = UD_parameters.Left;
					tb.Width = (this.ClientRectangle.Width) - (lb_files.Left + lb_files.Width + borderh) - borderh;
				}
			}

		}
		private void lb_filetypes_SelectedIndexChanged(object sender, EventArgs e)
		{
			FillFileList(txtSrcFolder, lb_files);
		}
		private void txtbox_DragDrop(object sender, DragEventArgs ee)
		{
			StringBuilder sb = new StringBuilder();
			String[] files;
			System.Windows.Forms.TextBox tb = (System.Windows.Forms.TextBox)sender;


			files = (String[])ee.Data.GetData(DataFormats.FileDrop);
			foreach (string ss in files) // should be only one
			{
				if (ss.Length > 0)
				{
					sb.Append(ss);
					break;
				}
			}
			((TextBox)sender).Text = sb.ToString().Replace("\r\n", "");
		}

		private void txtbox_DragEnter(object sender, DragEventArgs ee)
		{
			if (ee.Data.GetDataPresent(DataFormats.FileDrop))
			{
				ee.Effect = DragDropEffects.Copy;
			}
			else
			{
				ee.Effect = DragDropEffects.None;
			}
		}

		private void txtbox_DragLeave(object sender, EventArgs e)
		{
			// something
		}

		private void txtbox_DragOver(object sender, DragEventArgs e)
		{
			//something
		}
		#endregion

		private void btnExit_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void txtSrcFolder_DoubleClick(object sender, EventArgs e)
		{
			if (SelectFolder(sender, e))
			{
				//FillFileList(txtSrcFolder, listView1);
				FillFileList(txtSrcFolder, lb_files);
			}
			else
			{
				lb_files.Items.Clear();
			}
		}

		private bool SelectFolder(object sender, EventArgs e)
		{
			bool retval = false;
			System.Windows.Forms.FolderBrowserDialog fbd = new System.Windows.Forms.FolderBrowserDialog();
			System.Windows.Forms.TextBox tb = (System.Windows.Forms.TextBox)sender;
			if (System.IO.Directory.Exists(tb.Text))
			{
				fbd.SelectedPath = tb.Text;
			}
			System.Windows.Forms.DialogResult dr = fbd.ShowDialog();
			if (dr == System.Windows.Forms.DialogResult.OK)
			{
				tb.Text = fbd.SelectedPath;
				retval = true;
			}
			else
			{
				tb.Text = "";
			}
			return retval;
		}

		private bool FillFileList(TextBox whichbox, ListBox view1)
		{
			DirectoryInfo di;
			bool retval = false;
			int ft = lb_filetypes.SelectedIndex;
			if (Directory.Exists(whichbox.Text))
			{
				di = new DirectoryInfo(whichbox.Text);
				FileInfo[] files = di.GetFiles(_thesefiles[ft]);
				view1.Items.Clear();
				foreach (FileInfo file in files)
				{
					view1.Items.Add(file.Name);
				}
				retval = true;
			}
			return retval;
		}
		private void txtSrcFolder_TextChanged(object sender, EventArgs e)
		{
			if (!FillFileList(txtSrcFolder, lb_files))
			{
				lb_files.Items.Clear();
			}
		}

		private System.Collections.Generic.List<System.Windows.Forms.TextBox> GetParameters()
		{
			System.Collections.Generic.List<System.Windows.Forms.TextBox> theseboxes = new System.Collections.Generic.List<System.Windows.Forms.TextBox>();
			string txtname;

			for (int ii = 0; ii < _maxparams; ii++)
			{
				txtname = thistxtboxname + ii.ToString();
				if (this.Controls.ContainsKey(txtname))
				{
					theseboxes.Add((System.Windows.Forms.TextBox)this.Controls[txtname]);
				}
			}
			return theseboxes;
		}

		private void UD_parameters_ValueChanged(object sender, EventArgs e)
		{
			System.Windows.Forms.TextBox tb;
			System.Collections.Generic.List<System.Windows.Forms.TextBox> theseboxes;
			int thisvalue = (int)UD_parameters.Value;
			System.Drawing.Rectangle rect;
			rect = UD_parameters.Bounds;
			rect.Y += (rect.Height + borderv);
			rect.Width = this.ClientRectangle.Width - rect.X - borderh;
			for (int ii = 0; ii < thisvalue; ii++)
			{
				tb = new System.Windows.Forms.TextBox();
				tb.Name = thistxtboxname + ii.ToString();
				//tb.Text = tb.Name;
				tb.Anchor = AnchorStyles.Right | AnchorStyles.Left | AnchorStyles.Top;
				tb.Bounds = rect;
				rect.Y += (rect.Height + borderv);
				if (!this.Controls.ContainsKey(tb.Name))
				{
					this.Controls.Add(tb);
				}
				else
				{
					tb.Dispose();
					tb = null;
				}
			}
			theseboxes = GetParameters();
			if (theseboxes != null)
			{
				for (int ii = 9; ii > thisvalue - 1; ii--)
				{
					foreach (System.Windows.Forms.TextBox tb1 in theseboxes)
					{
						if (tb1.Name.Equals(thistxtboxname + ii.ToString()))
						{
							this.Controls.Remove(tb1);
							tb1.Dispose();
							//tb1 = null;
							break;
						}
					}
				}

			}
		}

		private void btnLaunch_Click(object sender, EventArgs e)
		{
			string filename;
			string parameters = System.String.Empty;
			System.Collections.Generic.List<System.Windows.Forms.TextBox> theseboxes;
			System.Diagnostics.Process newproc;
			if (lb_files.SelectedIndex >= 0)
			{
				filename = (txtSrcFolder.Text.EndsWith("\\") ? txtSrcFolder.Text : txtSrcFolder.Text + "\\") + lb_files.SelectedItem.ToString();
				if (!System.String.IsNullOrEmpty(filename))
				{
					if (System.IO.File.Exists(filename))
					{
						theseboxes = GetParameters();
						foreach (System.Windows.Forms.TextBox tb in theseboxes)
						{
							//parameters += " \"" + tb.Text + "\"";
							parameters += " " + tb.Text;
						}
						newproc = new System.Diagnostics.Process();
						newproc.StartInfo.FileName = filename;
						newproc.StartInfo.Arguments = parameters;
						newproc.StartInfo.WorkingDirectory = txtStartFolder.Text;
						newproc.Start();
					}

				}
			}
		}

	}
}
