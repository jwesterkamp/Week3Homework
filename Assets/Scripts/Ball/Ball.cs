using UnityEngine;

public class Ball : MonoBehaviour
{
    [SerializeField]
    private Rigidbody2D rigidBody = null;

    [SerializeField]
    private float speed = 1.0f;

    private Vector3 currentDirection = Vector3.up;

    //TODO: Add code to move ball along with code to delete pieces upon colliding with one
    //Ball should only move once its been launched

    void Awake()
    {
        //currentDirection = new Vector3(Random.Range(-1.0f, 1.0f), Random.Range(-1.0f, 1.0f), 0);
        // currentDirection = new Vector3.up;
    }
   void Start()
    {

    }

    void Update()
    {
            var newDelta = currentDirection * Time.deltaTime * speed;
            rigidBody.MovePosition(transform.position + newDelta);
            //transform.Translate(currentDirection * Time.deltaTime * speed);
        
    }

         void OnCollisionEnter2D(Collision2D collision)
        {
            currentDirection = Vector2.Reflect(currentDirection, collision.contacts[0].normal);
        }
}
