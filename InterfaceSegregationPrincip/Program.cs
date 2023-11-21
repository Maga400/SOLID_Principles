
//-------------------------------------------------------------BEFORE--------------------------------------------------
#region ISP_START

//public interface IInformation
//{
//    public void aboutWeather();
//    public void aboutCar();
//    public void aboutAnimal();
//    public void aboutPeople();
//    public void aboutBus();
//    public void aboutShip();
//}

//public class allDataChannel : IInformation
//{
//    public void aboutAnimal()
//    {
//        throw new NotImplementedException();
//    }

//    public void aboutBus()
//    {
//        throw new NotImplementedException();
//    }

//    public void aboutCar()
//    {
//        throw new NotImplementedException();
//    }

//    public void aboutPeople()
//    {
//        throw new NotImplementedException();
//    }

//    public void aboutShip()
//    {
//        throw new NotImplementedException();
//    }

//    public void aboutWeather()
//    {
//        throw new NotImplementedException();
//    }
//}

//public class animalChannel : IInformation
//{
//    public void aboutAnimal()
//    {
//        throw new NotImplementedException();
//    }

//    public void aboutBus()
//    {
//        throw new NotImplementedException();
//    }

//    public void aboutCar()
//    {
//        throw new NotImplementedException();
//    }

//    public void aboutPeople()
//    {
//        throw new NotImplementedException();
//    }

//    public void aboutShip()
//    {
//        throw new NotImplementedException();
//    }

//    public void aboutWeather()
//    {
//        throw new NotImplementedException();
//    }
//}

#endregion ISP_END


//-------------------------------------------------------------AFTER--------------------------------------------------
#region İSP_START
public interface ILivingThingsInformation
{
    public void aboutPeople();
    public void aboutAnimal();
}

public interface IWeatherInformation
{
    public void aboutWeather();
}
public interface IVehicleInformation
{
    public void aboutCar();
    public void aboutBus();
    public void aboutShip();
}

public class AllDataChannel : IWeatherInformation, IVehicleInformation, ILivingThingsInformation
{
    public void aboutAnimal()
    {
        throw new NotImplementedException();
    }

    public void aboutBus()
    {
        throw new NotImplementedException();
    }

    public void aboutCar()
    {
        throw new NotImplementedException();
    }

    public void aboutPeople()
    {
        throw new NotImplementedException();
    }

    public void aboutShip()
    {
        throw new NotImplementedException();
    }

    public void aboutWeather()
    {
        throw new NotImplementedException();
    }
}

public class Vehicle : IVehicleInformation
{
    public void aboutBus()
    {
        throw new NotImplementedException();
    }

    public void aboutCar()
    {
        throw new NotImplementedException();
    }

    public void aboutShip()
    {
        throw new NotImplementedException();
    }
}

#endregion ISP_END

//Bu exampilin menasi o demekdir ki, yeni ki menim bir interfacem var ve daxilinde coxlu method saxliyir menim bir klasim var ve bu klasa
//interface daxilindeki butun methodlar lazimdi ve ondan impliment edir mesel ucun mende bir dene de klas var ve bu klasa sadece interfaceden bir method lazimdir
//ve biz bu klasi interfaceden toredende onun daxilindeki butun methodlar gelir ve bizde lazimsiz methodlar yaranir.Bu zaman bizim qabagimiza
//Interface Segregation Princip cixir bu prinsipde bize soylenirki bacardiqiniz qeder interfaceleri bolun yeni ki kiciltin ona gorede men 
//interfacemi 3 hisseye boldum ve her bir interfacede mentiqen mene lazim olacaq methodlari qruplasdirdim.