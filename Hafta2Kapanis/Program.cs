using System.ComponentModel.DataAnnotations;
using System.ComponentModel.Design;
using System.Diagnostics.CodeAnalysis;
using System.Diagnostics.Metrics;
using System.Formats.Asn1;
using System.Threading.Channels;

Console.WriteLine(@"
Merhaba
Nasılsın ?
İyiyim
Sen nasılsın ?");

////Bir adet metinsel , bir adet tam sayı verisi tutmak için
////2 adet değişken tanımlayınız. Bunların değerlerini atayıp ,
////ekrana yazdırınız.
string hey = "hey ";
int a = 0;
Console.WriteLine(hey + a);


////Rastgele bir sayı üretip , ekrana yazdırınız
Random r = new Random();
Console.WriteLine(r.Next());

////Rastgele bir sayı üretip , bunun 3'e bölümünden
////kalanı ekrana yazdırınız.
Random r2 = new Random();
Console.WriteLine(r2.Next() % 3);


////Kullanıcıya yaşını sorup , 18'den
////büyükse "+" küçükse "-" yazdıran bir uygulama.
Console.Write("Yaşınızı giriniz: ");
int yas = Convert.ToInt32(Console.ReadLine());
switch (yas)
{
    case < 18:
        Console.WriteLine("-");
        break;

    case > 18:
        Console.WriteLine("+");
        break;
    default:
        Console.WriteLine("Yaşınız 18");
        break;
}


////Ekrana 10 defa " Sen Vodafone gibi anı yaşarken ,
////ben Turkcell gibi seni her yerde çekemem."
////yazan bir uygulama.

int counter = 0;
while (counter < 10)
{
    Console.WriteLine("Sen Vodafone gibi anı yaşarken,\n ben Turkcell gibi seni her yerde çekemem");
    counter++;
}

// Kullanıcıdan 2 adet metinsel değer alıp "Gülse Birsel" ,
// "Demet Evgar" , bunların yerlerini değiştiriniz.
string str1 = "Gülse Birsel";
string str2 = "Demet Evgar";
string str3 = string.Empty;
str3 = str1;
str1 = str2;
str2 = str3;





////Değer döndürmeyen ismi BenDegerDondurmem olan bir metot tanımlayınız.
////Ekrana "Ben değer döndürmem , benim bir karşılığım yok ,
////beni değişkene atamaya çalışma" yazsın.
void BenDegerDondurmem()

{
    Console.WriteLine("Ben değer döndürmem , benim bir karşılığım yok , \nbeni değişkene atamaya çalışma");

}

////İki sayıyı alıp bunların toplam değerini geriye döndüren bir metot yazınız.

static int Toplam(int sayi1, int sayi2)
{
    int toplam = sayi1 + sayi2;
    Console.WriteLine(" \n" + toplam);
    return toplam;
}

Toplam(8, 12);


////Kullanıcıdan true ya da false değeri alıp string bir değer dönen bir metot tanımlayınız.
static string StrDoner(bool x)
{
    if (x == true)
    {
        string dogru = "true";
        Console.WriteLine(dogru);
        return dogru;
    }
    else
    {
        string yanlis = "false";
        Console.WriteLine(yanlis);
        return yanlis;
    }
}

StrDoner(true);



////3 Kişinin yaşlarını alıp en yaşlı olanının yaş bilgisini dönen bir metot yazınız.

static int Buyuk(int m, int n, int z)
{

    int enBuyuk = 0;
    if ((m > n) && (m > z))
    {
        enBuyuk = m;
        return enBuyuk;
    }


    else if ((n > m) && (n > z))
    {
        enBuyuk = n;
        return enBuyuk;
    }
    else if ((z > m) && (z > n))
    {
        enBuyuk = z;
        return enBuyuk;
    }
    else;
    return 0;

}

int enBuyuk = Buyuk(18, 34, 78);
Console.WriteLine(enBuyuk);

//// Kullanıcıdan sınırsız sayıda sayı alıp , bunlardan en büyüğünü
//// ekrana yazdıran ve aynı zamanda geriye dönen bir metot yazınız.



static int EnBuyuk()
{
    int sayii = 0;
    int max = 0;
    Console.WriteLine("Sayılar bittiğinde -1 ile çıkış yapabilirsiniz");
    do
    {
        sayii = int.Parse(Console.ReadLine());
        if (sayii > max)
        {
            max = sayii;

        }
        else
        {

        }

    }

    while (!(sayii == -1));
    return max;
}


int enBuyukMethod = EnBuyuk();
Console.WriteLine(enBuyukMethod);


////Bir metot yardımıyla kullanıcıdan alınan 2 ismin yerlerini değiştiren uygulamayı yazınız.

Console.WriteLine("iki tane string girin.");
string str4 = Console.ReadLine();
string str5 = Console.ReadLine();

Console.WriteLine(str4);
Console.WriteLine(str5);
SwapStrings(ref str4, ref str5);



static void SwapStrings(ref string str4, ref string str5)
{
    string str6 = string.Empty;
    str6 = str4;
    str4 = str5;
    str5 = str6;
    Console.WriteLine(str4);
    Console.WriteLine(str5);
}

////Kullanıcıdan alınan sayının tek mi yoksa çift mi olduğu bilgisini (true/false) dönen bir metot.
Console.Write("Bir sayı girin: ");
int number = int.Parse(Console.ReadLine());

bool isEven = IsEven(number);
Console.WriteLine("Is the number even ? " + isEven);


static bool IsEven(int number)
{
    return number % 2 == 0;
}


//Kullanıcıdan alınan hız ve zaman bilgileriyle , gidilen yolu hesaplayan bir metot yazınız.
Console.Write("Hızı giriniz: ");
int hiz = int.Parse(Console.ReadLine());
Console.Write("Zamanı  giriniz: ");
int zaman = int.Parse(Console.ReadLine());
int yol;

YoluHesapla(hiz, zaman, out yol);
Console.WriteLine("Yol " + yol + " km");

static void YoluHesapla(int v, int t,out int x)
{
    x = v * t;
}


//Yarıçap bilgisi verilen bir dairenin alanını hesaplayan bir metot yazınız.
Console.WriteLine("Yarıçapı giriniz");
double r = double.Parse(Console.ReadLine());
const double pi = 3.14159265359;
double area;
Area(r, out area);

Console.WriteLine("Dairenin alanı: " + area);
static void Area(double r, out double area)
{ 
    area = r * r * pi; 
}

//"Zaman bir GeRi SayIm" cümlesini alıp , hepsi büyük harf ve hepsi küçük harfle yazdırınız.
string sentence = "Zaman bir GeRi SayIm";
Console.WriteLine(sentence.ToLower());
Console.WriteLine(sentence.ToUpper());

//"    Selamlar   " metnini bir değişkene atayıp , başındaki ve sonundaki boşlukları siliniz. Kalıcı olarak.

string hi = "    Selamlar   ";
string hiTrimmed = hi.Trim();
Console.WriteLine(hiTrimmed);