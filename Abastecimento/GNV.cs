namespace CltAbast;

    public class GNV : Abastecimento{
        public GNV(string nome, decimal valorAtual) : base(nome, valorAtual)
        {

        }
        public override void ExecutarAjustes()
        {
            decimal acrescimo = ValorAcumulado * 0.02m;
            AtualizarValor(acrescimo, DateTime.Now, "Ajustes para GNV");
            }
    }