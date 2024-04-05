namespace class5aprel
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Calculate c=new Calculate();
            //Console.WriteLine(c.Add(1,5));
            IDivide c = new Calculate();
            Console.WriteLine(c.Divide(1,5));
        }
    }
}
