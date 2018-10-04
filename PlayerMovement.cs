using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour {

	public CharacterController2D controller; 
	public Animator animator;
	public Rigidbody2D rigidBody2D;
	public float runSpeed = 40f;
	private 

	float horizontalMove = 0f;
	bool jump = false;
	bool sprint = false;

	// Update is called once per frame
	void Update () 
	{
		horizontalMove = Input.GetAxisRaw("Horizontal") * runSpeed;
		animator.SetFloat("Speed", Mathf.Abs(horizontalMove));
		if (Input.GetButtonDown ("Jump")) 
		{
			jump = true;
			animator.SetBool("IsJumping", true);
		}
	}

	void FixedUpdate () {
		controller.Move(horizontalMove * Time.fixedDeltaTime, false, jump);
		jump = false;
	}

	public void OnLanding()
	{
		animator.SetBool ("IsJumping", false);
	}

}