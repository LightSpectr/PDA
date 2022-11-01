using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Xml.Linq;

namespace cv3._2
{
    internal class Barva
    {
        private readonly byte red, green, blue;
        private readonly string name;
        private readonly double intensity;

        public Barva(string name, byte red, byte green, byte blue)
        {
            this.name = name;
            this.red = red;
            this.green = green;
            this.blue = blue;
            intensity = (this.red + this.green + this.blue) / 3;
        }

        public string Name
        {
            get { return this.name; }
        }
        public double Intensity
        {
            get { return this.intensity; }  
        }

        public string Hex
        {
            get { return String.Format("#{0}{1}{2}", this.red.ToString("X2"), this.green.ToString("X2"), this.blue.ToString("X2")); }
        }

        public override string ToString()
        {
            return String.Format("{0} (#{1}{2}{3}):{4}", name, red.ToString("X2"), green.ToString("X2"), blue.ToString("X2"), intensity) ;
        }

    }
}
