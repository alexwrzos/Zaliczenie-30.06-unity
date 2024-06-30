using UnityEngine;

public class Message : MonoBehaviour
{
 [SerializeField] private string message = "Przeszedłeś gre";

 private void OnTriggerEnter2D(Collider2D other)
 {
    Debug.Log("Hurra");
    if(other.CompareTag ("Player"))
    {
        Debug.Log(message);
    }
 }
}

