# Módulo 6 - Gerenciamento de cenas e Inputs

Revisão: **28/05/2024**<br>
Instrutor: **Bruno Freitas**<br>

## Aula 1
- **Cenas**
    - É +- como uma fase, engloba os gameObjects específicos em determinada cena. É possível ter mais de uma cela ao mesmo tempo no jogo. É possível editar mais de uma cena ao mesmo tempo no jogo.
    - Não há como não ter uma cena no Unity.

## Aula 2
- **Gerenciar cena a partir de código**
    - criando duas cenas
    - criando um script que irá carregar uma cena
    - vincular o script em um button que está na cena 1
        - a função carrega a cena 2
    - na cena 2 há um cubo vermelho, só para perceber a mudança
    - explicações adicionais do código C#. Script05SceneManager.cs
    --**Obs.**: tem que carregar a cena no Build Settings
- Nessa fiz o exemplo do botão que exibe a cena 2, e adicionei nessa cena 2 um botão para voltar à cena 1.

## Aula 3
- **Movimentação de objeto**
    - Update(): tem que ser aplicada o input de pressionamento para verificar a cada frame se ocorreu acionamento. Há diversos eventos para o tipo de acionamento de tecla.
    - Exemplo: MovimentaCubo.cs
        - mais explicações
