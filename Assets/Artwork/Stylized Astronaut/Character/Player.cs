using UnityEngine;
using System.Collections;

public class Player : MonoBehaviour {

	private float speed = 3f;
	private Vector3 moveDir;

		void Start () {
			
			GetComponent<Rigidbody>().velocity = new Vector3(0, 0, 20);
			StartCoroutine(stopXMovement());

		}

		void Update () {
		moveDir.x = Input.GetAxisRaw("Horizontal");
		if (Input.GetKey("a"))
        {
			GetComponent<Rigidbody>().MovePosition(GetComponent<Rigidbody>().position + moveDir * speed * Time.fixedDeltaTime);
			StartCoroutine(stopXMovement());
		}
        if (Input.GetKey("d"))
        {
			GetComponent<Rigidbody>().MovePosition(GetComponent<Rigidbody>().position + moveDir *speed * Time.fixedDeltaTime);
			StartCoroutine(stopXMovement());
		}

		}

	IEnumerator stopXMovement()
    {
		yield return new WaitForSeconds(1);
		GetComponent<Rigidbody>().velocity = new Vector3(0, 0, 20);
	}
}
