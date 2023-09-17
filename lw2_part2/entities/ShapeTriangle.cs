using System.Drawing;

namespace lw2_part2.entities
{
    public class ShapeTriangle : AbstractShape
    {
        public ShapeTriangle(Graphics graphics) : base(graphics) { }

        public override void Draw(Pen pen)
        {
            Point[] triangle =
            {
                new Point(X - A, Y + B),
                new Point(X, Y - B),
                new Point(X + A, Y + B)
            };
            graphics.DrawPolygon(pen, triangle);
        }
    }
}