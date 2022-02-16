using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EXceptionHW
{
    public class Garage: IGarage
    {
        public List<Car> cars = new List<Car>();
        public string[] carTypes;

        public Garage( string[] carTypes)
        {
       
            this.carTypes = carTypes;
        }

        public void AddCar(Car c)
        {
            bool ok = false;
            try
            {
                foreach (Car car in cars)
                {
                    if (car.TotalLost == c.TotalLost && car.Brand == c.Brand &&
                        car.NeedsRepair == c.NeedsRepair)
                        throw new CarAlreadyHereException("We already have this car.."); 
                }
                if (c.TotalLost == true)
                    throw new WeDoNotFixTotalLostException("Sorry but we dont fix total lost..");
                foreach(string carType in carTypes)
                {
                    if (carType == c.Brand)
                        ok = true; 
                        
                }
                if (ok == false)
                    throw new WrongGargeException("We dont taking car of this brand");
                if (c == null)
                    throw new CarNullException("No car was enterd");
                if (c.NeedsRepair == false)
                    throw new RepairMismatchException("This car dont need repair..");
                cars.Add(c);          
            }
          catch
            {
                throw;
            }
        }

        public void FixCar(Car c)
        {
            bool ok = false;
            try
            {
                if(c == null)
                    throw new CarNullException("No car was enterd");
                foreach(Car car in cars)
                {
                    if (c.TotalLost == car.TotalLost && c.NeedsRepair == car.NeedsRepair && c.Brand == car.Brand)
                        ok = true;
                }
                if (ok == false)
                    throw new CarNotInGarageException("The Car is not in the list of the Garage");

                if (c.NeedsRepair == false)
                    throw new RepairMismatchException("This car dont need repair..");
                c.NeedsRepair = false;

            }
            catch (Exception)
            {
                throw;
            }
        }

        public void TakeOutCar(Car c)
        {
            
            bool ok = false;
            try
            {
                if (c == null)
                    throw new CarNullException("No car was enterd");
                foreach (Car car in cars)
                {
                    if (c.TotalLost == car.TotalLost && c.NeedsRepair == car.NeedsRepair
                        && c.Brand == car.Brand)
                    ok = true;

                    
                        
                }
                if (ok == false)
                    throw new CarNotInGarageException("The Car is not in the list of the Garage");
                if (c.NeedsRepair == true)
                    throw new CarNotReadyException("Your car needs repair");
       
                cars.Remove(c);
  
            }
            catch(Exception)
            {
                throw;
            }
        }
    }
}
