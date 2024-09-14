
class Program{
    static void Main(){
        string enjoymentLevel = "";
        while(enjoymentLevel != "exit"){
            Menu();
            enjoymentLevel = GetEnjoymentLevel().ToLower();
            if(enjoymentLevel == "exit"){
                Exit();
                break;
            }
            string stadium = GetStadiumRecommendations(enjoymentLevel);
            if(stadium != ""){
                string game = GetGameRecommendations(stadium);
                DisplayStadiumDetails(stadium, game);
            }
        }
    }

    static void Menu(){
        Console.Clear();
        System.Console.WriteLine("Welcome to College Football Intro\n");
    }

    static string GetEnjoymentLevel(){
        System.Console.WriteLine("Please select your preferred enjoyment level:\nBoring\nAverage\nFun\nEpic\n\nEnter exit to close\n");
        return (Console.ReadLine());
    }

    static string GetStadiumRecommendations(string enjoymentLevel){
        switch(enjoymentLevel){
            case "boring":
                return "Neyland Stadium";
            case "average":
                return "Jordan-Hare Stadium";
            case "fun":
                return "Tiger Stadium";
            case "epic":
                return "Saban Field at Bryant-Denny Stadium";
            default:
                System.Console.WriteLine("Invalid enjoyment level.");
                Pause();
                return "";
        }
    }

    static string GetGameRecommendations(string stadium){
        switch(stadium){
            case "Neyland Stadium":
                return "vs Kent State";
            case "Jordan-Hare Stadium":
                return "vs Kentucky";
            case "Tiger Stadium":
                return "vs Alabama";
            case "Saban Field at Bryant-Denny Stadium":
                return "vs Auburn";
            default:
                return "No game scheduled";
            
        } 
    }

    static void DisplayStadiumDetails(string stadium, string game){
        if(stadium != "" && game != ""){
            Console.Clear();
            System.Console.WriteLine($"Best Stadium to visit: {stadium}\nBest Game to see: {game}");
        }
        Pause();
    }

    static void Pause(){
        System.Console.WriteLine("\nPress any key to return to Menu...\n");
        Console.ReadKey();
    }

    static void Exit(){
        Console.WriteLine("\nClosing program. Thank you for using College Football Intro\n");
    }
}