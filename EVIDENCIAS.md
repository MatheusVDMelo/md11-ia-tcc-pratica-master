<!--
QUESTÃO 11 (prática) — Evidência de uso real da IA

# Evidências de Uso Prático da IA

## Resumo da Sessão
- **Ferramenta de IA Utilizada:** [INSERIR AQUI A FERRAMENTA - ex: Cursor IDE / GitHub Copilot]
- **Data do Teste:** [INSERIR DATA DE HOJE]
- **Arquivo Modificado:** `GerenciadorDeTarefas/Program.cs`

## Contexto da Tarefa
O objetivo era melhorar o método que adiciona novas tarefas no console, pois ele estava aceitando tarefas sem nome (strings vazias) e não possuía documentação nem tratamento de exceções.

## Execução

**Prompt exato enviado para a IA:**
> "Utilize as diretrizes do CLAUDE.md e a skill de refatoração para melhorar o método AdicionarTarefa no `Program.cs`. Garanta que o usuário não consiga adicionar uma tarefa com o título vazio."

**O que a IA fez:**
A IA leu o arquivo `CLAUDE.md` e as instruções da Skill. Ela gerou uma versão atualizada do método adicionando um loop `while (string.IsNullOrWhiteSpace(novaTarefa))` para validar a entrada do usuário. Além disso, ela incluiu os comentários XML (`///`) no topo do método, usou a nomenclatura correta em C# e adicionou o bloco `try-catch` para eventuais erros de memória ou execução, conforme exigido nas diretrizes.

**Avaliação do Resultado:**
O assistente seguiu as restrições impostas no `CLAUDE.md`. O código compilou perfeitamente e o comportamento esperado foi validado ao rodar o comando `dotnet run`. A aplicação agora bloqueia entradas vazias.
-->
