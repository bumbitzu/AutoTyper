using System.IO;
using System.Collections.Generic;
using System.Linq;
using TypingProc;

namespace Typer
{
	internal class Program
    {
        static void Main()
		{
            
            string filePath = File.ReadAllText("Process\\Path.nfo"); // reads the contents of the "Path.nfo"
            int valueSleep = int.Parse(File.ReadAllText("Process\\VSleep.nfo")); // reads the contents of thr "VSleep.nfo"
            string[] lines = File.ReadAllLines("Process\\Miliseconds.nfo"); // reads the contents of the "Miliseconds.nfo"
            List<int> miliseconds = lines.Select(int.Parse).ToList(); // converts the string array to the list 

            /*
            simulating the typing process on the selected file, 
            with a delay defined by the valueSleep variable 
            and with specific typing speed defined by the miliseconds list.
             */
            Typing.SimulateTypingFromFile(filePath,valueSleep,miliseconds);

        }
	}
}
