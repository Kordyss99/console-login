namespace console_login_dongusu
{
    internal class Programd
    {
        static void Main(string[] args)
        {
            string username = "1";
            string pass = "1";
            string kad, ksif;

            Console.WriteLine("Kullanıcı Doğrulanıyor");

            int deneme = 0;
            bool kontrol = false;

            while (deneme <= 3 && !kontrol) 
            {
                
                Console.Write("Kullanıcı Adı: ");
                kad = Console.ReadLine();
                Console.Write("Kullanıcı Sifre: ");
                ksif = Console.ReadLine();

                if (username == kad && pass == ksif)
                {
                    kontrol = true;
                    Console.WriteLine("Giriş Başarılı");
                }
                else
                {
                    deneme++;
                    Console.WriteLine("Yanlış Girdiniz");
                }
            }
            if (kontrol)
            {
                Console.WriteLine("Kordyss99");
            }
            else
            {
                kontrol = false;
                Console.WriteLine("programdan gidin");
            }
            
        }
    }
}
