using Oshxona;

SALOM:
IshBoshqaruvchi ishBoshqaruvchi = new IshBoshqaruvchi();
OshxonaMalumotlari oshxonaMalumotlari = new OshxonaMalumotlari();
Console.WriteLine("===========Bizning Behruz Burgirga xush kelibsiz=========");
Console.WriteLine("      1)Bitta Fasfud olish");
Console.WriteLine("      2)Bizning Fasfudlar");
Console.WriteLine("      3)Siz olmoqchi bulgan Fasfud haqida");
Console.WriteLine("      4)Admin uchun");
Console.WriteLine("bulimni tanlang (eslatma: 1, 2, 3, 4 kommandalarini kiriting)");
int kommanda = int.Parse(Console.ReadLine());
if (kommanda == 1)
{
    Console.WriteLine("Fasfud nomini kiriting");
    string fasfud_nomi = Console.ReadLine();
    oshxonaMalumotlari.BittaMalumotniOlish(fasfud_nomi);
}
if (kommanda == 2)
{
    oshxonaMalumotlari.BarchaMalumotlarniOlish();
}
else if (kommanda == 3)
{
    bool natija1 = true;
    bool natija2 = true;
    Console.WriteLine("Fasfud nomini kiriting: ");
    string fasfudNomi = Console.ReadLine();
    if (oshxonaMalumotlari.TekshirFasfudNomini(fasfudNomi))
    {
        natija1 = false;
    }
    Console.WriteLine("Fasfud narxini kiriting: ");
    decimal fasfudNarxi = decimal.Parse(Console.ReadLine());
    if (oshxonaMalumotlari.TekshirFasfudNarxini(fasfudNarxi))
    {
        natija2 = false;

    }
    if (natija1 == false && natija2 == false)
    {
        System.Console.WriteLine("siz istagan fasfud bizda mavjud");

    }
    else
    {
        Console.WriteLine("siz istagan fasfud bizda mavjud emas");

    }
}
else if (kommanda == 4)
{
    Console.WriteLine("Parolni kiriting:");
    ishBoshqaruvchi.Kod(Console.ReadLine());
    Console.WriteLine("====== Admin qilishi mumkin bulgan ishlar ========");
    Console.WriteLine("      1)Bazadagi ma'lumotlarni olish");
    Console.WriteLine("      2)Bazadagi ma'lumotlarni uchirish");
    Console.WriteLine("      3)Bazadagi ma'lumotlarni qushish");
    Console.WriteLine("      4)Barcha ma'lumotlarni uchirish");
    int kommanda1 = int.Parse(Console.ReadLine());
    if (kommanda1 == 1)
    {
        oshxonaMalumotlari.BarchaMalumotlarniOlish();
    }
    if (kommanda1 == 2)
    {
        Console.WriteLine("Fasfud nomini kiriting: ");
        string fasfudnomi = Console.ReadLine();
        oshxonaMalumotlari.BittaFasfudniUchir(fasfudnomi);
    }
    if (kommanda1 == 3)
    {
        Console.WriteLine("Fasfud nomini kiriting: ");
        string fasfudnomi = Console.ReadLine();
        Console.WriteLine("Telifon narxini kiriting: ");
        decimal fasfudnarxi = decimal.Parse(Console.ReadLine());
        oshxonaMalumotlari.FasfudniQushish(fasfudnomi, fasfudnarxi);

    }
    if (kommanda1 == 4)
    {
        oshxonaMalumotlari.BarchaFasfudniUchir();
    }
    Console.WriteLine("Bazaga qushilgandan keyingi ma'lumotlar");
    oshxonaMalumotlari.BarchaMalumotlarniOlish();
}
goto SALOM;
//Bu funksiya oshxonaning funksiyasi
//Bu yerda kuplab sodda funksiyalar bor
//Misol uchun quyidagilar: 
//Siz olmoqchi bulgan Fasfud haqida
//Bizning Fasfudlar
//Bitta Fasfud olish
//
//Admin uchun quyidagilar
//Bazadagi ma'lumotlarni olish
//Bazadagi ma'lumotlarni uchirish
//Bazadagi ma'lumotlarni qushish
//Barcha ma'lumotlarni uchirish