using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Autos
{
    class Kocsi
    {
        string gyártmány;
        string típus;
        string rendszám;
        int teljesítmény;

        public string Gyártmány { get => gyártmány; set => gyártmány = value; }
        public string Típus { get => típus; set => típus = value; }
        public string Rendszám { get => rendszám; set => rendszám = value; }
        public int Teljesítmény { get => teljesítmény; set => teljesítmény = value; }

        public Kocsi(string rendszám, string gyártmány, string típus, int teljesítmény)
        {
            this.Gyártmány = gyártmány;
            this.Típus = típus;
            this.Rendszám = rendszám;
            this.Teljesítmény = teljesítmény;
        }

        //-- örökölt tulajdonságot felülírunk (megváltoztatunk) -> polimorfizmus
        public override string ToString()
        {
            return "Rendszám: " + rendszám + ", Gyármány: " + gyártmány + ", Típus: " + típus + ", Teljesítmény: " + teljesítmény + " Kw";
        }
    }
}
