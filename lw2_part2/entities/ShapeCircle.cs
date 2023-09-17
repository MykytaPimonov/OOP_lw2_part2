using System.Drawing;

namespace lw2_part2.entities
{
    public class ShapeCircle : AbstractShape
    {
        public ShapeCircle(Graphics graphics) : base(graphics) { }
        
        public override void Draw(Pen pen)
        {
            Rectangle circle = new Rectangle(X - A, Y - B, 2 * A, 2 * B);
            graphics.DrawEllipse(pen, circle);
        }
    }
}