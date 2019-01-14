using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ativEspinhos : MonoBehaviour {

	// Use this for initialization
	public GameObject EspinhosGo;
	public GameObject my;
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	void OnTriggerEnter(Collider other){
		if(other.gameObject.CompareTag("Player")){
			EspinhosGo.gameObject.GetComponent<Rigidbody>().useGravity=true;
			print("Caiu os espinhos");
			Destroy(my);
		}
	}
}
