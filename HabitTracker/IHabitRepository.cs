using System.Collections.Generic;

namespace HabitTracker
{
    public interface IHabitRepository
    {
        // Retorna lista de habitos guardados no ficheiro de persistência
        List<Habit> LerHabitos();

        // Guarda lista de habitos recebido em parâmetro no ficheiro de persistência
        void SalvarHabitos(List<Habit> habitos);
    }
}
