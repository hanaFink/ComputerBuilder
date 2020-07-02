using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuildComp
{
    class HomeCompBuilder:CompBuilder
    {
        protected override void AddBox()
        {
            comp.AddBox("Thin box");
        }

        protected override void AddGraphicCard()
        {
            comp.AddGraphicCard("Good GraphicCard");
        }

        protected override void AddMemory()
        {
            comp.Memory("Regular memory");
        }

        protected override void AddMotherBoard()
        {
            comp.AddMotherBoard("Very thin MotherBoard");
        }

        protected override void Addprocessor()
        {
            comp.Addprocessor("Regular processor");
        }
    }
}
