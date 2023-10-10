using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Movies.EntityFramework.Models
{
    [Table("Actor")]
    public class ActorModel
    {
        [Key,DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public short ActorId { get; set; }
        public string Name { get; set; }
        public DateTime DateOfBirth { get; set; }
        public ICollection<MovieModel> Movies { get; set; }

    }
}
