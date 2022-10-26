using CalcularImposto1.interfaces;

namespace CalcularImposto1.classes
{
    public abstract class Pessoa : IPessoa
    {
        public string? nome { get; set; }


        public float rendimento { get; set; }


        public Endereco? endereco {get; set;}


        public abstract float CalcularImposto(float rendimento);
        
    }
}