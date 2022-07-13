namespace EstudoFuncionario2._0.Services
{
    public class ConverterGrauGrauIdService
    {
        public string AtribuirGrau(int grauId)
        {
            switch (grauId)
            {
                case 1:
                    return "Junior";
                case 2:
                    return "Pleno";
                case 3:
                    return "Senior";
                default:
                    return "Grau Inexistente";
            }
        }

        public int AtribuirGrauId(string grau)
        {
            switch (grau)
            {
                case "Junior":
                    return 1;
                case "Pleno":
                    return 2;
                case "Senior":
                    return 3;
                default:
                    return 0;
            }
        }
    }
}
