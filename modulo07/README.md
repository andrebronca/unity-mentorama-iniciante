# Módulo 7 - Conhecendo os mecanismos da física

Revisão: **29/05/2024**<br>
Instrutor: **Bruno Freitas**<br>

## Aula 1
-**Engine de Física**<br>
    - 2D e 3D possuem comportamentos distintos, uma não consegue interferir na outra.<br>
    - Selecionar o objeto e adicionar o componente: Rigidbody<br>
    - **Rigidbody**<br>
        -- Drag: atrito. Se houver objetos com valores diferentes, o maior valor representará maior atrito com o ar, no caso de queda, dependendo o caso, será mais lento.<br>
        -- Is Kinematic: se ativo, não terá efeito da física.<br>
    - Rigidbody será específico do Collider.<br>
        -- Collider 2D para Rigidbody 2D.<br>
        -- Collider 3D para Rigidbody 3D.<br>

## Aula 2
-**Collider**
    - Criar um Physic Material: permite que o objeto "quica" quando colide com outro. Valor vai de 0.0 a 1.0
        - **Bounciness**
    - Em Scene02 há alguns exemplo de aplicação de física.
    - Collider > **Is Trigger** > para disparar algo via código C# e não efetivamente colidir.
    - **Colidir.cs**: contém exemplo do Is Trigger
    - **MovimentaCubo.cs**: contém exemplo de movimentação com teclas

## Aula 3
-**RayCast**: Criar um raio que dura um frame, tem posição de origem e destino e caso colida com algo, retorna o valor do que foi colidido. Clique em local específico da tela, para detectar a posição pode ser feito com RayCast.
    - **RayCast.cs**: tem um exemplo do uso, basta vincular o scritp a um objeto que esteja alinhado com outro para ver o resultado no console.
    - RayMask: faz com que os raios só acertem algo em uma layer específica.
    - Deve ser executado na FixedUpdate()
