using SFML.Graphics;
using SFML.Window;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Intro_2D_Spiel
{
    class Program
    {
        static void Main(string[] args)
        {
            RenderWindow win = new RenderWindow(new VideoMode(800, 600), "Hallo Fenster");
            win.Clear();

            win.Closed += win_Closed;

            win.Display();
            while(win.IsOpen())
            {

                win.DispatchEvents();

            }

        }

        static void win_Closed(object sender, EventArgs e)
        {
            RenderWindow win = (RenderWindow)sender;
            win.Close();

        }




    }
}
