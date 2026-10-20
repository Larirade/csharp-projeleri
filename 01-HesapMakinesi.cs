namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n1, n2, result;
            char symbol;
            Console.WriteLine("sayı 1 i giriniz ");
            n1 = int.Parse(Console.ReadLine());
            Console.WriteLine("sayı 2 giriniz");
            n2 = int.Parse(Console.ReadLine());
            Console.WriteLine("yapmak istediğiniz işlemi giriniz ");
            symbol = char.Parse(Console.ReadLine());
            switch (symbol)
            {
                case '+':
                    result = n1 + n2;
                    Console.WriteLine("Sayılarınızın toplamı " + result);
                    break;
                case '-':
                    result = n1 - n2;
                    Console.WriteLine("işleminizin sonucu " + result);
                    break;
                case '*':
                    result = n1 * n2;
                    Console.WriteLine("işleminizin sonucu" + result);
                    break;
                case '/':
                    if (n2!=0)
                    {
                        result = n1 / n2;
                        Console.WriteLine("işlem sonucu " + result);
                    }
                    else
                    {
                        Console.WriteLine("Payda 0 olamaz");
                    }
                    break;







            }




        }
    }
}
