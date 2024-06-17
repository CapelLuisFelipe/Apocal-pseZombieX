## Apocalípse Zombie X

**Descrição do Jogo:**

Apocalípse Zombie X é um jogo de ação e sobrevivência onde um policial tenta escapar de uma cidade infestada por zumbis. O jogador precisa usar suas habilidades de movimentação, corrida e teleportação estratégica para evitar os zumbis e sobreviver o maior tempo possível.

**Instruções para Jogabilidade:**

- **Movimentação:**  Utilize as teclas W, A, S, D para mover o policial pelo mapa da cidade.
- **Correr:** Segure a tecla Ctrl para aumentar a velocidade de corrida do policial, permitindo fugas rápidas dos zumbis.
- **Mudar Tempo:** Pressione a tecla Q para alternar entre dia e noite. Isso pode afetar a visibilidade e o comportamento dos zumbis.
- **Teleportar:** Pressione a tecla T para teleportar o policial para um ponto seguro do mapa, facilitando a fuga dos zumbis.

**Gameplay:**
Vídeo demonstrativo de gameplay do jogo:
- **Link: https://youtu.be/y_3xp551iVw**

**Prints do jogo:**
  
- **Menu do Jogo:**

![image](https://github.com/CapelLuisFelipe/Apocal-pseZombieX/assets/125330670/19232293-5b6d-42c2-b217-a99ff755cb85)

- **Print durante o dia:**
![image](https://github.com/CapelLuisFelipe/Apocal-pseZombieX/assets/125330670/d011dca7-e4dd-46f2-9b48-018153e4e978)

 - **Print durante a noite:**

![image](https://github.com/CapelLuisFelipe/Apocal-pseZombieX/assets/125330670/d05fe81b-3152-4fe8-a8d6-93d059df053e) 

- **Print na floresta:**

![image](https://github.com/CapelLuisFelipe/Apocal-pseZombieX/assets/125330670/8aaa8344-81bd-4ede-936e-202f2c4302b9)

- **Print na cidade:**

![image](https://github.com/CapelLuisFelipe/Apocal-pseZombieX/assets/125330670/3e910c63-4757-44b0-8bdd-9cf7dd55b257)


**Funcionalidades Desenvolvidas:**
- **Correr**
Foi implementado um sistema que permite ao jogador aumentar a velocidade do personagem quando a tecla Ctrl é pressionada, facilitando a fuga dos zumbis.

**Código:**
```csharp
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlePersonagem : MonoBehaviour
{
    [SerializeField] private float speed = 5.0f;
    [SerializeField] private float runningMultiplier = 2.0f; // Multiplicador para a corrida
    private Animator heroi;

    void Start()
    {
        heroi = GetComponent<Animator>();
    }

    void Update()
    {
        bool isMoving = false;
        float currentSpeed = speed;

        // Verifica se a tecla Control está pressionada para correr
        if (Input.GetKey(KeyCode.LeftControl) || Input.GetKey(KeyCode.RightControl))
        {
            currentSpeed *= runningMultiplier; // Dobra a velocidade
        }

        // Verifica se alguma tecla de movimento está pressionada
        if (Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.D))
        {
            isMoving = true;
        }

        // Movimentação para frente e para trás
        if (Input.GetKey(KeyCode.W))
        {
            transform.Translate(Vector3.forward * Time.deltaTime * currentSpeed);
        }
        else if (Input.GetKey(KeyCode.S))
        {
            transform.Translate(-Vector3.forward * Time.deltaTime * currentSpeed);
        }

        // Rotação para esquerda e direita
        if (Input.GetKey(KeyCode.A))
        {
            transform.Rotate(0, -1, 0);
        }
        else if (Input.GetKey(KeyCode.D))
        {
            transform.Rotate(0, 1, 0);
        }

        // Atualiza as variáveis do Animator
        heroi.SetBool("Correndo", isMoving);
        heroi.SetBool("Parado", !isMoving);
    }
}
```

![image](https://github.com/CapelLuisFelipe/Apocal-pseZombieX/assets/125330670/17a5d9a3-6afb-4609-b013-aee86ce7dffa)



- **Teleportar**
Foi adicionado um sistema que permite ao jogador teleportar o personagem para uma posição pré-definida no mapa, usando a tecla T para facilitar a fuga estratégica dos zumbis.
using UnityEngine;

**Código:**

```csharp
public class Teleporter : MonoBehaviour
{
    public Transform teleportTarget; // Alvo de teletransporte

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.T)) // Teletransporte ao pressionar a tecla T
        {
            if (teleportTarget != null)
            {
                Teleport();
                Debug.Log("Teletransporte realizado para: " + teleportTarget.position);
            }
            else
            {
                Debug.LogWarning("TeleportTarget não está definido!");
            }
        }
    }

    void Teleport()
    {
        transform.position = teleportTarget.position;
    }
}
```

![image](https://github.com/CapelLuisFelipe/Apocal-pseZombieX/assets/125330670/ee14fc6f-2d2b-480a-b0b4-d460ba84f4ea)




