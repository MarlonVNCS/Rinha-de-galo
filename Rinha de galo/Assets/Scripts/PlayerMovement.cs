using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    float moveSpeed = 10;
    float jumpForce = 1F;


    void Start()
    {

    }

    void Update()
    {
        float horizontalInput = Input.GetAxis ("Horizontal"); 
        float verticalInput = Input.GetAxis("Vertical");
        
        float jumpInput = Input.GetAxis("Jump");

        transform.Translate(new Vector3(horizontalInput, 0, verticalInput) * moveSpeed * Time.deltaTime);
        if(Input.GetKeyDown("space"))
            transform.Translate(new Vector3(0, jumpInput, 0) * jumpForce);

    }
}
