using System.Drawing;

namespace lw2_part2.entities
{
    public class ShapeProxy : AbstractShape
    {
        private const int DefaultCoordinates = 0;
        private const int DefaultSide = 50;
        
        private AbstractShape shape;
        public ShapeProxy(AbstractShape shape) : base(shape.GetGraphics())
        {
            this.shape = shape;
            correct();
        }

        private void correct()
        {
            if (shape.X < 0)
            {
                shape.X = DefaultCoordinates;
            }

            if (shape.Y < 0)
            {
                shape.Y = DefaultCoordinates;
            }

            if (shape.A > 0 && shape.B > 0)
            {
                return;
            }

            if (shape.A <= 0 && shape.B > 0)
            {
                shape.A = shape.B;
                return;
            }

            if (shape.A > 0 && shape.B <= 0)
            {
                shape.B = shape.A;
                return;
            }

            shape.A = DefaultSide;
            shape.B = DefaultSide;
        }

        public override void Draw(Pen pen)
        {
            shape.Draw(pen);
        }

        public override void Hide()
        {
            shape.Hide();
        }
    }
}