using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C0731779_WEEK_04
{
    class Program
    {
        static void Main(string[] args)
        {
   
        }
    }

    class Village
    {
        public Village nextVillage;
        public String VillageName;
        public bool isAstrildeHere = false;
        public Village previousVillage;
    }
    class Countryside
    {
        Village Maple = new Village();
        Village Toronto = new Village();
        Village Ajax = new Village();
        Village First;
        Village Last;

            public void Launch()
        {
            Maple.VillageName = "Maple";
            Maple.nextVillage = Toronto;
            Maple.previousVillage = null;
            Toronto.VillageName = "Toronto";
            Toronto.nextVillage = Ajax;
            Ajax.VillageName = "Ajax";
            Ajax.nextVillage = null;
            Ajax.nextVillage = Toronto;
        }
    }
}
