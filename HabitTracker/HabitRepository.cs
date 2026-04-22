using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;

namespace HabitTracker
{
    public class HabitRepository : IHabitRepository
    {
        // Caminho JSON persistência
        private const string FicheiroJSON = "habitos.json";

        public List<Habit> LerHabitos()
        {
            if(!File.Exists(FicheiroJSON))
                return new List<Habit>();

            string json = File.ReadAllText(FicheiroJSON);
            return JsonConvert.DeserializeObject<List<Habit>>(json) ?? new List<Habit>();
        }

        public void SalvarHabitos(List<Habit> habitos)
        {
            // TODO: no futuro detectar e tratar de alguma forma caso não se consiga escrever no ficheiro
            // por motivo de permissão no caminho, ou outro motivo
            string jsonData = JsonConvert.SerializeObject(habitos, Formatting.Indented);
            File.WriteAllText(FicheiroJSON, jsonData);
        }
    }
}
