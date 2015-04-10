namespace PlayWithDebugger
{
    using System;
    class PlayWithDebugger
    {
        static void Main()
        {
            // With this program you can try the debugger functions;
            // The program prints at the console the numbers from 1 to 1000, each at a separate line;
            // Once you put a breakpoint at the CW line, try the Step Out function of the debugger (in my case Shift + F11)
            for (int i = 1; i <= 1000; i++)
            Console.WriteLine(" {0} ", i);
        }
    }
}
