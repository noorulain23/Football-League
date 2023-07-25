using System;
using System.Collections.Generic;
public class FootBallLeague
{
    public string name;
    public string presidentName;
    public string hostCountry;
    public LinkedList<Team> teams = new LinkedList<Team>();

    public FootBallLeague(string name, string presidentName, string hostCountry)
    {
        this.name = name;
        this.presidentName = presidentName;
        this.hostCountry = hostCountry;
    }
    public void AddTeam(Team team)
    {
        this.teams.AddLast(team);
    }
    public void Match(Team t1, Team t2)
    {
        if (t1.matchGoal > t2.matchGoal)
        {
            t1.score = t1.score + 5;
        }
        else if (t1.matchGoal < t2.matchGoal)
        {
            t1.score = t1.score + 0;
        }
        else if (t1.matchGoal == t2.matchGoal)
        {
            t1.score = t1.score + 2;
            t2.score = t2.score + 2;
        }
        t1.matchGoal = 0;
        t2.matchGoal = 0;
    }
    public void Match(Team t1, Team t2, bool random)
    {
        if (random == true)
        {
            Random randomNum = new Random();
            t1.matchGoal = randomNum.Next(0, 10);
            t2.matchGoal = randomNum.Next(0, 10);


            if (t1.matchGoal > t2.matchGoal)
            {
                t1.score = t1.score + 5;
            }
            else if (t1.matchGoal < t2.matchGoal)
            {
                t2.score = t2.score + 5;
            }
            else if (t1.matchGoal == t2.matchGoal)
            {
                t1.score = t1.score + 2;
                t2.score = t2.score + 2;
            }
        }
        else
        {
            this.Match(t1, t2);
        }

    }
    public void Winner()
    {
        int highestScore = 0;
        Team winTeam = null;
        foreach(Team item in teams)
        {
            if(item.score > highestScore)
            {
                highestScore = item.score;
                winTeam = item;
            }
        }
         Console.WriteLine($"The winning team of the GoldenBootTrophy is {winTeam.name} who have scored {winTeam.score} points");
    }

    public void GoldenBootTrophy1()
    {
        int highestGoal = 0;
        Player winningPlayer = null;
        foreach (Team t in teams)
        {
            foreach (Player p in t.players)
            {
                if (p.noOfGoals > highestGoal)
                {
                    highestGoal = p.noOfGoals;
                    winningPlayer = p;
                }
            }
        }
        Console.WriteLine($"Player who scored highest no.of goals are: {winningPlayer.name}");
    }
}