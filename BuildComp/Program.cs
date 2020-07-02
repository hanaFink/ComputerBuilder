using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuildComp
{
    class Program
    {
        static void Main(string[] args)
        {
            {
                List<CompBuilder> complab = new List<CompBuilder>();
                complab.Add(new GameCompBuilder());
                complab.Add(new HomeCompBuilder());
                complab.Add(new OfficeCompBuilder());

                Computer comp = AssembComp(complab[0]);
                Computer comp1 = AssembComp(complab[0]);
                Computer comp2 = AssembComp(complab[0]);
            }
        }
            static Computer AssembComp(CompBuilder builder)
            {
                builder.AssemblingComp();
                return builder.doComputer();
            }
    }
}
