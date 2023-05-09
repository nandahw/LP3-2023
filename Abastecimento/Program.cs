using CltAbast;

        var abastecimentos = new Abastecimento ("Renato Fernandez", 0m);
        var gasolina = new Gasolina("Gasolina", 0);
        gasolina.AtualizarValor(20, DateTime.Now, "Gasolina Comum");
        gasolina.AtualizarValor(50, DateTime.Now, "Gasolina Aditivada");
        gasolina.ExecutarAjustes();
        Console.WriteLine(gasolina.EmitirRelatorio());

        var diesel = new Diesel("Diesel", 0, -90);
        diesel.AtualizarValor(500, DateTime.Now, "Diesel");
        diesel.ExecutarAjustes();
        Console.WriteLine(diesel.EmitirRelatorio());