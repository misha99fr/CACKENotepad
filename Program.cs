// Decompiled with JetBrains decompiler
// Type: CackePcNotepad.Program
// Assembly: CackePcNotepad, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: BFB59E94-E563-4D87-868C-7C89747B5125
// Assembly location: C:\Users\Misha\OneDrive\Рабочий стол\CackePcNotepad.exe

using System;
using System.Windows.Forms;

namespace CackePcNotepad
{
  internal static class Program
  {
    [STAThread]
    private static void Main()
    {
      Application.EnableVisualStyles();
      Application.SetCompatibleTextRenderingDefault(false);
      Application.Run((Form) new Form1());
    }
  }
}
