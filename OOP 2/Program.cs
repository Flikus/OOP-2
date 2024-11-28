class Program 
{	

	static void newGame(GameAccount player1, GameAccount player2, Game game) {
		player1.WinGame(player2.UserName, game);
		player2.LoseGame(player1.UserName, game);
	}

	static void Main() {
		GameAccount player1 = new StandartAccount("User1");
		GameAccount player2 = new PayAccount("User2");
		GameAccount player3 = new WinstreakAccount("User3");

		Fabric fabric = new Fabric();
		
		Game game1 = fabric.CreateGame("standart", 10);

		newGame(player3, player2, game1);
		newGame(player3, player1, game1);
		newGame(player3, player1, game1);
		newGame(player1, player2, game1);
		newGame(player1, player3, game1);
		newGame(player2, player1, game1);

		Game game2 = fabric.CreateGame("onerisk", 20);

		newGame(player3, player2, game2);
		newGame(player3, player2, game2);
		newGame(player3, player1, game2);
		newGame(player2, player1, game2);
		newGame(player3, player2, game2);
		newGame(player1, player2, game2);

		Game game3 = fabric.CreateGame("training", 30);

		newGame(player3, player2, game3);
		newGame(player3, player2, game3);
		newGame(player3, player1, game3);
		newGame(player2, player1, game3);
		newGame(player3, player2, game3);
		newGame(player1, player2, game3);



		player1.GetStats();
		player2.GetStats();
		player3.GetStats();
	}
}

