ConsoleKeyInfo KeyInfo;
int[][] Octaves = new int[2][];
Octaves[0] = new int[] { 262, 277, 294, 311, 330, 349, 370, 392, 415, 440, 466, 494 };
Octaves[1] = new int[] { 523, 554, 587, 622, 659, 699, 740, 784, 831, 880, 932, 988 };

double g = Convert.ToDouble(Console.ReadLine());
int nt = 0;
int octave = 1;
KeyInfo = Console.ReadKey();
while (true)
{
    switch (KeyInfo.Key)
    {

        case ConsoleKey.Tab:
            Console.Clear();
            break;
        case ConsoleKey.Q:
            nt = 0;
            Console.WriteLine("C");
            break;
        case ConsoleKey.W:
            nt = 1;
            Console.WriteLine("C#");
            break;
        case ConsoleKey.E:
            nt = 2;
            Console.WriteLine("D");
            break;
        case ConsoleKey.R:
            nt = 3;
            Console.WriteLine("D#");
            break;
        case ConsoleKey.T:
            nt = 4;
            Console.WriteLine("E");
            break;
        case ConsoleKey.Y:
            nt = 5;
            Console.WriteLine("F");
            break;
        case ConsoleKey.U:
            nt = 6;
            Console.WriteLine("F#");
            break;
        case ConsoleKey.I:
            nt = 7;
            Console.WriteLine("G");
            break;
        case ConsoleKey.O:
            nt = 8;
            Console.WriteLine("G#");
            break;
        case ConsoleKey.P:
            nt = 9;
            Console.WriteLine("A");
            break;
        case ConsoleKey.A:
            nt = 10;
            Console.WriteLine("A#");
            break;
        case ConsoleKey.S:
            nt = 11;
            Console.WriteLine("B");
            break;

        case ConsoleKey.F2:
            octave = 1;
            Console.WriteLine("2 octava");
            break;
        case ConsoleKey.F1:
            Console.WriteLine("1 octava");
            octave = 0;
            break;
    }
    Console.Beep(Octaves[octave][nt], 200);
}
