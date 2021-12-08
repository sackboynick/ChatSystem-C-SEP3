using Entities;
using Microsoft.EntityFrameworkCore;

namespace DataAccess.Persistence
{
    public class ChatContext : DbContext
    {

        public DbSet<User> Users { get; set; }
        public DbSet<PrivateChat> PrivateChats { get; set; }
        public DbSet<GroupChat> GroupChats { get; set; }
        public DbSet<Friendship> Friendships { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            // name of database
            optionsBuilder.UseSqlite("Data Source = chats.db");
        }

    }
}