using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Drawably.Tools
{
    public interface IToolable
    {
        void OnToolSelected();
        void OnToolUnselected();
        void OnMouseMove(float x, float y);
        void OnMouseLeftClick(float x, float y);

        void OnMouseRightClick(float x, float y);

        void OnMouseDown(float x, float y);
        void OnMouseUp(float x, float y);

        void OnNewLayerSelected();

    }
}
