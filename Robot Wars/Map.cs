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

        /// <summary>
        /// Robot wars map
        /// </summary>
        /// <param name="Width">Width of the map (maximum X coordinate)</param>
        /// <param name="Height">Height of the map (maximum Y coordinate)</param>
        public Map(int Width, int Height)
        {
            this.Width = Width;
            this.Height = Height;
        }
    }
}
