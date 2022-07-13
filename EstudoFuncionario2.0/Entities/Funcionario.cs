namespace EstudoFuncionario2._0.Entities
{
    public class Funcionario
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public int Idade { get; set; }
        public DateTime DataNascimento { get; set; }
        public DateTime DataContratacao { get; set; }
        public DateTime DataCriacao { get; set; }
        public int CargoId { get; set; }
        public int GrauId { get; set; }
    }
}
