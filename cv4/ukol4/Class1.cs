using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cv4
{
    public class Nadrz
    {
        private string id;
        private uint objem;
        private uint stav;

        public Nadrz(string id,uint objem) {
            this.objem = objem;
            this.id = id;
            stav = 0;
        }

        public override bool Equals(object obj)
        {
            if (obj == null) {
                return false;
            }
            if (!(obj is Nadrz)) {
                return false;
            }
            return this.id==((Nadrz)obj).id;
        }

        public override string ToString()
        {
           return this.id + ": " + stav + "/" + objem;
        }

        public uint Stav
        {
            get { return stav; }
            set { stav = value; }
        }

        public uint Objem
        {
            get { return objem; }
            set {
                if (value <= objem) stav = value;
            }
        }

        public string Id {
            get { return id; }
        }

        public void Add(uint hod) {
            if (hod <= (objem - stav))
            {
                stav += hod;
            }
            else {
                throw new NelzeVlozitDoNadrzeException("Nedostatek kapacity");
                }
        }

        public void Remove(uint hod) {
            if (hod <= stav)
            {
                stav -= hod;
            }
            else {
                throw new NelzeOdebratZNadrzeException("Množství nelze odebrat");
            }
        }
        
    }
}
