using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Revisao
{
    internal class Casa :Edificacao
    {
        public bool FoiContruida { get; set; }
        public override string Nome { get; set; } 
        public override void Info()
        {

        }
    }
}
