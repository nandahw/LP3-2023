namespace CltAbast;

    public class Gasolina : Abastecimento
    {
        public Gasolina(string nome, decimal valorAtual) : base(nome, valorAtual)
        {

        }
        public override void ExecutarAjustes()
        {
            decimal acrescimo = ValorAcumulado * 0.01m;
            AtualizarValor(acrescimo, DateTime.Now, "Ajustes para Gasolina");
            }
            } 