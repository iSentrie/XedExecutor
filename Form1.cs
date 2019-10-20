// Decompiled with JetBrains decompiler
// Type: Bitizy_Is_Kinky.Form1
// Assembly: Bitizy Is Kinky, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: D340B761-28AD-4575-A5AA-D05BC4DA4006
// Assembly location: C:\Users\foriv\Desktop\Bitizy Is Kinky.exe

using System;
using System.ComponentModel;
using System.Drawing;
using System.Net;
using System.Windows.Forms;

namespace Bitizy_Is_Kinky
{
  public class Form1 : Form
  {
    private IContainer components;
    private Button button1;
    private Button button2;
    private TextBox textBox1;


    public Form1()
    {
      this.InitializeComponent();
    }

    private void button1_Click(object sender, EventArgs e)
    {
      string str1 = new WebClient()
      {
        Proxy = ((IWebProxy) null)
      }.DownloadString("https://pastebin.com/raw/AeMdfG00");
      string str2 = new WebClient()
      {
        Proxy = ((IWebProxy) null)
      }.DownloadString("https://pastebin.com/raw/SGCqf5SV");
      string text = this.textBox1.Text;
      if (str1.Contains(text))
      {
        int num = (int) MessageBox.Show("Whitelisted!");
        new Form2().Show();
        this.Hide();
      }
      else
      {
        int num = (int) MessageBox.Show("Key Invalid Sub To Cruzza Closing Now...");
                new Form2().Show();
                this.Hide();
            }
      if (!str2.Contains(this.textBox1.Text))
        return;
      int num1 = (int) MessageBox.Show("Blacklisted! Closing...");
      Application.Exit();
    }

    protected override void Dispose(bool disposing)
    {
      if (disposing && this.components != null)
        this.components.Dispose();
      base.Dispose(disposing);
    }

    private void InitializeComponent()
    {
      ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (Form1));
      this.button1 = new Button();
      this.button2 = new Button();
      this.textBox1 = new TextBox();
      this.SuspendLayout();
      this.button1.FlatStyle = FlatStyle.Flat;
      this.button1.ForeColor = Color.White;
      this.button1.Location = new Point(134, 84);
      this.button1.Name = "button1";
      this.button1.Size = new Size(64, 23);
      this.button1.TabIndex = 0;
      this.button1.Text = "Login";
      this.button1.UseVisualStyleBackColor = true;
      this.button1.Click += new EventHandler(this.button1_Click);
      this.button2.FlatStyle = FlatStyle.Flat;
      this.button2.ForeColor = Color.White;
      this.button2.Location = new Point(24, 84);
      this.button2.Name = "button2";
      this.button2.Size = new Size(64, 23);
      this.button2.TabIndex = 1;
      this.button2.Text = "Get Key";
      this.button2.UseVisualStyleBackColor = true;
      this.textBox1.BackColor = Color.Gray;
      this.textBox1.Location = new Point(24, 46);
      this.textBox1.Name = "textBox1";
      this.textBox1.Size = new Size(174, 20);
      this.textBox1.TabIndex = 2;
      this.textBox1.Text = "Put Key In Here";
      this.AutoScaleDimensions = new SizeF(6f, 13f);
      this.AutoScaleMode = AutoScaleMode.Font;
      this.BackColor = Color.FromArgb(64, 64, 64);
      this.ClientSize = new Size(226, 142);
      this.Controls.Add((Control) this.textBox1);
      this.Controls.Add((Control) this.button2);
      this.Controls.Add((Control) this.button1);
      this.FormBorderStyle = FormBorderStyle.FixedToolWindow;
      this.Icon = (Icon) componentResourceManager.GetObject("$this.Icon");
      this.Name = nameof (Form1);
      this.Text = "Bitizy Is Hott ";
      this.ResumeLayout(false);
      this.PerformLayout();
    }
  }
}
