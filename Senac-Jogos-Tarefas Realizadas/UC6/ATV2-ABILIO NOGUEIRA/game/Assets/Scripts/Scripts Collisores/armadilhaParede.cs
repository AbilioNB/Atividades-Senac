using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class armadilhaParede : MonoBehaviour {

	// Use this for initialization
	public GameObject pE;
	public GameObject pD;
	public GameObject my;
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	void OnTriggerEnter(Collider other){
		if(other.gameObject.CompareTag("Player")){
				pE.gameObject.GetComponent<Animation>().Play ();
				pD.gameObject.GetComponent<Animation>().Play ();
				print("Ativei as paredes");
				Destroy(my);
		}
	}
}
