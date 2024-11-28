class Fabric
{
    public Game CreateGame (string nameGame, int rating) {
        if(nameGame == "standart") {
            return new StandartGame("standart", rating);

        } else if(nameGame == "onerisk")  {
            return new OneriskGame("onerisk", rating);

        } else if(nameGame == "training") {
            return new TrainingGame("training");

        } else {
            Console.Write("\nПомилка: такого типу гри не існує\n\n");
            Environment.Exit(0);
        }

        return new StandartGame("error", -1);
    }
}