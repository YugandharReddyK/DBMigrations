namespace DBMigrations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using(SchoolContext context = new SchoolContext())
            {
                context.Students.Add(new Student { FirstName = "Shrivatsa", LastName = "Reddy", GradeId = 10});
                context.SaveChanges();
            }
        }
    }
}