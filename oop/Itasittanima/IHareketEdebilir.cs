using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Itasittanima
{
    internal interface IHareketEdebilir
    {
        public void Ilerle();
        public void Dur();
    }
    internal class Araba : IHareketEdebilir
    {
        public void Ilerle()
        {
            Console.WriteLine("Araba ilerliyor.");
        }
        public void Dur()
        {
            Console.WriteLine("Araba duruyuor.");
        }
    }
    internal class Bisiklet : IHareketEdebilir
    {
        public void Ilerle()
        {
            Console.WriteLine("Bisiklet pedalı çeviriliyor");
        }
        public void Dur()
        {
            Console.WriteLine("Bisiklet duruyor.");
        }
    }
    internal class Ucak : IHareketEdebilir
    {
        public void Ilerle()
        {
            Console.WriteLine("Ucak pistten kalkıyor.");
        }
        public void Dur()
        {
            Console.WriteLine("Ucak inise gecti.");
        }
    }

}
