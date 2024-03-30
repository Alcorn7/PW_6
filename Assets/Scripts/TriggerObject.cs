using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerObject : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
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
