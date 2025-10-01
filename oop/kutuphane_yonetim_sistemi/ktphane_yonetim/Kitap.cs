using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ktphane_yonetim
{
    internal class Kitap
    {
        private int _sayfa;
        public int Id { get; set; }
        public string Ad { get; set; }
        public string Yazar { get; set; }
        public int SayfaSayisi { get { return _sayfa; }
            set
            {
                if (value > 0)
                {
                    _sayfa = value;
                }
                else { throw new ArgumentOutOfRangeException("0 dan buyuk olmalı.");
                }
            }
        }
        public override string ToString()
        {
            return $"{Id} - {Ad} | {Yazar} | {SayfaSayisi} sayfa";
        }

    }
}