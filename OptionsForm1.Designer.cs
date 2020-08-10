namespace CmdLauncher
{
	partial class OptionsForm1
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.btn_exit = new System.Windows.Forms.Button();
			this.panel1 = new System.Windows.Forms.Panel();
			this.cb_option11 = new System.Windows.Forms.CheckBox();
			this.cb_option10 = new System.Windows.Forms.CheckBox();
			this.cb_option9 = new System.Windows.Forms.CheckBox();
			this.cb_option8 = new System.Windows.Forms.CheckBox();
			this.cb_option7 = new System.Windows.Forms.CheckBox();
			this.cb_option6 = new System.Windows.Forms.CheckBox();
			this.cb_option5 = new System.Windows.Forms.CheckBox();
			this.cb_option4 = new System.Windows.Forms.CheckBox();
			this.cb_option3 = new System.Windows.Forms.CheckBox();
			this.cb_option2 = new System.Windows.Forms.CheckBox();
			this.cb_option1 = new System.Windows.Forms.CheckBox();
			this.label1 = new System.Windows.Forms.Label();
			this.btn_cancel = new System.Windows.Forms.Button();
			this.panel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// btn_exit
			// 
			this.btn_exit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btn_exit.Location = new System.Drawing.Point(430, 373);
			this.btn_exit.Name = "btn_exit";
			this.btn_exit.Size = new System.Drawing.Size(153, 23);
			this.btn_exit.TabIndex = 3;
			this.btn_exit.Text = "Continue (OK)";
			this.btn_exit.UseVisualStyleBackColor = true;
			this.btn_exit.Click += new System.EventHandler(this.btn_exit_Click);
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.cb_option11);
			this.panel1.Controls.Add(this.cb_option10);
			this.panel1.Controls.Add(this.cb_option9);
			this.panel1.Controls.Add(this.cb_option8);
			this.panel1.Controls.Add(this.cb_option7);
			this.panel1.Controls.Add(this.cb_option6);
			this.panel1.Controls.Add(this.cb_option5);
			this.panel1.Controls.Add(this.cb_option4);
			this.panel1.Controls.Add(this.cb_option3);
			this.panel1.Controls.Add(this.cb_option2);
			this.panel1.Controls.Add(this.cb_option1);
			this.panel1.Location = new System.Drawing.Point(26, 25);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(557, 304);
			this.panel1.TabIndex = 1;
			// 
			// cb_option11
			// 
			this.cb_option11.AutoSize = true;
			this.cb_option11.Location = new System.Drawing.Point(17, 271);
			this.cb_option11.Name = "cb_option11";
			this.cb_option11.Size = new System.Drawing.Size(169, 20);
			this.cb_option11.TabIndex = 11;
			this.cb_option11.Text = "/Q      Turns echo off";
			this.cb_option11.UseVisualStyleBackColor = true;
			// 
			// cb_option10
			// 
			this.cb_option10.AutoSize = true;
			this.cb_option10.Location = new System.Drawing.Point(17, 245);
			this.cb_option10.Name = "cb_option10";
			this.cb_option10.Size = new System.Drawing.Size(490, 20);
			this.cb_option10.TabIndex = 10;
			this.cb_option10.Text = "/V:OFF   Disable delayed environment variable expansion. (see below)";
			this.cb_option10.UseVisualStyleBackColor = true;
			this.cb_option10.CheckedChanged += new System.EventHandler(this.cb_option10_CheckedChanged);
			// 
			// cb_option9
			// 
			this.cb_option9.AutoSize = true;
			this.cb_option9.Location = new System.Drawing.Point(17, 219);
			this.cb_option9.Name = "cb_option9";
			this.cb_option9.Size = new System.Drawing.Size(480, 20);
			this.cb_option9.TabIndex = 9;
			this.cb_option9.Text = "/V:ON   Enable delayed environment variable expansion. (see below)";
			this.cb_option9.UseVisualStyleBackColor = true;
			this.cb_option9.CheckedChanged += new System.EventHandler(this.cb_option9_CheckedChanged);
			// 
			// cb_option8
			// 
			this.cb_option8.AutoSize = true;
			this.cb_option8.Location = new System.Drawing.Point(17, 193);
			this.cb_option8.Name = "cb_option8";
			this.cb_option8.Size = new System.Drawing.Size(521, 20);
			this.cb_option8.TabIndex = 8;
			this.cb_option8.Text = "/F:OFF  Disable file and directory name completion characters (see below)";
			this.cb_option8.UseVisualStyleBackColor = true;
			this.cb_option8.CheckedChanged += new System.EventHandler(this.cb_option8_CheckedChanged);
			// 
			// cb_option7
			// 
			this.cb_option7.AutoSize = true;
			this.cb_option7.Location = new System.Drawing.Point(17, 167);
			this.cb_option7.Name = "cb_option7";
			this.cb_option7.Size = new System.Drawing.Size(516, 20);
			this.cb_option7.TabIndex = 7;
			this.cb_option7.Text = "/F:ON   Enable file and directory name completion characters (see below)";
			this.cb_option7.UseVisualStyleBackColor = true;
			this.cb_option7.CheckedChanged += new System.EventHandler(this.cb_option7_CheckedChanged);
			// 
			// cb_option6
			// 
			this.cb_option6.AutoSize = true;
			this.cb_option6.Location = new System.Drawing.Point(17, 141);
			this.cb_option6.Name = "cb_option6";
			this.cb_option6.Size = new System.Drawing.Size(354, 20);
			this.cb_option6.TabIndex = 6;
			this.cb_option6.Text = "/E:OFF  Disable command extensions (see below)";
			this.cb_option6.UseVisualStyleBackColor = true;
			this.cb_option6.CheckedChanged += new System.EventHandler(this.cb_option6_CheckedChanged);
			// 
			// cb_option5
			// 
			this.cb_option5.AutoSize = true;
			this.cb_option5.Location = new System.Drawing.Point(17, 115);
			this.cb_option5.Name = "cb_option5";
			this.cb_option5.Size = new System.Drawing.Size(349, 20);
			this.cb_option5.TabIndex = 5;
			this.cb_option5.Text = "/E:ON   Enable command extensions (see below)";
			this.cb_option5.UseVisualStyleBackColor = true;
			this.cb_option5.CheckedChanged += new System.EventHandler(this.cb_option5_CheckedChanged);
			// 
			// cb_option4
			// 
			this.cb_option4.AutoSize = true;
			this.cb_option4.Location = new System.Drawing.Point(17, 89);
			this.cb_option4.Name = "cb_option4";
			this.cb_option4.Size = new System.Drawing.Size(511, 20);
			this.cb_option4.TabIndex = 4;
			this.cb_option4.Text = "/D      Disable execution of AutoRun commands from registry (see below)";
			this.cb_option4.UseVisualStyleBackColor = true;
			// 
			// cb_option3
			// 
			this.cb_option3.AutoSize = true;
			this.cb_option3.Location = new System.Drawing.Point(17, 63);
			this.cb_option3.Name = "cb_option3";
			this.cb_option3.Size = new System.Drawing.Size(448, 20);
			this.cb_option3.TabIndex = 3;
			this.cb_option3.Text = "/S    Strip \" quote characters from inside command (see below)";
			this.cb_option3.UseVisualStyleBackColor = true;
			// 
			// cb_option2
			// 
			this.cb_option2.AutoSize = true;
			this.cb_option2.Location = new System.Drawing.Point(17, 37);
			this.cb_option2.Name = "cb_option2";
			this.cb_option2.Size = new System.Drawing.Size(445, 20);
			this.cb_option2.TabIndex = 2;
			this.cb_option2.Text = "/K      Carries out the command specified by string but remains";
			this.cb_option2.UseVisualStyleBackColor = true;
			this.cb_option2.CheckedChanged += new System.EventHandler(this.cb_option2_CheckedChanged);
			// 
			// cb_option1
			// 
			this.cb_option1.AutoSize = true;
			this.cb_option1.Checked = true;
			this.cb_option1.CheckState = System.Windows.Forms.CheckState.Checked;
			this.cb_option1.Location = new System.Drawing.Point(17, 11);
			this.cb_option1.Name = "cb_option1";
			this.cb_option1.Size = new System.Drawing.Size(503, 20);
			this.cb_option1.TabIndex = 1;
			this.cb_option1.Text = "/C      Carries out the command specified by string and then terminates";
			this.cb_option1.UseVisualStyleBackColor = true;
			this.cb_option1.CheckedChanged += new System.EventHandler(this.cb_option1_CheckedChanged);
			// 
			// label1
			// 
			this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(12, 399);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(613, 16);
			this.label1.TabIndex = 4;
			this.label1.Text = "https://docs.microsoft.com/en-us/windows-server/administration/windows-commands/c" +
    "md";
			// 
			// btn_cancel
			// 
			this.btn_cancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.btn_cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.btn_cancel.Location = new System.Drawing.Point(26, 368);
			this.btn_cancel.Name = "btn_cancel";
			this.btn_cancel.Size = new System.Drawing.Size(153, 23);
			this.btn_cancel.TabIndex = 2;
			this.btn_cancel.Text = "Cancel";
			this.btn_cancel.UseVisualStyleBackColor = true;
			// 
			// OptionsForm1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.AppWorkspace;
			this.CancelButton = this.btn_cancel;
			this.ClientSize = new System.Drawing.Size(628, 424);
			this.ControlBox = false;
			this.Controls.Add(this.btn_cancel);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.btn_exit);
			this.Cursor = System.Windows.Forms.Cursors.Default;
			this.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Margin = new System.Windows.Forms.Padding(4);
			this.Name = "OptionsForm1";
			this.Text = "OptionsForm1";
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button btn_exit;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.CheckBox cb_option1;
		private System.Windows.Forms.CheckBox cb_option2;
		private System.Windows.Forms.CheckBox cb_option3;
		private System.Windows.Forms.CheckBox cb_option4;
		private System.Windows.Forms.CheckBox cb_option5;
		private System.Windows.Forms.CheckBox cb_option6;
		private System.Windows.Forms.CheckBox cb_option7;
		private System.Windows.Forms.CheckBox cb_option8;
		private System.Windows.Forms.CheckBox cb_option9;
		private System.Windows.Forms.CheckBox cb_option10;
		private System.Windows.Forms.CheckBox cb_option11;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button btn_cancel;
	}
}