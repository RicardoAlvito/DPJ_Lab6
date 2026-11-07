using Unity.VisualScripting;
using UnityEngine;

[RequireComponent(typeof(Collider))]
public class PowerUp : MonoBehaviour
{
    public int up = 1; // Quantidade de vida a retirar
    public AudioClip hitSfx;

    private void Awake()
    {
        GetComponent<Collider>().isTrigger = true;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (!other.CompareTag("Player"))
        {
            return;
        }

        
        if (UIManager.Instance != null)
        {
            UIManager.Instance.AddLives(+up);
        }

        if (hitSfx != null)
        {
            AudioSource.PlayClipAtPoint(hitSfx, transform.position);
        }

        Destroy(gameObject);
    }
}