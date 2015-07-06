using UnityEngine;
using System.Collections;

public class pause : MonoBehaviour {
	private bool freeze = false;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetKeyDown("p") || Input.GetKeyDown("escape")){
			freeze = !freeze;
		}
		if (freeze == true) {
			Time.timeScale = 0f;
		} else {
			Time.timeScale = 1f;
		}
	}

	void OnGUI(){
		if(freeze == true){
			if(GUI.Button(new Rect(Screen.width / 2, Screen.height / 2 - 100, 300, 100), "Continuer")){
				freeze = false;
			}
			if(GUI.Button(new Rect(Screen.width / 2, (Screen.height / 2), 300, 100), "Quitter")){
				freeze = true;
				Application.Quit();
			}
		}
	}
}
