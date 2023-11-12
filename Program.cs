// See https://aka.ms/new-console-template for more information
namespace vars
{
    class Program
    {
        static void Main(string[] args)
        {
            int num= 2;
            string datetime = DateTime.Now.ToString("dd.MM.yyyy");
            string dateTime = DateTime.Now.ToString("dd/MM/yyyy");
            string hour = DateTime.Now.ToString("HH:mm");
            Console.WriteLine(num);
            Console.WriteLine(datetime);
            Console.WriteLine(hour);

            Console.ReadLine();

        }
    }
}
