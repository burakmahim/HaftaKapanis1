// 1) merhaba dünya
Console.WriteLine("Merhaba Dünya");

// 2) 2 sayı giriliyor toplamları yazdırılıyor.

Console.Write("Birinci sayiyi giriniz: ");
string numberOne = Console.ReadLine();
bool isnumberOneValid  = int.TryParse(numberOne, out int numberOneValue);

Console.Write("İkinci sayiyi giriniz: ");
string numberTwo = Console.ReadLine();
bool isnumberTwoValid = int.TryParse(numberTwo, out int numberTwoValue);

int num = numberOneValue + numberTwoValue;
Console.WriteLine($"toplam deger {num}");

// 3)  kullanıcıdan yaş bilgisi alınıyor 18 den büyükse yetişkin değilse çocuksunuz çıktısı veriliyor

Console.Write("yaşınızı giriniz: ");
string age = Console.ReadLine();
bool isageValid = int.TryParse(age, out int ageValue);

if (isageValid)
{
    if (ageValue > 18)
    {
        Console.WriteLine("Yetişkinsiniz");
    }
    else
    {
        Console.WriteLine("Çocuksunuz");
    }
}

else
{
    Console.WriteLine("Lütfen geçerli bir sayi giriniz");
}

// 4) kullanıcıdan tam sayı alınıyor sayı çift mi tek mi çıktısı veriliyor.

Console.Write("tam sayi giriniz: ");
string WholeNumber = Console.ReadLine();
bool isWholeNumberValid = int.TryParse(WholeNumber, out int wholeNumberValue);

if (isWholeNumberValid)
{
    if(wholeNumberValue % 2 == 0)
    {
        Console.WriteLine("sayı çifttir.");
    }
    else
    {
        Console.WriteLine("sayı tektir.");
    }
}

else
{
    Console.WriteLine("Sayi giriniz.");
}

// 5) kullanıcıdan sıcaklık derecesi alınıyor buna göre çıktı veriliyor.

Console.Write("Celsius cinsinden bir sıcaklık derecesi giriniz: ");
string degree = Console.ReadLine();
bool isDegreeVlaid = int.TryParse(degree, out int degreeValue);
if (isDegreeVlaid)
{
    if (degreeValue < 0)
    {
        Console.WriteLine("Donuyor");
    }

    else if (0 < degreeValue && degreeValue < 30)
    {
        Console.WriteLine("Normal");
    }

    else
    {
        Console.WriteLine("Sıcak");
    }
}

else
{
    Console.WriteLine("Lütfen sayi giriniz");
}

// 6) kullancıdan 1-7 arasında bir sayı isteniyor ona göre gün çıktısı veriliyor.
Console.Write("1-7 arasında bir sayi giriniz: ");
string day = Console.ReadLine();
bool isDayValid = short.TryParse(day, out short dayValue);
if (isDayValid)
{
switch (dayValue)
{

        case 1:
            Console.WriteLine("Pazartesi");
            break;

        case 2:
            Console.WriteLine("Sali");
            break;
        case 3:
            Console.WriteLine("Carsamba");
            break;
        case 4:
            Console.WriteLine("Persembe");
            break;
        case 5:
            Console.WriteLine("Cuma");
            break;
        case 6:
            Console.WriteLine("Cumartesi");
            break;
        case 7:
            Console.WriteLine("Pazar");
            break;
        default:
            Console.WriteLine("Geçersiz gün");
        break;
}

}
else
{
    Console.WriteLine("Bir sayı giriniz");
}

// 7) kullanıcıdan 0-100 arasında bir sayı isteyip dersten başarı durumunu çıktı verme
Console.Write("0-100 arasında bir sayı giriniz: ");
string note = Console.ReadLine();
bool isNote = short.TryParse(note, out short noteVlue);

