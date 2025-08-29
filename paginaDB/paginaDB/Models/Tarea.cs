namespace paginaDB.Models
{
    public class Tarea
    {
        public int Id { get; set; }
        public string nombreTarea { get; set; }
        public DateTime FechaVencimiento { get; set; }
        public string estado { get; set; }
        public int idUsuario { get; set; }
    }
}
