using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Robot_Wars
{
    class Map
    {
        public int Width;
        public int Height;

        public Map(int Width, int Height)
        {
            // Offset by 1 to adhere to the '25 possible coordinate positions' requirement
            this.Width = Width - 1;
            this.Height = Height - 1;
        }
    }
}
