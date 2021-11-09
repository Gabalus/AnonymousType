using System;
using AnonymousType.Models;
using Microsoft.EntityFrameworkCore;


namespace AnonymousType
{
    class Program
    {
        



        static void Main(string[] args)
        {

            using (MyContext myContext = new MyContext())
            {
                Player player = new Player();
                player.Name = "Kushnarev";
                player.Age = 21;
                player.Team = new Team() { Name = "Crabs3", League =new League() { Name = "Third" } };
                myContext.Players.Add(player);
                myContext.SaveChanges();
            }

            using (MyContext myContext = new MyContext())
            {
                Player player = new Player();
                player.Name = "Ivanov";
                player.Age = 22;
                player.Team = new Team() { Name = "Crabs2", League = new League() { Name = "Second" } };
                myContext.Players.Add(player);
                myContext.SaveChanges();
            }
            using (MyContext myContext = new MyContext())
            {
                Player player = new Player();
                player.Name = "Kuznecov";
                player.Age = 30;
                player.Team = new Team() { Name = "Crabs", League = new League() { Name = "Premier" } };
                myContext.Players.Add(player);
                myContext.SaveChanges();
            }


        }
    }
}
