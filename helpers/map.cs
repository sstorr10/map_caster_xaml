using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace map_caster.helpers
{
    class Map
    {
        private int map_width_feet;
        private int map_height_feet;

        private int feet_per_inch;
        private string source_image;

        public int TileColoumnCount { get; }
        public int TileRowCount { get; }

        public Map(int width_feet, int height_feet, string image_abs_path, int feet_per_inch = 5)
        {
            this.map_height_feet = height_feet;
            this.map_width_feet = width_feet;

            this.TileColoumnCount = width_feet / feet_per_inch;
            this.TileRowCount = height_feet / feet_per_inch;

            this.feet_per_inch = feet_per_inch;

            this.source_image = image_abs_path;
        }
    }
}
