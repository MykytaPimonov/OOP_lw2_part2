using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using lw2_part2.entities;
using lw2_part2.entities.enums;

namespace lw2_part2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ShapePainter sp = ShapePainter.builder()
                .graphics(field.CreateGraphics())
                .createShape(ShapeType.CIRCLE)
                .x(150).y(100).b(70)
                .submitShape()
                .createShape(ShapeType.RECTANGLE)
                .x(50).y(200).a(10).b(70)
                .submitShape()
                .createShape(ShapeType.TRIANGLE)
                .x(300).y(200).a(100).b(40)
                .submitShape()
                .build();

            ShapePainter.Iterator iterator = sp.iterator();

            while (iterator.hasNext())
            {
                AbstractShape shape = iterator.next();
                shape.Draw(Pens.Red);
            }
        }
    }
}