Random rnd = new Random();
Player me = new Player(rnd.Next(50, 150), rnd.Next(5, 25));
AI r2d2 = new AI(rnd.Next(50, 150), rnd.Next(5, 25));

Game game = new Game(me, r2d2);

game.PlayGame();