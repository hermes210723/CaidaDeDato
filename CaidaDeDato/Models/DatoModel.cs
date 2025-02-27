namespace CaidaDeDato.Models  // Asegúrate de que coincida con el nombre del proyecto
{
    public class DatoModel
    {
        public double Altura { get; set; }
        public double Tiempo { get; set; }
        public int NumeroAzar { get; set; }

        public void CalcularCaida()
        {
            const double gravedad = 9.81;
            Tiempo = Math.Sqrt((2 * Altura) / gravedad);
            NumeroAzar = new Random().Next(1, 101);
        }
    }
}