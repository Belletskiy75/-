// Написать игру, в которой играют двое игроков
// При старте они вводят свои никнейм
// При старте генириируется число от12 до 120  сообщается это число игрокам



Random rnd = new Random();
int gameNumber = rnd.Next(12, 120);
Console.WriteLine($"Number: {gameNumber}");

while(true)
{

Console.Write("User 1: ");
int a = Convert.ToInt32(Console.ReadLine());

    if (gameNumber - a > 0)
    {
        gameNumber -= a;
        Console.WriteLine($"Number: {gameNumber}");


        Console.Write("User 2's turn: ");
        int b = Convert.ToInt32(Console.ReadLine());

        if (gameNumber - b <= 0)
        {
            Console.WriteLine("User 2 wins!");
            break;
        }
        else
        {
            gameNumber -= b;
            Console.WriteLine($"Number: {gameNumber}");
        }
    }
    else
    {
        Console.WriteLine("User 1 wins!");
        break;
    }
}



