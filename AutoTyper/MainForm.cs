using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Diagnostics;
using System.IO;
using System.Linq;
using KillProcess;

namespace AutoWriter
{
    public partial class Main : Form
    {
        private string filePath;
        private static int valueSleep = 0;
        private static readonly List<int> miliseconds = new List<int>();
        public Main()
        {
            InitializeComponent();

            //register the global hotkey, you need to update the RegisterHotKey method 
            RegisterHotKey(this.Handle, 0, (int)(KeyModifier.Control), (int)Keys.D0);
            RegisterHotKey(this.Handle, 1, (int)(KeyModifier.Control), (int)Keys.D1);
        }
        
        //RegisterHotKey and UnregisterHotKey functions from the user32.dll
        [DllImport("user32.dll")]
        public static extern bool RegisterHotKey(IntPtr hWnd, int id, int fsModifiers, int vk);
        
        [DllImport("user32.dll")]
        public static extern bool UnregisterHotKey(IntPtr hWnd, int id);

        // WndProc method to handle Windows messages
        protected override void WndProc(ref Message m)
        {
            base.WndProc(ref m);
            if (m.Msg == 0x0312)
            {
                //checks the value of the WParam property of the Message object
                int id = m.WParam.ToInt32();
                if (id == 0)
                {
                    //if CTRL + 0 will stop the typing process and reset to the begin if will start again
                   buttonStop_Click(null,EventArgs.Empty);
                }
                if(id == 1)
                {
                    //if CTRL + 1 will start the typing process form begin
                    buttonStart_Click(null, EventArgs.Empty);
                }

            }
        }

        
        [Flags] //allow the enumeration members to be combined using bitwise operations.
        public enum KeyModifier
        {
            None = 0, //No key modifier is set.
            Alt = 1, //The Alt key is pressed.
            Control = 2,  //The Control key is pressed.
            Shift = 4, //The Shift
            WinKey = 8 //The Windows key
        }
        /// ///
        private void MainP_Load(object sender, EventArgs e)
        {
            /*
            initialize the application's state when it is first loaded. 
            The value of valueSleep is  used as sleep time before start typing
            The contents of the "VSleep.nfo" file are used to store the state of the sleep time  before start typing for future use of Typer.exe.  
            The trackBarSpeed is used to control the speed of typing in the application, the value 0 sets a default speed. 
            The contents of the "Miliseconds.nfo" file are used to store the state of the speed of typing for future use of Typer.exe.
            */
            File.WriteAllText("Process\\VSleep.nfo", valueSleep.ToString());
            trackBarSpeed.Value = 0;
            miliseconds.Add(950);
            miliseconds.Add(1000);
            miliseconds.Add(1050);
            miliseconds.Add(1100);
            miliseconds.Add(1150);
            miliseconds.Add(1200);
            miliseconds.Add(1250);
            miliseconds.Add(1300);
            File.WriteAllLines("Process\\Miliseconds.nfo", miliseconds.Select(x => x.ToString()).ToArray());
        }
        private void ButtonBrowse_Click(object sender, EventArgs e)
        {
            //create a new instance of the OpenFileDialog
            openFileDialog = new OpenFileDialog
            {
                //set the initial directory
                InitialDirectory = @"C:",
                //sets the filter for the files that will be displayed
                Filter = "Text files (*.txt)|*.txt"
            };

            // displays the dialog to the user.
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                //sets the Text property of the control
                //to the full path of the file that the user selected.
                textBrowse.Text = openFileDialog.FileName;
            }
        }
        private void TextBrowse_TextChanged(object sender, EventArgs e)
        {
            /*
            Store the path of a file that the user selects using the TextBrowse Textbox. 
            The labelCurentInput is used to display the path of the selected file. 
            The contents of the "Path.nfo" file are used to store the path of the selected file for future use.
             */
            labelCurentInput.Text = textBrowse.Text;
            filePath = labelCurentInput.Text;
            File.WriteAllText("Process\\Path.nfo", filePath);
        }
        private void TrackBarSpeed_Scroll(object sender, EventArgs e)
        {
            miliseconds.Clear(); //clear the contents of miliseconds.
            File.WriteAllText("Process\\Miliseconds.nfo", string.Empty); //empties the contents of "Miliseconds.nfo".

            //Checks the value of the trackbar.
            //Depending on the value of the trackbar,
            //it adds specific set of integers to the miliseconds list.
            if (trackBarSpeed.Value == 0)
            {
                miliseconds.Add(950);
                miliseconds.Add(1000);
                miliseconds.Add(1050);
                miliseconds.Add(1100);
                miliseconds.Add(1150);
                miliseconds.Add(1200);
                miliseconds.Add(1250);
                miliseconds.Add(1300);
                
            }
            else if (trackBarSpeed.Value == 1)
            {
                miliseconds.Add(550);
                miliseconds.Add(600);
                miliseconds.Add(650);
                miliseconds.Add(700);
                miliseconds.Add(750);
                miliseconds.Add(800);
                miliseconds.Add(850);
                miliseconds.Add(900);
                
            }
            else if (trackBarSpeed.Value == 2)
            {
                miliseconds.Add(150);
                miliseconds.Add(200);
                miliseconds.Add(250);
                miliseconds.Add(300);
                miliseconds.Add(350);
                miliseconds.Add(400);
                miliseconds.Add(450);
                miliseconds.Add(500);
                
            }
            else if (trackBarSpeed.Value == 3)
            {
                miliseconds.Add(80);
                miliseconds.Add(90);
                miliseconds.Add(100);
                miliseconds.Add(110);
                miliseconds.Add(120);
                miliseconds.Add(130);
                miliseconds.Add(140);
                miliseconds.Add(150);
                
            }
            else if (trackBarSpeed.Value == 4)
            {
                miliseconds.Add(35);
                miliseconds.Add(40);
                miliseconds.Add(45);
                miliseconds.Add(50);
                miliseconds.Add(55);
                miliseconds.Add(60);
                miliseconds.Add(65);
                miliseconds.Add(70);
            }

            //Writes the contents of the miliseconds list to the "Miliseconds.nfo"
            File.WriteAllLines("Process\\Miliseconds.nfo", miliseconds.Select(x => x.ToString()).ToArray());
        }  
        
