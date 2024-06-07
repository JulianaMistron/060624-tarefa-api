namespace Oportunidade
{
    public class OportunidadeModel
    {
        public int Id { get; set; }
        public string Descricao { get; set; }
        public DateTime DataEntrega { get; set; }
        public string NivelSurtos { get; set; }
        public int QtdHoras { get; set; }
        public long QtdErros { get; set; }
        public long Aprendizado { get; set; }
        public long HorasDeSono { get; set; }
        public int Folga { get; set; }
    }
}
