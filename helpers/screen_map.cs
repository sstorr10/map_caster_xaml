using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Shapes;

namespace map_caster.helpers
{
    class ScreenMap
    {
        int screen_width_inch;
        int screen_height_inch;

        public ScreenMap(int screen_width, int screen_height)
        {
            this.screen_height_inch = screen_height;
            this.screen_width_inch = screen_width;
        }

        public int GetMaxRenderWidth(int feet_to_inches)
        {
            return this.screen_width_inch * feet_to_inches;
        }

        public int GetMaxRenderHeight(int feet_to_inches)
        {
            return this.screen_height_inch * feet_to_inches;
        }
    }
}
