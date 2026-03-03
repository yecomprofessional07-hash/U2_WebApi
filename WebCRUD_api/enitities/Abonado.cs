namespace WebCRUD_api.enitities
{
    public class Abonado
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Direccion { get; set; }
        public string Telefono { get; set; }
        public string Email { get; set; }
        public double Saldo { get; set; }
        public DateTime Fechapago { get; set; } = DateTime.Now;
        public bool Activo { get; set; } = true;
    }
}
