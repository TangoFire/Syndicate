using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float moveSpeed = 5f;
    public Vector2 lastMoveDir;
   
    public float dashDistance = 10f;
    public GameObject dashEffect;
    public Transform dashStartPosition;

    public Rigidbody2D rb;

    public Camera cam;
    Vector2 input;
    Vector2 mousePos;


    private void Awake()
    {
        rb.GetComponent<Rigidbody2D>();  
    }
    private void Update()
    {
        input.x = Input.GetAxisRaw("Horizontal");
        input.y = Input.GetAxisRaw("Vertical");
       
        mousePos = cam.ScreenToWorldPoint(Input.mousePosition);
    }
    void FixedUpdate()
    {
        Vector2 direction = input.normalized;
        Vector2 velocity = direction * moveSpeed;
        Vector2 movement = velocity * Time.fixedDeltaTime;

        rb.MovePosition((Vector2)transform.position + movement);

        Vector2 lookDir = mousePos - rb.position;
        float angle = Mathf.Atan2(lookDir.y, lookDir.x) * Mathf.Rad2Deg - 90f;
        rb.rotation = angle;
        lastMoveDir = direction;
        HandleDash();
    }

    private void HandleDash()
    {
        if (Input.GetKeyDown(KeyCode.Space)    )
        {
         transform.position += (Vector3)lastMoveDir * dashDistance;
          //  Instantiate(dashEffect, new Vector2(transform.position.x, transform.position.y), Quaternion.identity);
        }
    }

}
