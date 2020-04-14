using System;
using System.Collections.Generic;
namespace Laboratorio04
{
    public class QualityAssurer : Machine
    {
        public List<Piece> Memory;

        public QualityAssurer(List<Piece> memory)
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
