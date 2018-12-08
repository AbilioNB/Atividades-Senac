using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyscript : MonoBehaviour {

	public GameObject x;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		colision ();
	}

	void colision(GameObject x){
	
		if (x.gameObject.CompareTag ("alien1")) {
			Destroy (x.gameObject);
		}
	}
	/*void OnConllisonEnter2D(Collision2D other){
	
		if (other.gameObject.CompareTag("alien1")) {
			Destroy (other.gameObject);
		}
	
	}*/
}
