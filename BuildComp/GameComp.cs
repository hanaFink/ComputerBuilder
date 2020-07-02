using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuildComp
{
    public class GameCompBuilder : CompBuilder
    {
        protected override void AddBox()
        {
            comp.AddBox("regular box");
        }

        protected override void AddGraphicCard()
        {
            comp.AddGraphicCard("Good GraphicCard");
        }

        protected override void AddMemory()
        {
            comp.Memory("Lot of memory");
        }

        protected override void AddMotherBoard()
        {
            comp.AddMotherBoard("Regular MotherBoard");
        }

        protected override void Addprocessor()
        {
            comp.Addprocessor("Good processor");
        }
    }
}
