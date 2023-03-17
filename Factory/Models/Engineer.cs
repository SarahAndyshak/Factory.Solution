using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Factory.Models
{
    public class Engineer
    {
        public int EngineerId { get; set; }
        [Required(ErrorMessage = "You must enter the engineer's name")]
        public string EngineerName { get; set; }
        [Required(ErrorMessage = "You must enter the engineer's contact information")]
        public string EngineerContact { get; set; }
        public List<EngineerMachine> JoinEntities { get; set; }
    }
}