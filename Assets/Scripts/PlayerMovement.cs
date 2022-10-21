using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
	public float speed = 12f;
    public float gravity = -9.81f;

    public Transform groundCheck;
    public float groundDistance = 0.4f;
    public LayerMask groundMask;

    Vector3 velocity;
	Vector3 movement;

    bool isGrounded;

	public bool canMove = true;

    // Update is called once per frame
    void Update()
    {
        isGrounded = Physics.CheckSphere(groundCheck.position, groundDistance, groundMask);

        if (isGrounded && velocity.y < 0)
        {
            velocity.y = -2f;
        }

		void FixedUpdate()
		{
			if (canMove) 
			{
				//rb.MovePosition(rb.position + movement * moveSpeed); (This is shaded as that this doesn't work in the moving platforms)
				velocity = speed * movement;
			}
			else
			{
				velocity = Vector3.zero;
			}
		}
	}

	private void OnTriggerEnter(Collider other)
	{
		if(other.gameObject.CompareTag("Pickups"))
		{
			Destroy(other.gameObject);
		}
	}

	public void DialogEnter() 
	{
			/*animator.SetFloat("Horizontal", 0);
			animator.SetFloat("Vertical", 0);
			animator.SetFloat("Speed", 0);*/
			canMove = false;
	}

	public void DialogExit() 
	{
		canMove = true;                  
	}

        /*float x = Input.GetAxis("Horizontal");
        float z = Input.GetAxis("Vertical");

        Vector3 move = transform.right * x + transform.forward * z;


        velocity.y += gravity * Time.deltaTime;*/
}
