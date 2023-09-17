using System.Collections.Generic;
using System.Drawing;
using lw2_part2.entities.enums;

namespace lw2_part2.entities
{
    public class ShapePainter
    {
        private Graphics graphics;
        private List<AbstractShape> shapes;
        
        private ShapePainter() {}

        public Iterator iterator()
        {
            return new Iterator(this);
        }
        
        public class Iterator
        {
            private ShapePainter sp;
            private int pointer;

            public Iterator(ShapePainter sp)
            {
                this.sp = sp;
                pointer = 0;
            }

            public bool hasNext()
            {
                return pointer < sp.shapes.Count;
            }

            public AbstractShape next()
            {
                return new ShapeProxy(sp.shapes[pointer++]);
            }
        }
        
        public static ShapePainterBuilder builder()
        {
            return new ShapePainterBuilder();
        }
        
        public class ShapePainterBuilder
        {
            private ShapePainter shapePainter;
            public ShapePainterBuilder()
            {
                shapePainter = new ShapePainter();
                shapePainter.shapes = new List<AbstractShape>();
            }

            public ShapePainterBuilder graphics(Graphics graphics)
            {
                shapePainter.graphics = graphics;
                return this;
            }

            public ShapeBuilder createShape(ShapeType type)
            {
                AbstractShape shape;
                if (type == ShapeType.CIRCLE)
                {
                    shape = new ShapeCircle(shapePainter.graphics);
                }
                else if (type == ShapeType.RECTANGLE)
                {
                    shape = new ShapeRectangle(shapePainter.graphics);
                }
                else
                {
                    shape = new ShapeTriangle(shapePainter.graphics);
                }
                shapePainter.shapes.Add(shape);
                
                return new ShapeBuilder(this, shape);
            }

            public ShapePainter build()
            {
                return shapePainter;
            }
            
            public class ShapeBuilder
            {
                private ShapePainterBuilder parent;
                private AbstractShape shape;
                
                public ShapeBuilder(ShapePainterBuilder parent, AbstractShape shape)
                {
                    this.parent = parent;
                    this.shape = shape;
                }

                public ShapeBuilder x(int x)
                {
                    shape.X = x;
                    return this;
                }
                
                public ShapeBuilder y(int y)
                {
                    shape.Y = y;
                    return this;
                }
                
                public ShapeBuilder a(int a)
                {
                    shape.A = a;
                    return this;
                }
                
                public ShapeBuilder b(int b)
                {
                    shape.B = b;
                    return this;
                }

                public ShapePainterBuilder submitShape()
                {
                    return parent;
                }
            }
        }
    }
}