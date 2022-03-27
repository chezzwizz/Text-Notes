Using System;
Using System.Windows.Forms;

class TextNotesProgram {
  [STAThread]
  static public void Main() {
    Application.Run(new TextNotes(TextNotesMainForm));
  }
}

