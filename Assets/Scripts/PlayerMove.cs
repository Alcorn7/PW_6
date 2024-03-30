using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    [SerializeField] private float _moveSpeed;

    void Update()
    {
        Move();
    }

    private void Move()
    {
        if(Input.GetKey(KeyCode.A)) 
        { 
            transform.Translate(-0.1f * _moveSpeed, 0f, 0f);
        }
        else if (Input.GetKey(KeyCode.D))
        {
            transform.Translate(0.1f * _moveSpeed, 0f, 0f);
        }        
    }

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log($"Triggered with {other.gameObject.name}!");
    }
}
