



firstMethod();


static void firstMethod()
{
    Console.WriteLine("Ekrana sevdiğiniz bir şarkı sözünü yazdırıyor");
}


Console.WriteLine("-----------------------------------" +
    "");



secondMethod(1,100);

static int secondMethod(int min, int max)

{
    Random random = new Random();
   int xRandom= random.Next(min,max+1);
    int remainder = xRandom % 2;

    Console.WriteLine("Rastgele sayının 2 ye bölümünden kalanı  "+ remainder);


    return remainder;
}


Console.WriteLine("-----------------------------------" +
    "");



int x= thirdMethod(2,5);

Console.WriteLine("Ikı sayının çarpımının sonucu: " + x);



    static int thirdMethod(int a,int b)
{

    return a * b;

}

Console.WriteLine("-----------------------------------" +
    "");



fourthMethod ("ahmet ", " can");

static void fourthMethod(string name, string surname)
{
    Console.WriteLine("Hoşgeldiniz  " + name + surname);
}


