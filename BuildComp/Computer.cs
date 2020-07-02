using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuildComp
{
    public class Computer
    {
        private List<String> details = new List<String>();

        public Computer()
        {
//???
        }

        public void AddBox(String box)
        {
            details.Add(box);
        }

        public void AddMotherBoard(String board)
        {
            details.Add(board);
        }

        public void Addprocessor(String processor)
        {
           details.Add(processor);
        }

        public void AddGraphicCard(String graphicCard)
        {
            details.Add(graphicCard);
        }

        public void Memory(String memory)
        {
            details.Add(memory);
        }
    }
}

