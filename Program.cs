// Ideas

// Implement a isBig boolean involving mushrooms, or even have a "What item does your character eat to get big?" i.e. add a mushroom and customMushroom variable

// You could have this such that if isBig = true then the "Game Over" doesn't happen, but isBig becomes false instead

// Similarly you could have bool star = false; that could be set to true by finding a star, making you invincible to the next enemy

// Implement item and customItem variables for another block, for like a fire flower or something

// Possibly rub off the serial numbers? i.e rename the Mushroom Kingdom and Mario and stuff ex. "The Fungus Pricipality" and "Plumberman"

// To do

// Add more rooms


using System;
namespace consolegame
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            string character = "";
            string boss = "";
            string goal = "";
            string friend = "";
            string item = "";
            bool isLuigi = true;
            while (true)
            {
                bool isMario = true;
                int points = 0;
                while (isMario)
                {
                    bool isBig = false;


                    while (isLuigi)
                    {
                        //START OF CHARACTER

                        Console.WriteLine("Welcome to the Mad Libs Mario Dungeon. Choose your Character.\n");
                        Console.WriteLine(
                            "1. Mario \n" +
                            "2. Luigi \n" +
                            "3. Princess Peach \n" +
                            "4. Enter your own character"
                        );
                        string userSelection = Console.ReadLine();
                        switch (userSelection.ToLower())
                        {
                            case "1":
                            case "mario":
                                character = "Mario";
                                Console.Clear();
                                Console.WriteLine($"You have chosen to play as {character}. Press any key to continue...");
                                Console.ReadKey();
                                break;
                            case "2":
                            case "luigi":
                                character = "Luigi";
                                Console.Clear();
                                Console.WriteLine($"You have chosen to play as {character}. Press any key to continue...");
                                Console.ReadKey();
                                break;
                            case "3":
                            case "princess peach":
                                character = "Princess Peach";
                                Console.Clear();
                                Console.WriteLine($"You have chosen to play as {character}. Press any key to continue...");
                                Console.ReadKey();
                                break;
                            default:
                                Console.Clear();
                                Console.WriteLine("Enter your custom character: ");
                                character = Console.ReadLine();
                                Console.Clear();
                                Console.WriteLine($"You have chosen to play as {character}. Press any key to continue...");
                                Console.ReadKey();
                                break;

                        };
                        // END OF CHARACTER

                        // START OF BOSS
                        Console.Clear();
                        string userSelection1 = "";
                        Console.WriteLine("Choose your final boss. \n");
                        Console.WriteLine(
                            "1. Bowser \n" +
                            "2. Wario \n" +
                            "3. Birdo \n" +
                            "4. Enter your own boss"
                        );
                        userSelection1 = Console.ReadLine();
                        switch (userSelection1.ToLower())
                        {
                            case "1":
                            case "bowser":
                                boss = "Bowser";
                                Console.Clear();
                                Console.WriteLine($"Rumor has it that {boss} has a castle nearby. Press any key to continue...");
                                Console.ReadKey();
                                break;
                            case "2":
                            case "wario":
                                boss = "Wario";
                                Console.Clear();
                                Console.WriteLine($"Rumor has it that {boss} has a castle nearby. Press any key to continue...");
                                Console.ReadKey();
                                break;
                            case "3":
                            case "birdo":
                                boss = "Birdo";
                                Console.Clear();
                                Console.WriteLine($"Rumor has it that {boss} has a castle nearby. Press any key to continue...");
                                Console.ReadKey();
                                break;
                            default:
                                Console.Clear();
                                Console.WriteLine("Enter your final boss: ");
                                boss = Console.ReadLine();
                                Console.Clear();
                                Console.WriteLine($"Rumor has it that {boss} has a castle nearby. Press any key to continue...");
                                Console.ReadKey();
                                break;
                        }
                        // END OF BOSS

                        // START OF FRIEND
                        Console.Clear();
                        string userSelection3 = "";
                        Console.WriteLine($"Who is {character}'s best friend? \n");
                        Console.WriteLine(
                            "1. Toad \n" +
                            "2. Donkey Kong \n" +
                            "3. Yoshi \n" +
                            "4. Enter your own friend"
                        );
                        userSelection3 = Console.ReadLine();
                        switch (userSelection3.ToLower())
                        {
                            case "1":
                            case "toad":
                                friend = "Toad";
                                Console.Clear();
                                Console.WriteLine($"{character}'s best friend is {friend}. Press any key to continue...");
                                Console.ReadKey();
                                break;
                            case "2":
                            case "donkey kong":
                                friend = "Donkey Kong";
                                Console.Clear();
                                Console.WriteLine($"{character}'s best friend is {friend}. Press any key to continue...");
                                Console.ReadKey();
                                break;
                            case "3":
                            case "yoshi":
                                friend = "Yoshi";
                                Console.Clear();
                                Console.WriteLine($"{character}'s best friend is {friend}. Press any key to continue...");
                                Console.ReadKey();
                                break;
                            default:
                                Console.Clear();
                                Console.WriteLine("Enter your custom friend: ");
                                friend = Console.ReadLine();
                                Console.Clear();
                                Console.WriteLine($"{character}'s best friend is {friend}. Press any key to continue...");
                                Console.ReadKey();
                                break;

                        }
                        // END OF FRIEND

                        // START OF GOALS
                        Console.Clear();
                        string userSelection4 = "";
                        Console.WriteLine($"Who or what is {character} looking for in the Mushroom Kingdom? \n");
                        Console.WriteLine(
                            "1. the princess \n" +
                            "2. friendship \n" +
                            "3. Mario \n" +
                            "4. Enter your own goal"
                        );
                        userSelection4 = Console.ReadLine();
                        switch (userSelection4.ToLower())
                        {
                            case "1":
                            case "the princess":
                                goal = "the princess";
                                Console.Clear();
                                Console.WriteLine($"{character} is in the Mushroom Kingdom looking for {goal}. Press any key to continue...");
                                Console.ReadKey();
                                break;
                            case "2":
                            case "friendship":
                                goal = "friendship";
                                Console.Clear();
                                Console.WriteLine($"{character} is in the Mushroom Kingdom looking for {goal}. Press any key to continue...");
                                Console.ReadKey();
                                break;
                            case "3":
                            case "mario":
                                goal = "Mario";
                                Console.Clear();
                                Console.WriteLine($"{character} is in the Mushroom Kingdom looking for {goal}. Press any key to continue...");
                                Console.ReadKey();
                                break;
                            default:
                                Console.Clear();
                                Console.WriteLine("Enter your custom goal: ");
                                goal = Console.ReadLine();
                                Console.Clear();
                                Console.WriteLine($"{character} is in the Mushroom Kingdom looking for {goal}. Press any key to continue...");
                                Console.ReadKey();
                                break;
                        }
                        // END OF GOALS

                        // START OF ITEM
                        Console.Clear();
                        string userSelection9 = "";
                        Console.WriteLine($"What does {character} eat to get big? \n");
                        Console.WriteLine(
                            "1. a mushroom \n" +
                            "2. spinach \n" +
                            "3. Enter your own food"
                        );
                        userSelection9 = Console.ReadLine();
                        switch (userSelection9.ToLower())
                        {
                            case "1":
                            case "a mushroom":
                            case "mushroom":
                                item = "a mushroom";
                                Console.Clear();
                                Console.WriteLine($"{character} eats {item} to grow big and strong. Press any key to continue...");
                                Console.ReadKey();
                                break;
                            case "2":
                            case "spinach":
                                item = "spinach";
                                Console.Clear();
                                Console.WriteLine($"{character} eats {item} to grow big and strong. Press any key to continue...");
                                Console.ReadKey();
                                break;
                            default:
                                Console.Clear();
                                Console.WriteLine("Enter your custom food: ");
                                item = Console.ReadLine();
                                Console.Clear();
                                Console.WriteLine($"{character} eats {item} to grow big and strong. Press any key to continue...");
                                Console.ReadKey();
                                break;
                        }
                        //End of ITEM

                        // ARRIVING IN THE MUSHROOM KINGDON
                        isLuigi = false;
                    }
                    Console.Clear();
                    string userSelection5 = "";
                    Console.WriteLine($"{character} arrives in the Mushroom Kingdom, looking for {goal}. They see a koopa turtle approaching. It appears hostile. What does {character} do? \n");
                    Console.WriteLine(
                        "1. Jump on its head \n" +
                        "2. Jump over it and run past \n" +
                        "3. Run straight into it"
                    );
                    userSelection5 = Console.ReadLine();
                    switch (userSelection5.ToLower())
                    {
                        case "1":
                        case "jump on its head":
                            points += 10;
                            Console.Clear();
                            Console.WriteLine($"{character} jumps on the turtle's head. 10 points! They run on to the next area. Press any key to continue...");
                            Console.ReadKey();
                            break;
                        case "2":
                        case "jump over it and run past":
                            Console.Clear();
                            Console.WriteLine($"{character} jumps over the turtle and runs on to the next area. Press any key to continue...");
                            Console.ReadKey();
                            break;
                        default:
                            Console.Clear();
                            string userSelection11 = "";
                            Console.WriteLine($"{character} runs straight into the turtle. Game Over. Press any key to continue...");
                            Console.ReadKey();
                            Console.WriteLine("Would you like to start from the beginning or start after character creation?");
                            Console.WriteLine(
                                "1. Restart from the beginning\n" +
                                "2. Restart after character creation"
                            );

                            userSelection11 = Console.ReadLine();
                            switch (userSelection11.ToLower())
                            {
                                case "1":
                                case "restart from the beginning":
                                    isMario = false;
                                    isLuigi = true;
                                    Console.Clear();
                                    break;

                                default:
                                    Console.Clear();
                                    isLuigi = false;
                                    isMario = false;
                                    break;
                            }
                            break;
                    }

                    // END OF ARRIVING IN MUSHROOM KINGDOM

                    if (isMario == false)
                    {
                        break;
                    }

                    // JUMPING ON BLOCKS 
                    Console.Clear();
                    string userSelection10 = "";
                    Console.WriteLine($"{character} notices a floating block with a question mark on it. What does {character} do? \n");
                    Console.WriteLine(
                        "1. Jump up and break the block \n" +
                        "2. Ignore it and run past "
                    );
                    userSelection10 = Console.ReadLine();
                    switch (userSelection10.ToLower())
                    {
                        case "1":
                        case "jump up and break the block":
                            points += 50;
                            Console.Clear();
                            Console.WriteLine($"{character} jumps up and hits the block, and {item} comes out and lands on them. {character} doubles in size! Press any key to continue...");
                            Console.ReadKey();
                            isBig = true;
                            break;
                        default:
                            Console.Clear();
                            Console.WriteLine($"{character} ignores the mysterious box and runs on. Press any key to continue...");
                            Console.ReadKey();
                            break;
                    }
                    // END OF JUMPING ON BLOCKS

                    // ARRIVING AT LARGE PIT
                    Console.Clear();
                    string userSelection6 = "";
                    Console.WriteLine($"Continuing on {character} arrives at the edge of large pit. What does {character} do?\n");
                    Console.WriteLine(
                        "1. Jump in the pit\n" +
                        "2. Jump over pit and move on"
                    );
                    userSelection6 = Console.ReadLine();
                    switch (userSelection6.ToLower())
                    {
                        case "2":
                        case "jump over it and run past":
                            Console.Clear();
                            Console.WriteLine($"{character} jumps over the pit and runs on to the next area. Press any key to continue...");
                            Console.ReadKey();
                            break;

                        default:
                            Console.Clear();
                            Console.WriteLine($"{character} jumps in the pit. Game Over. Press any key to continue...");
                            Console.ReadKey();
                            Console.Clear();
                            Console.WriteLine("Would you like to start from the beginning or start after character creation?");
                            Console.WriteLine(
                                "1. Restart from the beginning\n" +
                                "2. Restart after character creation"
                            );

                            string userSelection12 = Console.ReadLine();
                            switch (userSelection12.ToLower())
                            {
                                case "1":
                                case "restart from the beginning":
                                    isMario = false;
                                    isLuigi = true;
                                    Console.Clear();
                                    break;

                                default:
                                    Console.Clear();
                                    isLuigi = false;
                                    isMario = false;
                                    break;
                            }


                            break;
                    }
                    if (isMario == false)
                    {
                        break;
                    }
                    // END OF JUMPING IN PIT

                    // GOOMBAS
                    Console.Clear();
                    string userSelection7 = "";
                    Console.WriteLine($"After getting past the pit {character} sees two goombas. What does {character} do?\n");
                    Console.WriteLine(
                        "1. Jump on one goomba and run past the second\n" +
                        "2. Jump on one goomba and bounce onto the second taking out both\n" +
                        "3. Run straight into them\n" +
                        "4. Jump over both of them and run past"
                    );
                    userSelection7 = Console.ReadLine();
                    switch (userSelection7.ToLower())
                    {
                        case "1":
                        case "jump on one gooomba and run past the second":
                            Console.Clear();
                            Console.WriteLine($"{character} smashes one goomba and continues on. 5 points! Press any key to continue...");
                            Console.ReadKey();
                            points += 5;
                            break;
                        case "2":
                        case "jump on one goomba and bounce onto the second taking out both":
                            Console.Clear();
                            Console.WriteLine($"{character} smashes both goombas before continuing on! 10 points. Press any key to continue...");
                            Console.ReadKey();
                            points += 10;
                            break;
                        default:
                            if (isBig == false)
                            {
                                Console.Clear();
                                Console.WriteLine($"{character} runs straight into them. Game Over. Press any key to continue...");
                                Console.ReadKey();
                                Console.Clear();
                                Console.WriteLine("Would you like to start from the beginning or start after character creation?");
                                Console.WriteLine(
                                    "1. Restart from the beginning\n" +
                                    "2. Restart after character creation"
                                );

                                string userSelection13 = Console.ReadLine();
                                switch (userSelection13.ToLower())
                                {
                                    case "1":
                                    case "restart from the beginning":
                                        isMario = false;
                                        isLuigi = true;
                                        Console.Clear();
                                        break;

                                    default:
                                        Console.Clear();
                                        isLuigi = false;
                                        isMario = false;
                                        break;
                                }
                                break;

                            }
                            else
                            {
                                Console.Clear();
                                Console.WriteLine($"{character} runs straight into them. You shrink down to normal size. Press any key to continue...");
                                Console.ReadKey();
                                isBig = false;
                                Console.Clear();
                                break;
                            }
                        case "4":
                        case "jump over both of them and run past":
                            Console.Clear();
                            Console.WriteLine($"{character} jumps over both goombas and continues on. Press any key to continue...");
                            Console.ReadKey();
                            break;
                    }


                    if (isMario == false)
                    {
                        break;
                    }
                    // END OF GOOMBAS

                    // FINAL BOSS
                    Console.Clear();
                    string userSelection8 = "";
                    Console.WriteLine($"Finally {character} arrives at {boss}'s castle. After traveling through the castle they arive face to face with {boss}. What does {character} do?\n");
                    Console.WriteLine(
                        $"1. Jump on {boss}'s head \n" +
                        $"2. Run past {boss} and disable the bridge causing {boss} to fall into lava"
                    );
                    userSelection8 = Console.ReadLine();
                    switch (userSelection8.ToLower())
                    {
                        case "1":
                        case "jump on their head":
                            Console.Clear();
                            Console.WriteLine($"{character} jumps on {boss}'s head. Big Mistake. Game Over. Press any key to continue...");
                            Console.ReadKey();
                            Console.WriteLine("Would you like to start from the beginning or start after character creation?");
                            Console.WriteLine(
                                "1. Restart from the beginning\n" +
                                "2. Restart after character creation"
                            );

                            string userSelection13 = Console.ReadLine();
                            switch (userSelection13.ToLower())
                            {
                                case "1":
                                case "restart from the beginning":
                                    isMario = false;
                                    isLuigi = true;
                                    Console.Clear();
                                    break;

                                default:
                                    Console.Clear();
                                    isLuigi = false;
                                    isMario = false;
                                    break;
                            }
                            break;

                        case "2":
                        case "run past the boss and disable the bridge, causing the boss to fall into lava":
                            Console.Clear();
                            Console.WriteLine($"{character} runs past {boss} and disables the bridge and {boss} falls into lava! {character} earns 100 points for defeating {boss}. Press any key to continue...");
                            Console.ReadKey();
                            points += 100;
                            break;
                    }
                    if (isMario == false)
                    {
                        break;
                    }

                    Console.Clear();
                    Console.WriteLine($"{friend} was imprisoned at {boss}'s castle, but they say that {goal} is in another castle. Press any key to continue...");
                    Console.ReadKey();
                    Console.Clear();
                    Console.WriteLine($"{character} earned a total of {points} points. Congratulation, you win the game. Press any key to continue...");
                    Console.ReadKey();
                    Console.Clear();
                    Console.WriteLine("Would you like to start from the beginning or start after character creation?");
                    Console.WriteLine(
                        "1. Restart from the beginning\n" +
                        "2. Restart after character creation"
                    );

                    string userSelection14 = Console.ReadLine();
                    switch (userSelection14.ToLower())
                    {
                        case "1":
                        case "restart from the beginning":
                            isMario = false;
                            isLuigi = true;
                            Console.Clear();
                            break;

                        default:
                            Console.Clear();
                            isLuigi = false;
                            isMario = false;
                            break;
                    }

                    if (isMario == false)
                    {
                        break;
                    }
                }
            }
        }
    }
}

