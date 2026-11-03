using UnityEngine;
using UnityEngine.InputSystem.Interactions;

public class PlayerHeliScript : MonoBehaviour
{
    public Rigidbody2D rb;
    public float flyStrength;
    public bool gameOver = false;
    

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    public void Update()
    {
        if (Input.GetKeyDown(KeyCode.UpArrow) == true)
        {
            rb.linearVelocity = Vector2.up * flyStrength;
        }

        if (Input.GetKey(KeyCode.Space) == true)
        {
            rb.gravityScale = 0;
            rb.linearVelocity = new Vector2(rb.linearVelocity.x, 0);
        }
        else
        {
            rb.gravityScale = 1.25f;
        }
    }
    private void OnCollisionEnter(Collision collision)
    {

    }
}
