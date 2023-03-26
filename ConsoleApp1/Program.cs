

using ConsoleApp1;

Doctor Therapyst = new Doctor()
{
    Name = "Василий",
    Post = "Заведующий отделением",
    Specialization = "Терапевт"
};

Doctor Surgeon = new Doctor()
{
    Name = "Михаил",
    Post = "Дежурный врач",
    Specialization = "Хирург"
};

Pacient pacient = new Pacient()
{
    Name = "Максим",
    Pol = "Мужской",
    Age = "25"
};

Console.WriteLine("Обращение : ");
Console.WriteLine("1.Иммунитет");
Console.WriteLine("2.Часть тела");
 var Inicialization  = Console.ReadLine();
int ToConvert = Convert.ToInt32(Inicialization);

if (ToConvert == 1  ) 
{
    Random rnd = new Random();
    int value = rnd.Next(0, 1);
    if (value == 1)
    {
        var Cons = pacient.Status;
        Therapyst.Analiz(value);
        var buyMedicaments = pacient.BuyMedicaments;
        var godBuy = Therapyst.GoodBuy;
    }
    else { Therapyst.Analiz(value);
        var godBuy = Therapyst.GoodBuy;
    }
     
       
}
else {
    Random rnd = new Random();
    int value = rnd.Next(0, 1);
    if (value == 1)
    {
        var Cons = pacient.Status;
        Surgeon.Analiz(value);
        var buyMedicaments = pacient.BuyMedicaments;
        var godBuy = Therapyst.GoodBuy;
    }
    else if (value == 0)
    {
        Therapyst.Analiz(value);
        var godBuy = Therapyst.GoodBuy;
    }
}


