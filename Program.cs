// See https://aka.ms/new-console-template for more information

FootBallLeague footBallLeague = new FootBallLeague("FIFA", "Alexander", "Australia");

Coach londonCoach = new Coach("Psalm", 30);
Coach argentinaCoach = new Coach("Andrew", 32);
Team London = new Team("London", londonCoach);
Team Argentina = new Team("Argentina", argentinaCoach);

Player p1 = new Player("Messi", 10);
Player p2 = new Player("Christiano", 20);
Player p3 = new Player("Alex", 6);
Player p4 = new Player("Sam", 26);

footBallLeague.AddTeam(London);
footBallLeague.AddTeam(Argentina);

London.AddPlayer(p1);
London.AddPlayer(p2);
Argentina.AddPlayer(p3);
Argentina.AddPlayer(p4);

footBallLeague.Match(Argentina, London, true);
footBallLeague.Match(Argentina, London, true);
footBallLeague.Match(Argentina, London, true);
footBallLeague.Match(Argentina, London, true);
footBallLeague.Match(Argentina, London, true);
footBallLeague.Winner();
footBallLeague.GoldenBootTrophy1();

