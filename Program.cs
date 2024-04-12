namespace weatherforecast
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Merhaba, hava durumuna göre kıyafet öneri programına hoş geldiniz! ");
            Console.ReadLine();
            Console.Clear();
            Console.Write("Hava Açıkmı(A)/Kapalımı(K): ");
            string answer = Console.ReadLine();
            if (answer == "a" || answer == "A")
            {
                //Acık hava
                Console.Clear();
                Console.Write("Hava açık çok güzel! lütfen hava derecesinide yazınız: ");
                int derece = int.Parse(Console.ReadLine());
                Console.Clear();
                if (derece <= 15)
                {
                    Console.WriteLine("Hava açık lakin soğuk olacağa benziyor. Kalın giyinmenizde fayda var. Örn:Mont, Bot, Bere.");
                }
                else
                {
                    Console.WriteLine("Hava açık ve güneşli, tam yaz havası var. Rahat giyinebilirsiiniz. Örn:Sweet, Spor ayakkabı, T-shirt.");
                }
            }
            else        
            {
                //Kapalı hava
                Console.Clear();
                Console.Write("Hava kapalı! lütfen hava derecesinide yazınız: ");
                int derece = int.Parse(Console.ReadLine());
                Console.Clear();
                if (derece <= 15)
                {
                    Console.WriteLine("Hava kapalı ve soğuk olacağa benziyor. Kalın kıyafetler giymenizi ve şemsiye almanızı öneririm. Örn:Mont, Yağmurluk, Bot, Bere.");

                }
                else
                {
                    Console.WriteLine("Hava kapalı lakin sıcak. Yağmur ihtimaline karşı yağmurluk alabilirsiniz. Örn:Sweetshirt, Yağmurluk, Bot.");
                }
            }
            Console.ReadKey();
        } 
    }
}
