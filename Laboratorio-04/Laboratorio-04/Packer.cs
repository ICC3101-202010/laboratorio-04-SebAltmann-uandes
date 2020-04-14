using System;
using System.Collections.Generic;
namespace Laboratorio04
{
    public class Packer : Machine
    {
        public List<Piece> Memory;

        public Packer(List<Piece> memory)
        {
            this.Memory = memory;
        }

        public override void Encendido()
        {
            throw new NotImplementedException();
        }

        public override void Reinicio()
        {
            throw new NotImplementedException();
        }

        public override void Apagado()
        {
            throw new NotImplementedException();
        }
    }
}
