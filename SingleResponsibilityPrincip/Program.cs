
//-------------------------------------------------------------BEFORE--------------------------------------------------
//#region SRP_START
//public class Email
//{
//    public string Email_ { get; set; }
//    public string Password { get; set; }
//    public Email(string email, string password)
//    {
//        Email_ = email;
//        Password = password;
//    }

//    public void ShowEmail()
//    {
//        Console.WriteLine($"Email -> {Email_}\nPassword -> {Password}");
//    }

//    public void SendMessage(string email,string text) 
//    {
//        Console.WriteLine($"{email} - emailine {text} messageniz tam ugurla gonderildi");   
//    }
//}
//#endregion SRP_END


//-------------------------------------------------------------AFTER--------------------------------------------------
#region SRP_START
public class Send 
{
    public void SendMessage(string email, string text)
    {
        Console.WriteLine($"{email} - emailine {text} messageniz tam ugurla gonderildi");
    }
}
public class Email
{
    public string Email_ { get; set; }
    public string Password { get; set; }
    public Email(string email, string password)
    {
        Email_ = email;
        Password = password;
    }
    public void ShowEmail()
    {
        Console.WriteLine($"Email -> {Email_}\nPassword -> {Password}");
    }
}
#endregion SRP_END

//Bu exampilin menasi o demekdir ki ,yeni ki menim bir email klasim var ve bu email klasim ozune xas propertyler qebul edir ve bu propertyleri gosteren
//show methodum var ve birde sendMessage methodum var ki buda email qebul edir ve hemin emaile message gonderir.Biz SIngle Responsibility principine gore bir class bir is gormelidir ona gorede men sendMessage
//methodunu ayrica bir send clasi yaradib onun daxilinde yazdim sabah men sms gondermek istesem send clasind bu isis icra edecem amma men bunu Single principe gore
//ayirmasaydim men gerek Emailde edim ve buda duzgun sayilmir.