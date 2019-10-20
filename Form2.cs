// Decompiled with JetBrains decompiler
// Type: Bitizy_Is_Kinky.Form2
// Assembly: Bitizy Is Kinky, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: D340B761-28AD-4575-A5AA-D05BC4DA4006
// Assembly location: C:\Users\foriv\Desktop\Bitizy Is Kinky.exe

using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace Bitizy_Is_Kinky
{
  public class Form2 : Form
  {
    private IContainer components;
    private Label label1;
    private Label label2;
    private Button button1;
    private Button button3;
    private Label label3;
    private Label label4;
    private Label label5;

    public Form2()
    {
      this.InitializeComponent();
    }

    private void toolStripTextBox1_Click(object sender, EventArgs e)
    {
    }

    private void button1_Click(object sender, EventArgs e)
    {
      if (!Directory.Exists("\\Users\\Public\\Files"))
        return;
      Process.Start("\\Users\\Public\\Files\\Bitizy");
    }

    protected override void Dispose(bool disposing)
    {
      if (disposing && this.components != null)
        this.components.Dispose();
      base.Dispose(disposing);
    }

    private void InitializeComponent()
    {
      ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (Form2));
      this.label1 = new Label();
      this.label2 = new Label();
      this.button1 = new Button();
      this.button3 = new Button();
      this.label3 = new Label();
      this.label4 = new Label();
      this.label5 = new Label();
      this.SuspendLayout();
      this.label1.AutoSize = true;
      this.label1.Font = new Font("SimSun", 11.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.label1.ForeColor = Color.White;
      this.label1.Location = new Point(239, 13);
      this.label1.Name = "label1";
      this.label1.Size = new Size(63, 15);
      this.label1.TabIndex = 2;
      this.label1.Text = "Status:";
      this.label2.AutoSize = true;
      this.label2.Font = new Font("Microsoft Sans Serif", 11.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.label2.ForeColor = Color.FromArgb(128, (int) byte.MaxValue, 128);
      this.label2.Location = new Point(239, 28);
      this.label2.Name = "label2";
      this.label2.Size = new Size(83, 18);
      this.label2.TabIndex = 3;
      this.label2.Text = "Undetected";
      this.button1.FlatAppearance.BorderSize = 2;
      this.button1.FlatStyle = FlatStyle.Flat;
      this.button1.ForeColor = Color.White;
      this.button1.Location = new Point(12, 55);
      this.button1.Name = "button1";
      this.button1.Size = new Size(99, 32);
      this.button1.TabIndex = 5;
      this.button1.Text = "Executor";
      this.button1.UseVisualStyleBackColor = true;
      this.button1.Click += new EventHandler(this.button1_Click);
      this.button3.FlatAppearance.BorderSize = 2;
      this.button3.FlatStyle = FlatStyle.Flat;
      this.button3.ForeColor = Color.White;
      this.button3.Location = new Point(117, 55);
      this.button3.Name = "button3";
      this.button3.Size = new Size(99, 32);
      this.button3.TabIndex = 6;
      this.button3.Text = "Website";
      this.button3.UseVisualStyleBackColor = true;
      this.label3.AutoSize = true;
      this.label3.Font = new Font("Microsoft Sans Serif", 11.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.label3.ForeColor = Color.FromArgb(128, (int) byte.MaxValue, (int) byte.MaxValue);
      this.label3.Location = new Point(239, 61);
      this.label3.Name = "label3";
      this.label3.Size = new Size(71, 18);
      this.label3.TabIndex = 7;
      this.label3.Text = "Unknown";
      this.label4.AutoSize = true;
      this.label4.Font = new Font("SimSun", 11.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.label4.ForeColor = Color.White;
      this.label4.Location = new Point(239, 46);
      this.label4.Name = "label4";
      this.label4.Size = new Size(95, 15);
      this.label4.TabIndex = 8;
      this.label4.Text = "Expiration:";
      this.label5.AutoSize = true;
      this.label5.Font = new Font("Segoe Print", 9.75f, FontStyle.Italic, GraphicsUnit.Point, (byte) 0);
      this.label5.ForeColor = Color.White;
      this.label5.Location = new Point(17, 23);
      this.label5.Name = "label5";
      this.label5.Size = new Size(199, 23);
      this.label5.TabIndex = 9;
      this.label5.Text = "Bitizy Is Hott Sub To Cruzza";
      this.AutoScaleDimensions = new SizeF(6f, 13f);
      this.AutoScaleMode = AutoScaleMode.Font;
      this.BackColor = Color.Black;
      this.ClientSize = new Size(336, 101);
      this.Controls.Add((Control) this.label5);
      this.Controls.Add((Control) this.label4);
      this.Controls.Add((Control) this.label3);
      this.Controls.Add((Control) this.button3);
      this.Controls.Add((Control) this.button1);
      this.Controls.Add((Control) this.label2);
      this.Controls.Add((Control) this.label1);
      this.ForeColor = Color.AntiqueWhite;
      this.FormBorderStyle = FormBorderStyle.FixedToolWindow;
      this.Icon = (Icon) componentResourceManager.GetObject("$this.Icon");
      this.Name = nameof (Form2);
      this.Text = "B3IC Executor ";
      this.ResumeLayout(false);
      this.PerformLayout();
    }
  }
}
