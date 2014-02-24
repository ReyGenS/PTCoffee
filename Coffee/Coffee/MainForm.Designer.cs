/*
 * Created by SharpDevelop.
 * User: User
 * Date: 22.02.2014
 * Time: 13:26
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace Coffee
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
			this.button1 = new System.Windows.Forms.Button();
			this.Coffee = new System.Windows.Forms.CheckBox();
			this.Water = new System.Windows.Forms.CheckBox();
			this.Coffee_maker = new System.Windows.Forms.CheckBox();
			this.pictureBox2 = new System.Windows.Forms.PictureBox();
			this.pictureBox3 = new System.Windows.Forms.PictureBox();
			this.pictureBox4 = new System.Windows.Forms.PictureBox();
			this.pictureBox5 = new System.Windows.Forms.PictureBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.progressBar1 = new System.Windows.Forms.ProgressBar();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
			this.SuspendLayout();
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(35, 183);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(75, 23);
			this.button1.TabIndex = 0;
			this.button1.Text = "Cook";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.Button1Click);
			// 
			// Coffee
			// 
			this.Coffee.Location = new System.Drawing.Point(35, 53);
			this.Coffee.Name = "Coffee";
			this.Coffee.Size = new System.Drawing.Size(104, 24);
			this.Coffee.TabIndex = 1;
			this.Coffee.Text = "Coffee";
			this.Coffee.UseVisualStyleBackColor = true;
			this.Coffee.CheckedChanged += new System.EventHandler(this.CoffeeCheckedChanged);
			// 
			// Water
			// 
			this.Water.Location = new System.Drawing.Point(166, 53);
			this.Water.Name = "Water";
			this.Water.Size = new System.Drawing.Size(104, 24);
			this.Water.TabIndex = 2;
			this.Water.Text = "Water";
			this.Water.UseVisualStyleBackColor = true;
			this.Water.CheckedChanged += new System.EventHandler(this.WaterCheckedChanged);
			// 
			// Coffee_maker
			// 
			this.Coffee_maker.Location = new System.Drawing.Point(298, 53);
			this.Coffee_maker.Name = "Coffee_maker";
			this.Coffee_maker.Size = new System.Drawing.Size(104, 24);
			this.Coffee_maker.TabIndex = 3;
			this.Coffee_maker.Text = "Coffee maker";
			this.Coffee_maker.UseVisualStyleBackColor = true;
			this.Coffee_maker.CheckedChanged += new System.EventHandler(this.Coffee_makerCheckedChanged);
			// 
			// pictureBox2
			// 
			this.pictureBox2.BackColor = System.Drawing.SystemColors.ActiveCaption;
			this.pictureBox2.Location = new System.Drawing.Point(35, 98);
			this.pictureBox2.Name = "pictureBox2";
			this.pictureBox2.Size = new System.Drawing.Size(21, 20);
			this.pictureBox2.TabIndex = 6;
			this.pictureBox2.TabStop = false;
			// 
			// pictureBox3
			// 
			this.pictureBox3.BackColor = System.Drawing.SystemColors.ActiveCaption;
			this.pictureBox3.Location = new System.Drawing.Point(35, 133);
			this.pictureBox3.Name = "pictureBox3";
			this.pictureBox3.Size = new System.Drawing.Size(22, 20);
			this.pictureBox3.TabIndex = 7;
			this.pictureBox3.TabStop = false;
			// 
			// pictureBox4
			// 
			this.pictureBox4.BackColor = System.Drawing.SystemColors.ActiveCaption;
			this.pictureBox4.Location = new System.Drawing.Point(179, 98);
			this.pictureBox4.Name = "pictureBox4";
			this.pictureBox4.Size = new System.Drawing.Size(22, 20);
			this.pictureBox4.TabIndex = 8;
			this.pictureBox4.TabStop = false;
			// 
			// pictureBox5
			// 
			this.pictureBox5.BackColor = System.Drawing.SystemColors.ActiveCaption;
			this.pictureBox5.Location = new System.Drawing.Point(179, 133);
			this.pictureBox5.Name = "pictureBox5";
			this.pictureBox5.Size = new System.Drawing.Size(22, 20);
			this.pictureBox5.TabIndex = 9;
			this.pictureBox5.TabStop = false;
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(218, 98);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(65, 20);
			this.label1.TabIndex = 10;
			this.label1.Text = "Boil on/off";
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(218, 133);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(82, 20);
			this.label2.TabIndex = 11;
			this.label2.Text = "Warmer on/off";
			// 
			// label3
			// 
			this.label3.Location = new System.Drawing.Point(62, 98);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(96, 20);
			this.label3.TabIndex = 12;
			// 
			// label4
			// 
			this.label4.Location = new System.Drawing.Point(62, 133);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(96, 20);
			this.label4.TabIndex = 13;
			// 
			// progressBar1
			// 
			this.progressBar1.Location = new System.Drawing.Point(179, 182);
			this.progressBar1.Name = "progressBar1";
			this.progressBar1.Size = new System.Drawing.Size(121, 23);
			this.progressBar1.TabIndex = 14;
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(433, 244);
			this.Controls.Add(this.progressBar1);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.pictureBox5);
			this.Controls.Add(this.pictureBox4);
			this.Controls.Add(this.pictureBox3);
			this.Controls.Add(this.pictureBox2);
			this.Controls.Add(this.Coffee_maker);
			this.Controls.Add(this.Water);
			this.Controls.Add(this.Coffee);
			this.Controls.Add(this.button1);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "MainForm";
			this.Text = "PM-XII \"Special\"";
			((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
			this.ResumeLayout(false);
		}
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.PictureBox pictureBox5;
		private System.Windows.Forms.PictureBox pictureBox4;
		private System.Windows.Forms.PictureBox pictureBox3;
		private System.Windows.Forms.PictureBox pictureBox2;
		private System.Windows.Forms.ProgressBar progressBar1;
		private System.Windows.Forms.CheckBox Coffee_maker;
		private System.Windows.Forms.CheckBox Water;
		private System.Windows.Forms.CheckBox Coffee;
		private System.Windows.Forms.Button button1;
		
		void CoffeeCheckedChanged(object sender, System.EventArgs e)
		{
			this.Coffee.Checked=true;
		}
		
		void WaterCheckedChanged(object sender, System.EventArgs e)
		{
			this.Water.Checked=true;
		}
		
		void Coffee_makerCheckedChanged(object sender, System.EventArgs e)
		{
			this.Coffee_maker.Checked=true;
		}
		
	}
}
