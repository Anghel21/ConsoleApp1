using System;
using System.Collections.Generic;

public class Person
{
    public string Name { get; set; }
    public int Age { get; set; }

    public Person(string name, int age)
    {
        Name = name;
        Age = age;
    }
}
public class FootballPlayer : Person
{
    public int Number { get; set; }
    public int Height { get; set; }

    public FootballPlayer(string name, int age, int number, int height)
        : base(name, age)
    {
        Number = number;
        Height = height;
    }
}


public class Goalkeeper : FootballPlayer
{
    public Goalkeeper(string name, int age, int number, int height)
        : base(name, age, number, height)
    {
    }
}

public class Defender : FootballPlayer
{
    public Defender(string name, int age, int number, int height)
        : base(name, age, number, height)
    {
    }
}


public class Midfielder : FootballPlayer
{
    public Midfielder(string name, int age, int number, int height)
        : base(name, age, number, height)
    {
    }
}

public class Striker : FootballPlayer
{
    public Striker(string name, int age, int number, int height)
        : base(name, age, number, height)
    {
    }
}

public class Coach : Person
{
    public Coach(string name, int age)
        : base(name, age)
    {
    }
}

public class Referee : Person
{
    public Referee(string name, int age)
        : base(name, age)
    {
    }
}

public class Team
{
    public Coach Coach { get; set; }
    public List<FootballPlayer> Players { get; set; }

    public Team(Coach coach, List<FootballPlayer> players)
    {
        Coach = coach;
        Players = players;
    }

    public double GetAverageAge()
    {
        int totalAge = 0;
        foreach (var player in Players)
        {
            totalAge += player.Age;
        }
        return (double)totalAge / Players.Count;
    }
}

public class Goal
{
    public int Minute { get; set; }
    public FootballPlayer Player { get; set; }

    public Goal(int minute, FootballPlayer player)
    {
        Minute = minute;
        Player = player;
    }
}


public class Match
{
    public Team Team1 { get; set; }
    public Team Team2 { get; set; }
    public Referee Referee { get; set; }
    public List<Referee> AssistantReferees { get; set; }
    public List<Goal> Goals { get; set; }
    public Team Winner { get; set; }

    public Match(Team team1, Team team2, Referee referee, List<Referee> assistantReferees)
    {
        Team1 = team1;
        Team2 = team2;
        Referee = referee;
        AssistantReferees = assistantReferees;
        Goals = new List<Goal>();
    }
}

