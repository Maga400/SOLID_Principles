
//-------------------------------------------------------------BEFORE--------------------------------------------------
#region LSP_START
//public class Info
//{
//    public virtual void Show() 
//    {
//        //Show info
//    }
//    public virtual void Cut() 
//    {
//        //Cut info
//    }
//}

//public class CutInfo:Info
//{
//    public override void Show()
//    {
//        throw new Exception("Bu klasda sadece info kesiler biler gosterile bilmez");
//    }
//}


//class AllInfo
//{
//    private List<Info> _info;

//    public void CutAll()
//    {
//        foreach (var info in _info)
//            info.Cut();
//    }
//    public void ShowAll()
//    {
//        foreach (var info in _info)
//            if (info is not CutInfo)
//                info.Show();
//    }
//}
#endregion LSP_END


//-------------------------------------------------------------AFTER--------------------------------------------------
#region LSP_START
public class Info
{
    public virtual void Cut()
    {
        //Cut info
    }
}


public class ShowInfo : Info 
{
    public virtual void Show()
    {
        //Show info
    }
}

class AllInfo
{
    private List<Info> _info;
    private List<ShowInfo> _showInfo;

    public void CutAll()
    {
        //Siline bilen infolari gosteririk
    }
    public void ShowAll()
    {
        //Gosterile bilen infolari gosteririk
    }
}
#endregion LSP_END

//Bu exampilin menasi o demekdir ki,Derived klas base klasi evez ede bilsin yeni ki tam Base klas kimi olmasada onu en azindan normal 
//seviyyede idare ede bilsin,yola vere bilsin.Bu kodda o gosterilirki biz base klasda virtual method yaradiriq ve hemin base klasda bir klas 
//toredirik amma bu klasin basedeki bir virtual methodda ehtiyaci yoxdu bu zaman bizde problem bas verir ona gorede biz base klasi ele yaradiriqki
//derived klaslarin her biri onun daxilindeki virual methodu isletsin ve elave hansisa bir method lazimdirsa ozu yaratsin bu zamman bizde kodda duzgun isleyecek
//amma kohne versiyada mesel ucun derived klas base klasin bir virtual methodun isletmir ve base klasi hemin derived klas evez elemeli oldu buz zamn o onu evez ede bilmeyecek
//problem bas verecek amma biz baseni ele cur yaradirqkki bu virtual methodu her bir derived isletecek ve her hansisa bir derived klasa elave
//method lazimdirsa ozu yaradacaq ve bu zaman bizde derived klas base klasi evez ede bilecek ve bizde problem olmayacaq.