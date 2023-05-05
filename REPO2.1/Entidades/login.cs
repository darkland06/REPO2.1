namespace Entidades
{
    public class login
    {
        public string codigoUsuario { get; set; }
        public string contraseña { get; set; }

        public login()
        {
        }

        public login(string codigoUsuario, string contraseña)
        {
            this.codigoUsuario = codigoUsuario;
            this.contraseña = contraseña;
        }
    }
}
