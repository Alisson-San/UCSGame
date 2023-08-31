using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UCSGame.Base
{
    internal class Scene
    {
        public World World { get; set; }

        public Camera Camera { get; set; }

        public int Top = 1;

        public Scene() {
            World = new World(20, 80);
            World.Fill();
            Camera = new Camera();
        }

        public void Add(string text)
        {
            World.Add(Top,1, text);
            Top++;
        }

        public void RequestUserOption() 
        {
            Console.WriteLine("Escolha uma Opção:");
            string op = Console.ReadLine();
        }

        public void Show()
        {
            Camera.Draw(World);
        }
    }
}
