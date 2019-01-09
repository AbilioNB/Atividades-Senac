using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class abrePortas : MonoBehaviour {

	// Use this for initialization
	public GameObject door;
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnTriggerEnter(Collider other){
		if(other.gameObject.CompareTag("Player")){
				door.gameObject.GetComponent<Animation>().Play ();
				print("Abrir portas");
		}
	}
}
