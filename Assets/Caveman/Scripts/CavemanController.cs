using UnityEngine;
using System.Collections;

public class CavemanController : MonoBehaviour {

	private Animator animator;
	// Use this for initialization
	void Start () {
		animator = this.GetComponent<Animator>();
	}
	
	// Update is called once per frame
	void Update () {
		var vertical = Input.GetAxis("Vertical");
		var horizontal = Input.GetAxis("Horizontal");

		animator.SetBool("Attack", false);

		if (vertical > 0)
		{
			animator.SetInteger("Direction", 0);
		}
		else if (vertical < 0)
		{
			animator.SetInteger("Direction", 2);
		}
		else if (horizontal > 0)
		{
			animator.SetInteger("Direction", 1);
		}
		else if (horizontal < 0)
		{
			animator.SetInteger("Direction", 3);
		}

		if (Input.GetKeyDown (KeyCode.Space)){
			print ("space key was pressed");
			animator.SetBool("Attack", true);
		}
	}
}
