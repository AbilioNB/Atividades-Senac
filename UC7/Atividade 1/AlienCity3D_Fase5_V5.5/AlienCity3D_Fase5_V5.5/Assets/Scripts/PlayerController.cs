using UnityEngine;
using System.Collections;

[RequireComponent(typeof(CharacterController))]
public class PlayerController : MonoBehaviour {

	public float MoveSpeed;
	public float RotationSpeed;
	CharacterController cc;
	private Animator anim;
	protected Vector3 gravidade = Vector3.zero;
	protected Vector3 move = Vector3.zero;
	private bool jump = false;

	private int controlMove;

	private int life;
	
	void Start()
	{
		cc = GetComponent<CharacterController> ();
		anim = GetComponent<Animator>();
		anim.SetTrigger("Parado");
		controlMove=0;
		life=100;
	}

/*Legendas do Move:
0 : Parado
1: Frente
2:Tras
3:Esquerda
4:Direita
7:Pula */
	void Update()
	{
		Vector3 move;
		switch(controlMove){
			case 1:
				 move = new Vector3 (0,0,MoveSpeed);
				break;
				case 2:
					move = new Vector3 (0,0,(MoveSpeed*-1));
				break;
				case 3:
					move= new Vector3 ((MoveSpeed*-1),0,0);
				break;
				case 4:
					move= new Vector3 (MoveSpeed,0,0);
				break;
				default:
					move= new Vector3 (0,0,0);
					break;
		}
		
		
		//Vector3 move = Input.GetAxis ("Vertical") * transform.TransformDirection (Vector3.forward) * MoveSpeed;
		//transform.Rotate (new Vector3 (0, Input.GetAxis ("Horizontal") * RotationSpeed * Time.deltaTime, 0));
		
		if (controlMove!=7) {
			gravidade += Physics.gravity * Time.deltaTime;
		} 
		else 
		{
			gravidade = Vector3.zero;
			if(jump)
			{
				gravidade.y = 3f;
				jump = false;
			}
		}
		move += gravidade;
		cc.Move (move* Time.deltaTime);
		Anima ();
	}

	public void goFrente(){
		controlMove=1;
	}
	public void goTras(){
		controlMove=2;
	}
	public void goEsquerda(){
		controlMove=3;
	}
	public void goDireita(){
		controlMove=4;
	}
	public void goPulo(){
		controlMove=7;
	}
	public void stop(){
		controlMove=0;
	}

	public void tomarDano(){

		life=life-10;
		Handheld.Vibrate();
		Debug.Log(life);

	}
	void Anima()
	{
		if (controlMove==0)
		{
			anim.SetTrigger("Parado");
		} 
		else 
		{
			if(controlMove==7)
			{
				anim.SetTrigger("Pula");
				jump = true;
			}
			else
			{
				anim.SetTrigger("Corre");
			}
		}
	}
}
