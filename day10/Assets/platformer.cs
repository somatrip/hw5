using UnityEngine;
using System.Collections;

public class platformer : MonoBehaviour{
float jumpbool = 1f;
	
	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
		
		//basic movement
		if ( Input.GetKey ( KeyCode.LeftArrow ) ) {
			transform.position = transform.position + new Vector3 ( -8f, 0f , 0f) * Time.deltaTime;
		}
		if ( Input.GetKey ( KeyCode.RightArrow ) ) {
			transform.position = transform.position + new Vector3 ( 8f, 0f , 0f) * Time.deltaTime;
		}
		
		//if you haven't already, TEST, with just basic movement coded in!
		//jump, but only if player is on the ground
		
		Ray ray	= new Ray (transform.position, Vector3.down);
		RaycastHit rayHit = new RaycastHit();	
		
		if ( Input.GetKeyDown ( KeyCode.Space ) ) {
			//detect if player is grounded by raycasting downwards just past his feet
			//note: raycast from CENTER, so it won't hit inside of capsule
			
			if ( Physics.Raycast( ray, out rayHit, 2f) ) {
				rigidbody.AddForce (new Vector3 ( 0f, 10f,0f ), ForceMode.VelocityChange) ;
				jumpbool = 1f;
			}
					
			if ( jumpbool == 1f )	{
				rigidbody.AddForce (new Vector3 ( 0f, 10f,0f ), ForceMode.VelocityChange) ;
				jumpbool = 0f;
					
			}
		}
	}
}
