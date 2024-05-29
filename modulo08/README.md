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

    7:49

