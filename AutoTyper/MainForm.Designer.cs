namespace AutoWriter
{
	partial class Main
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
			this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
			this.textBrowse = new System.Windows.Forms.TextBox();
			this.buttonBrowse = new System.Windows.Forms.Button();
			this.trackBarSpeed = new System.Windows.Forms.TrackBar();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.numericUpDown = new System.Windows.Forms.NumericUpDown();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.label1 = new System.Windows.Forms.Label();
			this.groupBox3 = new System.Windows.Forms.GroupBox();
			this.labelCurentInput = new System.Windows.Forms.Label();
			this.buttonStart = new System.Windows.Forms.Button();
			this.buttonStop = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.trackBarSpeed)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDown)).BeginInit();
			this.groupBox1.SuspendLayout();
			this.groupBox2.SuspendLayout();
			this.groupBox3.SuspendLayout();
			this.SuspendLayout();
			// 
			// openFileDialog
			// 
			this.openFileDialog.FileName = "openFileDialog1";
			// 
			// textBrowse
			// 
			this.textBrowse.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.textBrowse.Location = new System.Drawing.Point(99, 11);
			this.textBrowse.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.textBrowse.Name = "textBrowse";
			this.textBrowse.Size = new System.Drawing.Size(344, 23);
			this.textBrowse.TabIndex = 0;
			this.textBrowse.TextChanged += new System.EventHandler(this.TextBrowse_TextChanged);
			// 
			// buttonBrowse
			// 
			this.buttonBrowse.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.buttonBrowse.Location = new System.Drawing.Point(9, 10);
			this.buttonBrowse.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.buttonBrowse.Name = "buttonBrowse";
			this.buttonBrowse.Size = new System.Drawing.Size(85, 24);
			this.buttonBrowse.TabIndex = 1;
			this.buttonBrowse.Text = "Browse";
			this.buttonBrowse.UseVisualStyleBackColor = true;
			this.buttonBrowse.Click += new System.EventHandler(this.ButtonBrowse_Click);
			// 
			// trackBarSpeed
			// 
			this.trackBarSpeed.Location = new System.Drawing.Point(29, 49);
			this.trackBarSpeed.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.trackBarSpeed.Maximum = 4;
			this.trackBarSpeed.Name = "trackBarSpeed";
			this.trackBarSpeed.Size = new System.Drawing.Size(141, 45);
			this.trackBarSpeed.TabIndex = 3;
			this.trackBarSpeed.Scroll += new System.EventHandler(this.TrackBarSpeed_Scroll);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(140, 97);
			this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(33, 15);
			this.label2.TabIndex = 5;
			this.label2.Text = "High";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(25, 97);
			this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(30, 15);
			this.label3.TabIndex = 6;
			this.label3.Text = "Low";
			// 
			// numericUpDown
			// 
			this.numericUpDown.Location = new System.Drawing.Point(4, 17);
			this.numericUpDown.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.numericUpDown.Name = "numericUpDown";
			this.numericUpDown.Size = new System.Drawing.Size(35, 21);
			this.numericUpDown.TabIndex = 6;
			this.numericUpDown.ValueChanged += new System.EventHandler(this.NumericUpDown_ValueChanged);
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.label3);
			this.groupBox1.Controls.Add(this.trackBarSpeed);
			this.groupBox1.Controls.Add(this.label2);
			this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.groupBox1.Location = new System.Drawing.Point(9, 46);
			this.groupBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.groupBox1.Size = new System.Drawing.Size(205, 140);
			this.groupBox1.TabIndex = 7;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Writing speed";
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.label1);
			this.groupBox2.Controls.Add(this.numericUpDown);
			this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.groupBox2.Location = new System.Drawing.Point(218, 46);
			this.groupBox2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.groupBox2.Size = new System.Drawing.Size(225, 45);
			this.groupBox2.TabIndex = 8;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = " Before start";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(44, 19);
			this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(55, 15);
			this.label1.TabIndex = 10;
			this.label1.Text = "Seconds";
			// 
			// groupBox3
			// 
			this.groupBox3.Controls.Add(this.labelCurentInput);
			this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.groupBox3.Location = new System.Drawing.Point(9, 190);
			this.groupBox3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.groupBox3.Name = "groupBox3";
			this.groupBox3.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.groupBox3.Size = new System.Drawing.Size(434, 45);
			this.groupBox3.TabIndex = 9;
			this.groupBox3.TabStop = false;
			this.groupBox3.Text = "Current input file";
			// 
			// labelCurentInput
			// 
			this.labelCurentInput.AutoSize = true;
			this.labelCurentInput.Location = new System.Drawing.Point(5, 19);
			this.labelCurentInput.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.labelCurentInput.Name = "labelCurentInput";
			this.labelCurentInput.Size = new System.Drawing.Size(0, 15);
			this.labelCurentInput.TabIndex = 0;
			// 
			// buttonStart
			// 
			this.buttonStart.BackColor = System.Drawing.Color.YellowGreen;
			this.buttonStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.buttonStart.Location = new System.Drawing.Point(218, 96);
			this.buttonStart.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.buttonStart.Name = "buttonStart";
			this.buttonStart.Size = new System.Drawing.Size(225, 44);
			this.buttonStart.TabIndex = 10;
			this.buttonStart.Text = "Start  ( CTRL + 1 )";
			this.buttonStart.UseVisualStyleBackColor = false;
			this.buttonStart.Click += new System.EventHandler(this.buttonStart_Click);
			// 
			// buttonStop
			// 
			this.buttonStop.BackColor = System.Drawing.Color.DarkOrange;
			this.buttonStop.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.buttonStop.Location = new System.Drawing.Point(218, 144);
			this.buttonStop.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.buttonStop.Name = "buttonStop";
			this.buttonStop.Size = new System.Drawing.Size(225, 44);
			this.buttonStop.TabIndex = 11;
			this.buttonStop.Text = "Stop  ( CTRL + 0 )";
			this.buttonStop.UseVisualStyleBackColor = false;
			this.buttonStop.Click += new System.EventHandler(this.buttonStop_Click);
			// 
			// Main
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(449, 246);
			this.Controls.Add(this.buttonStop);
			this.Controls.Add(this.buttonStart);
			this.Controls.Add(this.groupBox3);
			this.Controls.Add(this.groupBox2);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.buttonBrowse);
			this.Controls.Add(this.textBrowse);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.KeyPreview = true;
			this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.MaximizeBox = false;
			this.Name = "Main";
			this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
			this.Text = "AutoTyper - by ChicoMalo";
			this.Load += new System.EventHandler(this.MainP_Load);
			((System.ComponentModel.ISupportInitialize)(this.trackBarSpeed)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDown)).EndInit();
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.groupBox2.ResumeLayout(false);
			this.groupBox2.PerformLayout();
			this.groupBox3.ResumeLayout(false);
			this.groupBox3.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

        #endregion

        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.TextBox textBrowse;
        private System.Windows.Forms.Button buttonBrowse;
        private System.Windows.Forms.TrackBar trackBarSpeed;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown numericUpDown;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label labelCurentInput;
        private System.Windows.Forms.Button buttonStart;
        private System.Windows.Forms.Button buttonStop;
    }
}

