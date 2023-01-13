using System.Collections.Generic;
using System;
using System.ComponentModel.DataAnnotations;

namespace SweetTreats.Models
{
  public class Flavor
  {
    public int FlavorId { get; set; }
    [Required(ErrorMessage = "The flavor must have a name!")]
    public string Name { get; set; }
    public List<FlavorTreat> JoinEntities { get; }
  }
}