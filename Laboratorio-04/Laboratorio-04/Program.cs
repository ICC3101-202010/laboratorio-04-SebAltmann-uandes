using System;
using System.Collections.Generic;

namespace Laboratorio04
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Receptor PR = new Receptor(null);
            Storage PS = new Storage(null);
            ObjectAssembler OA = new ObjectAssembler(null);
            QualityAssurer QA = new QualityAssurer(null);
            Packer PP = new Packer(null);
        }
    }
}
