using System;
using System.Windows.Forms;

namespace ConsoleAppWithForm
{
    class Program
    {
        static System.Timers.Timer timer = null;
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine("Enter key Q to exit!");
            runForever();
            Application.Run(new WindowsFormsApp.Form1());
            
            var key = Console.ReadKey();
            if (key.KeyChar == 'Q' && timer != null)
            {
                timer.Stop();
            }
        }

        public static void runForever()
        {
            timer = new System.Timers.Timer(2000);
            timer.Elapsed += Timer_ElapsedAsync;
            timer.Start();
        }

        public static void Timer_ElapsedAsync(object sender, System.Timers.ElapsedEventArgs e)
        {
            Console.WriteLine("Hello");
        }
    }
}
