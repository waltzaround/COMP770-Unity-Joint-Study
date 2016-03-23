//lets give you some physics at the touch of a mouseclick
//Mmmm delicious physics

using UnityEngine;
using System.Collections;

public class ClickPhysics : MonoBehaviour {


	public float maxForce;
	// Use this for initialization
	void Start () {
	//nothing necessary here
	}
	
	// Update is called once per frame
	void Update () {
	//so i heard u like physics
		if (Input.GetMouseButton (0)) {
			// is the left mouse button being pressed? if so carry on
			Ray ray = Camera.main.ScreenPointToRay (Input.mousePosition);
			// define ray as whatever the mouse is moved on
			RaycastHit hit;
			// define hit as whatever the raycast hits
			if (Physics.Raycast (ray, out hit) && (hit.rigidbody != null)) {
				// did we hit something? if so execute everything in this if statement
				hit.rigidbody.AddForceAtPosition (ray.direction * maxForce, hit.point);
				// give whatever the raycast hits a good amount of fore. BANG!
			}
		}

	


	}
}
