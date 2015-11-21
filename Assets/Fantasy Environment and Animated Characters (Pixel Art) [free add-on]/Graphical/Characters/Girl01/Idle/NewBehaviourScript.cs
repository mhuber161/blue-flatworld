using UnityEngine;
using System.Collections;

public class NewBehaviourScript : MonoBehaviour {

	public float Speed;

	void FixedUpdate(){
		var mousePosition = Camera.main.ScreenToWorldPoint (Input.mousePosition);
	    Quaternion rot = Quaternion.LookRotation(transform.position - mousePosition, Vector3.forward);

	    transform.rotation = rot;
	}

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        var mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        Quaternion rot = Quaternion.LookRotation(transform.position - mousePosition, Vector3.forward);

        transform.rotation = rot;
	}
}
