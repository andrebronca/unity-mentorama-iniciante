# Gráficos na Unity
Revisão: **29/05/2024**<br>
Instrutor: **Alan Pereira**<br>

## Aula 1

- Conhecendo o instrutor

## Aula 2

Rendering: o processo de desenhar objetos 2D/3D na cena.<br>
Pipeline: ideia de linha de produção.<br>

**Culling**<br>
1. Não exibe o que está fora da área da câmera.
2. **Occlusin culling**. Exibe objetos que não apareçam na câmera, pois há outros objetos na frente. Esse objeto como está na área da câmera, será renderizado.
3. Templates de projetos. Possuem Render em Pipeline específicas.
4. Atualizar uma template simples para uma mais sofisticada.
    1. Window > Package Manager > Unity Registry
        1.1 Seleciona a render pipeline que deseja ou outro package
    2. Aplicar o package: Edit > Project Settings > Graphics
        1.1 Assets > new Folder > 'RenderingPipeline' > [Enter]
        1.2 Create > Rendering > Universal Render Pipeline > Pipeline Asset(Forward Renderer)
        1.3 Cria automaticamente dois assets
            1.3.1 UniversalRenderPipelineAsset
                1.3.1.1 Arrastar esse arquivo para o Campo do Graphics
                1.3.1.2 Scriptable Render Pipeline Settings
            1.3.2 UniversalRenderPipelineAsset_Renderer

## Aula 3

**Importação de modelos 3D**
1. Tipos de aquivos suportados pela Unity para importação
2. Formatos de exportação (recomendado, padrão da indústria)
    2.1 .fbx
    2.2 .obj
    2.3 .3ds
3. Formatos de aplicação (fica automatizado, edita e já carrega no Unity)
    3.1 .blend (Blender)
    3.2 .ma, .mpg (Maia)
    3.3 .max (3DSMax)
4. Assets > Import New Asset... > 'localizar o arquivo .fbx'
    4.1 [Download models 3D .FBX](https://free3d.com/3d-models/fbx)
    4.2 Assets > Models > Boat > 'importei o .fbx'
5. Ou selecionar o arquivo e arrastar para o projeto no Unity editor.
6. Rig Models
    6.1 [Robot Kyle 3D](https://rigmodels.com/model.php?view=Robot_Kyle-3d-model__208238ef467444a6a43fdc7983470162&manualsearch=1)
    6.2  Assets > Models > RobotKyle > 'importar o .fbx'
        6.2.1 Essa parte há mais arquivos para serem importados (arrastados)
        6.2.2 Normal*.tga e Color*.tga
        6.2.3 Tem que criar um Material para aplicar esses arquivos (.tga)
        6.2.4 O Material que veio no fbx não está editável (por hora)
        6.2.5 Adicionar o arquivo de RGB para o **Surface Inputs > Base Map**
        6.2.6 Adicionar o arquivo de Normal para **Normal Map**
        6.2.7 Mover o Model para Hierarchy, aplicar o material.
7. O Model vem com bloqueios de edição, para transformá-lo em prefab
    7.1 Criar um Empty Object, colocar o Model dentro
        7.1.1 Renomear: PrefabRK
    7.2 Arrastar esse PrefabRK para: Assets > Prefab

8. Propriedades do modelo importado
    8.1 Model está no formato .fbx.
    8.2 Scale Factor: fator de escala, unidade do modelo
    8.3 BlendShapes: são malhas extras com 'formatos' diferentes. Ex. Rosto sorrindo, sério, neutro.
    8.4 Mesh Compression: se for High, resulta em uma qualidade menor da malha.
    8.5 Read/Write Enable: se irá permitir alteração da malha via código.
    8.6 Generate Colliders: Geração de colisores.
    8.7 Weld Vertices: Verifica vértices que não são necessárias
    8.8 Index Format: Reserva memória caso o objeto seja muito complexo.
    8.9 Normals: Ângulos das faces, utilizado para a iluminação, dar a sensação de objeto 3D.
9. Com o modelo em Hierarchy (scene), para visualizar o colisor, localise o prefab do modelo.
    9.1 Irá aparecer: Mesh Filter, Mesh Renderer, Mesh Collider

## Aula 4

Revisão: 03/06/2024<br>
**Mesh Renderer, Skinned, configurações de importação: Rig**<br>
1. Em modelo, localizar a aba [Rig]: Rig é o que permite animar um objeto (personagem).
    1.1 No exemplo de um modelo de barco, como não tem animação, em Rig, o Animation 
    Type pode ficar em: None
        1.1.1 **Mesh Renderer**: 
            1.1.1.1 Cast Shadows: se vai produzir sombra.
            1.1.1.2 Contribute Global Illumin: se irá refletir (cor) em outros objetos.
        1.1.2 **Additional Settings**:
            1.1.2.1 Dynamic Occlusion: a Unity some com o objeto quando ele não é mais necessário no cenário.

    1.2 No exemplo do Robot Kyle: em Rig, o Animation Type será: Humanoid
        1.2.1 Com isso o Unity irá traduzir em um avatar, pode aproveitar as configurações de Rig em outros personagens humanoides.
        1.2.2 Como é o primeiro, deixar: Avatar Definition em Create From This Model.
            1.2.2.1: Surgiu um erro, o modelo não permitiu a criação do avatar: Invalid Avatar Rig Configuration, Missing or invalid transform: Required human none 'Hips' not found.
            1.2.2.2: Clicar no botão configure para carregar o Avatar.
        1.2.3 **obs.**: caso clique e não apareça as configurações da importação, mudar para navegação via teclado. Teve vez que o clique não exibia a configuração.
        1.2.4 Rig é como se fosse uma estrutura de ossos. Caso o botão [configure] não leve ao avatar, verificar se há o arquivo de avatar.
2. Objeto animado possui: **Skinned Mesh Renderer**
    2.1 Localizar o objeto (prefab) com o componente supracitado.
    2.2 Bounds: define os limites desse objeto. Conforme o objeto se movimenta, o bound muda a definição de região. Ex. Levantar braço aumenta o bound, encolher a animação, diminui o bound. O bound é monitorado pelo culling, quando sai de cena, não precisa mais ser renderizado.
        2.2.1 Update When Offscreen: se true, renderiza o objeto, mesmo quando o bound estiver fora da área da câmera.
3. BlendShapes
    3.1 Quando o projeto possui shapes, no Inspector aparece uma lista dos BlandShapes. Essas opções estarão no componente **Skinned Mesh Renderer**.

## Aula 5

Revisão: 03/06/2024<br>
**Mesh Renderer, Skinned, configurações de importação: Rig**<br>
1.
        

