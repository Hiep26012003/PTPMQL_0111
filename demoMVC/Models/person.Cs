using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace demoMVC.Models
{
[Table("Person")]
public class Person{
    [Key]
    public string PersonId { get; set; }
    public string fullname { get; set; }
    public string address { get; set; }
    public string old { get; set; }
}   
}