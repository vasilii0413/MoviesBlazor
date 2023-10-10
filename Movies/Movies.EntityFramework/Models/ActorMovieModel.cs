using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Movies.EntityFramework.Models
{
    public class ActorMovieModel
    {
        [Key,DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public short ActorId { get; set; }
        public short MovieId { get; set; }
        public ActorModel? Actor{ get; set; }
        public MovieModel? Movie { get; set; }
    }
}
