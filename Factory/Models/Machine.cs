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
    public DateTime ServiceDate { get; set; }
    public List<EngineerMachine> JoinEntities { get; }
  }
}