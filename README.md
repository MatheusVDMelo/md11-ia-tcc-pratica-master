# Avaliação Individual — Módulo 11 — Tecnologias Emergentes e IA

**Data de entrega:** DD/MM/AAAA
**Formato:** individual, de consulta aberta — use slides, anotações e a própria IA à vontade para pesquisar e testar suas respostas.

## Como participar

1. Faça um **fork** deste repositório.
2. Clone o seu fork localmente.
3. Responda as questões teóricas **direto neste README**, abaixo de cada uma.
4. Complete a parte prática (veja abaixo) editando `CLAUDE.md`, `.claude/skills/minha-skill/SKILL.md` e `EVIDENCIAS.md`.
5. Abra um **Pull Request** do seu fork de volta para este repositório.

> O PR não será mergeado — ele existe só para eu avaliar o seu diff. Pode deixar aberto depois de enviar.

O objetivo não é decorar definições, e sim demonstrar que você entende os conceitos e sabe aplicá-los para ganhar eficiência ao usar IA no seu projeto de TCC. Responda com suas próprias palavras — copiar e colar resposta pronta de IA sem entender não demonstra o aprendizado esperado.

---

## Questões dissertativas

### Questão 1 — O que é um "agent"?
O que é um "agent" (agente de IA)? Explique com suas próprias palavras e dê um exemplo de situação em que faz mais sentido usar um agente do que um chat comum.

**Sua resposta:**
Um agente de IA é um sistema autónomo que não se limita a gerar texto, mas é capaz de planear etapas, tomar decisões lógicas e utilizar ferramentas externas para executar ações no ambiente digital. Enquanto num chat comum o utilizador tem de copiar o código gerado e colá-lo no seu projeto manualmente, faz muito mais sentido usar um agente quando é necessário que a IA navegue diretamente pelos ficheiros de um repositório local, analise a estrutura de pastas e escreva as alterações de código diretamente nos ficheiros adequados de forma autónoma.

### Questão 2 — O que são guidelines?
O que são "guidelines" (diretrizes) ao usar uma IA generativa? Qual é o papel delas na qualidade das respostas geradas pelo modelo?

**Sua resposta:**
"Guidelines" são regras, restrições e padrões predefinidos que moldam o comportamento e as respostas da IA. O papel delas é garantir precisão, consistência e alinhamento com as necessidades do projeto. Ao definir diretrizes claras (por exemplo, obrigar o uso de boas práticas de programação orientada a objetos ou proibir a utilização de bibliotecas descontinuadas), evita-se que a IA tome decisões arbitrárias e garante-se que o resultado gerado possui um elevado padrão de qualidade técnica.

### Questão 4 — Escolha de modelo e nível de esforço
Qual modelo de IA utilizar para cada tipo de tarefa? Dê um exemplo de tarefa simples e outra mais complexa, explicando como você escolheria o modelo em cada caso. O que é o "nível de esforço" (effort level) e quando faz sentido aumentá-lo ou diminuí-lo?

**Sua resposta:**
A escolha do modelo deve basear-se no equilíbrio entre custo, velocidade e capacidade de raciocínio. Para uma tarefa simples, como formatar um bloco de texto ou criar uma expressão regular, um modelo mais leve e rápido (como o Claude 3 Haiku ou GPT-4o-mini) é suficiente. Para uma tarefa complexa, como projetar a arquitetura completa de uma aplicação web, é recomendável um modelo mais robusto (como o Claude 3.5 Sonnet ou o GPT-4o). 
O "nível de esforço" (*effort level*) diz respeito ao tempo e capacidade computacional que o modelo dedica a "pensar" antes de responder. Faz sentido aumentá-lo para desenhar a estrutura de bases de dados complexas ou resolver *bugs* difíceis, e diminuí-lo em tarefas diretas e repetitivas.

### Questão 5 — Como estruturar um bom prompt
Descreva os elementos que tornam um prompt mais eficaz (ex.: contexto, objetivo, formato esperado, exemplos, restrições).

**Sua resposta:**
Um prompt eficaz minimiza a ambiguidade ao incluir:
*   **Contexto:** O cenário geral (ex.: a linguagem de programação e *framework* a utilizar).
*   **Objetivo:** A ação específica que a IA deve realizar.
*   **Formato esperado:** A forma como a saída deve ser entregue (ex.: "Apresente apenas o bloco de código, sem texto adicional").
*   **Exemplos:** Entradas e saídas de referência para calibrar a precisão da resposta.
*   **Restrições:** O que a IA não deve, de todo, fazer.

### Questão 6 — Iteração de prompt
O que significa "iterar" um prompt? Por que a primeira resposta de uma IA geralmente não é a versão final, e como você usaria a resposta recebida para melhorar o próximo prompt?

**Sua resposta:**
Iterar um prompt significa ajustar e refinar a instrução inicial com base nos resultados obtidos. A primeira resposta raramente é a versão final porque o contexto inicial pode ser insuficiente ou a IA pode assumir premissas erradas. Se a IA gerar um código funcional, mas que utilize ciclos pouco eficientes, usa-se essa mesma resposta para construir um novo prompt mais específico, pedindo para refatorar a lógica utilizando *arrays* e reduzindo a complexidade de execução.

### Questão 7 — Zero-shot vs. few-shot
Qual é a diferença entre um prompt "zero-shot" e um prompt "few-shot"? Dê um exemplo de situação em que vale a pena incluir exemplos dentro do próprio prompt.

