namespace Don_banano
{
    public class Usuarios
    {
        public string Usuario { get; set; }
        public string Contraseña { get; set; }
        public string Rol { get; set; }

        public Usuarios(string usuario, string contraseña, string rol)
        {
            Usuario = usuario;
            Contraseña = contraseña;
            Rol = rol;
        }
    }
}
