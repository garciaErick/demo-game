using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
	public CharacterController2D characterController;
	float horizontalMove = 0f;
	bool jump = false;

    // Update is called once per frame
    void Update()
    {
			horizontalMove = Input.GetAxisRaw("Horizontal");
			jump = Input.GetButton("Jump") ? true : false;
        
    }

		private void FixedUpdate() {
			characterController.Move(horizontalMove, false, jump);
			jump = false;
			
		}
}
