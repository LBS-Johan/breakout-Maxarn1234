using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{


    private Rigidbody2D rb;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        rb.velocity = new Vector2(0, -5);
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.y < -6)
        {
            transform.position = new Vector2(0, 5);
        }
        float speed = 4;
        rb.velocity = rb.velocity.normalized * speed;
    }
}
