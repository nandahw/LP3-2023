namespace CltAbast;

    public class Diesel10 : Abastecimento{
        public Diesel10(string nome, decimal valorAtual) : base(nome, valorAtual)
        {

        }
        public override void ExecutarAjustes()
        {
            decimal acrescimo = ValorAcumulado * 0.02m;
            AtualizarValor(acrescimo, DateTime.Now, "Ajustes para Diesel S-10");
            }
    }