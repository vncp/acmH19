using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementIJKL : MonoBehaviour
{
    public float speed;
    private Rigidbody2D rb;
    private Vector3 mv;

    void Start()
    {
       rb = GetComponent<Rigidbody2D>();
    }

    private void Update() 
    {
        if (Input.GetKey(KeyCode.J))
             rb.AddForce(Vector3.left);
        if (Input.GetKey(KeyCode.L))
             rb.AddForce(Vector3.right);
        if (Input.GetKey(KeyCode.I))
             rb.AddForce(Vector3.up);
        if (Input.GetKey(KeyCode.K))
             rb.AddForce(Vector3.down);
 
    }
}