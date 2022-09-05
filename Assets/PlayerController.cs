using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    // Appears in the Inspector view from where you can set the speed
    public float speed;

    // Rigidbody variable to hold the player ball's rigidbody instance
    private Rigidbody rb;

   
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    //called once per frame
    private void Update()
    {
        // 2-d plane, x and z for horizontal and vertical movements

        // It records input from the keyboard.
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");

        // Vector3 variable, movement, holds 3D positions of the player ball in form of X, Y, and Z axes in the space.
        Vector3 movement = new Vector3(moveHorizontal, 0.0f, moveVertical);

        // Apply force on the player ball to move around
        rb.AddForce(movement * speed * Time.deltaTime);
    }
}