if (isNote)
{
    if(0 <= noteVlue && noteVlue <= 100)
    {
        if (0 <= noteVlue && noteVlue <= 60)
        {
            Console.WriteLine("Basarısız");
        }

        else if (60 < noteVlue && noteVlue <= 80)
        {
            Console.WriteLine("Orta");
        }

        else
        {
            Console.WriteLine("Basarılı");
        }
    }

    else
    {
        Console.WriteLine("Lütfen geçerli bir sayi giriniz.");
    }
}

else
{
    Console.WriteLine("Lütfen sayi giriniz");
}

// 8) kullanıcıdan 1-12 arasında numara iste gün sayısı cıktı ver.

Console.Write("1-12 arasında bir sayi giriniz: ");
string month = Console.ReadLine();
bool isMonth = short.TryParse(month, out short monthValue);

if (isMonth)
{
    switch (monthValue)
    {
        case 1:
            Console.WriteLine("Ocak 31 gün");
            break;

        case 2:
            Console.WriteLine("Şubat 28 gün");
            break;
        case 3:
            Console.WriteLine("Mart 31 gün");
            break;
        case 4:
            Console.WriteLine("Nisan 30 gün");
            break;
        case 5:
            Console.WriteLine("Mayıs 31 gün");
            break;
        case 6:
            Console.WriteLine("Haziran 30 gün");
            break;
        case 7:
            Console.WriteLine("Temmuz 31 gün");
            break;
        case 8:
            Console.WriteLine("Agustos 31 gün");
            break;
        case 9:
            Console.WriteLine("Eylül 30 gün");
            break;
        case 10:
            Console.WriteLine("Ekim 31 gün");
            break;
        case 11:
            Console.WriteLine("Kasım 30 gün");
            break;
        case 12:
            Console.WriteLine("Aralık 31 gün");
            break;
        default:
            Console.WriteLine("Geçersiz ay");
            break;
    }
}

else
{
    Console.WriteLine("Lütfen sayı giriniz");
}


//9) kullanıcıdan şifre alığ doğruluğuna göre çıktı verme
Console.Write("Sifre giriniz: ");
string password = Console.ReadLine();
bool isPassword = int.TryParse(password, out int passwordValue);

if (isPassword)
{
    if (passwordValue == 12345)
    {
        Console.WriteLine("Giris basarılı");
    }

    else
    {
        Console.WriteLine("Giris basarısız");
    }
}

else
{
    Console.WriteLine("Lütfen sayi giriniz");
}


// 10) kullanıcıdan işlem ve operatin alıp sonucu verme

// Kullanıcıdan ilk sayıyı al
Console.Write("İlk sayıyı girin: ");
string firstInput = Console.ReadLine();
bool isFirstValid = double.TryParse(firstInput, out double firstNumber);

// Kullanıcıdan ikinci sayıyı al
Console.Write("İkinci sayıyı girin: ");
string secondInput = Console.ReadLine();
bool isSecondValid = double.TryParse(secondInput, out double secondNumber);

// Kullanıcıdan işlemi al
Console.Write("Bir işlem seçin (+, -, *, /): ");
string operation = Console.ReadLine();

// Sayıların geçerli olup olmadığını kontrol et
if (!isFirstValid || !isSecondValid)
{
    Console.WriteLine("Geçersiz sayılar girdiniz.");
    return;
}

else
{

// İşlemi kontrol et ve sonucu hesapla
switch (operation)
{
    case "+":
        Console.WriteLine("Sonuç: " + (firstNumber + secondNumber));
        break;
    case "-":
        Console.WriteLine("Sonuç: " + (firstNumber - secondNumber));
        break;
    case "*":
        Console.WriteLine("Sonuç: " + (firstNumber * secondNumber));
        break;
    case "/":
        if (secondNumber != 0)
            Console.WriteLine("Sonuç: " + (firstNumber / secondNumber));
        else
            Console.WriteLine("Hata: Sıfıra bölme yapılamaz.");
        break;
    default:
        Console.WriteLine("Geçersiz işlem.");
        break;
}

}
