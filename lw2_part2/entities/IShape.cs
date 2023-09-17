using System.Drawing;

namespace lw2_part2.entities
{
    public interface IShape
    {
        void Draw(Pen pen);
        void Hide();
    }
}