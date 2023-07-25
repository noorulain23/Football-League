using System;
using System.Collections.Generic;
public class Team
{
    public string name;
    public LinkedList<Player> players = new LinkedList<Player>();
    public Coach coach;
    public int score;
    public int matchGoal;
    public Team(string name, Coach coach)
    {
        this.name = name;
        this.coach = coach;
    }
    public void AddPlayer(Player player)
    {
        this.players.AddLast(player);
        player.AssignTeam(this);
    }
}