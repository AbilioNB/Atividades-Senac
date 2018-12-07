using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moviBalas : MonoBehaviour {

    GameObject bullet;
    private float vel = 15f;
    public float Vel {

        get { return vel; }
        set { vel = value; }
    }
    void mover()
    {
        Vector3 aux = transform.position;
        aux.x += vel * Time.deltaTime;
        transform.position = aux;
        Object.Destroy(gameObject, 2.0f);
    }

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        /* transform.Translate(new Vector2(vel * Time.deltaTime, 0));
          */
        mover();
    }
}
