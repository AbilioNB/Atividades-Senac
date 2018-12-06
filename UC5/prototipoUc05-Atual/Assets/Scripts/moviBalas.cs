using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moviBalas : MonoBehaviour {


    float vel = 2.5f;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        transform.Translate(new Vector2(vel * Time.deltaTime, 0));
        Object.Destroy(gameObject, 2.0f);
    }
}
