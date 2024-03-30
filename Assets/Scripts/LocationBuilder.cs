using UnityEngine;

public class LocationBuilder : MonoBehaviour
{

    [SerializeField] private string playerName;
    [SerializeField] private Vector3 playerPosition;
    [SerializeField] private Vector3 playerSize;
    [SerializeField] private float playerDrag;
    [SerializeField] private bool playerGravity;
    [SerializeField] private bool playerTrigger;

    [SerializeField] private string enemyName;
    [SerializeField] private Vector3 enemyPosition;
    [SerializeField] private Vector3 enemySize;
    [SerializeField] private float enemyDrag;
    [SerializeField] private bool enemyGravity;
    [SerializeField] private bool enemyTrigger;

    [SerializeField] private string floorName;
    [SerializeField] private Vector3 floorPosition;
    [SerializeField] private Vector3 floorSize;
    [SerializeField] private float floorDrag;
    [SerializeField] private bool floorGravity;
    [SerializeField] private bool floorTrigger;


    private void Awake()
    {
        
        GameObject Player = GameObject.CreatePrimitive(PrimitiveType.Cube);
        createGameObject(Player, playerName, playerPosition, playerSize, playerDrag, playerGravity, playerTrigger);
        Player.AddComponent<PlayerMove>();
        Player.AddComponent<TriggerObject>();

        GameObject Enemy = GameObject.CreatePrimitive(PrimitiveType.Cube);
        createGameObject(Enemy, enemyName, enemyPosition, enemySize, enemyDrag, enemyGravity, enemyTrigger);
        Enemy.AddComponent<TriggerObject>();

        GameObject Floor = GameObject.CreatePrimitive(PrimitiveType.Cube);
        createGameObject(Floor, floorName, floorPosition, floorSize, floorDrag, floorGravity, floorTrigger);
        Floor.GetComponent<Rigidbody>().isKinematic = true;
    }


    private void createGameObject(GameObject go, string name, Vector3 position, Vector3 size, float drag, bool gravity = true, bool trigger = false)
    {
        go.name = name;

        go.AddComponent<Rigidbody>();
        go.GetComponent<Rigidbody>().useGravity = gravity;
        go.GetComponent<Rigidbody>().drag = drag;
        go.transform.localScale = size;

        go.AddComponent<BoxCollider>();
        go.GetComponent<BoxCollider>().isTrigger = trigger;
        
        go.transform.position = position;
        
    }
}
