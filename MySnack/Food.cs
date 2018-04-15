using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MySnack
{
     class Food
    {
	    private int x, y;
	    private readonly int width;
	    private readonly int hight;

	    private readonly SolidBrush sb ;

        public Rectangle FoodRec;

        public Food(Random _Random)
        {
            x = _Random.Next(28) * 16;
            y = _Random.Next(28) * 10;
            sb = new SolidBrush(Color.BlueViolet);
            width = hight = 11;
            FoodRec = new Rectangle(x,y,width, hight);
        }

        public void Foodlocation(Random _Random)
        {
            x = _Random.Next(28) * 16;
            y = _Random.Next(28) * 10;   
        }

        public void Drawfood(Graphics paper)
        {
            FoodRec.X = x;
            FoodRec.Y = y;
            paper.FillEllipse(sb, FoodRec);
        }

    }
}
