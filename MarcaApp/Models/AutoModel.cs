using System;
namespace MarcaApp.Models
{
    public class AutoModel
    {
        public string Marca { get; set; } = "";
        public string Modelo { get; set; } = "";
        public string Anio { get; set; } = "";

        public override string ToString()
        {
            return base.ToString();
        }
    }
}
