using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class autorun : MonoBehaviour {
	public GameObject pango;
	public float sautHauteur;
	public Text score;
	public Text life;
	public int vie = 1;
	public float scorePoint;
	public float scorePointScorePoint;
	public static int point;
	public int pointPoint;
	public int compteurSaut = 0;
	public float positionX;
	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
		//float positionY = transform.position.y;
		transform.Translate (Time.deltaTime * 2, 0, 0);
		scorePoint = scorePoint + (Time.deltaTime * 2 );
		point = (int)scorePoint;
		scorePointScorePoint = scorePointScorePoint + (Time.deltaTime * 2 );
		pointPoint = (int)scorePointScorePoint;
		positionX = positionX + (Time.deltaTime * 2);
		score.text = "Score : " + point.ToString ();
		if (pointPoint == 20) {
			vie = vie + 1;
			pointPoint = 0;
			scorePointScorePoint = 0;
			scorePointScorePoint = scorePointScorePoint + (Time.deltaTime * 2 );
			pointPoint = (int)scorePointScorePoint;
		}
		life.text = "Vie : " + vie.ToString ();
		if (pango.transform.position.x < 3.3 && pango.transform.position.x > 3.4) {
			vie = 0;
		}
		if (Input.GetKeyDown ("space")) {
			if(compteurSaut <= 2){
				if(transform.position.y > 0){
					compteurSaut = compteurSaut + 1;
					GetComponent<Rigidbody2D>().AddForce(new Vector2(0, 5), ForceMode2D.Impulse);
				} else {
					GetComponent<Rigidbody2D>().AddForce(new Vector2(0, 0), ForceMode2D.Impulse);
				}
			}
		}
		if(transform.position.y < 2){
			compteurSaut = 0;
		}
	}

	void OnGUI(){
		if (vie <= 0) {
			Time.timeScale = 0f;
			if(GUI.Button(new Rect(Screen.width / 2, Screen.height / 2 - 100, 300, 100), "GAME OVER CLICK TO TRY AGAIN")){
				Application.LoadLevel(Application.loadedLevel);
			}
		}
	}

	void OnMouseDown () {
		if(transform.position.y < 10){
			GetComponent<Rigidbody2D>().AddForce(new Vector2(0, 5), ForceMode2D.Impulse);
		} else {
			GetComponent<Rigidbody2D>().AddForce(new Vector2(0, 0), ForceMode2D.Impulse);
		}
	}

	void OnTriggerEnter2D(Collider2D other){
		if(other.tag == "petitPoint"){
			scorePoint = scorePoint + 10;
			Destroy(other.gameObject);
		}
		if(other.tag == "grandPoint"){
			scorePoint = scorePoint + 100;
			Destroy(other.gameObject);
		}
		if(other.tag == "petitObstacles"){
			pango.transform.position = new Vector3(pango.transform.position.x + 0.1f, pango.transform.position.y, pango.transform.position.z);
		}
		if(other.tag == "pique"){
			vie = vie - 1;
		}
		if(other.tag == "grandBonus" && pango.transform.position.x > -5){
			pango.transform.position = new Vector3(pango.transform.position.x - 0.5f, pango.transform.position.y, pango.transform.position.z);
			Destroy(other.gameObject);
		}
	}
}