// Decompiled with JetBrains decompiler
// Type: CackePcNotepad.Form1
// Assembly: CackePcNotepad, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: BFB59E94-E563-4D87-868C-7C89747B5125
// Assembly location: C:\Users\Misha\OneDrive\Рабочий стол\CackePcNotepad.exe

using System;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace CackePcNotepad
{
  public class Form1 : Form
  {
    private IContainer components = (IContainer) null;
    private RichTextBox richTextBox1;
    private MenuStrip menuStrip1;
    private ToolStripMenuItem файлToolStripMenuItem;
    private ToolStripMenuItem открытьToolStripMenuItem;
    private ToolStripMenuItem сохранитьКакToolStripMenuItem;
    private ToolStripMenuItem сохранитьToolStripMenuItem;
    private ToolStripMenuItem правкаToolStripMenuItem;
    private ToolStripMenuItem копироватьToolStripMenuItem;
    private ToolStripMenuItem вставитьToolStripMenuItem;
    private ToolStripMenuItem вырезатьToolStripMenuItem;
    private ToolStripMenuItem шрифтToolStripMenuItem;
    private ToolStripMenuItem настройкиШрифтовToolStripMenuItem1;
    private ToolStripMenuItem фонToolStripMenuItem;
    private ToolStripMenuItem настройкиШрифтовToolStripMenuItem;
    private SaveFileDialog saveFileDialog1;
    private OpenFileDialog openFileDialog1;

    public Form1()
    {
      this.InitializeComponent();
      this.saveFileDialog1.Filter = "Text File(*.txt)|*.txt|cackeNotepadFile(*.cnp)|*.cnp";
    }

    private void сохранитьКакToolStripMenuItem_Click(object sender, EventArgs e)
    {
      if (this.saveFileDialog1.ShowDialog() == DialogResult.Cancel)
        return;
      File.WriteAllText(this.saveFileDialog1.FileName, this.richTextBox1.Text);
      int num = (int) MessageBox.Show("Данный Файл Был успешно сохранен!");
    }

    private void сохранитьToolStripMenuItem_Click(object sender, EventArgs e)
    {
    }

    private void открытьToolStripMenuItem_Click(object sender, EventArgs e)
    {
      if (this.openFileDialog1.ShowDialog() != DialogResult.Cancel)
        ;
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
      this.richTextBox1 = new RichTextBox();
      this.menuStrip1 = new MenuStrip();
      this.файлToolStripMenuItem = new ToolStripMenuItem();
      this.открытьToolStripMenuItem = new ToolStripMenuItem();
      this.сохранитьКакToolStripMenuItem = new ToolStripMenuItem();
      this.сохранитьToolStripMenuItem = new ToolStripMenuItem();
      this.правкаToolStripMenuItem = new ToolStripMenuItem();
      this.копироватьToolStripMenuItem = new ToolStripMenuItem();
      this.вставитьToolStripMenuItem = new ToolStripMenuItem();
      this.вырезатьToolStripMenuItem = new ToolStripMenuItem();
      this.шрифтToolStripMenuItem = new ToolStripMenuItem();
      this.фонToolStripMenuItem = new ToolStripMenuItem();
      this.настройкиШрифтовToolStripMenuItem = new ToolStripMenuItem();
      this.настройкиШрифтовToolStripMenuItem1 = new ToolStripMenuItem();
      this.saveFileDialog1 = new SaveFileDialog();
      this.openFileDialog1 = new OpenFileDialog();
      this.menuStrip1.SuspendLayout();
      this.SuspendLayout();
      this.richTextBox1.Dock = DockStyle.Fill;
      this.richTextBox1.Location = new Point(0, 24);
      this.richTextBox1.Name = "richTextBox1";
      this.richTextBox1.Size = new Size(800, 426);
      this.richTextBox1.TabIndex = 0;
      this.richTextBox1.Text = "";
      this.menuStrip1.Items.AddRange(new ToolStripItem[4]
      {
        (ToolStripItem) this.файлToolStripMenuItem,
        (ToolStripItem) this.правкаToolStripMenuItem,
        (ToolStripItem) this.шрифтToolStripMenuItem,
        (ToolStripItem) this.фонToolStripMenuItem
      });
      this.menuStrip1.Location = new Point(0, 0);
      this.menuStrip1.Name = "menuStrip1";
      this.menuStrip1.Size = new Size(800, 24);
      this.menuStrip1.TabIndex = 1;
      this.menuStrip1.Text = "menuStrip1";
      this.файлToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[3]
      {
        (ToolStripItem) this.открытьToolStripMenuItem,
        (ToolStripItem) this.сохранитьКакToolStripMenuItem,
        (ToolStripItem) this.сохранитьToolStripMenuItem
      });
      this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
      this.файлToolStripMenuItem.Size = new Size(48, 20);
      this.файлToolStripMenuItem.Text = "Файл";
      this.открытьToolStripMenuItem.Name = "открытьToolStripMenuItem";
      this.открытьToolStripMenuItem.Size = new Size(180, 22);
      this.открытьToolStripMenuItem.Text = "Открыть";
      this.открытьToolStripMenuItem.Click += new EventHandler(this.открытьToolStripMenuItem_Click);
      this.сохранитьКакToolStripMenuItem.Name = "сохранитьКакToolStripMenuItem";
      this.сохранитьКакToolStripMenuItem.Size = new Size(180, 22);
      this.сохранитьКакToolStripMenuItem.Text = "Сохранить как";
      this.сохранитьКакToolStripMenuItem.Click += new EventHandler(this.сохранитьКакToolStripMenuItem_Click);
      this.сохранитьToolStripMenuItem.Name = "сохранитьToolStripMenuItem";
      this.сохранитьToolStripMenuItem.Size = new Size(180, 22);
      this.сохранитьToolStripMenuItem.Text = "сохранить";
      this.сохранитьToolStripMenuItem.Click += new EventHandler(this.сохранитьToolStripMenuItem_Click);
      this.правкаToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[3]
      {
        (ToolStripItem) this.копироватьToolStripMenuItem,
        (ToolStripItem) this.вставитьToolStripMenuItem,
        (ToolStripItem) this.вырезатьToolStripMenuItem
      });
      this.правкаToolStripMenuItem.Name = "правкаToolStripMenuItem";
      this.правкаToolStripMenuItem.Size = new Size(57, 20);
      this.правкаToolStripMenuItem.Text = "правка";
      this.копироватьToolStripMenuItem.Name = "копироватьToolStripMenuItem";
      this.копироватьToolStripMenuItem.Size = new Size(180, 22);
      this.копироватьToolStripMenuItem.Text = "копировать";
      this.вставитьToolStripMenuItem.Name = "вставитьToolStripMenuItem";
      this.вставитьToolStripMenuItem.Size = new Size(180, 22);
      this.вставитьToolStripMenuItem.Text = "вставить";
      this.вырезатьToolStripMenuItem.Name = "вырезатьToolStripMenuItem";
      this.вырезатьToolStripMenuItem.Size = new Size(180, 22);
      this.вырезатьToolStripMenuItem.Text = "вырезать";
      this.шрифтToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[1]
      {
        (ToolStripItem) this.настройкиШрифтовToolStripMenuItem1
      });
      this.шрифтToolStripMenuItem.Name = "шрифтToolStripMenuItem";
      this.шрифтToolStripMenuItem.Size = new Size(57, 20);
      this.шрифтToolStripMenuItem.Text = "Шрифт";
      this.фонToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[1]
      {
        (ToolStripItem) this.настройкиШрифтовToolStripMenuItem
      });
      this.фонToolStripMenuItem.Name = "фонToolStripMenuItem";
      this.фонToolStripMenuItem.Size = new Size(43, 20);
      this.фонToolStripMenuItem.Text = "Фон";
      this.настройкиШрифтовToolStripMenuItem.Name = "настройкиШрифтовToolStripMenuItem";
      this.настройкиШрифтовToolStripMenuItem.Size = new Size(180, 22);
      this.настройкиШрифтовToolStripMenuItem.Text = "Настройки фона";
      this.настройкиШрифтовToolStripMenuItem1.Name = "настройкиШрифтовToolStripMenuItem1";
      this.настройкиШрифтовToolStripMenuItem1.Size = new Size(187, 22);
      this.настройкиШрифтовToolStripMenuItem1.Text = "Настройки Шрифтов";
      this.openFileDialog1.FileName = "openFileDialog1";
      this.AutoScaleDimensions = new SizeF(6f, 13f);
      this.AutoScaleMode = AutoScaleMode.Font;
      this.ClientSize = new Size(800, 450);
      this.Controls.Add((Control) this.richTextBox1);
      this.Controls.Add((Control) this.menuStrip1);
      this.Icon = (Icon) componentResourceManager.GetObject("$this.Icon");
      this.MainMenuStrip = this.menuStrip1;
      this.Name = nameof (Form1);
      this.Text = "CACKENOTEPAD1.0";
      this.menuStrip1.ResumeLayout(false);
      this.menuStrip1.PerformLayout();
      this.ResumeLayout(false);
      this.PerformLayout();
    }
  }
}
