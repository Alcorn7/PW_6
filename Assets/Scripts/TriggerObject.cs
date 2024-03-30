using UnityEngine;

public class TriggerObject : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        Debug.Log($"Triggered with {other.gameObject.name}!");
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name != "Floor")
            Debug.Log($"{base.gameObject.name} touched {collision.gameObject.name}!");
    }
}
