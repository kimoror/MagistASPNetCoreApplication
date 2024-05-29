﻿using Corpa4Sem4.Database.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace PraktASPApp.Database
{
    public class ApplicationContext : DbContext
    {
        public DbSet<User>? Users { get; set; }
        public DbSet<Message>? Messages { get; set; }

        public ApplicationContext()
        {
            Database.EnsureCreated();
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
			var options = new
			{
				Server = "localhost:5432",
				Database = "application",
				User = "postgres",
				Password = "plami",
			};

			optionsBuilder.UseNpgsql($"Server = {options.Server}; Database ={options.Database}; Uid = {options.User}; Pwd = {options.Password};");
		}
    }
}
