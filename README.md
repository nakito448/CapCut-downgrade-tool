# CapCutVersionEditor

Editor simples em C# para Windows Forms que permite fazer downgrade das versões dos projetos do CapCut, com backup automático e restauração dos estilos de legenda.

## Funcionalidades

- Lista as versões instaladas do CapCut no PC (apenas 3 primeiros números da versão)
- Lista os projetos salvos do CapCut
- Aplica downgrade das versões nos projetos selecionados
- Faz backup automático do arquivo draft_content.json antes de qualquer alteração
- Botão para restaurar estilos de legenda a partir do backup, evitando perda de estilo após downgrade

## Como usar

1. Selecione a versão do CapCut desejada.
2. Selecione o projeto que quer modificar.
3. Clique em “Aplicar Versão” para fazer o downgrade.
4. Se o estilo da legenda for alterado, clique em “Restaurar Estilos do Backup”.

## Requisitos

- Windows com .NET Framework instalado
- Visual Studio para abrir o projeto e compilar (opcional)

---

Contribuições e sugestões são bem-vindas!

---

**Autor:** Seu Nome
