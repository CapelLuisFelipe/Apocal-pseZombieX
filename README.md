# **🧟‍♂️🔥 Apocalipse Zombie X 🧟‍♂️🔥**

## **Descrição do Jogo**

*Apocalipse Zombie X* é um eletrizante jogo de ação e sobrevivência onde você assume o papel de um policial tentando escapar de uma cidade infestada por zumbis. Para sobreviver, o jogador deve utilizar habilidades estratégicas de movimentação, corrida e teletransporte enquanto explora diferentes cenários e enfrenta desafios cada vez mais intensos.

## **Instruções de Jogabilidade**

- **Movimentação:** Utilize as teclas **W, A, S, D** para mover o personagem pelo mapa.
- **Correr:** Pressione **Ctrl** para aumentar a velocidade do personagem, permitindo fugas rápidas dos zumbis.
- **Mudança de Tempo:** Pressione **Q** para alternar entre dia e noite. A variação do tempo influencia a visibilidade e o comportamento dos inimigos.
- **Teletransporte:** Pressione **T** para se teleportar para um ponto seguro do mapa, garantindo uma fuga estratégica.

## **Gameplay**

Confira o vídeo demonstrativo do jogo:
▶️ [**Gameplay de Apocalipse Zombie X**](https://youtu.be/y_3xp551iVw)

## **Capturas de Tela**

### **📌 Menu Principal**
![Menu do Jogo](https://github.com/CapelLuisFelipe/Apocal-pseZombieX/assets/125330670/19232293-5b6d-42c2-b217-a99ff755cb85)

### **🌙 Cenário Noturno**
![Cena à Noite](https://github.com/CapelLuisFelipe/Apocal-pseZombieX/assets/125330670/d011dca7-e4dd-46f2-9b48-018153e4e978)

### **☀️ Cenário Diurno**
![Cena de Dia](https://github.com/CapelLuisFelipe/Apocal-pseZombieX/assets/125330670/d05fe81b-3152-4fe8-a8d6-93d059df053e)

### **🌲 Floresta Misteriosa**
![Floresta](https://github.com/CapelLuisFelipe/Apocal-pseZombieX/assets/125330670/8aaa8344-81bd-4ede-936e-202f2c4302b9)

### **🏙️ Cidade Infestada**
![Cidade](https://github.com/CapelLuisFelipe/Apocal-pseZombieX/assets/125330670/3e910c63-4757-44b0-8bdd-9cf7dd55b257)

---

## **Funcionalidades Desenvolvidas**

### **🏃‍♂️ Corrida Rápida**
Foi implementado um sistema de corrida que permite ao jogador aumentar temporariamente a velocidade do personagem ao pressionar a tecla **Ctrl**, facilitando a fuga de situações perigosas.

#### **Código:**
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

### **⚡ Teletransporte Estratégico**
Foi implementado um sistema de teletransporte que permite ao jogador escapar de emboscadas rapidamente ao pressionar **T**, transportando-se para um ponto seguro do mapa.

#### **Código:**
```csharp
using UnityEngine;

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

![Teletransporte](https://github.com/CapelLuisFelipe/Apocal-pseZombieX/assets/125330670/ee14fc6f-2d2b-480a-b0b4-d460ba84f4ea)

---

## **Conclusão**

*Apocalipse Zombie X* oferece uma experiência envolvente de sobrevivência em um mundo pós-apocalíptico repleto de perigos. Com mecânicas estratégicas de movimentação, corrida e teletransporte, o jogo proporciona desafios intensos e momentos de pura adrenalina. Prepare-se para testar suas habilidades e sobreviver o máximo possível neste caos zumbi! 🧟‍♂️🔥

