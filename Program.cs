namespace ConsoleApp30
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> list = new List<string>();
            Console.WriteLine(list.Capacity);
            list.Add("a");
            list.Add("a");
            list.Add("ab");
            list.Add("a");
            list.Add("a");
            list.Remove("ab");
            Console.WriteLine(list.Capacity);



        }
    }
}