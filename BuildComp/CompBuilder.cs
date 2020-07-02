using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuildComp
{
    public abstract class CompBuilder
    {
       
            protected Computer comp;

            public Computer doComputer()
            {
                if (comp == null)
                    throw new CompDidNotDoneYet("Computer is not done yet");

                return comp;
            }

            public void AssemblingComp()
            {
                this.comp = new Computer();
                AddBox();
                AddMotherBoard();
                Addprocessor();
                AddGraphicCard();
                AddMemory();
            }

            protected abstract void AddBox();

            protected abstract void AddMotherBoard();

            protected abstract void Addprocessor();

            protected abstract void AddGraphicCard();

            protected abstract void AddMemory();
        
    }
}
