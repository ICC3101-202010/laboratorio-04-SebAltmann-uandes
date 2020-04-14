using System;
using System.Collections.Generic;

namespace Laboratorio04
{
    public class Receptor : Machine
    {
        public List<Piece> Memory;

        public Receptor(List<Piece> memory)
        {
            this.Memory = memory;
        }

        public override void Encendido()
        {
            throw new NotImplementedException();
        }

        public override void Reinicio()
        {
            foreach (Piece piece in Memory)
            {
                Memory.Remove(piece);
            }
        }

        public override void Apagado()
        {
            throw new NotImplementedException();
        }
    }
}
