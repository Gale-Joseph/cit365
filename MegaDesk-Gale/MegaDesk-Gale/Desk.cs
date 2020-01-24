using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MegaDesk_Gale
{
    public enum Material
    {
        oak = 200,
        laminate = 100,
        pine = 50,
        rosewood = 300,
        veneer = 125

    }
    public class Desk
    {
        public int Width { get; set; }
        public int Depth { get; set; }
        public int Drawers { get; set; }
        public Material Surface { get; set; }

        //max and min constraints per instructions:
        private const int MinWidth = 24;
        private const int MaxWidth = 96;
        private const int MinDepth = 12;
        private const int MaxDepth = 96;

    }
}
