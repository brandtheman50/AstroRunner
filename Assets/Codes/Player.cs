using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour {

	private float speed = 6f;
	private Vector3 moveDir;
	private string midJump = "n";

		void Start () {
			
			GetComponent<Rigidbody>().velocity = new Vector3(0, 0, 20);
			
			

		}

		void Update () {
		moveDir.x = Input.GetAxisRaw("Horizontal");
		
		if (Input.GetKey("a") && (transform.position.x > -2.7))
        {
			GetComponent<Rigidbody>().MovePosition(GetComponent<Rigidbody>().position + moveDir * speed * Time.fixedDeltaTime);
			StartCoroutine(stopXMovement());
		}
        if (Input.GetKey("d") && (transform.position.x < 3.5))
        {
			GetComponent<Rigidbody>().MovePosition(GetComponent<Rigidbody>().position + moveDir *speed * Time.fixedDeltaTime);
			StartCoroutine(stopXMovement());
		}
		

	}
	
	private void OnTriggerEnter(Collider other)
    {
		if(other.tag == "obstacle")
        {
			Destroy(gameObject);
			GameFlow.gameStopped = true;
			SceneManager.LoadScene(4);
			
		}
    }
	
	IEnumerator stopXMovement()
    {
		yield return new WaitForSeconds(1);
		GetComponent<Rigidbody>().velocity = new Vector3(0, 0, 20);
	}
}
