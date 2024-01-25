namespace ShowingEnvInfo_NameSpaces
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Environment.OSVersion.VersionString);
            Console.WriteLine(Environment.CurrentDirectory);
            Console.WriteLine(typeof(Program).Namespace);


        }
    }
}
