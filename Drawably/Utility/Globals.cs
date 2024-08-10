using Drawably.UserControls.CanvasRelated;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Drawably.Utility
{
    /// <summary>
    /// Contains classes that can be accessed by any other class. Something like a singleton holder.
    /// TODO Each and every single one of these have to be set up correctly in order for the application to work.
    /// </summary>
    public static class Globals
    {
        public static CanvasContainer CanvasContainer { get; private set; }

        public static void SetUp(CanvasContainer newCanvasContainer) 
        {
            CanvasContainer = newCanvasContainer;

        }
    }
}
