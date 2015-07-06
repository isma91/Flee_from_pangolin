using UnityEngine;
using System.Collections;

public class FollowPlayerCamera : MonoBehaviour {
	public GameObject joueur;
	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
		transform.position = new Vector3 (joueur.transform.position.x, 3, joueur.transform.position.z - 1);
	}
	
}