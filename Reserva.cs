public class Reserva
{
    public List<Pessoa> Hospedes { get; set; } = new List<Pessoa>();
    public Suite Suite { get; set; }  // Agora será inicializada no construtor
    public int DiasReservados { get; set; }

    // Construtor recebe Suite e DiasReservados
    public Reserva(int diasReservados, Suite suite)
    {
        DiasReservados = diasReservados;
        Suite = suite ?? throw new ArgumentNullException(nameof(suite));
    }

    public void CadastrarHospedes(List<Pessoa> hospedes)
    {
        if (hospedes.Count <= Suite.Capacidade)
        {
            Hospedes = hospedes;
        }
        else
        {
            throw new Exception("Capacidade da suíte é menor que o número de hóspedes.");
        }
    }

    public int ObterQuantidadeHospedes()
    {
        return Hospedes.Count;
    }

    public decimal CalcularValorDiaria()
    {
        decimal valor = DiasReservados * Suite.ValorDiaria;

        if (DiasReservados > 10)
        {
            valor *= 0.9M; // 10% de desconto
        }

        return valor;
    }
}