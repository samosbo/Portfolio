//
// Creator: Samosbo, Samantha Osborne
// Prison Break Game using only If/Else/Else If statements
// Purpose: This is a project to test my ability to see if I can construct a text prison break game without the use of loops or additional methods.
// Its in line with my current class where we have not learned additional loops or methods
// This is intended to be a side silly project throughout the semester to optimize this game more and more with each lesson learned in class
// Unfortunately do to errors Most type errors require the game to restart as loops are not in this program YET.
//
using System;

namespace PrisonBreakIfElseONLY
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Declare Variables

            const int MaxHealth = 100;
            int currentHealth;
            string playerName;
            string userInput;
            int numID;
            char gender;
            int guardLevel;


            //Game Menu
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("Welcome to Westview Prison Break!");
            Console.ForegroundColor = ConsoleColor.White;

            //Blank line for Spacing
            Console.WriteLine();

            //Cont of Game Menu
            Console.WriteLine("Start\nCredits\nHow to\n\nNote: This game is recommended to be played in full screen!");
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
                numID = (int)(Math.Pow((playerName.Length), 8) % 10000);
                Console.WriteLine("Here is your prisoner ID!");
                //Blank Space for spacing purposes
                Console.WriteLine();
                //Print PLayersD card stating Prison Name, Icon of character, ID number, Sentence end time, Charge, and barcode at bottom.
                Console.WriteLine("------------------------------");
                Console.WriteLine("| Westview Prison            |");
                Console.WriteLine("| Prisoner ID: {0}        O |", numID);
                Console.WriteLine("| Sentence Ends: 1011101   | |");
                Console.WriteLine("| Charge: 10101011         ^ |");
                Console.WriteLine("||||||||||||||||||||||||||||||");
                Console.WriteLine("------------------------------");

                //print current guard level for West View Prison
                guardLevel = 0;
                Console.WriteLine("\nWESTVIEW PRISON GUARD LEVEL = {0} of 5, ", guardLevel);
                if (guardLevel == 0)
                {
                    Console.Write("OOOOO");
                }
                else if (guardLevel == 1)
                {
                    Console.Write("0OOOO");
                }
                else if (guardLevel == 2)
                {
                    Console.Write("00OOO");
                }
                else if (guardLevel == 3)
                {
                    Console.Write("000OO");
                }
                else if (guardLevel == 4)
                {
                    Console.Write("0000O");
                }
                else if (guardLevel == 5)
                {
                    Console.Write("00000");
                }

                //Blank for spacing purposes
                Console.WriteLine();

                //Request what gender character the user wants to play, M,F,O (for NPC's later)
                Console.Write("What gender would you like your character to have (M (male), F (female), O (other): ");
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
                    Console.WriteLine("It is a cold, snowy night at Westview Prison Break." +
                    "\nIt is Decemeber 20th 1997, likely close to midnight when you abruptly wake. " +
                    "\nSnow blows wildly outside covering the grass with a white blanket. " +
                    "\nAt least you think so, the small window at the top of the cell isn\'t exactly easy to look out. " +
                    "\nThe cell is cold, far colder than the memories in your mind. " +
                    "\nWarm smiles and a hearty fire fill as you think back to past holidays you spent with your family." +
                    "\nThis is the time of year where you wish you weren\'t locked behind these steel bars." +
                    "\nGetting to celebrate the festive time of the year with a helping of slop and stale bread." +
                    "\nYou turn over and try to get comfortable on the rock solid bed you're given." +
                    "\n..." +
                    "\n..." +
                    "\nBut what if you didn\'t have to?" +
                    "\nWhat if you could leave the prison?" +
                    "\nBut how would you leave? How could you get out past the gaurds in time for Christmas?" +
                    "\nImmediately you notice 4 options. " +
                    "\n\nThe ventalation systems through a vent located in the corner of your cell" +
                    "\n\nNavigating through the halls after dark" +
                    "\n\nMaking a run for it from the outside yard" +
                    "\n\nDig to the outside");

                    //Blank space for spacing purposes
                    Console.WriteLine();

                    // Request user's choice of plans 
                    Console.Write("What is your choice? (Vent, Halls, Run, Dig): ");
                    userInput = Console.ReadLine().ToLower().Trim();

                    if (userInput == "vent")
                    {
                        //Clear page to clear up space and provide intro to vent
                        Console.Clear();
                        Console.Write("The vent? You take another glance over to the vent up against the wall." +
                            "\nYou\'re certain you could fit in it if you needed to." +
                            "\nTheres only two issues you can see." +
                            "\nIt would be better having someone who could watch for a gaurd, maybe someone could escape with you?" +
                            "\nYou don't know what route in the vents will take you outside and what would send you straight to the gaurds." +
                            "\n\n What should you try and get first? (Ally or Route): ");
                        userInput = Console.ReadLine().Trim().ToLower();
                        if (userInput == "ally")
                        {
                            //For the gender Male, assumingly all male prisoners give user the option among the 3 of them or solo Provide short description of each NPC.
                            if (gender == 'M')
                            {
                                //Clear Console to keep it manageable on one screen
                                Console.Clear();
                                Console.WriteLine("Immediately you think of who you could ask while staring at the top of your cell." +
                                    "\nIt would need to be someone quick. Someone whos able to stay calm, after all this runs the risk of a huge extension of your prison time." +
                                    "Then 3 names appear in your head...");
                                //Blank Space for spacing purposes
                                Console.WriteLine();
                                //Print John's ID card stating Prison Name, Icon of character, ID number, Sentence end time, Charge, and barcode at bottom.
                                Console.WriteLine("------------------------------");
                                Console.WriteLine("| Westview Prison          J |");
                                Console.WriteLine("| Prisoner: John ID: 5846  O |");
                                Console.WriteLine("| Sentence Ends: 1998      | |");
                                Console.WriteLine("| Charge: Larceny          ^ |");
                                Console.WriteLine("||||||||||||||||||||||||||||||");
                                Console.WriteLine("------------------------------");
                                //Small tagling describing John (John is M prison rat out option- he will tell on the player)
                                Console.WriteLine("John. You're cell neighbor. He's always been quiet, calm. \nHe might be the perfect choice.");

                                //Blank Space for spacing purposes
                                Console.WriteLine();
                                //Print Donny's ID card stating Prison Name, Icon of character, ID number, Sentence end time, Charge, and barcode at bottom.
                                Console.WriteLine("------------------------------");
                                Console.WriteLine("| Westview Prison          D |");
                                Console.WriteLine("| Prisoner: Donny ID: 5846 O |");
                                Console.WriteLine("| Sentence Ends: 2015      | |");
                                Console.WriteLine("| Charge: Forgery          ^ |");
                                Console.WriteLine("||||||||||||||||||||||||||||||");
                                Console.WriteLine("------------------------------");
                                //Small tagling describing Donny (Donny is M prison sacrefice option- he will sacrefice himself for the player)
                                Console.WriteLine("Donny. Donny has always been someone you've relied on in your time here. \nHe seems like a great option.");

                                //Blank Space for spacing purposes
                                Console.WriteLine();
                                //Print Clyde's ID card stating Prison Name, Icon of character, ID number, Sentence end time, Charge, and barcode at bottom.
                                Console.WriteLine("------------------------------");
                                Console.WriteLine("| Westview Prison          C |");
                                Console.WriteLine("| Prisoner: Clyde ID: 4759 O |");
                                Console.WriteLine("| Sentence Ends: 2005      | |");
                                Console.WriteLine("| Charge: Arson            ^ |");
                                Console.WriteLine("||||||||||||||||||||||||||||||");
                                Console.WriteLine("------------------------------");
                                //Small tagling describing Clyde (Clyde is M prison betray option- he will betray on the player)
                                Console.WriteLine("Clyde. He tends to eat at the same table as you. He's helped you before when you're behind on your tasks." +
                                    "\nMaybe he'll help you on this? ");

                                //Blank line for spacing
                                Console.WriteLine();
                                //Remind the Solo option.
                                Console.WriteLine("You realize that maybe even knowing your fellow prison mates, you might just be able to pull off this alone." +
                                    "\nThe question is do you want to?");

                                //Blank line for spacing.
                                Console.WriteLine();

                                //Present the user options to pick between the individual prison partners or go solo
                                Console.Write("Who will you choose? (John, Donny, Clyde, or Alone): ");
                                userInput = Console.ReadLine().ToLower().Trim();

                                //If for John being choosen again RATS OUT
                                if (userInput == "john")
                                {

                                }
                                //if for donny again HELPS PLAYER (sacrefice)
                                else if (userInput == "donny")
                                {

                                }
                                //if for clyde again BETRAYS PLAYER
                                else if (userInput == "clyde")
                                {

                                }
                                //ALONE
                                else if (userInput == "alone")
                                {

                                    //Restate player choice and hint at day transfer
                                    Console.WriteLine("\n Attempting this yourself has the best chances you decide as you turn over awaiting the morning to begin your plan.");
                                    //Clear screen to keep it manageable for player and print date for new day
                                    Console.Clear();
                                    Console.ForegroundColor = ConsoleColor.Cyan;
                                    Console.WriteLine("Morning of December 21st");
                                    Console.WriteLine();
                                    Console.ForegroundColor = ConsoleColor.White;

                                    //Present player at breakfast pondering their next actions. Mapping out or going for it that night.
                                    Console.Write("You shovel another spoonful of slop onto your tray and locate an empty seat to eat." +
                                        "\nThe one thing you can't wait for is real food after all this time." +
                                        "\nYou eyes look upward for a moment spotting the vent reminding you of your plan." +
                                        "\nKnowing the route beforehand might be helpful for navigating the vents. Meaning the soonest you would leave is tomorrow" +
                                        "\nYet it is just vents, how many lefts and rights could it be? Plus leaving sooner may be beneficial to dodge gaurds." +
                                        "\nWhat option would you like to take? (Route or Leave):  ");
                                    userInput = Console.ReadLine().ToLower().Trim();
                                    if (userInput == "route")
                                    {
                                        //Clear for convinence of player
                                        Console.Clear();
                                        //Story for beginning route leading into the options of finishing route or going into gym. Finishing route will gain +1 guard level, gym will not.
                                        Console.Write("No, can\'t leave yet. A route is absoutely needed before you leave." +
                                            "\nYou only hope your making the right decision as you glance to the gaurd standing a bit away." +
                                            "\n\nAfter breakfast there is a free period. You begin to walk around the prison, starting at your cells and walking taking note of vents you pass." +
                                            "\nAs much as you try inevitably it is slightly suspicious to just be wandering around on your free time." +
                                            "\nOnce you realize this you begin to notice the gaurds steady gaze on you and possible footsteps behind you." +
                                            "\nYou only have a bit further to see before your done with your route, but as if it just needed the gym door is to your right." +
                                            "\nA choice to be made, which action do you take? (Further or Gym): ");
                                        userInput = Console.ReadLine().ToLower().Trim();
                                        //If for Further, will get stopped by a guard and gain +1 guard level.
                                        if (userInput == "further")
                                        {
                                            //Clear console for convience of player
                                            Console.Clear();
                                            //Paragraph for player where they will get STOPPED by guard.
                                            Console.WriteLine("You are so close to finish figuring out the vents outside, you can\'t stop now." +
                                                "\nRight as you reach the end of the hall seeing the final vent to the outside..." +
                                                "\nPress enter to continue");
                                            Console.ReadLine();

                                            //static Flash screen to blue for guard stop
                                            Console.BackgroundColor = ConsoleColor.Blue;
                                            Console.Clear();
                                            Console.ForegroundColor = ConsoleColor.Black;

                                            //increase guard level by 1
                                            Console.WriteLine("A Guard has identified you doing a suspicious activity!!");
                                            Console.WriteLine("\nWESTVIEW PRISON GUARD LEVEL +1 = 1 of 5, 0OOOO");
                                            guardLevel ++;
                                            Console.WriteLine("\n\nPlease click enter to continue... (it will flash back to black)");
                                            Console.ReadLine();

                                            //static Flash screen back to black
                                            Console.BackgroundColor = ConsoleColor.Black;
                                            Console.ForegroundColor = ConsoleColor.White;
                                            Console.Clear();

                                            //Interact with Guard present option for excuse, if poor excuse is choosen +1 guard, if good excuse is no effect on guard level
                                            Console.Write("You feel a hand on your shoulder as a Guard moves to stand in front of you." +
                                                "\n Guard: Prisoner {0}, I've been watching you since the cells, what are you up to?" +
                                                "\n You: \"Never been this way. Figured I'd see what its like.\" or \"Was trying to locate the gaurds office. I found contraband.\" " +
                                                "Which will you respond? (Never or Was): ", numID);
                                            userInput = Console.ReadLine().ToLower().Trim();
                                            //If for the never statement, this will lead to a further question which will have a +1 guard level or no effect
                                            if (userInput == "never")
                                            {
                                                //Continuation of the player and guard conversation
                                                Console.Write("\nGuard: Really. What was I born yesterday? You've been here for years. Have you really never been down this hall? " +
                                                    "\nYou: \"Believe it or not, No. Not once.\" or \"This prison is really big, I don't have a job over here. So I have no business being over here.\" " +
                                                    " Which will you choose: (Believe or This): ");
                                                userInput = Console.ReadLine().ToLower().Trim();
                                                //if for believe this option with be no effect
                                                if (userInput == "believe")
                                                {
                                                    Console.Write("\nGuard: Alright. Well get a move on to the yard or something. Don't spend your time wandering halls.");
                                                }
                                                //if for this this option will be +1 guard level
                                                if (userInput == "this")
                                                {
                                                    //static Flash screen to blue for guard stop
                                                    Console.BackgroundColor = ConsoleColor.Blue;
                                                    Console.Clear();
                                                    Console.ForegroundColor = ConsoleColor.Black;

                                                    //increase guard level by 1
                                                    Console.WriteLine("A Guard has identified you doing a suspicious activity!!");
                                                    guardLevel++;
                                                    Console.WriteLine("\nWESTVIEW PRISON GUARD LEVEL +1 = {0} of 5, ", guardLevel);
                                                    if (guardLevel == 0)
                                                    {
                                                        Console.Write("OOOOO");
                                                    }
                                                    else if (guardLevel == 1)
                                                    {
                                                        Console.Write("0OOOO");
                                                    }
                                                    else if (guardLevel == 2)
                                                    {
                                                        Console.Write("00OOO");
                                                    }
                                                    else if (guardLevel == 3)
                                                    {
                                                        Console.Write("000OO");
                                                    }
                                                    else if (guardLevel == 4)
                                                    {
                                                        Console.Write("0000O");
                                                    }
                                                    else if (guardLevel == 5)
                                                    {
                                                        Console.Write("00000");
                                                    }
                                                    Console.WriteLine("\n\nPlease click enter to continue... (it will flash back to black)");
                                                    Console.ReadLine();

                                                    //static Flash screen back to black
                                                    Console.BackgroundColor = ConsoleColor.Black;
                                                    Console.ForegroundColor = ConsoleColor.White;
                                                    Console.Clear();
                                                    //Final statement from Guard
                                                    Console.WriteLine("Exactly, you're not supposed to be. Go to the yard!");

                                                }


                                            }
                                            //if for the was statement will lead to the guard requesting the contraband. This will lead to a question for +1 guard level or no effect
                                            if (userInput == "was")
                                            {
                                                //Continuation of the player and guard conversation
                                                Console.Write("\nGuard: Well you don't need the office. Hand over the contraband to me and I might be able to get you a reward in a couple days or so. " +
                                                    "\nYou: \"Uh, I dropped it on the walk here.\" or \"I left it in the cell I found it. Cell 3564.\" " +
                                                    " Which will you choose: (Drop or Left) ");
                                                userInput = Console.ReadLine().ToLower().Trim();
                                                //if for believe this option with be no effect
                                                if (userInput == "left")
                                                {
                                                    Console.Write("\nGuard: Great idea. I'll head there. Keep it up, Prisoner {0}.", numID);
                                                    Console.WriteLine("\n\nPlease press enter to continue.");
                                                    Console.ReadLine();
                                                }
                                                //if for this this option will be +1 guard level
                                                if (userInput == "drop")
                                                {
                                                    //static Flash screen to blue for guard stop
                                                    Console.BackgroundColor = ConsoleColor.Blue;
                                                    Console.Clear();
                                                    Console.ForegroundColor = ConsoleColor.Black;

                                                    //increase guard level by 1
                                                    Console.WriteLine("A Guard has identified you doing a suspicious activity!!");
                                                    guardLevel++;
                                                    Console.WriteLine("\nWESTVIEW PRISON GUARD LEVEL +1 = {0} of 5, ", guardLevel);
                                                    if (guardLevel == 0)
                                                    {
                                                        Console.Write("OOOOO");
                                                    }
                                                    else if (guardLevel == 1)
                                                    {
                                                        Console.Write("0OOOO");
                                                    }
                                                    else if (guardLevel == 2)
                                                    {
                                                        Console.Write("00OOO");
                                                    }
                                                    else if (guardLevel == 3)
                                                    {
                                                        Console.Write("000OO");
                                                    }
                                                    else if (guardLevel == 4)
                                                    {
                                                        Console.Write("0000O");
                                                    }
                                                    else if (guardLevel == 5)
                                                    {
                                                        Console.Write("00000");
                                                    }
                                                    Console.WriteLine("\n\nPlease click enter to continue... (it will flash back to black)");
                                                    Console.ReadLine();

                                                    //static Flash screen back to black
                                                    Console.BackgroundColor = ConsoleColor.Black;
                                                    Console.ForegroundColor = ConsoleColor.White;
                                                    Console.Clear();
                                                    //Final statement from Guard
                                                    Console.WriteLine("I was following you. I would have seen it drop. Get back to the rest of the prison!");
                                                }

                                                //INPUT DEC 22 CODE HERE

                                            }

                                            //Clear Console for both views to regroup
                                            Console.Clear();
                                            //Paragraph explaining you now know the route
                                            Console.WriteLine("Well even if you did have to encounter the guard what matters now is you know the route of the vents!" +
                                                "\nYou eventually end up in the dining hall and start mentally reviewing what you accomplished." +
                                                "\n\nYou choose to go solo in the vents mission" +
                                                "\nYou got the route for the vents." +
                                                "\nWestview Prison Guard Level is: {0}", guardLevel);

                                            if (guardLevel == 0)
                                            {
                                                Console.Write("You have navigated through guard interactions with no suspicion!");
                                            }
                                            else if (guardLevel == 1)
                                            {
                                                Console.Write("You have navigated through guard interactions with a small amount of suspicion!");
                                            }
                                            else if (guardLevel == 2)
                                            {
                                                Console.Write("You have navigated through guard interactions with a little amount of suspicion!");
                                            }
                                            else if (guardLevel == 3)
                                            {
                                                Console.Write("You have navigated through guard interactions with some amount of suspicion!");
                                            }
                                            else if (guardLevel == 4)
                                            {
                                                Console.Write("You have navigated through guard interactions with a bit of suspicion!");
                                            }
                                            else if (guardLevel == 5)
                                            {
                                                Console.Write("You have navigated through guard interactions with a lot of suspicion!");
                                            }
                                            else
                                            {
                                                //Print error message for not stating an input/incorrectly typed option
                                                Console.ForegroundColor = ConsoleColor.Red;
                                                Console.WriteLine("ERROR: User has inputted an option not avaliable. Please restart.");
                                            }

                                            //Ending day tag
                                            Console.WriteLine("\nAs you conclude your meal you head to your cell ready to go to bed, knowing it is your last night here...");
                                            Console.WriteLine("\n\n\nPlease click enter to continue onto the next day.");
                                            Console.ReadLine();
                                        }

                                        //If for Gym, will avoid gaining a guard level but the map on escape will be slightly worse.
                                        if (userInput == "gym")
                                        {
                                            Console.WriteLine("You step inside the gym as you hear a guard slow down and glance into the gym spying you." +
                                            "\nYou quickly move over to a treadmill and begin jogging." +
                                            "\nThe guard walks off." +
                                            "\nGood job! You avoided rising suspicion with the guard." +
                                            "\nYou have a feeling the guards will be noticing you more often today so you follow the schedule accordingly for the remainder of the day." +
                                            "\nYou eventually end up in the dining hall and start mentally reviewing what you accomplished." +
                                            "\n\nYou choose to go solo in the vents mission" +
                                            "\nYou got as much of the route of the vents you could." +
                                            "\nYou narrowly avoided an altercation with a guard." +
                                            "\nWestview Prison Guard Level is: {0}", guardLevel);

                                            if (guardLevel == 0)
                                            {
                                                Console.Write("You have navigated through guard interactions with no suspicion!");
                                            }
                                            else if (guardLevel == 1)
                                            {
                                                Console.Write("You have navigated through guard interactions with a small amount of suspicion!");
                                            }
                                            else if (guardLevel == 2)
                                            {
                                                Console.Write("You have navigated through guard interactions with a little amount of suspicion!");
                                            }
                                            else if (guardLevel == 3)
                                            {
                                                Console.Write("You have navigated through guard interactions with some amount of suspicion!");
                                            }
                                            else if (guardLevel == 4)
                                            {
                                                Console.Write("You have navigated through guard interactions with a bit of suspicion!");
                                            }
                                            else if (guardLevel == 5)
                                            {
                                                Console.Write("You have navigated through guard interactions with a lot of suspicion!");
                                            }
                                            else
                                            {
                                                //Print error message for not stating an input/incorrectly typed option
                                                Console.ForegroundColor = ConsoleColor.Red;
                                                Console.WriteLine("ERROR: User has inputted an option not avaliable. Please restart.");
                                            }

                                            //Ending day tag
                                            Console.WriteLine("\nAs you conclude your meal you head to your cell ready to go to bed, knowing it is your last night here...");
                                            Console.WriteLine("\n\n\nPlease click enter to continue onto the next day.");
                                            Console.ReadLine();

                                            //INPUT THE DEC 22 CODE HERE
                                        }

                                        //Clear to signify next day
                                        Console.Clear();
                                        //Options to pick to spend your last day, print date at top 22
                                        Console.ForegroundColor = ConsoleColor.Cyan;
                                        Console.WriteLine("December 22 1997");
                                        Console.Write("\n\nToday is your last day at Westview Prison." +
                                            "\nAs nice as that sounds it almost feels sad." +
                                            "\nYou decide doing one last thing before you leave tonight will be a good end to this chapter of your life." +
                                            "\nYou could..." +
                                            "\n\nYou could workout in the gym" +
                                            "\nYou could hangout in the yard" +
                                            "\nYou could go do a job in the gardening area" +
                                            "\n\nWhich will you choose? (Workout, Hangout, Job, None");
                                        userInput = Console.ReadLine().ToLower().Trim();

                                        //every option will have 1 question one leading to guard level increase one will not. None will increase guard level no matter what. Workout will remove a level no matter what
                                        if (userInput == "workout")
                                        {
                                            //Clear for Player Convience
                                            Console.Clear();
                                            //Print intro for workout and present two options treadmill or weights
                                            Console.Write("You decide working out for a bit may clear your head!" +
                                                "\nYou arrive at the gym and you have two choices" +
                                                "\n\nWorking out on weights" +
                                                "\nRunning Treadmill" +
                                                "\n\n Which would you like to choose?");
                                            userInput = Console.ReadLine().ToLower().Trim();
                                        }
                                        else if (userInput == "hangout")
                                        {

                                        }
                                        else if (userInput == "job")
                                        {

                                        }
                                        else if (userInput == "none")
                                        {
                                            //This will just immediately raise guard level with a bit of dialogue first showing its a dumb idea.
                                            Console.WriteLine("You lay comfortably in your dorm bed choosing this as the best option." +
                                                "\nYou ignore the sense of odd feeling as you've never got to spend a day laying around doing nothing once at Westview." +
                                                "\nSurely a guard won't come by and see this..." +
                                                "\n\n Press enter to continute.");
                                            Console.ReadLine();

                                            //Guard level increases
                                            //static Flash screen to blue for guard stop
                                            Console.BackgroundColor = ConsoleColor.Blue;
                                            Console.Clear();
                                            Console.ForegroundColor = ConsoleColor.Black;

                                            //increase guard level by 1
                                            Console.WriteLine("A Guard has identified you doing a suspicious activity!!");
                                            guardLevel++;
                                            Console.WriteLine("\nWESTVIEW PRISON GUARD LEVEL +1 = {0} of 5, ", guardLevel);
                                            if (guardLevel == 0)
                                            {
                                                Console.Write("OOOOO");
                                            }
                                            else if (guardLevel == 1)
                                            {
                                                Console.Write("0OOOO");
                                            }
                                            else if (guardLevel == 2)
                                            {
                                                Console.Write("00OOO");
                                            }
                                            else if (guardLevel == 3)
                                            {
                                                Console.Write("000OO");
                                            }
                                            else if (guardLevel == 4)
                                            {
                                                Console.Write("0000O");
                                            }
                                            else if (guardLevel == 5)
                                            {
                                                Console.Write("00000");
                                            }
                                            Console.WriteLine("\n\nPlease click enter to continue... (it will flash back to black)");
                                            Console.ReadLine();

                                            //static Flash screen back to black
                                            Console.BackgroundColor = ConsoleColor.Black;
                                            Console.ForegroundColor = ConsoleColor.White;
                                            Console.Clear();

                                            //Intro tag saying what was suspicous.
                                            Console.WriteLine("You knew you wouldn't be able to lounge away all day without a Guard stopping you. Rats.");

                                        }



                                    }
                                    if (userInput == "leave")
                                    {

                                    }
                                }
                                else
                                {
                                    //Print error message for not stating an input/incorrectly typed option
                                    Console.ForegroundColor = ConsoleColor.Red;
                                    Console.WriteLine("ERROR: User has inputted an option not avaliable. Please restart.");
                                }
                            }
                            //For the gender female, assumingly all female prisoners give user the option among the 3 of them or solo. Provide short description of each NPC
                            else if (gender == 'F')
                            {
                                //Clear Console to keep it manageable on one screen
                                Console.Clear();
                                Console.WriteLine("Immediately you think of who you could ask while staring at the top of your cell." +
                                    "\nIt would need to be someone quick. Someone whos able to stay calm, after all this runs the risk of a huge extension of your prison time." +
                                    "Then 3 names appear in your head...");
                                //Blank Space for spacing purposes
                                Console.WriteLine();
                                //Print Gina's ID card stating Prison Name, Icon of character, ID number, Sentence end time, Charge, and barcode at bottom.
                                Console.WriteLine("------------------------------");
                                Console.WriteLine("| Westview Prison          G |");
                                Console.WriteLine("| Prisoner: Gina ID: 2781  O |");
                                Console.WriteLine("| Sentence Ends: 2011      | |");
                                Console.WriteLine("| Charge: Robbery          ^ |");
                                Console.WriteLine("||||||||||||||||||||||||||||||");
                                Console.WriteLine("------------------------------");
                                //Small tagling describing Gina (Gina is F prison help player option- she will sacrefice herself for the player)
                                Console.WriteLine("Gina. Someone you don't want to mess with at Westview. Fortunately, she's been kind to you." +
                                    "\nPerhaps this could be a great way to offer a thank you for that.");

                                //Blank Space for spacing purposes
                                Console.WriteLine();
                                //Print Lilac's ID card stating Prison Name, Icon of character, ID number, Sentence end time, Charge, and barcode at bottom.
                                Console.WriteLine("------------------------------");
                                Console.WriteLine("| Westview Prison          L |");
                                Console.WriteLine("| Prisoner: Lilac ID: 2156 O |");
                                Console.WriteLine("| Sentence Ends: 2030      | |");
                                Console.WriteLine("| Charge: Tax Fraud        ^ |");
                                Console.WriteLine("||||||||||||||||||||||||||||||");
                                Console.WriteLine("------------------------------");
                                //Small tagling describing Lilac (Lilac is F prison betray option- she will betray the player)
                                Console.WriteLine("Lilac. A prisoner who's made a name for herself. She's your cell neighbor. Always clear headed and sticks to plans." +
                                    "\nShe may be vital in a plan such as this.");

                                //Blank Space for spacing purposes
                                Console.WriteLine();
                                //Print Fran's ID card stating Prison Name, Icon of character, ID number, Sentence end time, Charge, and barcode at bottom.
                                Console.WriteLine("------------------------------");
                                Console.WriteLine("| Westview Prison          F |");
                                Console.WriteLine("| Prisoner: Fran ID: 9486  O |");
                                Console.WriteLine("| Sentence Ends: 2000      | |");
                                Console.WriteLine("| Charge: Insurance Fraud  ^ |");
                                Console.WriteLine("||||||||||||||||||||||||||||||");
                                Console.WriteLine("------------------------------");
                                //Small tagling describing Fran (Fran is F prison rat out option- she will rat out the player)
                                Console.WriteLine("Fran. You met her at your prison job. She has the job one over and would talk to you til your done. You may even dare to call her your friend." +
                                    "\n Maybe a friend would be nice to have while escaping.");

                                //Blank line for spacing
                                Console.WriteLine();
                                //Remind the Solo option.
                                Console.WriteLine("You realize that maybe even knowing your fellow prison mates, you might just be able to pull off this alone." +
                                    "\nThe question is do you want to?");

                                //Blank line for spacing.
                                Console.WriteLine();

                                //Present the user options to pick between the individual prison partners or go solo
                                Console.Write("Who will you choose? (Gina, Lilac, Fran, or Alone): ");
                                userInput = Console.ReadLine().ToLower().Trim();

                                //If for Gina being choosen again HELPS PLAYER (sacrefice)
                                if (userInput == "gina")
                                {

                                }
                                //if for Lilac again BETRAYS PLAYER
                                else if (userInput == "lilac")
                                {

                                }
                                //if for Fran again RATS OUT PLAYER
                                else if (userInput == "fran")
                                {

                                }
                                //ALONE
                                else if (userInput == "alone")
                                {

                                }
                                else
                                {
                                    //Print error message for not stating an input/incorrectly typed option
                                    Console.ForegroundColor = ConsoleColor.Red;
                                    Console.WriteLine("ERROR: User has inputted an option not avaliable. Please restart.");
                                }
                            }
                            //For the gender other, assumingly co ed prisoners give user the option among the 3 of them or solo. Provide short description of each NPC
                            else if (gender == 'O')
                            {
                                //Clear Console to keep it manageable on one screen
                                Console.Clear();
                                Console.WriteLine("Immediately you think of who you could ask while staring at the top of your cell." +
                                    "\nIt would need to be someone quick. Someone whos able to stay calm, after all this runs the risk of a huge extension of your prison time." +
                                    "Then 3 names appear in your head...");
                                //Blank Space for spacing purposes
                                Console.WriteLine();
                                //Print Max's ID card stating Prison Name, Icon of character, ID number, Sentence end time, Charge, and barcode at bottom.
                                Console.WriteLine("------------------------------");
                                Console.WriteLine("| Westview Prison          M |");
                                Console.WriteLine("| Prisoner: Max  ID: 3158  O |");
                                Console.WriteLine("| Sentence Ends: 2003      | |");
                                Console.WriteLine("| Charge: Perjury          ^ |");
                                Console.WriteLine("||||||||||||||||||||||||||||||");
                                Console.WriteLine("------------------------------");
                                //Small tagling describing Max (Max is O prison rat out option- they will tell on the player)
                                Console.WriteLine("Max. They are often around you. Someone you regularly talk to in your free time. " +
                                    "\nWhile nothing but small talk, this may be give you the oppurtunity to further that allyship.");

                                //Blank Space for spacing purposes
                                Console.WriteLine();
                                //Print Donny's ID card stating Prison Name, Icon of character, ID number, Sentence end time, Charge, and barcode at bottom.
                                Console.WriteLine("------------------------------");
                                Console.WriteLine("| Westview Prison          V |");
                                Console.WriteLine("| Prisoner: Vicky ID: 4639 O |");
                                Console.WriteLine("| Sentence Ends: 2009      | |");
                                Console.WriteLine("| Charge: Stolen Property  ^ |");
                                Console.WriteLine("||||||||||||||||||||||||||||||");
                                Console.WriteLine("------------------------------");
                                //Small tagling describing Vicky (Vicky is O prison sacrefice option- they will sacrefice for the player)
                                Console.WriteLine("Vicky. Vicky is your cell mate neighbor. You have an unspoken if I dont say anything you don't agreement." +
                                    "\nMaybe that agreement could be the foundation of a partnership?");

                                //Blank Space for spacing purposes
                                Console.WriteLine();
                                //Print Clyde's ID card stating Prison Name, Icon of character, ID number, Sentence end time, Charge, and barcode at bottom.
                                Console.WriteLine("------------------------------");
                                Console.WriteLine("| Westview Prison          S |");
                                Console.WriteLine("| Prisoner: Siri  ID: 8462 O |");
                                Console.WriteLine("| Sentence Ends: 2028      | |");
                                Console.WriteLine("| Charge: Blackmail        ^ |");
                                Console.WriteLine("||||||||||||||||||||||||||||||");
                                Console.WriteLine("------------------------------");
                                //Small tagling describing Siri (Siri is O prison betray option- they will betray on the player)
                                Console.WriteLine("Siri. They are someone you've relied on often in your time here. One people tend to be kind to due to their chillingly calm demeanor." +
                                    "\nThat calmness is what you need. They make a great choice.");

                                //Blank line for spacing
                                Console.WriteLine();
                                //Remind the Solo option.
                                Console.WriteLine("You realize that maybe even knowing your fellow prison mates, you might just be able to pull off this alone." +
                                    "\nThe question is do you want to?");

                                //Blank line for spacing.
                                Console.WriteLine();

                                //Present the user options to pick between the individual prison partners or go solo
                                Console.Write("Who will you choose? (Max, Vicky, Siri, or Alone): ");
                                userInput = Console.ReadLine().ToLower().Trim();

                                //If for Max being choosen again RATS OUT PLAYER
                                if (userInput == "max")
                                {

                                }
                                //If for vicky being choosen again HELPS PLAYER (sacrefices for them)
                                else if (userInput == "vicky")
                                {

                                }
                                // if for keaton being choosen again BETRAYS PLAYER
                                else if (userInput == "siri")
                                {

                                }
                                //if for alone
                                else if (userInput == "alone")
                                {

                                }
                                else
                                {
                                    //Print error message for not stating an input/incorrectly typed option
                                    Console.ForegroundColor = ConsoleColor.Red;
                                    Console.WriteLine("ERROR: User has inputted an option not avaliable. Please restart.");
                                }
                            }
                            else
                            {
                                //Print error message for not stating an input/incorrectly typed option
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.WriteLine("ERROR: User has inputted an option not avaliable. Please restart.");
                            }
                        }
                        else if (userInput == "route")
                        {

                        }
                        else
                        {
                            //Print error message for not stating an input/incorrectly typed option
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("ERROR: User has inputted an option not avaliable. Please restart.");
                        }

                    }
                    else if (userInput == "halls")
                    {
                        //Clear page to clear up space and provide intro to halls
                        Console.Clear();
                        Console.WriteLine("The halls is a great idea, you\'re certain of it." +
                            "\nYou take a quick glance to the darkness past your steel cell." +
                            "\nEven in the darkness you can't see which way to go, and if you were to leave it would be this dark." +
                            "\nWhich means you would need to have the route memorize. After all, theres no room for error." +
                            "\nIt may be helpful having someone with you, like an ally, who can help memorize the route in a short amount of time." +
                            "\n\n What should you try and get first? (Ally or Route): ");
                        userInput = Console.ReadLine().Trim().ToLower();

                        //Detail if user inputs ally who the allys are off gender input earlier
                        if (userInput == "ally")
                        {
                            //For the gender Male, assumingly all male prisoners give user the option among the 3 of them or solo Provide short description of each NPC.
                            if (gender == 'M')
                            {
                                //Clear Console to keep it manageable on one screen
                                Console.Clear();
                                Console.WriteLine("Immediately you think of who you could ask while staring at the top of your cell." +
                                    "\nIt would need to be someone quick. Someone whos able to stay calm, after all this runs the risk of a huge extension of your prison time." +
                                    "Then 3 names appear in your head...");
                                //Blank Space for spacing purposes
                                Console.WriteLine();
                                //Print John's ID card stating Prison Name, Icon of character, ID number, Sentence end time, Charge, and barcode at bottom.
                                Console.WriteLine("------------------------------");
                                Console.WriteLine("| Westview Prison          J |");
                                Console.WriteLine("| Prisoner: John ID: 5846  O |");
                                Console.WriteLine("| Sentence Ends: 1998      | |");
                                Console.WriteLine("| Charge: Larceny          ^ |");
                                Console.WriteLine("||||||||||||||||||||||||||||||");
                                Console.WriteLine("------------------------------");
                                //Small tagling describing John (John is M prison rat out option- he will tell on the player)
                                Console.WriteLine("John. You're cell neighbor. He's always been quiet, calm. \nHe might be the perfect choice.");

                                //Blank Space for spacing purposes
                                Console.WriteLine();
                                //Print Donny's ID card stating Prison Name, Icon of character, ID number, Sentence end time, Charge, and barcode at bottom.
                                Console.WriteLine("------------------------------");
                                Console.WriteLine("| Westview Prison          D |");
                                Console.WriteLine("| Prisoner: Donny ID: 5846 O |");
                                Console.WriteLine("| Sentence Ends: 2015      | |");
                                Console.WriteLine("| Charge: Forgery          ^ |");
                                Console.WriteLine("||||||||||||||||||||||||||||||");
                                Console.WriteLine("------------------------------");
                                //Small tagling describing Donny (Donny is M prison sacrefice option- he will sacrefice himself for the player)
                                Console.WriteLine("Donny. Donny has always been someone you've relied on in your time here. \nHe seems like a great option.");

                                //Blank Space for spacing purposes
                                Console.WriteLine();
                                //Print Clyde's ID card stating Prison Name, Icon of character, ID number, Sentence end time, Charge, and barcode at bottom.
                                Console.WriteLine("------------------------------");
                                Console.WriteLine("| Westview Prison          C |");
                                Console.WriteLine("| Prisoner: Clyde ID: 4759 O |");
                                Console.WriteLine("| Sentence Ends: 2005      | |");
                                Console.WriteLine("| Charge: Arson            ^ |");
                                Console.WriteLine("||||||||||||||||||||||||||||||");
                                Console.WriteLine("------------------------------");
                                //Small tagling describing Clyde (Clyde is M prison betray option- he will betray on the player)
                                Console.WriteLine("Clyde. He tends to eat at the same table as you. He's helped you before when you're behind on your tasks." +
                                    "\nMaybe he'll help you on this? ");

                                //Blank line for spacing
                                Console.WriteLine();
                                //Remind the Solo option.
                                Console.WriteLine("You realize that maybe even knowing your fellow prison mates, you might just be able to pull off this alone." +
                                    "\nThe question is do you want to?");

                                //Blank line for spacing.
                                Console.WriteLine();

                                //Present the user options to pick between the individual prison partners or go solo
                                Console.Write("Who will you choose? (John, Donny, Clyde, or Alone): ");
                                userInput = Console.ReadLine().ToLower().Trim();

                                //If for John being choosen again RATS OUT
                                if (userInput == "john")
                                {

                                }
                                //if for donny again HELPS PLAYER (sacrefice)
                                else if (userInput == "donny")
                                {

                                }
                                //if for clyde again BETRAYS PLAYER
                                else if (userInput == "clyde")
                                {

                                }
                                else if (userInput == "alone")
                                {

                                }
                                else
                                {
                                    //Print error message for not stating an input/incorrectly typed option
                                    Console.ForegroundColor = ConsoleColor.Red;
                                    Console.WriteLine("ERROR: User has inputted an option not avaliable. Please restart.");
                                }
                            }
                            //For the gender female, assumingly all female prisoners give user the option among the 3 of them or solo. Provide short description of each NPC
                            else if (gender == 'F')
                            {
                                //Clear Console to keep it manageable on one screen
                                Console.Clear();
                                Console.WriteLine("Immediately you think of who you could ask while staring at the top of your cell." +
                                    "\nIt would need to be someone quick. Someone whos able to stay calm, after all this runs the risk of a huge extension of your prison time." +
                                    "Then 3 names appear in your head...");
                                //Blank Space for spacing purposes
                                Console.WriteLine();
                                //Print Gina's ID card stating Prison Name, Icon of character, ID number, Sentence end time, Charge, and barcode at bottom.
                                Console.WriteLine("------------------------------");
                                Console.WriteLine("| Westview Prison          G |");
                                Console.WriteLine("| Prisoner: Gina ID: 2781  O |");
                                Console.WriteLine("| Sentence Ends: 2011      | |");
                                Console.WriteLine("| Charge: Robbery          ^ |");
                                Console.WriteLine("||||||||||||||||||||||||||||||");
                                Console.WriteLine("------------------------------");
                                //Small tagling describing Gina (Gina is F prison help player option- she will sacrefice herself for the player)
                                Console.WriteLine("Gina. Someone you don't want to mess with at Westview. Fortunately, she's been kind to you." +
                                    "\nPerhaps this could be a great way to offer a thank you for that.");

                                //Blank Space for spacing purposes
                                Console.WriteLine();
                                //Print Lilac's ID card stating Prison Name, Icon of character, ID number, Sentence end time, Charge, and barcode at bottom.
                                Console.WriteLine("------------------------------");
                                Console.WriteLine("| Westview Prison          L |");
                                Console.WriteLine("| Prisoner: Lilac ID: 2156 O |");
                                Console.WriteLine("| Sentence Ends: 2030      | |");
                                Console.WriteLine("| Charge: Tax Fraud        ^ |");
                                Console.WriteLine("||||||||||||||||||||||||||||||");
                                Console.WriteLine("------------------------------");
                                //Small tagling describing Lilac (Lilac is F prison betray option- she will betray the player)
                                Console.WriteLine("Lilac. A prisoner who's made a name for herself. She's your cell neighbor. Always clear headed and sticks to plans." +
                                    "\nShe may be vital in a plan such as this.");

                                //Blank Space for spacing purposes
                                Console.WriteLine();
                                //Print Fran's ID card stating Prison Name, Icon of character, ID number, Sentence end time, Charge, and barcode at bottom.
                                Console.WriteLine("------------------------------");
                                Console.WriteLine("| Westview Prison          F |");
                                Console.WriteLine("| Prisoner: Fran ID: 9486  O |");
                                Console.WriteLine("| Sentence Ends: 2000      | |");
                                Console.WriteLine("| Charge: Insurance Fraud  ^ |");
                                Console.WriteLine("||||||||||||||||||||||||||||||");
                                Console.WriteLine("------------------------------");
                                //Small tagling describing Fran (Fran is F prison rat out option- she will rat out the player)
                                Console.WriteLine("Fran. You met her at your prison job. She has the job one over and would talk to you til your done. You may even dare to call her your friend." +
                                    "\n Maybe a friend would be nice to have while escaping.");

                                //Blank line for spacing
                                Console.WriteLine();
                                //Remind the Solo option.
                                Console.WriteLine("You realize that maybe even knowing your fellow prison mates, you might just be able to pull off this alone." +
                                    "\nThe question is do you want to?");

                                //Blank line for spacing.
                                Console.WriteLine();

                                //Present the user options to pick between the individual prison partners or go solo
                                Console.Write("Who will you choose? (Gina, Lilac, Fran, or Alone): ");
                                userInput = Console.ReadLine().ToLower().Trim();

                                //If for Gina being choosen again HELPS PLAYER (sacrefice)
                                if (userInput == "gina")
                                {

                                }
                                //if for Lilac again BETRAYS PLAYER
                                else if (userInput == "lilac")
                                {

                                }
                                //if for Fran again RATS OUT PLAYER
                                else if (userInput == "fran")
                                {

                                }
                                else if (userInput == "alone")
                                {

                                }
                                else
                                {
                                    //Print error message for not stating an input/incorrectly typed option
                                    Console.ForegroundColor = ConsoleColor.Red;
                                    Console.WriteLine("ERROR: User has inputted an option not avaliable. Please restart.");
                                }
                            }
                            //For the gender other, assumingly co ed prisoners give user the option among the 3 of them or solo. Provide short description of each NPC
                            else if (gender == 'O')
                            {
                                //Clear Console to keep it manageable on one screen
                                Console.Clear();
                                Console.WriteLine("Immediately you think of who you could ask while staring at the top of your cell." +
                                    "\nIt would need to be someone quick. Someone whos able to stay calm, after all this runs the risk of a huge extension of your prison time." +
                                    "Then 3 names appear in your head...");
                                //Blank Space for spacing purposes
                                Console.WriteLine();
                                //Print Max's ID card stating Prison Name, Icon of character, ID number, Sentence end time, Charge, and barcode at bottom.
                                Console.WriteLine("------------------------------");
                                Console.WriteLine("| Westview Prison          M |");
                                Console.WriteLine("| Prisoner: Max  ID: 3158  O |");
                                Console.WriteLine("| Sentence Ends: 2003      | |");
                                Console.WriteLine("| Charge: Perjury          ^ |");
                                Console.WriteLine("||||||||||||||||||||||||||||||");
                                Console.WriteLine("------------------------------");
                                //Small tagling describing Max (Max is O prison rat out option- they will tell on the player)
                                Console.WriteLine("Max. They are often around you. Someone you regularly talk to in your free time. " +
                                    "\nWhile nothing but small talk, this may be give you the oppurtunity to further that allyship.");

                                //Blank Space for spacing purposes
                                Console.WriteLine();
                                //Print Donny's ID card stating Prison Name, Icon of character, ID number, Sentence end time, Charge, and barcode at bottom.
                                Console.WriteLine("------------------------------");
                                Console.WriteLine("| Westview Prison          V |");
                                Console.WriteLine("| Prisoner: Vicky ID: 4639 O |");
                                Console.WriteLine("| Sentence Ends: 2009      | |");
                                Console.WriteLine("| Charge: Stolen Property  ^ |");
                                Console.WriteLine("||||||||||||||||||||||||||||||");
                                Console.WriteLine("------------------------------");
                                //Small tagling describing Vicky (Vicky is O prison sacrefice option- they will sacrefice for the player)
                                Console.WriteLine("Vicky. Vicky is your cell mate neighbor. You have an unspoken if I dont say anything you don't agreement." +
                                    "\nMaybe that agreement could be the foundation of a partnership?");

                                //Blank Space for spacing purposes
                                Console.WriteLine();
                                //Print Clyde's ID card stating Prison Name, Icon of character, ID number, Sentence end time, Charge, and barcode at bottom.
                                Console.WriteLine("------------------------------");
                                Console.WriteLine("| Westview Prison          S |");
                                Console.WriteLine("| Prisoner: Siri  ID: 8462 O |");
                                Console.WriteLine("| Sentence Ends: 2028      | |");
                                Console.WriteLine("| Charge: Blackmail        ^ |");
                                Console.WriteLine("||||||||||||||||||||||||||||||");
                                Console.WriteLine("------------------------------");
                                //Small tagling describing Siri (Siri is O prison betray option- they will betray on the player)
                                Console.WriteLine("Siri. They are someone you've relied on often in your time here. One people tend to be kind to due to their chillingly calm demeanor." +
                                    "\nThat calmness is what you need. They make a great choice.");

                                //Blank line for spacing
                                Console.WriteLine();
                                //Remind the Solo option.
                                Console.WriteLine("You realize that maybe even knowing your fellow prison mates, you might just be able to pull off this alone." +
                                    "\nThe question is do you want to?");

                                //Blank line for spacing.
                                Console.WriteLine();

                                //Present the user options to pick between the individual prison partners or go solo
                                Console.Write("Who will you choose? (Max, Vicky, Siri, or Alone): ");
                                userInput = Console.ReadLine().ToLower().Trim();

                                //If for Max being choosen again RATS OUT PLAYER
                                if (userInput == "max")
                                {

                                }
                                //If for vicky being choosen again HELPS PLAYER (sacrefices for them)
                                else if (userInput == "vicky")
                                {

                                }
                                // if for keaton being choosen again BETRAYS PLAYER
                                else if (userInput == "siri")
                                {

                                }
                                //if for alone
                                else if (userInput == "alone")
                                {

                                }
                                else
                                {
                                    //Print error message for not stating an input/incorrectly typed option
                                    Console.ForegroundColor = ConsoleColor.Red;
                                    Console.WriteLine("ERROR: User has inputted an option not avaliable. Please restart.");
                                }
                            }
                        }

                        //Detail if user puts route the start of going through the halls and exploring (create map as the user goes)
                        else if (userInput == "route")
                        {

                        }
                        else
                        {
                            //Print error message for not stating an input/incorrectly typed option
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("ERROR: User has inputted an option not avaliable. Please restart.");
                        }

                    }
                    else if (userInput == "run")
                    {
                        //Clear page to clear up space and provide intro to run
                        Console.Clear();
                        Console.WriteLine("Run for it? Surely you\'re fast enough to outrun guards!" +
                            "\nFrom your memory the run from the yard to the front gate is less than 5 minutes." +
                            "\nSurely, you can handle that!" +
                            "\nEven then it may be beneficial to figure out the guard rotation... Perhaps going for the run then will be most successful." +
                            "\nIt could be a good idea finding someone to help you run for it. More eyes is always helpful watching guards." +
                            "\n\n What should you try and get first? (Ally or Guards): ");
                        userInput = Console.ReadLine().Trim().ToLower();

                        //Detail if user inputs ally who the allys are off gender input earlier
                        if (userInput == "ally")
                        {
                            //For the gender Male, assumingly all male prisoners give user the option among the 3 of them or solo Provide short description of each NPC.
                            if (gender == 'M')
                            {
                                //Clear Console to keep it manageable on one screen
                                Console.Clear();
                                Console.WriteLine("Immediately you think of who you could ask while staring at the top of your cell." +
                                    "\nIt would need to be someone quick. Someone whos able to stay calm, after all this runs the risk of a huge extension of your prison time." +
                                    "Then 3 names appear in your head...");
                                //Blank Space for spacing purposes
                                Console.WriteLine();
                                //Print John's ID card stating Prison Name, Icon of character, ID number, Sentence end time, Charge, and barcode at bottom.
                                Console.WriteLine("------------------------------");
                                Console.WriteLine("| Westview Prison          J |");
                                Console.WriteLine("| Prisoner: John ID: 5846  O |");
                                Console.WriteLine("| Sentence Ends: 1998      | |");
                                Console.WriteLine("| Charge: Larceny          ^ |");
                                Console.WriteLine("||||||||||||||||||||||||||||||");
                                Console.WriteLine("------------------------------");
                                //Small tagling describing John (John is M prison rat out option- he will tell on the player)
                                Console.WriteLine("John. You're cell neighbor. He's always been quiet, calm. \nHe might be the perfect choice.");

                                //Blank Space for spacing purposes
                                Console.WriteLine();
                                //Print Donny's ID card stating Prison Name, Icon of character, ID number, Sentence end time, Charge, and barcode at bottom.
                                Console.WriteLine("------------------------------");
                                Console.WriteLine("| Westview Prison          D |");
                                Console.WriteLine("| Prisoner: Donny ID: 5846 O |");
                                Console.WriteLine("| Sentence Ends: 2015      | |");
                                Console.WriteLine("| Charge: Forgery          ^ |");
                                Console.WriteLine("||||||||||||||||||||||||||||||");
                                Console.WriteLine("------------------------------");
                                //Small tagling describing Donny (Donny is M prison sacrefice option- he will sacrefice himself for the player)
                                Console.WriteLine("Donny. Donny has always been someone you've relied on in your time here. \nHe seems like a great option.");

                                //Blank Space for spacing purposes
                                Console.WriteLine();
                                //Print Clyde's ID card stating Prison Name, Icon of character, ID number, Sentence end time, Charge, and barcode at bottom.
                                Console.WriteLine("------------------------------");
                                Console.WriteLine("| Westview Prison          C |");
                                Console.WriteLine("| Prisoner: Clyde ID: 4759 O |");
                                Console.WriteLine("| Sentence Ends: 2005      | |");
                                Console.WriteLine("| Charge: Arson            ^ |");
                                Console.WriteLine("||||||||||||||||||||||||||||||");
                                Console.WriteLine("------------------------------");
                                //Small tagling describing Clyde (Clyde is M prison betray option- he will betray on the player)
                                Console.WriteLine("Clyde. He tends to eat at the same table as you. He's helped you before when you're behind on your tasks." +
                                    "\nMaybe he'll help you on this? ");

                                //Blank line for spacing
                                Console.WriteLine();
                                //Remind the Solo option.
                                Console.WriteLine("You realize that maybe even knowing your fellow prison mates, you might just be able to pull off this alone." +
                                    "\nThe question is do you want to?");

                                //Blank line for spacing.
                                Console.WriteLine();

                                //Present the user options to pick between the individual prison partners or go solo
                                Console.Write("Who will you choose? (John, Donny, Clyde, or Alone): ");
                                userInput = Console.ReadLine().ToLower().Trim();

                                //If for John being choosen again RATS OUT
                                if (userInput == "john")
                                {

                                }
                                //if for donny again HELPS PLAYER (sacrefice)
                                else if (userInput == "donny")
                                {

                                }
                                //if for clyde again BETRAYS PLAYER
                                else if (userInput == "clyde")
                                {

                                }
                                else if (userInput == "alone")
                                {

                                }
                                else
                                {
                                    //Print error message for not stating an input/incorrectly typed option
                                    Console.ForegroundColor = ConsoleColor.Red;
                                    Console.WriteLine("ERROR: User has inputted an option not avaliable. Please restart.");
                                }
                            }
                            //For the gender female, assumingly all female prisoners give user the option among the 3 of them or solo. Provide short description of each NPC
                            else if (gender == 'F')
                            {
                                //Clear Console to keep it manageable on one screen
                                Console.Clear();
                                Console.WriteLine("Immediately you think of who you could ask while staring at the top of your cell." +
                                    "\nIt would need to be someone quick. Someone whos able to stay calm, after all this runs the risk of a huge extension of your prison time." +
                                    "Then 3 names appear in your head...");
                                //Blank Space for spacing purposes
                                Console.WriteLine();
                                //Print Gina's ID card stating Prison Name, Icon of character, ID number, Sentence end time, Charge, and barcode at bottom.
                                Console.WriteLine("------------------------------");
                                Console.WriteLine("| Westview Prison          G |");
                                Console.WriteLine("| Prisoner: Gina ID: 2781  O |");
                                Console.WriteLine("| Sentence Ends: 2011      | |");
                                Console.WriteLine("| Charge: Robbery          ^ |");
                                Console.WriteLine("||||||||||||||||||||||||||||||");
                                Console.WriteLine("------------------------------");
                                //Small tagling describing Gina (Gina is F prison help player option- she will sacrefice herself for the player)
                                Console.WriteLine("Gina. Someone you don't want to mess with at Westview. Fortunately, she's been kind to you." +
                                    "\nPerhaps this could be a great way to offer a thank you for that.");

                                //Blank Space for spacing purposes
                                Console.WriteLine();
                                //Print Lilac's ID card stating Prison Name, Icon of character, ID number, Sentence end time, Charge, and barcode at bottom.
                                Console.WriteLine("------------------------------");
                                Console.WriteLine("| Westview Prison          L |");
                                Console.WriteLine("| Prisoner: Lilac ID: 2156 O |");
                                Console.WriteLine("| Sentence Ends: 2030      | |");
                                Console.WriteLine("| Charge: Tax Fraud        ^ |");
                                Console.WriteLine("||||||||||||||||||||||||||||||");
                                Console.WriteLine("------------------------------");
                                //Small tagling describing Lilac (Lilac is F prison betray option- she will betray the player)
                                Console.WriteLine("Lilac. A prisoner who's made a name for herself. She's your cell neighbor. Always clear headed and sticks to plans." +
                                    "\nShe may be vital in a plan such as this.");

                                //Blank Space for spacing purposes
                                Console.WriteLine();
                                //Print Fran's ID card stating Prison Name, Icon of character, ID number, Sentence end time, Charge, and barcode at bottom.
                                Console.WriteLine("------------------------------");
                                Console.WriteLine("| Westview Prison          F |");
                                Console.WriteLine("| Prisoner: Fran ID: 9486  O |");
                                Console.WriteLine("| Sentence Ends: 2000      | |");
                                Console.WriteLine("| Charge: Insurance Fraud  ^ |");
                                Console.WriteLine("||||||||||||||||||||||||||||||");
                                Console.WriteLine("------------------------------");
                                //Small tagling describing Fran (Fran is F prison rat out option- she will rat out the player)
                                Console.WriteLine("Fran. You met her at your prison job. She has the job one over and would talk to you til your done. You may even dare to call her your friend." +
                                    "\n Maybe a friend would be nice to have while escaping.");

                                //Blank line for spacing
                                Console.WriteLine();
                                //Remind the Solo option.
                                Console.WriteLine("You realize that maybe even knowing your fellow prison mates, you might just be able to pull off this alone." +
                                    "\nThe question is do you want to?");

                                //Blank line for spacing.
                                Console.WriteLine();

                                //Present the user options to pick between the individual prison partners or go solo
                                Console.Write("Who will you choose? (Gina, Lilac, Fran, or Alone): ");
                                userInput = Console.ReadLine().ToLower().Trim();

                                //If for Gina being choosen again HELPS PLAYER (sacrefice)
                                if (userInput == "gina")
                                {

                                }
                                //if for Lilac again BETRAYS PLAYER
                                else if (userInput == "lilac")
                                {

                                }
                                //if for Fran again RATS OUT PLAYER
                                else if (userInput == "fran")
                                {

                                }
                                else if (userInput == "alone")
                                {

                                }
                                else
                                {
                                    //Print error message for not stating an input/incorrectly typed option
                                    Console.ForegroundColor = ConsoleColor.Red;
                                    Console.WriteLine("ERROR: User has inputted an option not avaliable. Please restart.");
                                }
                            }
                            //For the gender other, assumingly co ed prisoners give user the option among the 3 of them or solo. Provide short description of each NPC
                            else if (gender == 'O')
                            {
                                //Clear Console to keep it manageable on one screen
                                Console.Clear();
                                Console.WriteLine("Immediately you think of who you could ask while staring at the top of your cell." +
                                    "\nIt would need to be someone quick. Someone whos able to stay calm, after all this runs the risk of a huge extension of your prison time." +
                                    "Then 3 names appear in your head...");
                                //Blank Space for spacing purposes
                                Console.WriteLine();
                                //Print Max's ID card stating Prison Name, Icon of character, ID number, Sentence end time, Charge, and barcode at bottom.
                                Console.WriteLine("------------------------------");
                                Console.WriteLine("| Westview Prison          M |");
                                Console.WriteLine("| Prisoner: Max  ID: 3158  O |");
                                Console.WriteLine("| Sentence Ends: 2003      | |");
                                Console.WriteLine("| Charge: Perjury          ^ |");
                                Console.WriteLine("||||||||||||||||||||||||||||||");
                                Console.WriteLine("------------------------------");
                                //Small tagling describing Max (Max is O prison rat out option- they will tell on the player)
                                Console.WriteLine("Max. They are often around you. Someone you regularly talk to in your free time. " +
                                    "\nWhile nothing but small talk, this may be give you the oppurtunity to further that allyship.");

                                //Blank Space for spacing purposes
                                Console.WriteLine();
                                //Print Donny's ID card stating Prison Name, Icon of character, ID number, Sentence end time, Charge, and barcode at bottom.
                                Console.WriteLine("------------------------------");
                                Console.WriteLine("| Westview Prison          V |");
                                Console.WriteLine("| Prisoner: Vicky ID: 4639 O |");
                                Console.WriteLine("| Sentence Ends: 2009      | |");
                                Console.WriteLine("| Charge: Stolen Property  ^ |");
                                Console.WriteLine("||||||||||||||||||||||||||||||");
                                Console.WriteLine("------------------------------");
                                //Small tagling describing Vicky (Vicky is O prison sacrefice option- they will sacrefice for the player)
                                Console.WriteLine("Vicky. Vicky is your cell mate neighbor. You have an unspoken if I dont say anything you don't agreement." +
                                    "\nMaybe that agreement could be the foundation of a partnership?");

                                //Blank Space for spacing purposes
                                Console.WriteLine();
                                //Print Clyde's ID card stating Prison Name, Icon of character, ID number, Sentence end time, Charge, and barcode at bottom.
                                Console.WriteLine("------------------------------");
                                Console.WriteLine("| Westview Prison          S |");
                                Console.WriteLine("| Prisoner: Siri  ID: 8462 O |");
                                Console.WriteLine("| Sentence Ends: 2028      | |");
                                Console.WriteLine("| Charge: Blackmail        ^ |");
                                Console.WriteLine("||||||||||||||||||||||||||||||");
                                Console.WriteLine("------------------------------");
                                //Small tagling describing Siri (Siri is O prison betray option- they will betray on the player)
                                Console.WriteLine("Siri. They are someone you've relied on often in your time here. One people tend to be kind to due to their chillingly calm demeanor." +
                                    "\nThat calmness is what you need. They make a great choice.");

                                //Blank line for spacing
                                Console.WriteLine();
                                //Remind the Solo option.
                                Console.WriteLine("You realize that maybe even knowing your fellow prison mates, you might just be able to pull off this alone." +
                                    "\nThe question is do you want to?");

                                //Blank line for spacing.
                                Console.WriteLine();

                                //Present the user options to pick between the individual prison partners or go solo
                                Console.Write("Who will you choose? (Max, Vicky, Siri, or Alone): ");
                                userInput = Console.ReadLine().ToLower().Trim();

                                //If for Max being choosen again RATS OUT PLAYER
                                if (userInput == "max")
                                {

                                }
                                //If for vicky being choosen again HELPS PLAYER (sacrefices for them)
                                else if (userInput == "vicky")
                                {

                                }
                                // if for keaton being choosen again BETRAYS PLAYER
                                else if (userInput == "siri")
                                {

                                }
                                //if for alone
                                else if (userInput == "alone")
                                {

                                }
                                else
                                {
                                    //Print error message for not stating an input/incorrectly typed option
                                    Console.ForegroundColor = ConsoleColor.Red;
                                    Console.WriteLine("ERROR: User has inputted an option not avaliable. Please restart.");
                                }
                            }
                        }
                        //Detail if user puts guards on how they idk figure it out
                        else if (userInput == "guards")
                        {

                        }
                        else
                        {
                            //Print error message for not stating an input/incorrectly typed option
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("ERROR: User has inputted an option not avaliable. Please restart.");
                        }
                    }
                    else if (userInput == "dig")
                    {
                        //Clear page to clear up space and provide intro to dug
                        Console.Clear();
                        Console.Write("Digging through the floor to the outside? " +
                            "\nSurely its possible right?" +
                            "\nWhat tool would be the best for the job? You ponder for a moment. A hammer would be best for the tile then a shovel for dirt." +
                            "\nYou could get those in the gardening shed!" +
                            "\nEven then it may be beneficial to figure out the guard rotation... Perhaps going for the run then will be most successful." +
                            "\nIt could be a good idea finding someone to help you run for it. More eyes is always helpful watching guards." +
                            "\n\n What should you try and get first? (Ally, Tools or Guards): ");
                        userInput = Console.ReadLine().Trim().ToLower();

                        //Detail if user inputs ally who the allys are off gender input earlier
                        if (userInput == "ally")
                        {
                            //For the gender Male, assumingly all male prisoners give user the option among the 3 of them or solo Provide short description of each NPC.
                            if (gender == 'M')
                            {
                                //Clear Console to keep it manageable on one screen
                                Console.Clear();
                                Console.WriteLine("Immediately you think of who you could ask while staring at the top of your cell." +
                                    "\nIt would need to be someone quick. Someone whos able to stay calm, after all this runs the risk of a huge extension of your prison time." +
                                    "Then 3 names appear in your head...");
                                //Blank Space for spacing purposes
                                Console.WriteLine();
                                //Print John's ID card stating Prison Name, Icon of character, ID number, Sentence end time, Charge, and barcode at bottom.
                                Console.WriteLine("------------------------------");
                                Console.WriteLine("| Westview Prison          J |");
                                Console.WriteLine("| Prisoner: John ID: 5846  O |");
                                Console.WriteLine("| Sentence Ends: 1998      | |");
                                Console.WriteLine("| Charge: Larceny          ^ |");
                                Console.WriteLine("||||||||||||||||||||||||||||||");
                                Console.WriteLine("------------------------------");
                                //Small tagling describing John (John is M prison rat out option- he will tell on the player)
                                Console.WriteLine("John. You're cell neighbor. He's always been quiet, calm. \nHe might be the perfect choice.");

                                //Blank Space for spacing purposes
                                Console.WriteLine();
                                //Print Donny's ID card stating Prison Name, Icon of character, ID number, Sentence end time, Charge, and barcode at bottom.
                                Console.WriteLine("------------------------------");
                                Console.WriteLine("| Westview Prison          D |");
                                Console.WriteLine("| Prisoner: Donny ID: 5846 O |");
                                Console.WriteLine("| Sentence Ends: 2015      | |");
                                Console.WriteLine("| Charge: Forgery          ^ |");
                                Console.WriteLine("||||||||||||||||||||||||||||||");
                                Console.WriteLine("------------------------------");
                                //Small tagling describing Donny (Donny is M prison sacrefice option- he will sacrefice himself for the player)
                                Console.WriteLine("Donny. Donny has always been someone you've relied on in your time here. \nHe seems like a great option.");

                                //Blank Space for spacing purposes
                                Console.WriteLine();
                                //Print Clyde's ID card stating Prison Name, Icon of character, ID number, Sentence end time, Charge, and barcode at bottom.
                                Console.WriteLine("------------------------------");
                                Console.WriteLine("| Westview Prison          C |");
                                Console.WriteLine("| Prisoner: Clyde ID: 4759 O |");
                                Console.WriteLine("| Sentence Ends: 2005      | |");
                                Console.WriteLine("| Charge: Arson            ^ |");
                                Console.WriteLine("||||||||||||||||||||||||||||||");
                                Console.WriteLine("------------------------------");
                                //Small tagling describing Clyde (Clyde is M prison betray option- he will betray on the player)
                                Console.WriteLine("Clyde. He tends to eat at the same table as you. He's helped you before when you're behind on your tasks." +
                                    "\nMaybe he'll help you on this? ");

                                //Blank line for spacing
                                Console.WriteLine();
                                //Remind the Solo option.
                                Console.WriteLine("You realize that maybe even knowing your fellow prison mates, you might just be able to pull off this alone." +
                                    "\nThe question is do you want to?");

                                //Blank line for spacing.
                                Console.WriteLine();

                                //Present the user options to pick between the individual prison partners or go solo
                                Console.Write("Who will you choose? (John, Donny, Clyde, or Alone): ");
                                userInput = Console.ReadLine().ToLower().Trim();

                                //If for John being choosen again RATS OUT
                                if (userInput == "john")
                                {

                                }
                                //if for donny again HELPS PLAYER (sacrefice)
                                else if (userInput == "donny")
                                {

                                }
                                //if for clyde again BETRAYS PLAYER
                                else if (userInput == "clyde")
                                {

                                }
                                else if (userInput == "alone")
                                {

                                }
                                else
                                {
                                    //Print error message for not stating an input/incorrectly typed option
                                    Console.ForegroundColor = ConsoleColor.Red;
                                    Console.WriteLine("ERROR: User has inputted an option not avaliable. Please restart.");
                                }
                            }
                            //For the gender female, assumingly all female prisoners give user the option among the 3 of them or solo. Provide short description of each NPC
                            else if (gender == 'F')
                            {
                                //Clear Console to keep it manageable on one screen
                                Console.Clear();
                                Console.WriteLine("Immediately you think of who you could ask while staring at the top of your cell." +
                                    "\nIt would need to be someone quick. Someone whos able to stay calm, after all this runs the risk of a huge extension of your prison time." +
                                    "Then 3 names appear in your head...");
                                //Blank Space for spacing purposes
                                Console.WriteLine();
                                //Print Gina's ID card stating Prison Name, Icon of character, ID number, Sentence end time, Charge, and barcode at bottom.
                                Console.WriteLine("------------------------------");
                                Console.WriteLine("| Westview Prison          G |");
                                Console.WriteLine("| Prisoner: Gina ID: 2781  O |");
                                Console.WriteLine("| Sentence Ends: 2011      | |");
                                Console.WriteLine("| Charge: Robbery          ^ |");
                                Console.WriteLine("||||||||||||||||||||||||||||||");
                                Console.WriteLine("------------------------------");
                                //Small tagling describing Gina (Gina is F prison help player option- she will sacrefice herself for the player)
                                Console.WriteLine("Gina. Someone you don't want to mess with at Westview. Fortunately, she's been kind to you." +
                                    "\nPerhaps this could be a great way to offer a thank you for that.");

                                //Blank Space for spacing purposes
                                Console.WriteLine();
                                //Print Lilac's ID card stating Prison Name, Icon of character, ID number, Sentence end time, Charge, and barcode at bottom.
                                Console.WriteLine("------------------------------");
                                Console.WriteLine("| Westview Prison          L |");
                                Console.WriteLine("| Prisoner: Lilac ID: 2156 O |");
                                Console.WriteLine("| Sentence Ends: 2030      | |");
                                Console.WriteLine("| Charge: Tax Fraud        ^ |");
                                Console.WriteLine("||||||||||||||||||||||||||||||");
                                Console.WriteLine("------------------------------");
                                //Small tagling describing Lilac (Lilac is F prison betray option- she will betray the player)
                                Console.WriteLine("Lilac. A prisoner who's made a name for herself. She's your cell neighbor. Always clear headed and sticks to plans." +
                                    "\nShe may be vital in a plan such as this.");

                                //Blank Space for spacing purposes
                                Console.WriteLine();
                                //Print Fran's ID card stating Prison Name, Icon of character, ID number, Sentence end time, Charge, and barcode at bottom.
                                Console.WriteLine("------------------------------");
                                Console.WriteLine("| Westview Prison          F |");
                                Console.WriteLine("| Prisoner: Fran ID: 9486  O |");
                                Console.WriteLine("| Sentence Ends: 2000      | |");
                                Console.WriteLine("| Charge: Insurance Fraud  ^ |");
                                Console.WriteLine("||||||||||||||||||||||||||||||");
                                Console.WriteLine("------------------------------");
                                //Small tagling describing Fran (Fran is F prison rat out option- she will rat out the player)
                                Console.WriteLine("Fran. You met her at your prison job. She has the job one over and would talk to you til your done. You may even dare to call her your friend." +
                                    "\n Maybe a friend would be nice to have while escaping.");

                                //Blank line for spacing
                                Console.WriteLine();
                                //Remind the Solo option.
                                Console.WriteLine("You realize that maybe even knowing your fellow prison mates, you might just be able to pull off this alone." +
                                    "\nThe question is do you want to?");

                                //Blank line for spacing.
                                Console.WriteLine();

                                //Present the user options to pick between the individual prison partners or go solo
                                Console.Write("Who will you choose? (Gina, Lilac, Fran, or Alone): ");
                                userInput = Console.ReadLine().ToLower().Trim();

                                //If for Gina being choosen again HELPS PLAYER (sacrefice)
                                if (userInput == "gina")
                                {

                                }
                                //if for Lilac again BETRAYS PLAYER
                                else if (userInput == "lilac")
                                {

                                }
                                //if for Fran again RATS OUT PLAYER
                                else if (userInput == "fran")
                                {

                                }
                                else if (userInput == "alone")
                                {

                                }
                                else
                                {
                                    //Print error message for not stating an input/incorrectly typed option
                                    Console.ForegroundColor = ConsoleColor.Red;
                                    Console.WriteLine("ERROR: User has inputted an option not avaliable. Please restart.");
                                }
                            }
                            //For the gender other, assumingly co ed prisoners give user the option among the 3 of them or solo. Provide short description of each NPC
                            else if (gender == 'O')
                            {
                                //Clear Console to keep it manageable on one screen
                                Console.Clear();
                                Console.WriteLine("Immediately you think of who you could ask while staring at the top of your cell." +
                                    "\nIt would need to be someone quick. Someone whos able to stay calm, after all this runs the risk of a huge extension of your prison time." +
                                    "Then 3 names appear in your head...");
                                //Blank Space for spacing purposes
                                Console.WriteLine();
                                //Print Max's ID card stating Prison Name, Icon of character, ID number, Sentence end time, Charge, and barcode at bottom.
                                Console.WriteLine("------------------------------");
                                Console.WriteLine("| Westview Prison          M |");
                                Console.WriteLine("| Prisoner: Max  ID: 3158  O |");
                                Console.WriteLine("| Sentence Ends: 2003      | |");
                                Console.WriteLine("| Charge: Perjury          ^ |");
                                Console.WriteLine("||||||||||||||||||||||||||||||");
                                Console.WriteLine("------------------------------");
                                //Small tagling describing Max (Max is O prison rat out option- they will tell on the player)
                                Console.WriteLine("Max. They are often around you. Someone you regularly talk to in your free time. " +
                                    "\nWhile nothing but small talk, this may be give you the oppurtunity to further that allyship.");

                                //Blank Space for spacing purposes
                                Console.WriteLine();
                                //Print Donny's ID card stating Prison Name, Icon of character, ID number, Sentence end time, Charge, and barcode at bottom.
                                Console.WriteLine("------------------------------");
                                Console.WriteLine("| Westview Prison          V |");
                                Console.WriteLine("| Prisoner: Vicky ID: 4639 O |");
                                Console.WriteLine("| Sentence Ends: 2009      | |");
                                Console.WriteLine("| Charge: Stolen Property  ^ |");
                                Console.WriteLine("||||||||||||||||||||||||||||||");
                                Console.WriteLine("------------------------------");
                                //Small tagling describing Vicky (Vicky is O prison sacrefice option- they will sacrefice for the player)
                                Console.WriteLine("Vicky. Vicky is your cell mate neighbor. You have an unspoken if I dont say anything you don't agreement." +
                                    "\nMaybe that agreement could be the foundation of a partnership?");

                                //Blank Space for spacing purposes
                                Console.WriteLine();
                                //Print Clyde's ID card stating Prison Name, Icon of character, ID number, Sentence end time, Charge, and barcode at bottom.
                                Console.WriteLine("------------------------------");
                                Console.WriteLine("| Westview Prison          S |");
                                Console.WriteLine("| Prisoner: Siri  ID: 8462 O |");
                                Console.WriteLine("| Sentence Ends: 2028      | |");
                                Console.WriteLine("| Charge: Blackmail        ^ |");
                                Console.WriteLine("||||||||||||||||||||||||||||||");
                                Console.WriteLine("------------------------------");
                                //Small tagling describing Siri (Siri is O prison betray option- they will betray on the player)
                                Console.WriteLine("Siri. They are someone you've relied on often in your time here. One people tend to be kind to due to their chillingly calm demeanor." +
                                    "\nThat calmness is what you need. They make a great choice.");

                                //Blank line for spacing
                                Console.WriteLine();
                                //Remind the Solo option.
                                Console.WriteLine("You realize that maybe even knowing your fellow prison mates, you might just be able to pull off this alone." +
                                    "\nThe question is do you want to?");

                                //Blank line for spacing.
                                Console.WriteLine();

                                //Present the user options to pick between the individual prison partners or go solo
                                Console.Write("Who will you choose? (Max, Vicky, Siri, or Alone): ");
                                userInput = Console.ReadLine().ToLower().Trim();

                                //If for Max being choosen again RATS OUT PLAYER
                                if (userInput == "max")
                                {

                                }
                                //If for vicky being choosen again HELPS PLAYER (sacrefices for them)
                                else if (userInput == "vicky")
                                {

                                }
                                // if for keaton being choosen again BETRAYS PLAYER
                                else if (userInput == "siri")
                                {

                                }
                                //if for alone
                                else if (userInput == "alone")
                                {

                                }
                                else
                                {
                                    //Print error message for not stating an input/incorrectly typed option
                                    Console.ForegroundColor = ConsoleColor.Red;
                                    Console.WriteLine("ERROR: User has inputted an option not avaliable. Please restart.");
                                }
                            }
                        }
                        //Detail if user puts guards on how they idk figure it out
                        else if (userInput == "guards")
                        {

                        }
                        //Detail if user put tools how they retrieve and sneakily get them from the shed
                        else if (userInput == "tools")
                        {

                        }
                        else
                        {
                            //Print error message for not stating an input/incorrectly typed option
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("ERROR: User has inputted an option not avaliable. Please restart.");
                        }
                    }

                    else
                    {
                        //Provide error message for inputting no option
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("ERROR: User has inputted an option not avaliable. Please restart.");
                    }

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
            //Option for Credits on Game Menu
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
