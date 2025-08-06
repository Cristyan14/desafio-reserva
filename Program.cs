class Program
{
    static void Main(string[] args)
    {
      
         var hospedes = new List<Pessoa>
        {
            new Pessoa("João", 28),
            new Pessoa("Maria", 25)
        };

        var suite = new Suite("Premium", 2, 150.00m);

        // Passa a suite no construtor da Reserva
        var reserva = new Reserva(12, suite);
        reserva.CadastrarHospedes(hospedes);

        Console.WriteLine($"Hóspedes: {reserva.ObterQuantidadeHospedes()}");
        Console.WriteLine($"Valor da diária total: R$ {reserva.CalcularValorDiaria():0.00}");
    }
}