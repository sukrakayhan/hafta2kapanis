/* 1 - Aşağıdaki çıktıyı yazan bir program.

Merhaba
Nasılsın ?
İyiyim
Sen nasılsın ? */
// ----------- CEVAP -----------------
 Console.WriteLine("Merhaba");
Console.WriteLine("Nasılsın ?");
Console.WriteLine("İyiyim");
Console.WriteLine("Sen nasılsın ?"); 

// -----------------------------------------------
//2 - Bir adet metinsel, bir adet tam sayı verisi tutmak için 2 adet değişken tanımlayınız. Bunların değerlerini atayıp , ekrana yazdırınız.
 string text = "Merhaba, bu deneme mesajıdır.";
int number = 10;
Console.WriteLine(text);
Console.WriteLine(number); 
// -----------------------------------------------
//3 - Rastgele bir sayı üretip , ekrana yazdırınız.
Random random = new Random();
int randomNumber = random.Next(1,100);
Console.WriteLine(randomNumber);
// -----------------------------------------------
//4 - Rastgele bir sayı üretip , bunun 3'e bölümünden kalanı ekrana yazdırınız.
Random random = new Random();
int randomNumber = random.Next(1, 100);
int divNumber = randomNumber % 3;
Console.WriteLine(randomNumber);
Console.WriteLine(divNumber);
// -----------------------------------------------
//5 - Kullanıcıya yaşını sorup, 18'den büyükse "+" küçükse "-" yazdıran bir uygulama.
Console.WriteLine("Kaç yaşındasınız : ");
int age = Convert.ToInt32(Console.ReadLine());
if(age >=18)
{
    Console.WriteLine("+");
}
else Console.WriteLine("-");
// -----------------------------------------------
//6 - Ekrana 10 defa " Sen Vodafone gibi anı yaşarken , ben Turkcell gibi seni her yerde çekemem." yazan bir uygulama.
Console.WriteLine("Sen Vodafone gibi anı yaşarken, ben Turkcell gibi seni her yerde çekemem.");
}
// -----------------------------------------------
//7 - Kullanıcıdan 2 adet metinsel değer alıp "Gülse Birsel" , "Demet Evgar" , bunların yerlerini değiştiriniz.
Console.WriteLine("1. Kullanıcının adını soyadını giriniz: ");
string text1 = Console.ReadLine();
Console.WriteLine("2. Kullanıcının adını soyadını giriniz: ");
string text2 = Console.ReadLine();
string temp;
temp = text1;
text1 = text2;
text2=temp;
Console.WriteLine($"1. nin değiştirilmiş hali {text1}");
Console.WriteLine($"2. nin değiştirilmiş hali {text2}");

// -----------------------------------------------
//8 - Değer döndürmeyen ismi BenDegerDondurmem olan bir metot tanımlayınız. Ekrana "Ben değer döndürmem , benim bir karşılığım yok , beni değişkene atamaya çalışma" yazsın.

void BenDegerDondurmem()
{
    Console.WriteLine("Ben değer döndürmem , benim bir karşılığım yok , beni değişkene atamaya çalışma");
}
BenDegerDondurmem();
//9-İki sayıyı alıp bunların toplam değerini geriye döndüren bir metot yazınız.
int Topla(int number1, int number2)
{
    return number1 + number2;
}
Console.WriteLine(Topla(10,15));
// -----------------------------------------------
//10 - Kullanıcıdan true ya da false değeri alıp string bir değer dönen bir metot tanımlayınız.
string IsItTrue(ref string text)
{
    return text;
}
Console.WriteLine("True or False");
string text = Console.ReadLine();
Console.WriteLine(IsItTrue(ref text));
// -----------------------------------------------
//11 - 3 Kişinin yaşlarını alıp en yaşlı olanının yaş bilgisini dönen bir metot yazınız.
Console.WriteLine("1. kullanıcın yaşını giriniz : ");
int age1=Convert.ToInt32(Console.ReadLine());
Console.WriteLine("2. kullanıcın yaşını giriniz : ");
int age2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("3. kullanıcın yaşını giriniz : ");
int age3 = Convert.ToInt32(Console.ReadLine());

