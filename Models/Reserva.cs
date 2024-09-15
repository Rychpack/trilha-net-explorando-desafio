namespace DesafioProjetoHospedagem.Models
{
    public class Reserva
    {
        public List<Pessoa> Hospedes { get; set; }
        public Suite Suite { get; set; }
        public int DiasReservados { get; set; }

        public Reserva() { }

        public Reserva(int diasReservados)
        {
            DiasReservados = diasReservados;
        }

        public void CadastrarHospedes(List<Pessoa> hospedes)
        {
            if (Suite.Capacidade >= hospedes.Count)
            {
                Hospedes = hospedes;
            }
            else
            {
                throw new Exception("A capacidade de hóspedes não pode exceder a capacidade máxima da suíte.");

            }

        }

        public void CadastrarSuite(Suite suite)
        {
            Suite = suite;
        }

        public int ObterQuantidadeHospedes()
        {
            return Hospedes.Count;
        }

        public decimal CalcularValorDiaria()
        {
            decimal valor = 0;
            valor = DiasReservados * Suite.ValorDiaria;


            if (DiasReservados >= 10)
            {
                valor = (DiasReservados - (DiasReservados * 0.1M)) * Suite.ValorDiaria;
            }

            return valor;
        }

        public void ListarHospedes(List<Pessoa> hospedes)
        {
            foreach (var item in hospedes)
            {
                Console.WriteLine($"Hóspedes: {item.NomeCompleto}");
            }
        }
    }
}