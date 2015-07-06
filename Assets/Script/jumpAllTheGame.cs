using UnityEngine;
using System.Collections;

public class jumpAllTheGame : MonoBehaviour {
	public GameObject joueur;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnMouseDown () {
		if(joueur.transform.position.y < 10){
			joueur.GetComponent<Rigidbody2D>().AddForce(new Vector2(0, 5), ForceMode2D.Impulse);
		} else {
			joueur.GetComponent<Rigidbody2D>().AddForce(new Vector2(0, 0), ForceMode2D.Impulse);
		}
	}
}
