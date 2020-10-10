using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FemiFriendsApp.Models.ConData
{
  [Table("Countries", Schema = "dbo")]
  public partial class Country
  {
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int CountryID
    {
      get;
      set;
    }

    public ICollection<MyFriend> MyFriends { get; set; }
    public string CountryName
    {
      get;
      set;
    }
  }
}
