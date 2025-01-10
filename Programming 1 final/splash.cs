using System;









namespace Programming_1_final
{
    public class splash
    {
        public splash()
        {


        }

        public static void AnimateAsciiArt()
        {
            int screenWidth = Console.WindowWidth;
            int animationWidth = 50; // Width of the ASCII art

            for (int position = 0; position <= screenWidth - animationWidth; position++)
            {
                Console.Clear();
                DisplayAnimatedAsciiArtAtPosition(position);
                Thread.Sleep(50);
            }
        }

        public static void DisplayAnimatedAsciiArtAtPosition(int position)
        {
            Console.SetCursorPosition(position, Console.CursorLeft);
            Console.ForegroundColor = ConsoleColor.Green;


            Console.WriteLine("██╗  ██╗ █████╗ ███╗   ██╗ ██████╗ ███╗   ███╗ █████╗ ███╗   ██╗");
            Console.WriteLine("██║  ██║██╔══██╗████╗  ██║██╔════╝ ████╗ ████║██╔══██╗████╗  ██║");
            Console.WriteLine("███████║███████║██╔██╗ ██║██║  ███╗██╔████╔██║███████║██╔██╗ ██║");
            Console.WriteLine("██╔══██║██╔══██║██║╚██╗██║██║   ██║██║╚██╔╝██║██╔══██║██║╚██╗██║");
            Console.WriteLine("██║  ██║██║  ██║██║ ╚████║╚██████╔╝██║ ╚═╝ ██║██║  ██║██║ ╚████║");
            Console.WriteLine("╚═╝  ╚═╝╚═╝  ╚═╝╚═╝  ╚═══╝ ╚═════╝ ╚═╝     ╚═╝╚═╝  ╚═╝╚═╝  ╚═══");

            Console.WriteLine("        ██╗  ██╗ █████╗ ███╗   ██╗ ██████╗ ███╗   ███╗ █████╗ ███╗   ██╗");
            Console.WriteLine("        ██║  ██║██╔══██╗████╗  ██║██╔════╝ ████╗ ████║██╔══██╗████╗  ██║");
            Console.WriteLine("        ███████║███████║██╔██╗ ██║██║  ███╗██╔████╔██║███████║██╔██╗ ██║");
            Console.WriteLine("        ██╔══██║██╔══██║██║╚██╗██║██║   ██║██║╚██╔╝██║██╔══██║██║╚██╗██║");
            Console.WriteLine("        ██║  ██║██║  ██║██║ ╚████║╚██████╔╝██║ ╚═╝ ██║██║  ██║██║ ╚████║");
            Console.WriteLine("        ╚═╝  ╚═╝╚═╝  ╚═╝╚═╝  ╚═══╝ ╚═════╝ ╚═╝     ╚═╝╚═╝  ╚═╝╚═╝  ╚═══");





            Console.ResetColor();
        }


    }


}

    


