using UnityEngine;
using System.Collections;

public class click_to_move : MonoBehaviour {
float distance;
Vector3 clickdestination;	
float speed = 5f;	

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
		
	void Update () {
		//generate raycast beforehand, since this one is kind of complicated
		Ray ray	= Camera.main.ScreenPointToRay ( Input.mousePosition );
		 //reserving space in memory for this
		
		if (Input.GetMouseButtonDown(0)) {
			RaycastHit rayHit = new RaycastHit();
			
			if ( Physics.Raycast( ray, out rayHit, 100000f) ) {
				Vector3 clickdestination = rayHit.point;
				distance = ( clickdestination - transform.position ).magnitude;
					if (distance > 5f)
					{
					rigidbody.velocity = Vector3.zero;
					rigidbody.AddForce (Vector3.Normalize(clickdestination) * speed, ForceMode.VelocityChange) ;
				}
			}
		}
	}
}