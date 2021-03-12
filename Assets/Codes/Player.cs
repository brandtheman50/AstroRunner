using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour {

	private float speed = 7f;
	private Vector3 moveDir;
	private string midJump = "n";
	public float playerMov;
	
	public GameObject player;

	void Start () 
	{
		StartCoroutine("Player_Move");
	}
	

	IEnumerator Player_Move()
    {
		yield return new WaitForSeconds(5);
		player.GetComponent<Rigidbody>().velocity = player.transform.forward * playerMov;
	}
	private void OnTriggerEnter(Collider other)
    {
		if(other.tag == "obstacle")
        {
			
			GameFlow.instance.RunnerHit();
			GameFlow.gameStopped = true;
			
			
			Application.LoadLevel("EndScene");
			
		}
		if(other.tag == "coin")
        {
			FindObjectOfType<AudioManager>().Play("Coin");
		}
    }
	
	
}
