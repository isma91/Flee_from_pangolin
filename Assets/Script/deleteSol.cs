using UnityEngine;
using System.Collections;

public class deleteSol : MonoBehaviour {
	public GameObject camera;
	void OnTriggerEnter2D (Collider2D allObject) {
		if (camera.transform.position.x >= 1) {
			if (camera.transform.position.x % 4 < 2 || camera.transform.position.x % 4 > 2) {
				if (allObject.transform.parent) {
					Destroy (allObject.gameObject.transform.parent.gameObject);
				} else {
					Destroy (allObject.gameObject);
				}
			}
		}
	}
}
