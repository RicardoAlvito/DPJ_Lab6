using Unity.VisualScripting;
using UnityEngine;

[RequireComponent(typeof(Collider))]
public class Token : MonoBehaviour
{
    public int value = 1; 
    public AudioClip pickupSfx;

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
            UIManager.Instance.AddScore(value);
        }

        if (pickupSfx != null)
        {
            AudioSource.PlayClipAtPoint(pickupSfx, transform.position);
        }

        Destroy(gameObject);
    }
}