using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Xml.Linq;
using System.Runtime.Serialization;

namespace cv2
{
    internal class Nadrz
    {
        private uint stav;
        private readonly uint kapacita;

        public Nadrz(uint kapacita)
        {
            this.stav = 0;
            this.kapacita = kapacita;
        }

        public uint Stav
        {
            get { return stav; }
            set { stav = value; }
        }

        public void Pridat(uint val)
        {
            if (val + stav <= kapacita)
            {
                stav += val;
            }
            else
            {
                throw new NadrzNelzeProvestOperaciException("Capacity overflow");
            }
        }

        public void Odebrat(uint val)
        {
            if (stav - val >= 0)
            {
                stav -= val;
            }
            else
            {
                throw new NadrzNelzeProvestOperaciException("Quantity is less then 0");
            }
        }

        public override string ToString()
        {
            return "placeholder";
        }

    }

    public class NadrzNelzeProvestOperaciException : Exception
    {
       
        public NadrzNelzeProvestOperaciException(string message)
            : base(message)
        { }

        
    }

}
