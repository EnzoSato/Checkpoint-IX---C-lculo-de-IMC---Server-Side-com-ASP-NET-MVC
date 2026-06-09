namespace CalculadoraImc.Models
{
    public class ImcModel
    {
        public double Peso { get; set; }
        public double Altura { get; set; }
        public double ResultadoImc { get; set; }
        public string Classificacao { get; set; } = string.Empty;
    }
}