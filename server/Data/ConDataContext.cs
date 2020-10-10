using System.Reflection;
using System.Linq;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Microsoft.Extensions.Configuration;

using FemiFriendsApp.Models.ConData;

namespace FemiFriendsApp.Data
{
  public partial class ConDataContext : Microsoft.EntityFrameworkCore.DbContext
  {
    public ConDataContext(DbContextOptions<ConDataContext> options):base(options)
    {
    }

    public ConDataContext()
    {
    }

    partial void OnModelBuilding(ModelBuilder builder);

    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);

        builder.Entity<FemiFriendsApp.Models.ConData.MyFriend>()
              .HasOne(i => i.Gender)
              .WithMany(i => i.MyFriends)
              .HasForeignKey(i => i.GenderID)
              .HasPrincipalKey(i => i.GenderID);
        builder.Entity<FemiFriendsApp.Models.ConData.MyFriend>()
              .HasOne(i => i.Country)
              .WithMany(i => i.MyFriends)
              .HasForeignKey(i => i.CountryID)
              .HasPrincipalKey(i => i.CountryID);
        builder.Entity<FemiFriendsApp.Models.ConData.MyFriend>()
              .HasOne(i => i.State)
              .WithMany(i => i.MyFriends)
              .HasForeignKey(i => i.StateID)
              .HasPrincipalKey(i => i.StateID);


        builder.Entity<FemiFriendsApp.Models.ConData.MyFriend>()
              .Property(p => p.DateOfBirth)
              .HasColumnType("datetime");

        this.OnModelBuilding(builder);
    }


    public DbSet<FemiFriendsApp.Models.ConData.Country> Countries
    {
      get;
      set;
    }

    public DbSet<FemiFriendsApp.Models.ConData.Gender> Genders
    {
      get;
      set;
    }

    public DbSet<FemiFriendsApp.Models.ConData.MyFriend> MyFriends
    {
      get;
      set;
    }

    public DbSet<FemiFriendsApp.Models.ConData.State> States
    {
      get;
      set;
    }
  }
}
