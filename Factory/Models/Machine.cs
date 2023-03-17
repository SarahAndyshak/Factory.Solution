using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Factory.Models
{
    public class Machine
    {
        public int MachineId { get; set; }
        [Required(ErrorMessage = "You must enter the machine's name")]
        public string MachineName { get; set; }
        [Required(ErrorMessage = "You must enter machine specs")]
        public string MachineDetails { get; set; }
        public List<EngineerMachine> JoinEntities { get; set; }
    }
}