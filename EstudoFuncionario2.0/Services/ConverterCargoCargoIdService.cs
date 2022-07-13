using EstudoFuncionario2._0.Entities;

namespace EstudoFuncionario2._0.Services
{
    
    public class ConverterCargoCargoIdService
    {
        public string AtribuirCargo(int cargoId)
        {
          
            switch (cargoId)
            {
                case 8:
                    return "Analista";
                case 9:
                    return "Gestor";
                case 10:
                    return "Encarregado da Limpeza";
                default:
                    return "Cargo Inexistente";
            }
        }

        public int AtribuirCargoId(string cargo)
        {

            switch (cargo)
            {
                case "Analista":
                    return 8;
                case "Gestor":
                    return 9;
                case "Encarregado da Limpeza":
                    return 10;
                default:
                    return 0;
            }
        }
    }
}
