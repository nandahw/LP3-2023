namespace CltAbast;

    public class Diesel08 : Abastecimento{
        public Diesel08(string nome, decimal valorAtual) : base(nome, valorAtual)
        {

        }
        public override void ExecutarAjustes()
        {
            decimal acrescimo = ValorAcumulado * 0.03m;
            AtualizarValor(acrescimo, DateTime.Now, "Ajustes para Diesel S-10");
            }
    }