using System.Collections.Generic;
using System;
using System.ComponentModel.DataAnnotations;

namespace SweetTreats.Models
{
  public class Treat
  {
    public int TreatId { get; set; }
    [Required(ErrorMessage = "The treat must have a name!")]
    public string Name { get; set; }
    public List<FlavorTreat> JoinEntities { get; }
  }
}