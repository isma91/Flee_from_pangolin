using UnityEngine;
using System.Collections;

public class solSpawn : MonoBehaviour {
	public GameObject sol;
	public GameObject joueur;
	public GameObject piques;
	public GameObject cube;
	public GameObject obstacle;
	public GameObject platform1;
	public GameObject platform2;
	public GameObject platform3;
	public GameObject petitPoint;
	public GameObject grandPoint;
	public GameObject bonus;
	public float random;
	// Use this for initialization
	void Start () {
	}

	// Update is called once per frame
	void Update () {
		if (joueur.transform.position.x > 1) {
			random = Random.Range(0, 100);
			if (joueur.transform.position.x % 4 < 2 || joueur.transform.position.x % 4 > 2) {
				Instantiate(sol, new Vector3 (joueur.transform.position.x, 0, 0), Quaternion.identity);
				Instantiate(sol, new Vector3 (joueur.transform.position.x, 6, 0), Quaternion.identity);
			}
			//4 et 4.1 8 et 8.1 etc....
			if(joueur.transform.position.x % 4 < 0.1) {
				//10% de chance
				if(random < 10){
					Instantiate (petitPoint, new Vector3((joueur.transform.position.x) + 5, Random.value * Random.Range(1, 5), 0) ,Quaternion.identity);
					Instantiate(cube, new Vector3((joueur.transform.position.x) + 5, Random.value * Random.Range(1, 5), 0), Quaternion.identity);
					Instantiate (obstacle, new Vector3((joueur.transform.position.x) + 2, 0.5f, 0), Quaternion.identity);
				}
				if(random > 10 && random < 20){
					Instantiate (petitPoint, new Vector3((joueur.transform.position.x) + 10, Random.value * Random.Range(1, 5), 0) ,Quaternion.identity);
					Instantiate (grandPoint, new Vector3((joueur.transform.position.x) + 5, Random.value * Random.Range(1, 5), 0) ,Quaternion.identity);
				    Instantiate(cube, new Vector3((joueur.transform.position.x) + 10, Random.value * Random.Range(1, 5), 0), Quaternion.identity);
					Instantiate (piques, new Vector3((joueur.transform.position.x) + 7, 0, 0), Quaternion.identity);
					Instantiate (obstacle, new Vector3((joueur.transform.position.x) + 2, 0.5f, 0), Quaternion.identity);
					Instantiate (bonus, new Vector3((joueur.transform.position.x) + Random.value * Random.Range(1, 5), Random.value * Random.Range(1, 5), 0), Quaternion.identity);
				}
				if(random > 20 && random < 30){
					Instantiate (petitPoint, new Vector3((joueur.transform.position.x) + 15, Random.value * Random.Range(1, 5), 0) ,Quaternion.identity);
					Instantiate(cube, new Vector3((joueur.transform.position.x) + 15, Random.value * Random.Range(1, 5), 0), Quaternion.identity);
					Instantiate (piques, new Vector3((joueur.transform.position.x) + 13, 0, 0), Quaternion.identity);
					Instantiate (obstacle, new Vector3((joueur.transform.position.x) + 2, 0.5f, 0), Quaternion.identity);
				}
			}
		}
	}
}
