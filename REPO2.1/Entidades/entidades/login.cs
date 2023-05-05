namespace Entidades
{
    public class login
    {
        public string usuario { get; set; }
        public string contrasena { get; set; }

        public login()
        {
        }

        public login(string usuario, string contrasena)
        {
            this.usuario = usuario;
            this.contrasena = contrasena;
        }
    }
}
