using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Movies.EntityFramework.Models
{
    [Table("Movie")]
    public class MovieModel
    {
        [Key,DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public short MovieId { get; set; }
        public string Name { get; set; }
        public string Genre {  get; set; }
        public short AgeRestriction { get; set; }
        public short Year { get; set; }
        public string Description { get; set; }
        public short Length { get; set; }
        public string ImageUrl { get; set; }
        public virtual ICollection<ActorModel>Actors { get; set; }
    }
}
