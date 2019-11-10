using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float speed;
    private Rigidbody2D rb;
    private Vector2 mv;
    public float jump;
    void Start()
    {
       rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        Vector2 moveInput = new Vector2(Input.GetAxis("Horizontal"), 0);
        mv = moveInput.normalized * speed;

        float check = Input.GetAxis("Vertical");

        if(check != 0)
        {
            rb.AddForce(transform.up * jump);
        }
    }

    private void FixedUpdate()
    {
        rb.MovePosition(rb.position + mv*Time.fixedDeltaTime);
    }
}