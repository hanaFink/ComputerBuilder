using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuildComp
{
    class OfficeCompBuilder:CompBuilder
    {
        protected override void AddBox()
        {
            comp.AddBox("Regular box");
        }

        protected override void AddGraphicCard()
        {
            comp.AddGraphicCard("Regular GraphicCard");
        }

        protected override void AddMemory()
        {
            comp.Memory("Regular memory");
        }

        protected override void AddMotherBoard()
        {
            comp.AddMotherBoard("Regular MotherBoard");
        }

        protected override void Addprocessor()
        {
            comp.Addprocessor("Regular processor");
        }
    }
}

