---
name: minha-skill
description: TODO — preencha depois de decidir o que a sua skill faz e quando ela deve ser usada
---

# Skill: Refatoração Segura de C#

## Descrição
Use esta skill sempre que o usuário pedir para "refatorar", "limpar" ou "melhorar" um método existente no projeto GerenciadorDeTarefas.

## Instruções de Execução
Ao refatorar um código, você DEVE seguir estes passos exatos:
1. **Preservar Comportamento:** Não altere a lógica de negócios central nem a assinatura do método (nome, retornos e parâmetros principais).
2. **Tratamento de Erros:** Adicione blocos `try-catch` apropriados se o método lidar com conversão de tipos ou leitura de dados.
3. **Documentação:** Adicione um comentário XML (///) acima do método refatorado explicando brevemente o que ele faz.
4. **Saída:** Retorne **apenas** o novo método refatorado, sem apagar o código anterior no seu raciocínio, para que o usuário possa fazer o *diff* facilmente.

<!--
PARTE PRÁTICA — Skill reutilizável

Implemente aqui uma Skill para uma tarefa recorrente deste projeto
(ex.: adicionar uma nova funcionalidade ao Program.cs seguindo o estilo
já usado, ou gerar um teste pra uma função nova).

Renomeie a pasta `minha-skill/` para o nome real da sua skill.
Apague este comentário antes de entregar.
-->
