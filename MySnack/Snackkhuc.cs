using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MySnack
{
    [SuppressMessage("ReSharper", "MemberCanBePrivate.Global")]
    class Snackkhuc
    {
        
        private Rectangle[] snackrec;

        public Rectangle[] Snackrec
        {
            get { return snackrec; }
        }

        private readonly SolidBrush brush;
        private readonly int x;
	    private readonly int y;
	    private readonly int width;
	    private readonly int hight;

	    /// <summary>
        /// construction snack function
        /// </summary>
        public Snackkhuc()
        {
            snackrec = new Rectangle[4];
            brush = new SolidBrush(Color.Blue);
            x = 30;
            y = 30;
            width = 13;
            hight = 12;
            for (int i = 0; i < snackrec.Length; i++)
            {
                snackrec[i] = new Rectangle(x, y, width, hight);
                x += 16;
            }
         
            
        }
        /// <summary>
        /// Draw snack function
        /// </summary>
        /// <param name="paper"></param>
        public void Drawsnack(Graphics paper)
        {
            foreach (Rectangle rec in snackrec)
            {
                paper.FillEllipse(brush,rec);
            }
            paper.FillEllipse(new SolidBrush(Color.YellowGreen),snackrec[snackrec.Length-1]);
            paper.FillEllipse(new SolidBrush(Color.Red), snackrec[0]);
        }
        /// <summary>
        /// Draw snack run function
        /// </summary>
        public void drawsnackrun()
        {
            for (int i = snackrec.Length - 1; i > 0; i--)
            {
                snackrec[i] = snackrec[i - 1];
            }
        }

        
        /// <summary>
        /// vẽ rắn khi đi xuống
        /// </summary>
        public void movedown()
        {
            drawsnackrun();
            snackrec[0].Y += 12;
        }
        public void moveup()
        {
            drawsnackrun();
            snackrec[0].Y -= 12;
        }
        public void moveright()
        {
            drawsnackrun();
            snackrec[0].X += 12;
        }
        public void moveleft()
        {
            drawsnackrun();
            snackrec[0].X -= 12;
        }

        public void GrowSnack()
        {
            List<Rectangle> rec = snackrec.ToList();
            rec.Add(new Rectangle(snackrec[snackrec.Length-1].X, snackrec[snackrec.Length-1].Y,width, hight));
            snackrec = rec.ToArray();
        }
    }
}
