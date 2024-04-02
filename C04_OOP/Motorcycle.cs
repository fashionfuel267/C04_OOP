using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C04_OOP
{
    internal sealed class Motorcycle : TwoWheeler
    { 
        public string StartingMethod{get;set;}
        public decimal BPH { get; set; }
        public decimal KMPL { get; set; }
        public decimal Cooling { get; set; }
        public int FrontBreak { get; set; }
        public int RearBreak { get; set; }
    }
}
