
//-------------------------------------------------------------BEFORE--------------------------------------------------
//#region OCP_START
//public class Student
//{
//    public int Id { get; set; }
//    public string Name { get; set; }
//    public string Surname { get; set; }
//    public int Age { get; set; }
//    public Student(int ıd, string name, string surname, int age)
//    {
//        Id = ıd;
//        Name = name;
//        Surname = surname;
//        Age = age;
//    }
//}

//public class Academy 
//{
//    public string Name { get; set; }
//    public string SearchType { get; set;}
//    public List<Student> Students { get; set; }
//    public Academy(string name, List<Student> students, string searchType)
//    {
//        Name = name;
//        Students = students;
//        SearchType = searchType;
//    }

//    public bool SearchStudent() 
//    {
//        if(SearchType == "name") 
//        {
//            //Ada gore axtarma;

//        }
//        else if(SearchType == "surname") 
//        {
//            //Soyada gore axtarma
//        }

//        return true;
//    }
//}

//#endregion OCP_END


//-------------------------------------------------------------AFTER--------------------------------------------------
#region OCP_START
public class Student
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Surname { get; set; }
    public int Age { get; set; }
    public Student(int ıd, string name, string surname, int age)
    {
        Id = ıd;
        Name = name;
        Surname = surname;
        Age = age;
    }
}

public interface ISearch
{
    public bool Search(Academy academy,object text);
}

public class NameSearch : ISearch
{
    public bool Search(Academy academy,object text)
    {
        if (academy.Students[0].Name == text) 
        {
            //Axtarisa uygun deyer qaytarir
        }

        return true;
    }
}

public class AgeSearch : ISearch
{
    public bool Search(Academy academy, object text)
    {
        if (academy.Students[0].Age == Convert.ToInt32(text))
        {
            //Axtarisa uygun deyer qaytarir
        }

        return true;
    }
}

public class Academy
{
    public string Name { get; set; }
    public ISearch SearchType { get; set; }
    public List<Student> Students { get; set; }
    public Academy(string name, List<Student> students, ISearch searchType)
    {
        Name = name;
        Students = students;
        SearchType = searchType;
    }
    public bool SearchStudent(object text)
    {
        return SearchType.Search(this,text);
    }
}

#endregion OCP_END

//Bu principin for example -da,Men bir Academy klasi yaradiram ve telebelerim olur search methodu daxilinde men search type gore axtaris eliyirem
//eyer search type namedirse nameye gore telebe axtariram ve s.Sabah mende surnameye gore olsa men birde gerek kohne kodumda proyekt daxilinde ne qeder
//seyi deyisim.Ona gorede burada Open Closed principi ortaya girir ve biz kodumuzu deyisikliklere yeni ki update aciq bir formayi getiririk
//ve kohne kodda hec ne deyismirik.Ona gorede men bir dene search interface yaradiram ve onun daxilinde search typem namedirse nameye gore agedirse ageye gore
//searchingimi aparib geri deyer qaytariram ve academy clasimda da he bir ifle yoxlama etmeden duzgun sekilde isim icra olunur.
