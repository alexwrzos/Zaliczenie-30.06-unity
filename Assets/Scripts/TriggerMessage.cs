using UnityEngine;
using TMPro;
using System.Collections;
public class TriggerMessage : MonoBehaviour
{
    [SerializeField] private string message = "KONIEC";
    [SerializeField] private TextMeshProUGUI messageText;
    [SerializeField] private float messageDuration = 4.0f;

    void Start()
    {
        messageText.text = message;
        messageText.enabled = false;
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
        messageText.text = message;
        messageText.enabled = true;
        }
    }

}
