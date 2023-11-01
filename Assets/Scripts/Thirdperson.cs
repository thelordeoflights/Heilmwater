using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Thirdperson : MonoBehaviour
{

    public Transform orientation;
    public Transform player;
    public Transform playerObj;
    public float rotationSpeed;
    // Start is called before the first frame update
    void Start()
    {

        // Cursor.lockState = CursorLockMode.Locked;
        // Cursor.visible = false;
    }

    // Update is called once per frame
    void Update()
    {
        //rotate orientation
        Vector3 viewD = player.position - new Vector3(transform.position.x, player.position.y, transform.position.z);
        orientation.forward = viewD.normalized;

        //rotate player object
        float verticalInput = Input.GetAxis("Vertical");
        float horizontalInput = Input.GetAxis("Horizontal");
        Vector3 inputD = orientation.forward + orientation.right * horizontalInput;

        if (inputD != Vector3.zero)
        {
            // Debug.Log("HERE");
            playerObj.forward = Vector3.Slerp(playerObj.forward, inputD.normalized, Time.deltaTime * rotationSpeed);
        }
    }
}
