using Assignment02.DbContexts;

namespace Assignment02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using ITIDbContext dbContext = new ITIDbContext();
        }
    }
}