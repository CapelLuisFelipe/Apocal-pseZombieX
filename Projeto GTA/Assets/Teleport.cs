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
