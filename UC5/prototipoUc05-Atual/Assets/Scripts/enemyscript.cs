using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyscript : MonoBehaviour {


	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}


	void OnConllison(Collision2D other){
	
		if (other.gameObject.CompareTag("alien1")) {
		
			Destroy (other.gameObject);
		}
	
	}
}
