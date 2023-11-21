
//-------------------------------------------------------------BEFORE--------------------------------------------------
//#region DIP_START
//public class Master
//{
//    public void FixCar() { }
//    public void PaintCar() { }
//}


//public class Service 
//{
//    public Master master { get; set; }

//    public void BuyCar() { }
//}
//#endregion DIP_END


//-------------------------------------------------------------AFTER--------------------------------------------------
#region DIP_START

public interface ICarFunctionality 
{
    public void FixCar();
    public void PaintCar();
}
public class Master : ICarFunctionality
{
    public void FixCar()
    {
        throw new NotImplementedException();
    }

    public void PaintCar()
    {
        throw new NotImplementedException();
    }
}
public class Service
{
    public ICarFunctionality carFunctionality { get; set; }
    public void BuyCar() { }
}
#endregion DIP_END

//Bu exampilin menasi o demekdir ki,yeni ki bizim high-level klasimiz low-level klasimizdan asili olmali deyil.Bir baseden yeni ki ya
//abstract clasdan yada interfaceden asili olmalidir.Burdaki klaslardada onu gorusuz high-level klasin low-level klasdan asililigi aradan qaldirilir.
