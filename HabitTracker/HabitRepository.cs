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
            try
            {
                string json = JsonConvert.SerializeObject(habitos, Formatting.Indented);
                File.WriteAllText(FicheiroJSON, json);
            }
            catch (IOException ex)
            {
                throw new HabitTrackerException("Erro ao guardar ficheiro.", ex);
            }
        }
    }
}
