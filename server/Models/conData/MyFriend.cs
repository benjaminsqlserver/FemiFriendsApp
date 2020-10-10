using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FemiFriendsApp.Models.ConData
{
  [Table("MyFriends", Schema = "dbo")]
  public partial class MyFriend
  {
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public Int64 FriendID
    {
      get;
      set;
    }
    public string FirstName
    {
      get;
      set;
    }
    public string OtherNames
    {
      get;
      set;
    }
    public string Surname
    {
      get;
      set;
    }
    public int GenderID
    {
      get;
      set;
    }
    public Gender Gender { get; set; }
    public DateTime DateOfBirth
    {
      get;
      set;
    }
    public string ResidentialAddress
    {
      get;
      set;
    }
    public string City
    {
      get;
      set;
    }
    public int CountryID
    {
      get;
      set;
    }
    public Country Country { get; set; }
    public int? StateID
    {
      get;
      set;
    }
    public State State { get; set; }
    public string WhatsappNumber
    {
      get;
      set;
    }
    public string OtherPhoneNumber
    {
      get;
      set;
    }
    public string Email
    {
      get;
      set;
    }
    public string Photo
    {
      get;
      set;
    }
  }
}
