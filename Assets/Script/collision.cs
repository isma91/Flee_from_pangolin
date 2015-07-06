using UnityEngine;
using System.Collections;

public class collision : MonoBehaviour {
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}


	void OnTriggerEnter2D(Collider2D other){
		Debug.Log ("COLLISION !!!");
		if (other.tag == "Player") {
			if (this.transform.position.x < transform.position.x){
				Debug.Log ("left");
			}
			else {
				Debug.Log("right");
			}
		}
	}	
}