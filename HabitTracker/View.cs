using System;
using System.Collections.Generic;

namespace HabitTracker {

    /// 
    /// Componente View do padrão MVC 
    /// Responsável por:
    ///   - Apresentar informação ao utilizador na consola
    ///   - Recolher input do utilizador
    ///   - Notificar o Controller quando o utilizador age (via eventos)
    ///   - Ir buscar dados ao Model via evento com ref (sem referência direta)
    ///
    /// REGRA: A View não conhece o Controller nem o Model.
    ///        Nunca instanciar Model ou Controller aqui.
    ///        Para obter dados do Model, usar o evento PrecisoDaListaDeHabitos.
    /// 
    class View {

        // ── Eventos de comunicação com o Model (via ref, sem dependência) ──

        /// 
        /// A View dispara este evento quando precisa da lista de hábitos.
        /// O Model responde preenchendo o parâmetro ref lista.
        /// Vinculação feita no Controller: view.PrecisoDaListaDeHabitos += model.SolicitarListaHabitos
        /// 
        public delegate void SolicitacaoListaHabitos(ref List<Habit> lista);
        public event SolicitacaoListaHabitos PrecisoDaListaDeHabitos;

        //  Eventos de input para o Controller 

        /// 
        /// Disparado quando o utilizador submete os dados de um novo hábito.
        /// Vinculação feita no Controller: view.UtilizadorSubmeteuNovoHabito += AdicionarHabito
        /// 
        public delegate void PedidoComNomeDescricao(string nome, string descricao);
        public event PedidoComNomeDescricao UtilizadorSubmeteuNovoHabito;

        /// 
        /// Disparado quando o utilizador seleciona um hábito para concluir.
        /// O índice passado é 0-based (convertido internamente a partir do número digitado).
        /// Vinculação feita no Controller: view.UtilizadorSubmeteuConclusao += ConcluirHabito
        /// 
        public delegate void PedidoComIndice(int indice);
        public event PedidoComIndice UtilizadorSubmeteuConclusao;

        //  Inicialização 

        /// Construtor vazio — a View não inicializa Model nem Controller.
        public View() { }

        // Apresentação do menu
        /// 
        /// Limpa a consola e desenha o menu principal com as opções disponíveis.
        /// Chamado pelo Controller no início de cada ciclo de interação.
        /// 
        public void DesenharMenuPrincipal() {
            // TODO: limpar consola com Console.Clear()
            //       desenhar o menu com as opções:
            //         1. Adicionar hábito
            //         2. Concluir hábito
            //         0. Sair
            //       pedir input com Console.Write("Opção: ")
            throw new NotImplementedException();
        }

        //  Atualização da lista (chamado pelo evento do Model) 

        /// 
        /// Obtém a lista de hábitos via evento PrecisoDaListaDeHabitos
        /// e desenha-a na consola.
        /// Subscrito ao evento Model.ListaFoiAlterada pelo Controller.
        /// 
        public void AtualizarLista() {
            // TODO: declarar List<Habit> lista = null
            //       disparar PrecisoDaListaDeHabitos?.Invoke(ref lista)
            //       se lista for null ou vazia, mostrar "(sem hábitos registados)"
            //       caso contrário, percorrer a lista e mostrar cada hábito com:
            //         número, [✓] se ConcluidoHoje() ou [ ] se não, Nome e Descricao
            throw new NotImplementedException();
        }

        // ── Fluxo: adicionar hábito

        /// 
        /// Pede ao utilizador o nome e descrição do novo hábito.
        /// Após recolher os dados, dispara UtilizadorSubmeteuNovoHabito.
        /// Chamado pelo Controller quando o utilizador escolhe a opção 1.
        /// 
        public void PedirDadosNovoHabito() {
            // TODO: mostrar cabeçalho "── Adicionar hábito ──"
            //       pedir Nome com Console.ReadLine()
            //       pedir Descrição com Console.ReadLine()
            //       disparar UtilizadorSubmeteuNovoHabito?.Invoke(nome, descricao)
            throw new NotImplementedException();
        }

        // ── Fluxo: concluir hábito

        /// 
        /// Mostra a lista atual e pede ao utilizador que selecione um hábito.
        /// Após recolher a seleção, dispara UtilizadorSubmeteuConclusao.
        /// Chamado pelo Controller quando o utilizador escolhe a opção 2.
        /// 
        public void PedirSelecaoHabito() {
            // TODO: chamar AtualizarLista() para mostrar a lista
            //       mostrar cabeçalho "── Concluir hábito ──"
            //       pedir número do hábito com Console.ReadLine()
            //       converter para índice 0-based (número digitado - 1)
            //       se a conversão falhar, chamar MostrarErro("Entrada inválida.")
            //       caso contrário, disparar UtilizadorSubmeteuConclusao?.Invoke(indice)
            throw new NotImplementedException();
        }

        // ── Feedback ───────────────────────────────────────────────────────

        /// 
        /// Mostra uma mensagem de sucesso a verde e aguarda tecla.
        /// Chamado pelo Controller após operações bem-sucedidas.
        /// 
        /// <param name="mensagem">Texto a apresentar</param>
        public void MostrarSucesso(string mensagem) {
            // TODO: definir Console.ForegroundColor = ConsoleColor.Green
            //       escrever "✓ {mensagem}"
            //       repor Console.ResetColor()
            //       aguardar tecla com Console.ReadKey()
            throw new NotImplementedException();
        }

        /// 
        /// Mostra uma mensagem de erro a vermelho e aguarda tecla.
        /// Chamado pelo Controller ou internamente quando o input é inválido.
        /// 
        /// <param name="mensagem">Texto a apresentar</param>
        public void MostrarErro(string mensagem) {
            // TODO: definir Console.ForegroundColor = ConsoleColor.Red
            //       escrever "✗ {mensagem}"
            //       repor Console.ResetColor()
            //       aguardar tecla com Console.ReadKey()
            throw new NotImplementedException();
        }
    }
}
