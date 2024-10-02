Console.WriteLine("Ruya Manavina Hosgeldiniz");
Console.WriteLine("Elma = 2 TL");
Console.WriteLine("Armut = 3 TL");
Console.WriteLine("Cilek = 2 TL");
Console.WriteLine("Muz = 3 TL");
Console.WriteLine("Diger butun meyveler = 4 TL");
Console.WriteLine("Hangi Meyveyi Satin Almak Isterdiniz (Elma/Armut/Cilek/Muz/Diger):");
//Secilen meyvenin adinidaki karekterleri hep kucuk yazmayi saglayan fonksiyon eklendi.
string selectedFruit = Console.ReadLine().ToLower();
// Secilen meyveyi kontrol edip fiyatini yazdiran if else yapisi
if (selectedFruit == "muz")
{
    Console.WriteLine("Sectiginiz meyvenin fiyati :3 tl");
}
else if (selectedFruit == "elma")
{
    Console.WriteLine("Sectiginiz meyvenin fiyati :2 tl");
}
else if (selectedFruit == "armut")
{
    Console.WriteLine("Sectiginiz meyvenin fiyati :3 tl");
}
else if (selectedFruit == "cilek")
{
    Console.WriteLine("Sectiginiz meyvenin fiyati :2 tl");
}
else
{
    Console.WriteLine("Sectiginiz meyvenin fiyati :4 tl");
}

/*
Console.WriteLine("Rüya Manavına Hoşgeldiniz");
Console.WriteLine("Elma = 2 ₺");
Console.WriteLine("Armut = 3 ₺");
Console.WriteLine("Çilek = 2 ₺");
Console.WriteLine("Muz = 3 ₺");
Console.WriteLine("Diğer bütün meyveler = 4 ₺");
Console.WriteLine("Hangi Meyveyi Satın Almak İsterdiniz (Elma/Armut/Çilek/Muz/Diğer):");
   

    // Kullanıcının girdiği meyve adını küçük harfe çeviren fonksiyon

    string selectedFruit = Console.ReadLine().ToLower();

    // Switch-case yapısı ile meyvenin fiyatını kontrol eder
    switch (selectedFruit)
    {
        case "elma":
            Console.WriteLine("Seçtiğiniz meyvenin fiyatı: 2 ₺");
            break;
        case "armut":
            Console.WriteLine("Seçtiğiniz meyvenin fiyatı: 3 ₺");
            break;
        case "çilek":
            Console.WriteLine("Seçtiğiniz meyvenin fiyatı: 2 ₺");
            break;
        case "muz":
            Console.WriteLine("Seçtiğiniz meyvenin fiyatı: 3 ₺");
            break;
        default:
            Console.WriteLine("Seçtiğiniz meyvenin fiyatı: 4 ₺");
            break;
    }

  */

// switch yapisini kullanmak bu uygulama icin daha mantikli cunku okunabilirligi daha yuksek 