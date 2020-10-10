using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FemiFriendsApp.Models.ConData
{
  [Table("States", Schema = "dbo")]
  public partial class State
  {
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int StateID
    {
      get;
      set;
    }

    public ICollection<MyFriend> MyFriends { get; set; }
    public string StateName
    {
      get;
      set;
    }
    public int? CountryID
    {
      get;
      set;
    }
  }
}
