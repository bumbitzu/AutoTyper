using System;
using System.IO;
using System.Collections.Generic;
using System.Media;
using System.Threading;
using System.Windows.Forms;
using WindowsInput;
using WindowsInput.Native;
using RRandom;
namespace TypingProc
{
    public class Typing
    {

        /*
        Simulate the typing process on the file located in the filePath variable. 
        The method uses the input simulator to simulate the keyboard and mouse inputs, 
        and plays different sounds corresponding to the characters it is typing. 
        The valueSleep variable is used to delay before start typing
         */
        public static void SimulateTypingFromFile(string filePath,int valueSleep,List<int> miliseconds)
        {
            // check the existence of the file
            if (filePath=="")
            {
                MessageBox.Show("The file does not exist");
                return;
            }

            // read the contents of the file
            string fileContent = File.ReadAllText(filePath);

            SoundPlayer space = new SoundPlayer("Sounds\\Space.wav");
            List<SoundPlayer> player = new List<SoundPlayer>();
            player.Add(new SoundPlayer("Sounds\\1.wav"));
            player.Add(new SoundPlayer("Sounds\\2.wav"));
            player.Add(new SoundPlayer("Sounds\\3.wav"));
            player.Add(new SoundPlayer("Sounds\\4.wav"));
            player.Add(new SoundPlayer("Sounds\\5.wav"));
            player.Add(new SoundPlayer("Sounds\\6.wav"));
            player.Add(new SoundPlayer("Sounds\\7.wav"));
            player.Add(new SoundPlayer("Sounds\\8.wav"));
            player.Add(new SoundPlayer("Sounds\\9.wav"));
            player.Add(new SoundPlayer("Sounds\\10.wav"));
            player.Add(new SoundPlayer("Sounds\\11.wav"));
            player.Add(new SoundPlayer("Sounds\\12.wav"));
            player.Add(new SoundPlayer("Sounds\\13.wav"));
            player.Add(new SoundPlayer("Sounds\\14.wav"));
            player.Add(new SoundPlayer("Sounds\\15.wav"));
            player.Add(new SoundPlayer("Sounds\\16.wav"));
            
            // Initializes the InputSimulator
            var sim = new InputSimulator();
            Thread.Sleep(valueSleep);
            // it goes through every character in the file content
            int scroll = 0;
            foreach (char c in fileContent)
            {

                int num = 0;
                Rdm.Random_(ref num);
                Random rnd = new Random();
                var nr = rnd.Next(0, 8);
                Thread.Sleep(miliseconds[nr]);
                // check if the character is a letter or a number or a symbol
                if (c == ' ')
                {
                    space.Play();
                    sim.Keyboard.TextEntry(c.ToString());
                }
                if (Char.IsLetterOrDigit(c) || Char.IsPunctuation(c) || Char.IsSymbol(c))
                {
                    player[num].Play();
                    sim.Keyboard.TextEntry(c.ToString());
                }

                else
                {
                    switch (c)
                    {
                        case '\n':
                            scroll++;
                            space.Play();
                            sim.Keyboard.KeyPress(VirtualKeyCode.RETURN);
                            if (scroll > 12 && scroll % 2 == 0)
                            {
                                sim.Mouse.VerticalScroll(-1);
                            }
                            break;
                    }
                }
            }         
        }
    }
}
