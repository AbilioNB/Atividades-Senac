using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class abrePortas : MonoBehaviour {

	// Use this for initialization
	public GameObject door;
	private int keysPlayer;
	public GameObject my;
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnTriggerEnter(Collider other){
		keysPlayer=other.GetComponent<PlayerController>().contKeys;
		if(other.gameObject.CompareTag("Player")&&keysPlayer==2){
				door.gameObject.GetComponent<Animation>().Play ();
				print("Abrir portas");
				Destroy(my);
		}
	}
}
