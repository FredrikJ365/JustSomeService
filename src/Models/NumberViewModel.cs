using System;

namespace src.Models
{
    public class NumberViewModel
    {
        public int RandomNumber
        {
            get
            {
                return new Random().Next(256);
            }
        }
    }
}