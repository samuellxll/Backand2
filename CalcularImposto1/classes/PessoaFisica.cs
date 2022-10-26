using CalcularImposto1.interfaces;

namespace CalcularImposto1.classes
{
    public class PessoaFisica : Pessoa, IPessoaFisica
    {
        
        public string? cpf{get; set;}

        
        public PessoaFisica(DateTime dataNasc) 
        {
            this.dataNasc = dataNasc;
               
        }

        public PessoaFisica()
        {
        }

        public DateTime dataNasc{get; set;}

                
        public override float CalcularImposto(float rendimento)
        {
            if(rendimento <=1500){

                float resultado = (rendimento / 100) * 2;

                return resultado;

            }else if(rendimento > 1500 && rendimento < 3000){

                float resultado = (rendimento / 100) * 3.5f;

                return resultado;

            }else{

                float resultado = (rendimento/ 100) * 5;

                return resultado;

            }

        }

        public bool ValidarDataNacimento(DateTime dataNasc)
        {

            DateTime DataAtual = DateTime.Today;

            var anos =( DataAtual  - dataNasc).TotalDays / 365;

            if(anos< 18){

                            return false;
            }else{

                return true;
            }
          
        }

        public bool ValidarDataNacimento (string dataNasc){

                if(DateTime.TryParse(dataNasc, out DateTime DataConvertida)){

                    DateTime DataAtual = DateTime.Today;

                    double anos = (DataAtual -DataConvertida).TotalDays / 365;

                    Console.WriteLine(anos);

                    if(anos >=18){

                        return true;
                    }
                }

            return false;
        }
    }
}