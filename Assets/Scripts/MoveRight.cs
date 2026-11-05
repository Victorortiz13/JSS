using UnityEngine;

public class MoveRight : MonoBehaviour
{
    public Rigidbody2D rBody;
    public float speed;
    private float rightBound = 12f;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rBody.linearVelocity = Vector2.right * speed;
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.x > rightBound && gameObject.CompareTag("Projectile"))
        {
            Destroy(gameObject);
        }


    }
}
