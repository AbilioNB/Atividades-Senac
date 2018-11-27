using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControler : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {


        float H = 5 * Input.GetAxis("Horizontal");
        float V = 5 * Input.GetAxis("Vertical");

        transform.Translate(new Vector3(H * Time.deltaTime, V * Time.deltaTime, 0));

    }
}
