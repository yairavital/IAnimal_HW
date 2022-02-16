using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EXceptionHW
{
    public class Car
    {
      

        public string Brand { get; set; }
        public bool TotalLost { get; set; }
        public bool NeedsRepair { get; set; } 
        public Car(string brand, bool totalLost, bool needsRepair)
        {
            Brand = brand;
            TotalLost = totalLost;
            NeedsRepair = needsRepair;
            try
            {
                if (TotalLost == true && NeedsRepair == false)
                    throw new RepairMismatchException("This car dont need repair..");
            }
            catch (Exception )
            {
                throw;
            }
        }


    }
}
