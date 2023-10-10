using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float movespeed = 5.0f;
    public Transform orientation;
    public Transform playerTransform;
    float verticalInput;
    float horizontalInput;


    void myInput()
    {
        verticalInput = Input.GetAxisRaw("Vertical");
        horizontalInput = Input.GetAxisRaw("Horizontal");
        transform.Translate(playerTransform.forward * Time.deltaTime * verticalInput * movespeed);
        transform.Translate(playerTransform.right * Time.deltaTime * horizontalInput * movespeed);
    }

    void Update()
    {
        myInput();
    }
}

