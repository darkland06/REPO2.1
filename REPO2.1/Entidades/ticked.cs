namespace Entidades
{
    public class ticked
    {
        public DateTime fecha { get; set; }
        public string idTicked { get; set; }
        public string usuario { get; set; }

        public string contrasena { get; set; }
        public string nombreCliente { get; set; }

        public string tipoSoporte { get; set; }

        public string descripcionSoporte { get; set; }

        public ticked()
        {
        }

        public ticked(DateTime fecha, string idTicked, string usuario, string contrasena, string nombreCliente, string tipoSoporte, string descripcionSoporte)
        {
            this.fecha = fecha;
            this.idTicked = idTicked;
            this.usuario = usuario;
            this.contrasena = contrasena;
            this.nombreCliente = nombreCliente;
            this.tipoSoporte = tipoSoporte;
            this.descripcionSoporte = descripcionSoporte;
        }
    }
}