int isOld = Math.Max(age1, age2);
int old = Math.Max(isOld, age3);
Console.WriteLine($"En yaşlı kullanıcı {old} yaşında.");
// -----------------------------------------------
//12 - Kullanıcıdan sınırsız sayıda sayı alıp , bunlardan en büyüğünü ekrana yazdıran ve aynı zamanda geriye dönen bir metot yazınız.
int FindMaxNumber()
{
    int max = int.MinValue; // Başlangıçta en küçük değeri alıyoruz.
    while (true)
    {
        Console.WriteLine("Bir sayı girin. Bitirmek için 'q' ya basınız. ");
        string input = Console.ReadLine();

        if (input == "q") // Kullanıcı q yazarsa döngöden çıkar.
        {
            break;
        }
        if (int.TryParse(input, out int number)) // Girdi bir sayı mı kontrol edilir.
        {
            if (number > max)
            {
                max = number;
            }
        }
        else
        {
            Console.WriteLine("Geçerli bir sayı giriniz.");
        }
    }
        Console.WriteLine($"En büyük sayı {max}");
        return max;
}
FindMaxNumber();

// -----------------------------------------------
//13 - Bir metot yardımıyla kullanıcıdan alınan 2 ismin yerlerini değiştiren uygulamayı yazınız.
Console.WriteLine("1. İsmi giriniz. ");
string name1=Console.ReadLine();
Console.WriteLine("2. İsmi giriniz. ");
string name2=Console.ReadLine();

SwapNames(ref name1, ref name2);
Console.WriteLine($"Yer değiştirildikten sonra 1. İsim: {name1}");
Console.WriteLine($"Yer değiştirildikten sonra 2. İsim: {name2}");

static void SwapNames(ref string name1, ref string name2)
{
    string temp = name1;
    name1 = name2;
    name2 = temp; 
}
// -----------------------------------------------
// 14 - Kullanıcıdan alınan sayının tek mi yoksa çift mi olduğu bilgisini (true/false) dönen bir metot.
Console.WriteLine("Bir sayı giriniz : ");
string input = Console.ReadLine();
if(int.TryParse(input, out int number))
{
    int div = number %2;
    if(div == 0)
    {
        Console.WriteLine($"Girdiğiniz {number} sayısı çift sayıdır.");
    }
    else
    {
        Console.WriteLine($"Girdiğiniz {number} sayısı tek sayıdır.");
    }
}
else
    Console.WriteLine("Htalı giriş yaptınız."); 
// -----------------------------------------------
//15 - Kullanıcıdan alınan hız ve zaman bilgileriyle , gidilen yolu hesaplayan bir metot yazınız.
Console.WriteLine("Ortalama hızınızı giriniz (km/saat)");
int speed = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Kaç dakikadır yoldasınız?");
int time = Convert.ToInt32(Console.ReadLine());
int road = (time * speed) / 60 ;
Console.WriteLine($"Gidilen yol {road} km");
// -----------------------------------------------
//16 - Yarıçap bilgisi verilen bir dairenin alanını hesaplayan bir metot yazınız.
Console.WriteLine("Hesaplanacak dairenin yarıçapı kaç cm ?");
double radius = Convert.ToDouble(Console.ReadLine());
double area = CalculateCircleArea(radius);
Console.WriteLine($"Dairenin alanı {area:F2}"); // Alanı iki ondalık sayı olarak gösteriyoruz.

double CalculateCircleArea(double radius)
{
    if (radius < 0)
    {
        Console.WriteLine("Yarıçap negatif olamaz. Pozitif değer giriniz.");
        return 0;
    }
    else
    {
        double area = Math.PI*Math.Pow(radius, 2); // Alan= π * r^2
        return area;
    }
}
// -----------------------------------------------
//17 - "Zaman bir GeRi SayIm" cümlesini alıp, hepsi büyük harf ve hepsi küçük harfle yazdırınız.

string text = "Zaman bir GeRi SayIm";
string toLowerText = text.ToLower();
string toUpperText = text.ToUpper();

Console.WriteLine(toLowerText); // Hepsi küçük yazıyor.
Console.WriteLine(toUpperText); // Hepsi büyük yazıyor. 
// -----------------------------------------------
//18 - "    Selamlar   " metnini bir değişkene atayıp , başındaki ve sonundaki boşlukları siliniz. Kalıcı olarak.
string text = "    Selamlar   ";
string trimText=text.Trim();
Console.WriteLine(trimText);