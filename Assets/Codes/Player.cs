using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour {

	private float speed = 7f;
	private Vector3 moveDir;
	private string midJump = "n";
	public static int playerMov;
	public Animator anim;
	void Start () 
	{
		playerMov = 20;
		StartCoroutine(playerSpeed());
	}
	void Update()
	{
		moveDir.x = Input.GetAxisRaw("Horizontal");

		if (Input.GetKey("a") && (transform.position.x > -2.7))
		{
			GetComponent<Rigidbody>().MovePosition(GetComponent<Rigidbody>().position + moveDir * speed * Time.fixedDeltaTime);
			StartCoroutine(stopXMovement());
		}
		if (Input.GetKey("d") && (transform.position.x < 3.5))
		{
			GetComponent<Rigidbody>().MovePosition(GetComponent<Rigidbody>().position + moveDir * speed * Time.fixedDeltaTime);
			StartCoroutine(stopXMovement());
		}
		if (Input.GetKey("space") && (GameFlow.timePickUp == 1))
		{
			GameFlow.timePickUp = 0;
			CamMove.camMovement = 10;
			playerMov = 10;
		}
		if (playerMov == 10)
		{
			StopCoroutine(playerSpeed());

			StartCoroutine(slow());
		}
		else
		{
			StopCoroutine(slow());
			StartCoroutine(playerSpeed());

		}

	}

	IEnumerator playerSpeed()
	{
		yield return new WaitForSeconds(3);
		anim.SetTrigger("Run");
		GetComponent<Rigidbody>().velocity = new Vector3(0, 0, playerMov);
		StartCoroutine(playerSpeed());

	}
	IEnumerator slow()
	{
		GetComponent<Rigidbody>().velocity = new Vector3(0, 0, playerMov);
		yield return new WaitForSeconds(1);
		playerMov = 20;
		StartCoroutine(slow());
	}



	private void OnTriggerEnter(Collider other)
    {
		if(other.tag == "obstacle" || (GameFlow.o2 ==0))
        {
			
			GameFlow.instance.RunnerHit();
			GameFlow.gameStopped = true;
			
			StopCoroutine(playerSpeed());
			StopCoroutine(slow());
			Application.LoadLevel("EndScene");
			
		}
    }
	
	IEnumerator stopXMovement()
    {
		GetComponent<Rigidbody>().velocity = new Vector3(0, 0, playerMov);
		yield return new WaitForSeconds(1);
		playerMov = 20;
	}
}
