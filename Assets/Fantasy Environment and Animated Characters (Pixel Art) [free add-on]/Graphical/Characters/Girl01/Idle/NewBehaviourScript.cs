using UnityEngine;
using System.Collections;

public class NewBehaviourScript : MonoBehaviour {

	public float speed;

	void FixedUpdate(){
		var mousePosition = Camera.main.ScreenToWorldPoint (Input.mousePosition);

	}

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
