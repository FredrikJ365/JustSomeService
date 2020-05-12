using System;

namespace src.Models
{
    public class NumberViewModel
    {
        public int RandomUnsignedByteNumber
        {
            get
            {
                return new Random().Next(256);
            }
        }
    }
}