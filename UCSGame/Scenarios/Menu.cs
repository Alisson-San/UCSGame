﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UCSGame.Base;

namespace UCSGame.Scenarios
{
    internal class Menu : Scene
    {
        public Menu() 
        {
            Add("1) Jogar");
            Add("2) Sair");
        }
    }
}
