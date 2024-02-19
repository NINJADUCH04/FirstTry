using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UIElements;

public class PlayerScript : MonoBehaviour
{
    private Interactable X;
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
            X.CallEvent();
            Debug.Log("press x");
        }
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.TryGetComponent<Interactable>(out  X))
        {
           // Debug.Log("Key and book are Keying");
            trigger =true;
        }
      

       
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        if(collision.TryGetComponent<Interactable>(out var x))
        {
            trigger = false;
        }


    }



}
