using System;
using System.Collections.Generic;
namespace Laboratorio04
{
    public class Packer : Machine
    {
        public List<Piece> Memory;
        public bool On = false;

        public Packer(List<Piece> memory)
        {
            this.Memory = memory;
        }

        public override void Encendido()
        {
            On = true;
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
            On = false;
        }
    }
}