**Sua resposta:**
Um prompt "zero-shot" é uma instrução direta sem qualquer exemplo de referência, dependendo apenas do conhecimento prévio da IA. Um prompt "few-shot" inclui um ou mais exemplos concretos do formato de entrada e da saída desejada. Vale a pena incluir exemplos ("few-shot") em tarefas que exigem uma formatação estrita, como ao pedir à IA para ler ficheiros de *logs* e extrair os dados para um formato JSON com chaves específicas e formatos de data estandardizados.

### Questão 8 — Memória e contexto entre sessões
O que significa uma IA "ter memória" entre sessões diferentes de conversa? Por que, em um projeto longo como o TCC, é importante decidir o que precisa ser "lembrado" e como fornecer esse contexto para a IA a cada nova conversa?

**Sua resposta:**
Como os chats normais perdem o histórico assim que a sessão é fechada, "ter memória" significa persistir as regras de negócio e os padrões do código de forma acessível. Num projeto longo, é fundamental consolidar estas informações num documento central (como um ficheiro `CLAUDE.md`). Fornecer este contexto a cada nova interação garante que a IA não sugira abordagens incompatíveis e adote imediatamente as convenções do projeto, poupando tempo de alinhamento em todas as sessões.

### Questão 9 — Avaliar a resposta da IA
Antes de aplicar a sugestão de uma IA no seu projeto, como você verifica se ela está correta? Descreva pelo menos 2 formas práticas de checar a confiabilidade de uma resposta gerada por IA.

**Sua resposta:**
Para garantir a confiabilidade:
1.  **Validação na Documentação Oficial:** Cruzar os métodos e bibliotecas sugeridos com a documentação oficial da linguagem, garantindo que as funções realmente existem e não foram inventadas ou descontinuadas.
2.  **Testes em Ambiente Isolado:** Executar o bloco de código gerado num ambiente controlado (*sandbox*) ou criar testes unitários focados para garantir que a lógica lida corretamente com exceções, antes de a integrar no código principal.

### Questão 10 — Dividir tarefas complexas em etapas
Por que, em tarefas mais complexas, pode ser melhor dividir o trabalho em um fluxo de etapas (ex.: primeiro classificar/organizar, depois processar, depois revisar) em vez de pedir tudo em um único prompt? Dê um exemplo aplicado a uma tarefa do seu TCC.

**Sua resposta:**
Dividir o trabalho evita que a IA perca o foco, ignore detalhes importantes ou esgote o seu limite de contexto num único passo. No desenvolvimento de um projeto prático, como a construção da API backend DomusFinances, não se deve pedir tudo de uma vez. Em vez disso, pede-se primeiro à IA para desenhar o contexto e a estrutura da base de dados PostgreSQL; após aprovar essa parte, num segundo passo, solicita-se a criação dos *controllers* em .NET para gerir as transações; por fim, pede-se a lógica de validação. Esta abordagem em etapas garante um código muito mais coeso e fiável.

> **Questão 3** (como escrever um bom CLAUDE.md) e a **Questão 11** (prática, evidência de uso real da IA) são respondidas nos próprios arquivos `CLAUDE.md` e `EVIDENCIAS.md` — veja a parte prática abaixo.

---

## Parte prática

1. **Complete o `CLAUDE.md`** na raiz deste repositório — é onde você responde a Questão 3, documentando o projeto para orientar um assistente de IA.
2. **Complete a Skill** em `.claude/skills/minha-skill/SKILL.md`, com instruções reutilizáveis para uma tarefa recorrente do projeto. Renomeie a pasta `minha-skill/` para o nome real da sua skill.
3. **Conecte um assistente de IA ao código local** (Claude Code, GitHub Copilot, Cursor, ou outro de sua escolha) e use-o pelo menos uma vez de verdade, aplicando o `CLAUDE.md` e/ou a Skill que você criou em uma tarefa real do projeto `GerenciadorDeTarefas`.
4. **Complete o `EVIDENCIAS.md`** — é onde você responde a Questão 11, documentando essa experiência (ferramenta usada, prompt exato, o que a IA fez, se seguiu suas instruções).

### O que NÃO fazer

- ❌ Copiar as respostas, o CLAUDE.md ou a Skill de um colega
- ❌ Inventar uma evidência que não aconteceu de verdade
- ❌ Alterar arquivos fora do escopo pedido

## Sobre o projeto de exemplo

Dentro de `GerenciadorDeTarefas/` tem um console app simples em C# — um gerenciador de tarefas fictício — que serve de base para você praticar. Não é necessário adicionar funcionalidades novas ao app; o foco é a configuração e o uso da IA em cima desse código.

Abra `GerenciadorDeTarefas.sln` no Visual Studio, ou rode pelo terminal:

```bash
cd GerenciadorDeTarefas
dotnet run
```

---

## Critérios de avaliação (10 pontos)

| Critério | Pontos |
|---|---|
| Questões dissertativas (conjunto) | 4 |
| `CLAUDE.md` bem estruturado e específico ao projeto (Questão 3) | 2 |
| Skill funcional e realmente reutilizável | 2 |
| `EVIDENCIAS.md` — uso real da IA, seguindo (ou não) o CLAUDE.md/Skill (Questão 11) | 1 |
| Qualidade do Pull Request (descrição clara, organizado, dentro do escopo) | 1 |

## Entrega

Envie o **link do seu Pull Request** pelo Akademos até a data acima.
