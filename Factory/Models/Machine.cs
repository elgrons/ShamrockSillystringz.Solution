using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;
using System;

namespace Factory.Models
{
  public class Machine
  {
    public int MachineId { get; set; }
    [Required(ErrorMessage = "The machine name field can't be empty!")]
    public string MachineName { get; set; }
    [Range(1, int.MaxValue, ErrorMessage = "You must add a machine to an engineer. Has an engineer been added yet?")]
    public DateTime ServiceDate { get; set; }
    public List<EngineerMachine> JoinEntities { get; }
  }
}