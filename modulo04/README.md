# Módulo 4 - Conhecendo a Unity UI

Revisão: **28/05/2024**<br>
Instrutor: **Bruno Freitas**<br>

## Aula 1
- Unity UI
    - não é a interface da Unity
    - é o recurso para criar interface para os jogos
    - quando adiciona um button, será automático ter o pai: Canvas
    - Todos os UI trabalham com Rect Transform
- Canvas (pai de todos os UI)
    - **Render Mode**
        - Screen space - Overlay: renderiza a UI por cima da tela do jogo.
        - Screen space - Camera: renderiza a UI um pouco a frente da camera. Distorção ou efeito na camera será aplicado a UI.
        - World Space - renderiza junto com o mundo do jogo
- Rect Transform
    - Possui ancoragem. O gizmo da ancora é tipo um "trevo de 4 folhas".
    - Pode ser útil para manter a distância de UI caso haja alteração na posição ou dimensão do UI pai.
    - para rotacionar no centro do UI, deve-se configurar:
    - **Pivot**: x 0.5, y 0.5
    - **Scale**: se redimensionar, irá distorcer o texto do UI

## Aula 2
**UI**<br>
- Text (básico)
    - Componente **Text**
        - É possível altear via script essa propriedade.
- Text Mesh Pro (novidade)
    - textbox: se o texto for grande, pode ser que não fique visível ou visível por completo.
        - Horizontal Overflow e Vertical Overflow: Overlow vai permitir a visualização completa do texto, mesmo fora da textbox.
    - Raycast Target: se irá ter alguma colisão com o texto.
- Button
    - **Button** (componente) 
        - interactible: habilita/desabilita o botão para evento de clique.
        - On click(): permite arrastar objetos e depois selecionar a função, desse objeto, que será executada.
- Toggle
    - efeito de clicado/não clicado
- Slider
    - pode ser utilizado para controle de volume de audio. Mudar a direção.
- Scrollbar
- Dropdown

## Aula 3
- SeletorDeEnigma.cs
    - Visualizar o script que faz comunicação com UI.
    - Modulo04/Quizz/Assets/
- Um UI com um código adicionado, **add Component**
- Executar uma função de um script vinculado a outro objeto
    - Ex. Clique de botão, muda mensagem em um text.
    - Text deve ter um arquivo de script vinculado.
    - Button em On Click deve adicionar o objeto
        - selecionar a função, desse objeto, que irá executar.
