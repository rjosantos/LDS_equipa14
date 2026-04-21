using System;
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

        public void TestarData()
        {
            Console.WriteLine($"Ficheiro: {Path.GetFullPath(FicheiroJSON)}");

            var testList = new List<Habit>();
            testList.Add(new Habit { Nome = "habito test 1", Descricao = "desc habito 1" });
            testList.Add(new Habit { Nome = "habito test 2", Descricao = "desc habito 2" });
            testList.Add(new Habit { Nome = "habito test 3", Descricao = "desc habito 3" });
            SalvarHabitos(testList);

            var readHabits = LerHabitos();
            foreach(var h in readHabits)
            {
                Console.WriteLine($" - Nome: {h.Nome} - Desc: {h.Descricao}");
            }
            Console.ReadKey(); // pausar execução para ver dados
        }
    }
}
