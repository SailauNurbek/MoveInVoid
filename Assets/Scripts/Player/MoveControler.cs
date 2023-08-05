using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveControler : MonoBehaviour
{
    Rigidbody2D rb;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }       


    
    private void FixedUpdate()
    {
        Move();
        MouseRatata();
    }

    public float thrust = 10;
    private void Move()
    {        
        if (Input.GetKey(KeyCode.W))
        {
            rb.AddForce(transform.up * thrust, ForceMode2D.Impulse);
        }
        if (Input.GetKey(KeyCode.S))
        {
            rb.AddForce(transform.up * -thrust, ForceMode2D.Impulse);
        }
        if (Input.GetKey(KeyCode.D))
        {
            rb.AddTorque(-thrust, ForceMode2D.Impulse);
        }
        if (Input.GetKey(KeyCode.A))
        {
            rb.AddTorque(thrust, ForceMode2D.Impulse);
        }
    }

    private void MouseRatata()
    {
        Vector2 mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        transform.up = mousePosition - (Vector2)transform.position;
    }
}
