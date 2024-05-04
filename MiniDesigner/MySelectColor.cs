using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniDesigner
{
    internal class MySelectColor
    {
        public Color myR { get; set; }
        public Color myG { get; set; }
        public Color myB { get; set; }
        public Color myA { get; set; }

        public MySelectColor() { }
        


            public MySelectColor(Color r, Color g, Color b, Color a)
        {            
            this.myR = Color.Red;
            this.myG = Color.Green;
            this.myB = Color.Blue;
            this.myA = Color.FromArgb(255, 255, 255, 255);
        }




    }
}
