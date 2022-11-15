using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField]
    private float speed = 10.0f;
    [SerializeField]
    private float JumpForce = 15.0f;
    private Rigidbody2D rb;
    private bool isFacingRight = true;
    private Vector3 pos;
    private bool Jumped;

    public Camera main;

    void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log("yes");
        Jumped = false;
    }

    void Start()
    {
        Jumped = false;
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        float move = Input.GetAxis("Horizontal");
        pos = main.WorldToScreenPoint(transform.position);

        if ((Input.GetKeyDown("w") || Input.GetKeyDown("space") || Input.GetKeyDown(KeyCode.UpArrow)) && !Jumped)
        {
            rb.velocity += new Vector2(0, JumpForce);
            Jumped = true;
        }
        if (Input.GetKey("d") || Input.GetKey(KeyCode.RightArrow))
        {
            rb.velocity += Vector2.right * move * speed * Time.deltaTime;
        }
        else if (Input.GetKey("a") || Input.GetKey(KeyCode.LeftArrow))
        {
            rb.velocity += Vector2.right * move * speed * Time.deltaTime;
        }
        Flip();
    }


    public void Flip()
    {
        if (Input.mousePosition.x < 90)
            transform.localRotation = Quaternion.Euler(0, 180, 0);

        if (Input.mousePosition.x > -90)
            transform.localRotation = Quaternion.Euler(0, 0, 0);
    }
}
