using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class InputTouch : MonoBehaviour
{

    public float MoveSpeed;
	public float RotationSpeed;
	CharacterController cc;
	private Animator anim;
	protected Vector3 gravidade = Vector3.zero;
	protected Vector3 move = Vector3.zero;
	private bool jump = false;
    void Start()
    {
        anim - GetComponente<Animator>();
        anim.SetTrigger("Parado");
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void stayPersonagem(){
        anim.SetTrigger("Parado");
    }
    

}
