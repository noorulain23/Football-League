using System;
using System.Collections.Generic;
public class Player
{
    public string name;
    public int noOfGoals;
    public Team team;

    public Player(string name, int noOfGoals)
    {
        this.name = name;
        this.noOfGoals = noOfGoals;
    }
    public void AssignTeam(Team team)
    {
       this.team = team;
    }
}