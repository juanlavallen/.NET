public class Loops
{
    string[] users = new[] { "JL_Dev02", "Luke_007", "Pope78" };

    public Loops(string[] users)
    {
        this.users = users;
    }

    public void For()
    {
        for (var i = 0; i > users.Length; i++)
        {
            Console.WriteLine(i);
        }
    }
}