using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerScript : MonoBehaviour
{
  public float speed = 1.5f;
    private Rigidbody2D playerRigidbody2D;
    bool trigger = false;
    bool bookTrigger = false;

    // Start is called before the first frame update
    void Start()
    {
        playerRigidbody2D = GetComponent<Rigidbody2D>();
        playerRigidbody2D.gravityScale = 0; // Disable gravity for the main character

    }

    // Update is called once per frame
    void Update()
    {
        Vector2 moveInput = new Vector2(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"));
        Vector2 moveVelocity = moveInput.normalized * speed;
        playerRigidbody2D.velocity = moveVelocity;
        if(Input.GetKeyDown(KeyCode.X) && trigger) {
            Debug.Log("press x");
        }
        if (Input.GetKeyDown(KeyCode.X) && bookTrigger)
        {
            Debug.Log("press X for book");
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.name == "key")
        {
            Debug.Log("its working");
            trigger = true;
        }
        if(collision.gameObject.name == "Book")
        {
            Debug.Log("this is a book");
            bookTrigger = true;
        }

       
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        if(collision.gameObject.name == "key")
        {
            trigger = false;
        }

        if (collision.gameObject.name == "Book")
        {
            bookTrigger = false;
        }

    }



}
