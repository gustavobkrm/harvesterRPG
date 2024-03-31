using System.ComponentModel.DataAnnotations;

namespace harvesterRPG.Models
{
    public class JobItem
    {
        [Key]
        public int IdItem { get; set; }
        public int IdJob { get; set; }    
        public string ItemName { get; set; }
        public string Climate { get; set; }
        public int ItemDices { get; set; }
    }
}
