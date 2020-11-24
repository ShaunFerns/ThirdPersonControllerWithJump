using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ThirdPersonCharacterControl : MonoBehaviour
{
    public float Speed;

	void Update ()
    {
        PlayerMovement();
    }

    void PlayerMovement()
   //below are the lines for jump, adjust the figure that get mulitplied by Vector3.up to adjust height of jump, the if(tranform position is to stop double jumps
    {
        if (Input.GetKeyDown (KeyCode.Space))
        
        {
            if(transform.position.y <= 1.05f) 
            GetComponent<Rigidbody> ().AddForce (Vector3.up * 400);
        }
        float hor = Input.GetAxis("Horizontal");
        float ver = Input.GetAxis("Vertical");
        Vector3 playerMovement = new Vector3(hor, 0f, ver) * Speed * Time.deltaTime;
        transform.Translate(playerMovement, Space.Self);
    }
}