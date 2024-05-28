# Módulo 1 - Introdução ao Unity

## Aula 1

Revisão: **28/05/2024**<br>
Instrutor: **Bruno Freitas**<br>
Tópico: **Introdução Geral**<br>

### O que é Unity?

É uma engine para desenvolvimento de jogos de computador, também utilizada em outras áreas na indústria para criação de ambientes 3D, como: animação, arquitetura, automobilística, etc.

## Aula 2

Revisão: **28/05/2024**<br>
Tópico: **Quem trabalha na indústria de jogos ?**<br>

### Principais

- Arte
    - Artistas 2D, 3D
    - Artistas de efeito
        - Necessário dominar as ferramentas de engine
    - Artistas técnicos
        - Fazem a ponte entre os artistas 2D, 3D e a engine
- Programação
    - Desenvolvimento do código do jogo.
    - Devem conhecer todas as áreas da engine
- Game play
    - Responsáveis pela criação da regra do jogo

### Indústria de jogos nacional

- [Wildlife](https://wildlifestudios.com/donation-rio-grande-do-sul/)
    - Está entre as 10 maiores empresas, de desenvolvimento de games, do mundo
    - Jogos que conseguem juntos uma receita de +de 6 milhões de dólares/mês
        - Zooba
        - Sniper 3D
        - Tennis Clash
- [Fanatee Games](https://fanatee.com/)
    - 2ª Maior empresa de jogos de palavra do mundo.
    - Letroca
    - CodyCross
- [Aquiris](https://www.aquiris.com.br/)
    - Empresa de Porto Alegre - RS
    - Horizon Chase
- [Octagon](http://octagongame.com/)
- [Black River](https://www.facebook.com/blackrivergames/)
    - Está em Manaus, pertence à Samsung
- [Consultar a indústria de jogos](https://www.industriadejogos.com.br/)

## Aula 3

Revisão: **28/05/2024**<br>
Tópico: **Ferramenta necessária**<br>

### Instalação do Unit

- [Unity](https://unity.com/pt)
    - Baixar o Unity Hub
        - Permite a instalação de versões diferentes do Unity Engine
            - Recomendável instalar a versão LTS
        - Criação de projetos
        - Atualização das Engines
        - Adicionar suporte de build para outras plataformas
        - Na primeira instalação, não precisa de nenhuma build

## Aula 4

### Primeiro projeto

- Versão da Unity na aula: **2019.4.12f1**
- Testando com a **2019.4.40f1**
    - Versão somente para estudo, pois os motores gráficos já estão defasados.

### Templates de projetos

- 2D, 3D, 3D with extras
    - usados na antiga pipeline da Unity (antigo motor gráfico)
        - está defasado
- High Definition RP
    - Para projetos de grande desempenho, jogos com gráficos ultra realistas, mais pesados.
- Universal Render Pipeline - **utilizado na aula**
    - Não é uma regra, porém, utilizar a mesma versão da aula, quando está conhecendo a ferramenta, diminui o problema de ter dificuldade de achar um recurso por ter uma descrição atualizada.
    - Para jogos mais simples, iluminação mais simples
    - Ideal para jogos de mobile
    - **3D Sample Scene (URP)**
- Há outros micropojetos na Unity
    - baixar para estudar

### Aparência do projeto inicial

<img src="https://github.com/andrebronca/unity-mentorama-iniciante/blob/andre_pc_pti/modulo01/img/Screenshot_3.png" alt="Visão Geral"/>

<img src="https://github.com/andrebronca/unity-mentorama-iniciante/blob/andre_pc_pti/modulo01/img/Screenshot_4.png" alt="Visão Game"/>


### Pesquisando os Assets

- Mesh
    - Extensão do arquivo: .fbx
    - Duplo clique abre o visualizador 3D do Windows
- Model
    - Extensão: .fbx
    - Duplo clique abre o visualizador 3D do Windows
- Material
    - Extensão: .mat
- Texture
    - Extensão: .tif
- Shader
    - Extensão: .ShaderGraph
- Script
    - Extensão: .cs
    - Linguagem: C#
- Scenes
    - Extensão: .unity
- Prefab
    - Extensão: prefab

### Project
- Lista todos os arquivos (Assets) do projeto
- É possível fazer buscas, salvar em favoritos, adicionar arquivos

### Console
- Utilizado também para debug, visualização de erros em codificação

### Cenas
- Não tem um padrão para utilização, um jogo pode ter algumas ou dezenas de cenas.
- Cada nível pode ser uma cena.
- A criação de cenas é subjetiva, depende da forma de organização do projeto que se queira fazer.

### Movimentação na cena
- scrool (botão central)
    - clicar + segurar + arrastar: movimenta a câmera
    - permite aplicar zoom, aproxima ou recua
- botão esquerdo
    - seleciona os elementos da cena
    - pressinando **W** entra no modo de movimentação do objeto, surge os axis.
    - pressionando **E** aparece o axis de rotação.
    - pressionando **R** permite redimensionar um eixo ou todos.
    - pressionando **Q** volta para a movimentação da cena
    - pressionando **T** permite mudar a dimensão
    - pressionando **Y** exibe junto os recursos de **W** e **E** e **R**
    - pressinando **F** ajusta a câmera para determinado elemento

### Alguns recursos

<img src="https://github.com/andrebronca/unity-mentorama-iniciante/blob/andre_pc_pti/modulo01/img/Screenshot_5.png" alt="Visualização na Cena"/>

1) Permite visualizar detalhes dos objetos
2) Visão 2D da cena
3) Oculta/exibe iluminação
4) On/Off som
5) Alguns efeitos visuais, aumentar ou diminuir processamento
6) Recursos para a câmera
7) São os símbolos 2D que aparecem na cena: (câmera, iluminação)

### Inspector
Todos os elementos na cena, são considerados GameObject.<br>
- GameObject
    - Possui componentes, podem ser identicos ou diferentes de outros GameObjects.
    - Cada componente possui atributos.
    - **Todo** asset que está em cena é chamado de GameObject
- Parte comum a todos
    - Ativar/desativar
    - Renomear
    - Aplicar tag
    - Aplicar layer
        - Utilizado para colisões
    - Definir se é static ou não
- Seleção do elemento
    - Pivot e Center
        - Center da mesh
        - Pivot da mesh
        - Pivot e Center estão posicionados em locais diferentes.
        - A rotação muda, conforme a seleção.
    - Local e Global
        - Local: rotaciona o elemento a partir do seu eixo
        - Global: rotaciona o elemento a partir do eixo da "cena", é outra referência.
        - O ambiente possui uma referência de coordenada e um novo elmento terá outra referência que pode não estar alinhada com o ambiente.


## Mudando a posição de alguns elemntos
- alterando posição
- alterando rotação
<img src="https://github.com/andrebronca/unity-mentorama-iniciante/blob/andre_pc_pti/modulo01/img/Screenshot_8.png" alt="Alterando a posição de alguns GameObjects"/>