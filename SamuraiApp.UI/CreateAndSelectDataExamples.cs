using System;
using System.Linq;
using SamuraiApp.Domain;
using SamuraiApp.Data;
using Microsoft.EntityFrameworkCore;
using SamuraiApp.Migrations.SqlLite;
using SamuraiApp.Migrations.SqlServer;
using System.Collections.Generic;

namespace SamuraiApp.UI
{
    public class CreateAndSelectDataExamples
    {
        public SamuraiSqlServerContext Context { get; }
        public CreateAndSelectDataExamples()
        {
            Context = new SamuraiSqlServerContext();
        }
        public  void RunStoredProcedure()
        {
            using(var context = new SamuraiSqlServerContext())
            {
                string nameToSearch = "Julia";
                var samurai = context.Samurais
                    .FromSql($"EXEC dbo.FilterSamuraiByPartOfName {nameToSearch}")
                    .OrderByDescending(s => s.Name)
                    .Where(s => (s.Name ?? "") != "" )
                    .ToList(); 
                samurai.ForEach(s => Console.WriteLine(s.Name));
                Console.WriteLine();
            }
        }

        internal void InsertOneToOneRelation()
        {
            var samurai = new Samurai { Name = "One to one samurai" };
            samurai.SecretIdentity = new SecretIdentity { RealName = "Julia" };
            Context.Add(samurai);
            Context.SaveChanges();
        }

        internal void InsertNewItemsIntoPkgGraph()
        {
            var samurai = new Samurai
            {
                Name = "Big Boy V 3",
                Quotes = new List<Quote>
                {
                    new Quote {Text = "Big bada boom 4!"},
                    new Quote {Text = "Big bada boom 5!"}
                }
            };
            Context.Samurais.Add(samurai);
            Context.SaveChanges();
        }

        internal void InsertNewPkgGraph()
        {
            var samurai = new Samurai
            {
                Name = "Big Boy",
                Quotes = new List<Quote>
                {
                    new Quote {Text = "Big bada boom!"}
                }
            };
            Context.Samurais.Add(samurai);
            Context.SaveChanges();
        }

        public  void RunFunctionProcedure()
        {
            
            using(var context = new SamuraiSqlServerContext())
            {
                string nameToSearch = "Julia";
                var samurai = context.Samurais
                    .FromSql($"SELECT * FROM dbo.FilterSamuraiByPartOfNameFunc ({nameToSearch})")
                    .OrderByDescending(s => s.Name)
                    .Where(s => (s.Name ?? "") != "" )
                    .ToList(); 
                samurai.ForEach(s => Console.WriteLine(s.Name));
                Console.WriteLine();
            }
        }

        public  void RowSqlQuery()
        {
            using(var context = new SamuraiSqlLiteContext())
            {
                var samurai = context.Samurais.FromSql("SELECT * FROM Samurais WHERE Id IS NOT NULL")
                    .OrderByDescending(s => s.Name)
                    .Where(s => (s.Name ?? "") != "" )
                    .ToList(); 
                samurai.ForEach(s => Console.WriteLine(s.Name));
                Console.WriteLine();
            }
        }

        public  void DeletingTheObject()
        {
            using(var context = new SamuraiSqlLiteContext())
            {
                string nameToSearch = "Julia";
                //Linq Methods
                var samurai = context.Samurais
                    .Where(s => s.Name == nameToSearch)
                    .FirstOrDefault();
                context.Remove(samurai);
                context.SaveChanges();
            }
        }

        public  void InsertSamurai()
        {
            var samurai = new Samurai() { Name = "bobo" };
            using (var context = new SamuraiSqlServerContext())
            {
                context.Samurais.Add(samurai);
                context.SaveChanges();
            }
        }

        public  void SimpleSamuraiQuery()
        {
            using(var context = new SamuraiSqlLiteContext())
            {
                //Linq Methods
                var samurais = context.Samurais
                    .Where(s => s.Name == "Julia")
                    .ToList();
                //Linq Query Syntax 
                samurais = (from s in context.Samurais 
                    where s.Name == "Julia"
                    select s)
                    .ToList();
            }
        }
        public  void MoreSimpleSamuraiQuery()
        {
            using(var context = new SamuraiSqlLiteContext())
            {
                string nameToSearch = "Julia";
                //Linq Methods
                var samurais = context.Samurais
                    .Where(s => s.Name == nameToSearch)
                    .ToList();
                //Linq Query Syntax 
                samurais = (from s in context.Samurais 
                    where s.Name == nameToSearch
                    select s)
                    .ToList();
            }
        }
        public  void RetriveAndUpdateSamurai()
        {
            using(var context = new SamuraiSqlLiteContext())
            {
                string nameToSearch = "Julia";
                //Linq Methods
                var samurai = context.Samurais
                    .Where(s => s.Name == nameToSearch)
                    .FirstOrDefault();
                samurai.Name += "San";
                context.SaveChanges();
            }
        }
    }
}
