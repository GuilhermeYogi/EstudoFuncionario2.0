namespace EstudoFuncionario2._0.Services
{
    public class RetornaIdadeService 
    {
        public int CalcularIdade(DateTime dataNascimento)
        {

            int idade;
            DateTime hoje = DateTime.Today;

            idade = hoje.Year - dataNascimento.Year;
            if (hoje.Month < dataNascimento.Month)
            {
                return --idade;
            }
            else if (hoje.Month == dataNascimento.Month)
            {
                if (hoje.Day < dataNascimento.Day)
                {
                    return --idade;
                }
            }

            return idade;

        }            
    }
}