        private void buttonStart_Click(object sender, EventArgs e)
        {
            /*
            Start the typing process 
            The executable file "Typer.exe" located in the same directory as the current application. 
            The code uses the Path.Combine method to make sure that the path of the executable file is 
            correct and it can be started regardless of where the application is running.
             */
            string currentDirectory = Directory.GetCurrentDirectory();
            string executablePath = Path.Combine(currentDirectory, "Process\\Typer.exe");
            Process.Start(executablePath);
        }
        private void NumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            /*
            set sleep time in seconds before start typing, 
            The contents of the "VSleep.nfo" file are used to store the state of the sleep time for future use of Typer.exe 
            The event handler updates the value of the file every time the user changes the value of the NumericUpDown control.
             */
            File.WriteAllText("Process\\VSleep.nfo", string.Empty);
            valueSleep = (int)numericUpDown.Value * 1000;
            File.WriteAllText("Process\\VSleep.nfo",valueSleep.ToString());
            
        }
        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            //overwriting the contents of the files with an empty string
            File.WriteAllText("Process\\Miliseconds.nfo", string.Empty);
            File.WriteAllText("Process\\VSleep.nfo", string.Empty);
            File.WriteAllText("Process\\Path.nfo", string.Empty);

            //unregistering thr hotkeys that were previously registered using the RegisterHotKey function.
            UnregisterHotKey(this.Handle, 0);
            UnregisterHotKey(this.Handle, 1);
            base.OnFormClosing(e);
        }

        private void buttonStop_Click(object sender, EventArgs e)
        {
            KProcess.KillTyper();
        }
    }
}
