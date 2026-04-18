using System;

namespace HabitTracker {

    /// 
    /// Representa um hábito do utilizador.
    /// Esta classe é usada pelo Model para guardar e carregar dados via Json.NET.
    /// Não deve ter dependências de View nem de Controller.
    /// 
    class Habit {

        // ── Propriedades ───────────────────────────────────────────────────

        /// Nome do hábito. Ex: "Beber água"
        public string Nome { get; set; }

        /// Descrição breve do hábito. Ex: "Beber 2L por dia"
        public string Descricao { get; set; }

        /// 
        /// Data e hora em que o hábito foi concluído.
        /// Null se ainda não foi concluído.
        /// 
        public DateTime? DataConclusao { get; set; }

        // ── Construtores ───────────────────────────────────────────────────

        /// 
        /// Construtor vazio obrigatório para o Json.NET conseguir deserializar.
        /// Não remover.
        /// 
        public Habit() { }

        /// 
        /// Construtor principal. Cria um hábito novo sem data de conclusão.
        /// 
        /// <param name="nome">Nome do hábito</param>
        /// <param name="descricao">Descrição do hábito</param>
        public Habit(string nome, string descricao) {
            // TODO: inicializar as propriedades Nome, Descricao e DataConclusao
            throw new NotImplementedException();
        }

        // ── Métodos ────────────────────────────────────────────────────────

        /// 
        /// Indica se o hábito foi concluído hoje.
        /// Compara a data de DataConclusao com DateTime.Today.
        /// 
        /// <returns>True se concluído hoje, False caso contrário</returns>
        public bool ConcluidoHoje() {
            // TODO: retornar true se DataConclusao tem valor e é de hoje
            throw new NotImplementedException();
        }
    }
}
