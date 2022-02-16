using EXceptionHW;
string[] carType = {"Kia", "Mazda" };
Garage garage = new Garage(carType);
Car c = new Car("Kia", false, true);
Car c1 = new Car("kd", false, true);
Car c2 = new Car("Mazda", false, true);
garage.AddCar(c);
Console.WriteLine(garage.cars[0].Brand);
garage.AddCar(c2);
Console.WriteLine(garage.cars[1].Brand);
garage.FixCar(c);
garage.TakeOutCar(c);
Console.WriteLine(garage.cars[0].Brand);
//Car c3 = new Car();//event- viewer

