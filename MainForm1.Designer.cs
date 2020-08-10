namespace CmdLauncher
{
	partial class MainForm1
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
			this.txtSrcFolder = new System.Windows.Forms.TextBox();
			this.lbl_src = new System.Windows.Forms.Label();
			this.txtStartFolder = new System.Windows.Forms.TextBox();
			this.lbl_start = new System.Windows.Forms.Label();
			this.lb_files = new System.Windows.Forms.ListBox();
			this.btnLaunch = new System.Windows.Forms.Button();
			this.btnExit = new System.Windows.Forms.Button();
			this.UD_parameters = new System.Windows.Forms.NumericUpDown();
			this.lbl_parameters = new System.Windows.Forms.Label();
			this.lb_filetypes = new System.Windows.Forms.ListBox();
			this.cb_WithOptions = new System.Windows.Forms.CheckBox();
			((System.ComponentModel.ISupportInitialize)(this.UD_parameters)).BeginInit();
			this.SuspendLayout();
			// 
			// txtSrcFolder
			// 
			this.txtSrcFolder.AllowDrop = true;
			this.txtSrcFolder.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.txtSrcFolder.Location = new System.Drawing.Point(138, 12);
			this.txtSrcFolder.Margin = new System.Windows.Forms.Padding(4);
			this.txtSrcFolder.Name = "txtSrcFolder";
			this.txtSrcFolder.Size = new System.Drawing.Size(588, 26);
			this.txtSrcFolder.TabIndex = 2;
			this.txtSrcFolder.TextChanged += new System.EventHandler(this.txtSrcFolder_TextChanged);
			this.txtSrcFolder.DragDrop += new System.Windows.Forms.DragEventHandler(this.txtbox_DragDrop);
			this.txtSrcFolder.DragEnter += new System.Windows.Forms.DragEventHandler(this.txtbox_DragEnter);
			this.txtSrcFolder.DragOver += new System.Windows.Forms.DragEventHandler(this.txtbox_DragOver);
			this.txtSrcFolder.DragLeave += new System.EventHandler(this.txtbox_DragLeave);
			this.txtSrcFolder.DoubleClick += new System.EventHandler(this.txtSrcFolder_DoubleClick);
			// 
			// lbl_src
			// 
			this.lbl_src.AutoSize = true;
			this.lbl_src.Location = new System.Drawing.Point(15, 16);
			this.lbl_src.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.lbl_src.Name = "lbl_src";
			this.lbl_src.Size = new System.Drawing.Size(111, 18);
			this.lbl_src.TabIndex = 1;
			this.lbl_src.Text = "Source Folder";
			this.lbl_src.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// txtStartFolder
			// 
			this.txtStartFolder.AllowDrop = true;
			this.txtStartFolder.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.txtStartFolder.Location = new System.Drawing.Point(138, 43);
			this.txtStartFolder.Margin = new System.Windows.Forms.Padding(4);
			this.txtStartFolder.Name = "txtStartFolder";
			this.txtStartFolder.Size = new System.Drawing.Size(588, 26);
			this.txtStartFolder.TabIndex = 4;
			this.txtStartFolder.DragDrop += new System.Windows.Forms.DragEventHandler(this.txtbox_DragDrop);
			this.txtStartFolder.DragEnter += new System.Windows.Forms.DragEventHandler(this.txtbox_DragEnter);
			this.txtStartFolder.DragOver += new System.Windows.Forms.DragEventHandler(this.txtbox_DragOver);
			this.txtStartFolder.DragLeave += new System.EventHandler(this.txtbox_DragLeave);
			// 
			// lbl_start
			// 
			this.lbl_start.AutoSize = true;
			this.lbl_start.Location = new System.Drawing.Point(15, 47);
			this.lbl_start.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.lbl_start.Name = "lbl_start";
			this.lbl_start.Size = new System.Drawing.Size(117, 18);
			this.lbl_start.TabIndex = 3;
			this.lbl_start.Text = "Start-In Folder";
			this.lbl_start.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// lb_files
			// 
			this.lb_files.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.lb_files.FormattingEnabled = true;
			this.lb_files.HorizontalScrollbar = true;
			this.lb_files.ItemHeight = 18;
			this.lb_files.Location = new System.Drawing.Point(18, 93);
			this.lb_files.Name = "lb_files";
			this.lb_files.Size = new System.Drawing.Size(344, 274);
			this.lb_files.TabIndex = 5;
			// 
			// btnLaunch
			// 
			this.btnLaunch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.btnLaunch.Location = new System.Drawing.Point(15, 388);
			this.btnLaunch.Name = "btnLaunch";
			this.btnLaunch.Size = new System.Drawing.Size(84, 26);
			this.btnLaunch.TabIndex = 9;
			this.btnLaunch.Text = "&Launch";
			this.btnLaunch.UseVisualStyleBackColor = true;
			this.btnLaunch.Click += new System.EventHandler(this.btnLaunch_Click);
			// 
			// btnExit
			// 
			this.btnExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btnExit.Location = new System.Drawing.Point(636, 388);
			this.btnExit.Name = "btnExit";
			this.btnExit.Size = new System.Drawing.Size(84, 26);
			this.btnExit.TabIndex = 10;
			this.btnExit.Text = "E&xit";
			this.btnExit.UseVisualStyleBackColor = true;
			this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
			// 
			// UD_parameters
			// 
			this.UD_parameters.Location = new System.Drawing.Point(374, 115);
			this.UD_parameters.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
			this.UD_parameters.Name = "UD_parameters";
			this.UD_parameters.Size = new System.Drawing.Size(86, 26);
			this.UD_parameters.TabIndex = 7;
			this.UD_parameters.ValueChanged += new System.EventHandler(this.UD_parameters_ValueChanged);
			// 
			// lbl_parameters
			// 
			this.lbl_parameters.AutoSize = true;
			this.lbl_parameters.Location = new System.Drawing.Point(371, 93);
			this.lbl_parameters.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.lbl_parameters.Name = "lbl_parameters";
			this.lbl_parameters.Size = new System.Drawing.Size(94, 18);
			this.lbl_parameters.TabIndex = 6;
			this.lbl_parameters.Text = "Parameters";
			this.lbl_parameters.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// lb_filetypes
			// 
			this.lb_filetypes.FormattingEnabled = true;
			this.lb_filetypes.ItemHeight = 18;
			this.lb_filetypes.Location = new System.Drawing.Point(475, 82);
			this.lb_filetypes.Name = "lb_filetypes";
			this.lb_filetypes.Size = new System.Drawing.Size(134, 58);
			this.lb_filetypes.TabIndex = 8;
			this.lb_filetypes.SelectedIndexChanged += new System.EventHandler(this.lb_filetypes_SelectedIndexChanged);
			// 
			// cb_WithOptions
			// 
			this.cb_WithOptions.AutoSize = true;
			this.cb_WithOptions.Location = new System.Drawing.Point(138, 388);
			this.cb_WithOptions.Name = "cb_WithOptions";
			this.cb_WithOptions.Size = new System.Drawing.Size(122, 22);
			this.cb_WithOptions.TabIndex = 11;
			this.cb_WithOptions.Text = "With Options";
			this.cb_WithOptions.UseVisualStyleBackColor = true;
			// 
			// MainForm1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.ControlDark;
			this.ClientSize = new System.Drawing.Size(734, 427);
			this.Controls.Add(this.cb_WithOptions);
			this.Controls.Add(this.lb_filetypes);
			this.Controls.Add(this.lbl_parameters);
			this.Controls.Add(this.UD_parameters);
			this.Controls.Add(this.btnExit);
			this.Controls.Add(this.btnLaunch);
			this.Controls.Add(this.lb_files);
			this.Controls.Add(this.lbl_start);
			this.Controls.Add(this.txtStartFolder);
			this.Controls.Add(this.lbl_src);
			this.Controls.Add(this.txtSrcFolder);
			this.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Margin = new System.Windows.Forms.Padding(4);
			this.Name = "MainForm1";
			this.Text = "CmdLauncher";
			this.Load += new System.EventHandler(this.MainForm1_Load);
			this.Resize += new System.EventHandler(this.MainForm1_Resize);
			((System.ComponentModel.ISupportInitialize)(this.UD_parameters)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox txtSrcFolder;
		private System.Windows.Forms.Label lbl_src;
		private System.Windows.Forms.TextBox txtStartFolder;
		private System.Windows.Forms.Label lbl_start;
		private System.Windows.Forms.ListBox lb_files;
		private System.Windows.Forms.Button btnLaunch;
		private System.Windows.Forms.Button btnExit;
		private System.Windows.Forms.NumericUpDown UD_parameters;
		private System.Windows.Forms.Label lbl_parameters;
		private System.Windows.Forms.ListBox lb_filetypes;
		private System.Windows.Forms.CheckBox cb_WithOptions;
	}
}

