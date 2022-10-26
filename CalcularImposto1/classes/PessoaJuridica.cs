using CalcularImposto1.interfaces;

namespace CalcularImposto1.classes
{
    public class PessoaJuridica : Pessoa, IPessoaJuridica
    {

        public string? CNPJ{get; set;}


        public string? RazaoSocila{get; set;}

        public override float CalcularImposto(float rendimento)
        {
            if (rendimento<3000) {

                float resultado = (rendimento *0.03f);

                return resultado;

            }else if( rendimento <=6000){

                float resultado = (rendimento *0.05f);
                
                return resultado;

            }else if( rendimento <= 10000){

            float resultado = (rendimento *0.07f);

                return resultado;

            }else{

            float resultado = (rendimento *0.09f);

                return resultado;

            }
        }

        public bool ValidarCNPJ(string CNPJ)
        {
            throw new NotImplementedException();
        }
    }
}