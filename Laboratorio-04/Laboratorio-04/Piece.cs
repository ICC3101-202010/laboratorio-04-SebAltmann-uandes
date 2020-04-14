using System;
namespace Laboratorio04
{
    public class Piece
    {
        private string Name;
        public bool WasRecieved = false;
        public bool IsStored = false;
        public bool IsAssembled = false;
        public bool Quality = false;
        public bool IsPacked = false;

        public Piece(String name)
        {
            this.Name = name;
        }
    }
}
