using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IOLAB {
    public class Directory 
    {
        public string theMachineStops { get; set; }
        public string TelegramCopy { get; set; }
        public Directory()
        {
            theMachineStops = @"C:\Users\FeiFei\Desktop\IOLAB\theMachineStops.cs";
            TelegramCopy = @"C:\Users\FeiFei\Desktop\IOLAB\TelegramCopy.txt";
        }
    }
   
}

