# Módulo 2 - Trabalho com objetos na cena

## Aula 1

Revisão: **28/05/2024**<br>
Instrutor: **Bruno Freitas**<br>

### Asset Store
- Asset Store [Ctrl + 9]
    - [AssetStore](https://assetstore.unity.com/)
- [itch](https://itch.io/)

## Aula 2
- Criação de uma nova cena
    - no projeto do módulo 1, aula 4.

### Cube
- Adicionando um cube (forma primitiva)
    - composta de quatro componentes
        - Transform
            - altera posição, rotação e escala
            - clicar na letra do eixo e arrastar o cursor, altera o valor do eixo.
        - Cube (Mesh Filter)
            - é o que exporta de um editor 3D (blender, 3DMax)
        - Mesh Renderer
            - responsável pela forma que a mesh será renderizada
            - recebe textura
        - Box Collider
            - serve para detectar quando outro objeto colide com esse objeto

### Snap de objetos
- colar um objeto na borda do outro
    - pressiona **V**, clica na vértice e arrasta o objeto para o lado desejado
        - é possível deixar o objeto bem alinhado
    - achando a posição que deseja, soltar a tecla **V**
    - criar uma forma para testar:
        - juntar 4 cubos

### prefab
- cria um elemento e que deseja reproduzí-lo em outros locais
- Hierarchy -> Create Empty
    - arrastar a forma(s) para esse GameObject
        - cubos do exemplo do snap
    - GameObject será o pai dos elementos
        - selecionando este gameObject é possível deslocar todos os elementos.
        - clicando em um elemento interno, é possível alterar a apresentação.
- Clicando no elemento pai e arrastando para o Project, é criado um prefab. A cor irá alterar para azul.
- Reutilizar o prefab
    - clicar e arrastar do Project para o Hierarchy
- Editar um prefab, aplicar para todos os outros
    <img src="https://github.com/andrebronca/unity-mentorama-iniciante/blob/andre_pc_pti/modulo02/img/Screenshot_10.png" alt="Editar prefab"/>
    - caso edita, e queira aplicar a alteração para os demais prefabs
        - clicar no gameObject pai > Overrides > apply all
            - opção acima está no inspector
    - open
        - abre para edição do prefab
    - select
        - localiza o prefab no Project


## Aula 3
- Câmera e iluminação

### Câmera
- Camera (component)
    - **Projection**
        - para 3D: perspective
        - 2D: orthographic
    - FOV Axis
        - fecha ou abre a visualização da lente, conforme a seleção
            - Vertical
            - Horizontal
    - Field of View
        - posição da câmera, visualizando os objetos
    - Physical Camera
        - true: exibe configuração para simular uma câmera "real"
    - Clipping Planes
        - Near (perto)
        - Far (longe)
        - faz um corte de objetos, demonstra onde irá começar a cortar o objeto na exibição (movimentação) da cena
    - **Environment**
        - skybox (é o céu do ambiente 3D)

### Iluminação
- Directional Light (iluminação principal na cena)
    - aplica iluminação a todos os objetos da cena, no mesmo ângulo, independente de onde está posicionada a directional light
    - **Light**
        - Mode
            - Realtime: a luz muda conforme se movimenta na tela do jogo, fica mais pesado e realista o processamento/resultado.
            - Baked: fixa uma iluminação (mapa de iluminação) e a movimentação não irá alterar o ângulo da luz depois.
        - Indirect Multiplier: como a luz irá refletir e reiluminar outros objetos próximos
        - Culling Masc: permite selecionar algo que não irá receber o efeito do ângulo de iluminação. Ex. Dentro de uma casa e fora de uma casa. Directional Light funciona como o Sol.
        - Shadow Type: como o efeito de sombra irá se comportar no mundo do jogo

- Point Light (adicionar no Hierarchy)
    - Range: altera a área de alcance da iluminação.
- Spot Light
    - Reproduz uma luz mais focada.
        - objeto configurado (checked static como) (objeto a ser iluminado):
            - Contribute GI
            - Batching Static
            - Reflection Probe Static
    - aproximar do objeto e aumentar o valor da intensity para perceber.
    