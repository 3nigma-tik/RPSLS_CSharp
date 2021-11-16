namespace RPSLS_Revamp
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] availableGestures = { "rock", "paper", "scissors", "lizard", "spock" };
            Game game = new Game();
            game.Run();

        }
    }
}
