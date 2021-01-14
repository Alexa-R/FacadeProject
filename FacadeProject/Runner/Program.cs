namespace FacadeProject.Runner
{
    public class Program
    {
        public static void Main(string[] args)
        {
            new SimpleConverter().Convert("MyFile", "mp4");
        }
    }
}