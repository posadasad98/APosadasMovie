namespace PL.Models
{
    public class Movie
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Poster { get; set; }
        public string Descripcion { get; set; }

        public List<object> Movies { get; set;}
    }
}
