using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ThirdPersonCharacterController : MonoBehaviour
{

    public float Speed;
    public float JumpHeight = 1f;

    // Update is called once per frame
    void Update()
    {
        PlayerMovement();

        if (Input.GetKey(KeyCode.Space))
        {
            Jump();
        }
    }

    void PlayerMovement()
    {
        float hor = Input.GetAxis("Horizontal");
        float ver = Input.GetAxis("Vertical");
        Vector3 playerMovement = new Vector3(hor, 0f, ver) * Speed * Time.deltaTime;
        transform.Translate(playerMovement, Space.Self);


    }

    void Jump()
    {
        GetComponent<Rigidbody>().AddForce(0, 10, 0);
    }


}


