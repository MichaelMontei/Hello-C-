string hello = "Hello There Explorer! What do you wanna name your character?";
Console.WriteLine(hello);

string characterName = Console.ReadLine();
string check = "Welcome! " + characterName + ", I am excited to have you here! Shall we play a game? yes or no?";
Console.WriteLine(check);

string confirmation = Console.ReadLine();
if (confirmation == "yes")
{
    Console.WriteLine(
        "Oké Adventurer! You are walking in a forest and suddenly a weird sound comes from the distance, you try to step aside but fail! A wild Pokemon Appears!");
    Console.WriteLine(
        "What will be your choice? You just don't care about all of this, or you try to catch this rare species! leave or catch?");
    string answer = Console.ReadLine();
        if (answer == "leave")
        { 
            Console.WriteLine("Useless Trainer you are" + characterName);
        }

        else if (answer == "catch")
        {
            Console.WriteLine("Wow I knew it ! " + characterName);
            Console.WriteLine("Lets throw a dice and see if you can catch the rare species! " + characterName);
            Console.WriteLine("if the dice hits 4 or higher you will be the new owner of this Pokemon!");
            
            Console.WriteLine("Press ANY key to roll the dice.");
            
            Console.ReadKey();
            int randomNum;
            Random random = new Random();
            randomNum = random.Next(1, 7);
            

            Console.WriteLine("You rolled a " + randomNum);
                
            if (randomNum >= 4)
            {
                Console.WriteLine("Great Job! " + characterName + ", You are a true Adventurer!");
            }
            else
            {
                Console.WriteLine("Damnit, Im never lucky with these dice rolls! Lets try again");
            }

        }
        else
        {
            Console.WriteLine("You have to learn how to type! Try Again! " + characterName);
        }      
}
else if (confirmation == "no")
{
    Console.WriteLine("No game? Well that's really your loss!");
}
else
{
    Console.WriteLine("Typing Skills are Needed here! yes or no?");
}