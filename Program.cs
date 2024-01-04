namespace SayiTaminOyunu.Odev
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Random rnd = new Random();
                int point = 0;
                Console.WriteLine("Sayı bulmaca oyununa hoş geldiniz!\nOynamak istediğiniz seviyeyi seçiniz (EASY-MİD-HARD)");
                string res = Console.ReadLine();
                if (res == "E")
                {
                    int number = rnd.Next(0, 16);
                    Console.WriteLine("1-15 dahil olmak üzere bir sayı tuttum 5 tahmin hakkın var!");
                    for (int i = 1; i <= 5; i++)
                    {
                        Console.WriteLine($"{i}. Tahmin hakkın : ");
                        byte guess = byte.Parse(Console.ReadLine());
                        if (guess < number)
                        {
                            Console.WriteLine("Aklımdaki sayı daha büyük!");
                        }
                        else if (guess > number)
                        {
                            Console.WriteLine("Aklımdaki sayı daha küçük!");
                        }
                        else if (guess == number)
                        {
                            point += (5 - i) * 10; //Tekte bilirse 40 puan sonrasında 30 20 10  .....
                            Console.WriteLine($"Tebrikler {i}. Tahmin hakkında doğru bildin\n Puan : {point}");
                            break;
                        }
                        if (i == 5) 
                        {
                            Console.WriteLine($"Bilemedin aklımdaki sayı = {number}\nÜzgünüm Tekrar Dene");
                            break;
                        }

                    }
                }
                if (res == "M")
                {
                    int number = rnd.Next(0, 51);
                    Console.WriteLine("1-50 dahil olmak üzere bir sayı tuttum 7 tahmin hakkın var!");
                    for (int i = 1; i <= 7; i++)
                    {
                        Console.WriteLine($"{i}. Tahmin hakkın : ");
                        byte guess = byte.Parse(Console.ReadLine());
                        if (guess < number)
                        {
                            Console.WriteLine("Aklımdaki sayı daha büyük!");
                        }
                        else if (guess > number)
                        {
                            Console.WriteLine("Aklımdaki sayı daha küçük!");
                        }
                        else if (guess == number)
                        {
                            point += (7 - i) * 20; //Tekte bilirse 120 puan sonrasında 100 80 60 40 20
                            Console.WriteLine($"Tebrikler {i}. Tahmin hakkında doğru bildin\n Puan : {point}");
                            break;
                        }
                        if(i == 7)
                        {
                            Console.WriteLine($"Bilemedin aklımdaki sayı = {number}\nÜzgünüm Tekrar Dene");
                            break;
                        }
                    }
                }
                if (res == "H")
                {
                    int number = rnd.Next(0, 151);
                    Console.WriteLine("1-150 dahil olmak üzere bir sayı tuttum 3 tahmin hakkın var!");
                    for (int i = 1; i <= 3; i++)
                    {
                        Console.WriteLine($"{i}. Tahmin hakkın : ");
                        byte guess = byte.Parse(Console.ReadLine());
                        if (guess < number)
                        {
                            Console.WriteLine("Aklımdaki sayı daha büyük!");
                        }
                        else if (guess > number)
                        {
                            Console.WriteLine("Aklımdaki sayı daha küçük!");
                        }
                        else if (guess == number)
                        {
                            point += (3 - i) * 33 + 1; //Tekte bilirse 67 puan sonrasında  34 1
                            Console.WriteLine($"Tebrikler {i}. Tahmin hakkında doğru bildin\n Puan : {point}");
                            break;
                        }
                         if (i == 3)
                        {
                            Console.WriteLine($"Bilemedin aklımdaki sayı = {number} Üzgünüm Tekrar Dene");
                            break;
                        } 
                    }
                }
            }
            catch (FormatException)
            {
                Console.WriteLine("Lütfen istenilen veri dışında veri girişi yapmayınız!");
            }
            catch (OverflowException)
            {
                Console.WriteLine("Lütfen değerler arasında bir sayı giriniz!");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Bilinmeyen bir hata oluştu lütfen geliştirici ile bağlantıya geçiniz!");
               
            }
        }
    }
}