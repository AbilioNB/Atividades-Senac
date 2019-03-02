using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movPlatform : MonoBehaviour {

	// Use this for initialization
	public GameObject buffer;
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	void OnTriggerEnter(Collider other){
		if(other.gameObject.CompareTag("Player")){
				buffer.gameObject.GetComponent<Animation>().Play ();
				print("Ativei as plataforma");
		}
	}
}
