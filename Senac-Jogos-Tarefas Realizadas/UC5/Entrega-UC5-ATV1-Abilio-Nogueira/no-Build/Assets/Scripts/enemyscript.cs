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
	/*Utiliza o sistema de colisão para caso entre em contato com o vilão , ele seja destruido*/
	void OnTriggerEnter2D(Collider2D col){
		if(col.gameObject.tag =="bala"){
			Destroy(this.gameObject);
		}
	}
}
