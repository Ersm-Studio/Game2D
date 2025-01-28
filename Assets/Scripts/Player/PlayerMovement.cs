using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
   
    public CharacterController2D characterController;
    float horiznotalMove=0f;
    float runspeed=40f;
    public bool Jump=false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        horiznotalMove = Input.GetAxisRaw("Horizontal")*runspeed;
        if (Input.GetButtonDown("Jump"))
        {

            Jump = true;
        }


    }
    private void FixedUpdate()
    {
        //Move The Player1
        characterController.Move(horiznotalMove * Time.fixedDeltaTime, false, Jump);
        Jump = false;
    }

}
