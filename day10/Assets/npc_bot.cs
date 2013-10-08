using UnityEngine;
using System.Collections;

public class npc_bot : MonoBehaviour {
Vector3 direction = Vector3.forward;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		
		transform.position += direction;	
		
		Ray ray	= new Ray (transform.position, direction);
		RaycastHit rayHit = new RaycastHit();	
		
		if ( Physics.Raycast( ray, out rayHit, 10f) ) {
			var randomNumber = 10 * ( Random.value );
			
		if (randomNumber < 5) {
				transform.Rotate (Vector3.up * 90);		
				direction = Vector3.right;
			}		
		else{
				transform.Rotate (Vector3.down * 90);
				direction = Vector3.left;
			}
			
		}
	}	
}
