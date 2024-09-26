namespace PracticaBarcosEntidades
{
    public class Barco
    {
        public int IdBarco { get; set; }
        public required string Nombre { get; set; }
        public int Antiguedad { get; set; }
        public int Tripulacion { get; set; }

        public Decimal tasa { get; set; }


    }
}

