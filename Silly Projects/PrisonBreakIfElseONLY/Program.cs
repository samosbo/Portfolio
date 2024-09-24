//
// Creator: Samosbo, Samantha Osborne
// Prison Break Game using only If/Else/Else If statements
// Purpose: This is a project to test my ability to see if I can construct a text prison break game without the use of loops or additional methods.
// Its in line with my current class where we have not learned additional loops or methods
// This is intended to be a side silly project throughout the semester to optimize this game more and more with each lesson learned in class
// Unfortunately do to errors Most type errors require the game to restart as loops are not in this program YET.
//
namespace PrisonBreakIfElseONLY
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Declare Variables

            string playerName;
            string userInput;
            int numID;
            char gender;


            //Game Menu
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("Welcome to Westview Prison Break!");
            Console.ForegroundColor = ConsoleColor.White;

            //Blank line for Spacing
            Console.WriteLine();

            //Cont of Game Menu
            Console.WriteLine("Start\nCredits\nHow to");
            Console.Write("\nPlease enter which option you would like to do: ");
            userInput = Console.ReadLine().ToLower().Trim();

            //If and Else If for game menu options 
            if (userInput == "start")
            {
                //Clear Game Menu as player has choosen to start game
                Console.Clear();

                //Request Player Name and calculate Prisoner ID off this and inform player
                Console.Write("What is your name? ");
                playerName = Console.ReadLine().Trim();
                numID = (int)(Math.Pow((playerName.Length), 8) % 1000000);
                Console.WriteLine("Your Prisoner ID is: Prisoner {0}",numID);

                //Blank for spacing purposes
                Console.WriteLine();

                //Request what gender character the user wants to play, M,F,O (for NPC's later)
                Console.WriteLine("What gender would you like your character to have (M (male), F (female), O (other): ");
                gender = char.Parse(Console.ReadLine().ToUpper());

                //Blank for spacing purposes
                Console.WriteLine();
                
                //Print option for player to play with static visuals or flash visuals
                Console.WriteLine(@"There are two options in which this game may be played...

              Static (where flashes will pause to make it easier to view)

              Flash (where flashes will be very quick for visual effect
                ");

                // Gather input off playing the game static or flash and started nested if/else for those game modes
                Console.Write("Which option would you like to play (Static or Flash): ");
                userInput = Console.ReadLine().ToLower().Trim();
                if (userInput == "static")
                {
                    //Clear Static/Flash option and open the game intro with a small paragraph, present plan options
                    Console.Clear();
                    Console.WriteLine(@"It is a cold, snowy night at Westview Prison Break. 
                    It is Decemeber 20th 1997, likely close to midnight when you abruptly wake.
                    Snow blows wildly outside covering the grass with a white blanket.
                    At least you think so, the small window at the top of the cell isn't exactly easy to look out.
                    The cell is cold, far colder than the memories in your mind. 
                    Warm smiles and a hearty fire fill as you think back to past holidays you spent with your family.
                    This is the time of year where you wish you weren't locked behind these steel bars.
                    Getting to celebrate the festive time of the year with a helping of slop and stale bread.
                    You turn over and try to get comfortable on the rock solid bed you're given.
                    ...
                    ...
                    But what if you didn't have to?
                    What if you could leave the prison?
                    But how would you leave? How could you get out past the gaurds in time for Christmas?
                    Immediately you notice 4 options. 

                    The ventalation systems through a vent located in the corner of your cell
                    Navigating through the halls after dark
                    Making a run for it from the outside yard
                    Dig to the outside");

                    // Request user's choice of plans 
                    Console.WriteLine("What is your choice? (Vent, Halls, Run, Dig): ");
                    userInput = Console.ReadLine().ToLower().Trim();

                }
                else if (userInput == "flash")
                {

                }
                else
                {
                    //Provide error message for incorrect input
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("ERROR: User has inputted an option not avaliable. Please restart.");
                }



            }
            else if (userInput == "credits")
            {
                //Provide Credits for Westview Prison Break
            }
            else if (userInput == "how to")
            {
                //Explain How to of Westview Prison Break
                Console.WriteLine(@" Westview Prison Break is a text decision game where the player will choose actions their prisoner character will do and see the result.
                The User will have time to process their options with multiple storylines that the character could end up following.
                As for literal instrutions:
                In all cases the player will be presented a series of questions that request for the player to input a response; an example being:
                --------------------------------------------
                Walk Forward
                Walk Backwards
                Walk Left
                Which option would you like to take? 
                --------------------------------------------
                This is where you would then type the option you would like to do.
                This program is NOT case sensitive but any typos or missed spaces WILL result in the program crashing and needing to be reran.
                Be careful about that!
                That is the only instruction on this game, Enjoy!!

                Please rerun this program to start the game.");
                
            }
            else
            {
                //Print error message informing user to rerun program
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("ERROR: User has inputted an option not avalible, please restart.");
            }
            
            
            
            
      

        }
    }
}
