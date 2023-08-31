using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UCSGame.Base;

namespace UCSGame.Scenarios
{
    internal class City : Scene
    {

        public City()
        {
            Add("Você sente frio...");
            Add("─────────█▄██▄█");
            Add("█▄█▄█▄█▄█▐█┼██▌█▄█▄█▄█▄█");
            Add("███┼█████▐████▌█████┼███");
            Add("█████████▐████▌█████████");
            Add("1) Entrar no Castelo e se abrigar.");
            Add("2) Entrar na loja.");
            Add("3) Voltar para o Menu");
        }
    }
}
