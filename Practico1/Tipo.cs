namespace Practico1
{
    public class Tipo
    {
        int codigo;
        string nombreTipo;

        public Tipo(int codigo, string nombreTipo)
        {
            this.codigo = codigo;
            this.nombreTipo = nombreTipo;
        }

        public int Codigo { get => codigo; set => codigo = value; }
        public string NombreTipo { get => nombreTipo; set => nombreTipo = value; }
    }
}