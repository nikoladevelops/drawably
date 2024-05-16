using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Drawably.Tools
{
    public interface IToolable
    {
        void OnMouseLeftClick(Graphics g, float locationX, float locationY);

        void OnMouseRightClick(Graphics g, float locationX, float locationY);

    }
}
