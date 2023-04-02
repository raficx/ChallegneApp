using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChalengeApp
{
    internal class Latarka
    {
        public bool Wlaczona { get; set; } = false;
        public string Kolor { get; set; } = "Czarna";
        public void Wlacz()
        {
            this.Wlaczona = true;
        }
        public void Wylacz()
        {
            this.Wlaczona = false;
        }
    }
}
