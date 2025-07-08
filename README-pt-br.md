# CapCut-downgrade-tool

esse meu primeiro projeto publicado desculpe qualquer bug

##

Editor simples em C# para Windows Forms que permite fazer downgrade das versões dos projetos do CapCut, com backup automático.

![Captura de tela 2025-07-07 174112](https://github.com/user-attachments/assets/df2f9ead-1def-4240-8b35-0f55b0da688e)

-⚠️ Este aplicativo foi criado como uma solução para o seguinte problema comum:

- "This project was created by a newer version of CapCut. Update now." (Este projeto foi criado por uma versão mais recente do CapCut. Atualize agora.)

## Funcionalidades

- Lista as versões instaladas do CapCut no PC (apenas 3 primeiros números da versão)
- Lista os projetos salvos do CapCut
- Aplica downgrade das versões nos projetos selecionados
- Faz backup automático do arquivo draft_content.json antes de qualquer alteração
- Os backups são armazenados em : C:\Users%username%\AppData\Local\CapCut\User Data\Projects\com.lveditor.draft
  
## Como usar

1. Selecione a versão do CapCut desejada.
2. Selecione o projeto que quer modificar.
3. Clique em “Aplicar Versão” para fazer o downgrade.
4. Se o estilo da legenda for alterado, existe o backup.

## Avisos Importantes

- O CapCut altera automaticamente estilos de legenda que não são compatíveis com versões antigas.  
- Isso significa que, ao fazer downgrade para versões antigas do CapCut, algumas legendas podem perder fontes, cores ou efeitos especiais que só existem em versões mais novas.  
- O texto da legenda **não é perdido**, apenas o estilo pode ser modificado.  
- Para minimizar esse problema, este editor cria backups automáticos e permite restaurar os estilos originais depois do downgrade.  
- Recomendamos usar versões do CapCut próximas à versão original do projeto para evitar perda de estilo.  
- Se você abrir projetos criados em versões muito recentes do CapCut em versões muito antigas, pode haver perda de qualidade visual nas legendas devido à incompatibilidade.
- exemplo do que acontece com legendas abertas em um CapCut antigo um projeto do CapCut versão 6.5.0 quando aberto na versao 4.0.0

 ![Captura de tela 2025-07-08 080025](https://github.com/user-attachments/assets/3b2ae8f1-e572-4670-b19f-72b0693cd77a)

## Requisitos

- Windows com .NET Framework instalado
- Visual Studio para abrir o projeto e compilar (opcional)

---

Contribuições e sugestões são bem-vindas!

---

**Autor:** nakito448


