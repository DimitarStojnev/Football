using Football;
using System.ComponentModel;


Coach coach1 = new Coach("Dragan Stojkovic Piksi", 58);
List<FootballPlayer> players1 = new List<FootballPlayer>();
FootballPlayer footballPlayer1 = new Goalkeeper("Vanja Milinkovic-Savic", 26, 1, 2.02);
FootballPlayer footballPlayer2 = new Defender("Strahinja Pavlovic", 22, 2, 1.94);
FootballPlayer footballPlayer3 = new Defender("Milos Veljkovic", 27, 13, 1.90);
FootballPlayer footballPlayer4 = new Defender("Nikola Milenkovic", 25, 15, 1.95);
FootballPlayer footballPlayer5 = new Striker("Dusan Tadic", 34, 10, 1.81);
FootballPlayer footballPlayer6 = new Striker("SaSa Lukic", 26, 16, 1.82);
FootballPlayer footballPlayer7 = new Striker("Nemanja Gudelj", 31, 8, 1.87);
FootballPlayer footballPlayer8 = new Defender("Srdjan Babic", 27, 4, 1.94);
FootballPlayer footballPlayer9 = new Midfielder("Dusan Tadic", 34, 10, 1.81);
FootballPlayer footballPlayer10 = new Midfielder("Dusan Vlahovic", 23, 18, 1.90);
FootballPlayer footballPlayer11 = new Midfielder("Aleksandar Mitrovic", 28, 9, 1.89);

players1.Add(footballPlayer1);
players1.Add(footballPlayer2);
players1.Add(footballPlayer3);
players1.Add(footballPlayer4);
players1.Add(footballPlayer5);
players1.Add(footballPlayer6);
players1.Add(footballPlayer7);
players1.Add(footballPlayer8);
players1.Add(footballPlayer9);
players1.Add(footballPlayer10);
players1.Add(footballPlayer11);


Team team1 = new Team(coach1, players1);
Console.WriteLine("Team 1 Coach:");
Console.WriteLine(team1.Coach.Name + " " + team1.Coach.Age);
Console.WriteLine();
Console.WriteLine("Team 1 Squad:");
foreach (var item in players1)
{
    Console.WriteLine("№" + item.Number + " " + item.Name);
}
Console.WriteLine();
Console.WriteLine("Average Age in Team 1 is: " + team1.AverageAge(players1) + " age");

Coach coach2 = new Coach("Baltazar Bruno", 45);
List<FootballPlayer> players2 = new List<FootballPlayer>();
FootballPlayer footballPlayer12 = new Goalkeeper("Georgi Argilashki", 31, 1, 1.90);
FootballPlayer footballPlayer13 = new Defender("Pa Konate", 29, 3, 1.77);
FootballPlayer footballPlayer14 = new Defender("Viktor Genev", 34, 4, 1.89);
FootballPlayer footballPlayer15 = new Defender("Atanas Cernev", 21, 27, 1.96);
FootballPlayer footballPlayer16 = new Midfielder("Dilan Mertens", 27, 6, 1.88);
FootballPlayer footballPlayer17 = new Midfielder("Plamen Concev", 20, 34, 1.75);
FootballPlayer footballPlayer18 = new Midfielder("Monir Al Badarin", 17, 77, 1.65);
FootballPlayer footballPlayer19 = new Striker("Antoan Baroan", 22, 11, 1.85);
FootballPlayer footballPlayer20 = new Striker("Nikolaj Minkov", 25, 17, 1.71);
FootballPlayer footballPlayer21 = new Midfielder("Krasian Kolev", 19, 5, 1.79);
FootballPlayer footballPlayer22 = new Defender("Roberto Buncec", 31, 44, 1.87);

players2.Add(footballPlayer12);
players2.Add(footballPlayer13);
players2.Add(footballPlayer14);
players2.Add(footballPlayer15);
players2.Add(footballPlayer16);
players2.Add(footballPlayer17);
players2.Add(footballPlayer18);
players2.Add(footballPlayer19);
players2.Add(footballPlayer20);
players2.Add(footballPlayer21);
players2.Add(footballPlayer22);

Team team2 = new Team(coach2, players2);
Console.WriteLine();
Console.WriteLine("Team 2 coach:");
Console.WriteLine(team2.Coach.Name + " " + team2.Coach.Age);
Console.WriteLine();
Console.WriteLine("Team 2 Squad:");
foreach (var item in team2.Players)
{
    Console.WriteLine("№" + item.Number + " " + item.Name);
}
Console.WriteLine();
Console.WriteLine("Average Age in Team 2 is: " + team2.AverageAge(players2) + " age");
Console.WriteLine();
Referee referee = new Referee("Georgi Kabakov", 37);
Referee assistantReferee1 = new Referee("Srdjan Jovanovic", 37);
Referee assistantReferee2 = new Referee("Novan Simovic", 41);

List<Referee> referees = new List<Referee>();
referees.Add(referee);
referees.Add(assistantReferee1);
referees.Add(assistantReferee2);

Console.WriteLine("The Referees for the match are:");
foreach (var item in referees)
{
    Console.WriteLine(item.Name + " " + item.Age);
}

Goal goal1 = new Goal(footballPlayer6, 22);
Goal goal2 = new Goal(footballPlayer19, 70);
Goal goal3 = new Goal(footballPlayer11, 88);

List<Goal> goals = new List<Goal>();
goals.Add(goal1);
goals.Add(goal2);
goals.Add(goal3);

int team1Goals = 0;
int team2Goals = 0;

Console.WriteLine();
foreach (var item in goals)
{
    if (team1.Players.Contains(item.Player))
    {
        team1Goals++;
        Console.WriteLine(item.ToString());
        Console.WriteLine($"Result is {team1Goals}:{team2Goals}");
    }
    else
    {
        team2Goals++;
        Console.WriteLine(item.ToString());
        Console.WriteLine($"Result is {team1Goals}:{team2Goals}");
    }
}
Console.WriteLine();
Console.WriteLine($"Final Result is {team1Goals}:{team2Goals}!");
if (team1Goals > team2Goals)
{
    Console.WriteLine("Winner is Team 1!");
}
else if (team1Goals < team2Goals)
{
    Console.WriteLine("Winner is Team 2!");
}
else
{
    Console.WriteLine("Draw!");
}
