using System.Drawing;

namespace lw2_part2.entities
{
    public abstract class AbstractShape : IShape
    {
        private int x;
        private int y;
        private int a;
        private int b;

        protected Graphics graphics;

        public AbstractShape(Graphics graphics)
        {
            this.graphics = graphics;
        }

        public Graphics GetGraphics()
        {
            return graphics;
        }

        public int X
        {
            get => x;
            set => x = value;
        }

        public int Y
        {
            get => y;
            set => y = value;
        }

        public int A
        {
            get => a;
            set => a = value;
        }
        
        public int B
        {
            get => b;
            set => b = value;
        }
        
        public virtual void Hide()
        {
            Point point = new Point(-1, -1);
            graphics.DrawPolygon(Pens.White, new []{point});
        }

        public abstract void Draw(Pen pen);
    }
}