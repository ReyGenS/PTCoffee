/*
 * Created by SharpDevelop.
 * User: User
 * Date: 22.02.2014
 * Time: 13:26
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Coffee
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		public MainForm()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		
		
		
		void Button1Click(object sender, EventArgs e)
		{
			bool warmer;
			if(Water.Checked==false)
			{
				pictureBox2.BackColor=Color.Red;
				label3.Text="Boiler empty";
			}
			if(Coffee.Checked==false)
			{
                label4.Text="Pot empty";
                pictureBox3.BackColor=Color.Red;
			}
			if(Coffee_maker.Checked==false)
			{
				warmer=false;
				label4.Text="Warmer empty";
				pictureBox3.BackColor=Color.Red;
				
			}
			if(Coffee.Checked==true && Coffee_maker.Checked==true && Water.Checked==true)
			{

					pictureBox4.BackColor=Color.Green;
					pictureBox5.BackColor=Color.Green;
				    pictureBox2.BackColor=Color.Green;
				    pictureBox3.BackColor=Color.Green;
				    label3.Text="Boiler not empty";
				    label4.Text="Pot not empty";
				    for(int i = 0; i<=10000;i++)
				    {
				    	progressBar1.Value=i*100/10000;
                        if(i==10000)
				       {
				    	   MessageBox.Show("Coffee ready","Finally!");
				       }
				    
				    }
				    
				   
			}
		}
	}
}
