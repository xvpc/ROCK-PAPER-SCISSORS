class Program{
    static void Main(string[] args){
        bool Playing = true;
        Random random = new Random();
        String Player;
        String Computer;
        String PlayAgain;

        while(Playing){
            Player = "";
            Computer = "";

            while(Player != "ROCK" && Player != "PAPER" && Player != "SCISSORS"){
                Console.WriteLine("Choose ROCK PAPER OR SCISSORS");
                Player = Console.ReadLine().ToUpper();
            }

            switch(random.Next(1, 4)){
                case 1:
                    Computer = "ROCK";
                    break;
                case 2:
                    Computer = "PAPER";
                    break;
                case 3:
                    Computer = "SCISSORS";
                    break;
            }
            Console.WriteLine("You Chooes: " + Player);
            Console.WriteLine("Computer Chooes: " + Computer);
            switch(Player){
                case "ROCK":
                    if(Computer == "ROCK"){
                        Console.WriteLine("It's A Draw!");
                    }else if(Computer == "PAPER"){
                        Console.WriteLine("You Lost!");
                    }else{
                        Console.WriteLine("You Won!");
                    }
                    break;
                case "PAPER":
                    if(Computer == "PAPER"){
                        Console.WriteLine("It's A Draw!");
                    }else if(Computer == "SCISSORS"){
                        Console.WriteLine("You Lost!");
                    }else{
                        Console.WriteLine("You Won!");
                    }
                    break;
                case "SCISSORS":
                    if(Computer == "SCISSORS"){
                        Console.WriteLine("It's A Draw!");
                    }else if(Computer == "ROCK"){
                        Console.WriteLine("You Lost!");
                    }else{
                        Console.WriteLine("You Won!");
                    }
                    break;
            }
            Console.WriteLine("Want to play again? yes/no");
            PlayAgain = Console.ReadLine().ToLower();
            if(PlayAgain != "yes" && PlayAgain != "y"){
                Playing = false;
            }
        }

        Console.WriteLine("Thanks for playing!, Bye");

        Console.ReadKey();
    }
}