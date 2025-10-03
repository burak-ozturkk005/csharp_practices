using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace not
{
    public class Ogrenci
    {
        private int _not;
        public int Id { get; set; }
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public int Not
        {
            get { return _not; }
            set
            {
                if (value >= 0 && value <= 100)
                    _not = value;
                else
                    throw new ArgumentOutOfRangeException("Not 0-100 arasında olmalı.");
            }
        }
        public override string ToString()
        {
            return $"{Id} - {Ad} {Soyad} | Not: {Not}";
        }

    }
}
