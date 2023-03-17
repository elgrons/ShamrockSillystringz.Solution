using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;
using System;

namespace Factory.Models
{
  public class Engineer
  {
    public int EngineerId { get; set; }
    [Required(ErrorMessage = "The engineer's name can't be empty.")]
    public string EngineerName { get; set; }
    [Range(1, int.MaxValue, ErrorMessage = "You must add an engineer to a machine. Has a machine been added yet?")]
    public string EngineerDetails { get; set; }
    public List<EngineerMachine> JoinEntities { get; }
  }
}
