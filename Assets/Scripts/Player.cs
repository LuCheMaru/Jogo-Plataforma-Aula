using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    private float Horizontal;
    private Rigidbody2D rb;
    private bool isFacingRight = true;

    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
    }
    // Update is called once per frame
    void Update()
    {
        Horizontal = Input.GetAxis("Horizontal");
        Debug.Log(Horizontal);
        this.rb.velocity = new Vector2(Horizontal * 100f,rb.velocity.y);
        Flip();
        /*if (Input.GetKey(KeyCode.Space)) {
            Debug.Log("A");
        }
        if (Input.GetMouseButtonDown(0))
        {
            Debug.Log("B");
        }*/
    }

    private void Flip()
    {
        if(isFacingRight && Horizontal < 0f || !isFacingRight && Horizontal > 0)
        {
            isFacingRight = !isFacingRight;
            Vector3 localScale = transform.localScale;
            localScale.x *= -1f;
            transform.localScale = localScale;
        }
    }
}
