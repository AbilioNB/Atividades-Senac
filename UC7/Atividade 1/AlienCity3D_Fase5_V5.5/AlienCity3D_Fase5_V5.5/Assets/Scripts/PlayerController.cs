using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;


[RequireComponent(typeof(CharacterController))]
public class PlayerController : MonoBehaviour {

	public GameObject persona;
	public float MoveSpeed;
	public float RotationSpeed;
	CharacterController cc;
	private Animator anim;
	protected Vector3 gravidade = Vector3.zero;
	protected Vector3 move = Vector3.zero;
	private bool jump = false;

	private int controlMove;

	private int life;

	private bool nochao;
	
	void Start()
	{
		cc = GetComponent<CharacterController> ();
		anim = GetComponent<Animator>();
		anim.SetTrigger("Parado");
		controlMove=7;
		life=100;
		nochao=true;
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
		//(x,y,z)
		Vector3 move;
		switch(controlMove){
			case 1:
				move = 1 * transform.TransformDirection (Vector3.forward) * MoveSpeed;
					transform.Rotate (new Vector3 (0,0* RotationSpeed * Time.deltaTime, 0));
				break;
				case 2:
					move = -1 * transform.TransformDirection (Vector3.forward) * MoveSpeed;
					transform.Rotate (new Vector3 (0,0* RotationSpeed * Time.deltaTime, 0));
				break;
				break;
				case 3:
					move = 0 * transform.TransformDirection (Vector3.forward) * MoveSpeed;
						transform.Rotate (new Vector3 (0,-1* RotationSpeed * Time.deltaTime, 0));
				break;
				case 4:
					move = 0 * transform.TransformDirection (Vector3.forward) * MoveSpeed;
						transform.Rotate (new Vector3 (0,1* RotationSpeed * Time.deltaTime, 0));
				break;
				default:
					move= new Vector3 (0,0,0);
					break;
		}
		
		
		if (controlMove!=7) {
			gravidade += Physics.gravity * Time.deltaTime;
		} 
		else 
		{
			
		if(nochao)
			{
				gravidade = Vector3.zero;
				if(jump)
				{
					gravidade.y = 5f;
					jump = false;
				}
				nochao=false;
			}

		}
		move += gravidade;
		cc.Move (move* Time.deltaTime);
		Anima ();
		toNoSolo();
		if(controlMove==7){
			controlMove=0;
		}
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
		if(nochao){
			controlMove=7;
		}else{
			controlMove=0;
		}
	}
	public void stop(){
		controlMove=0;
	}
	public void tomarDano(){

		life=life-10;
		Handheld.Vibrate();
		Debug.Log(life);
		if(life==0){
				 Handheld.Vibrate();
				Handheld.Vibrate();		
				SceneManager.LoadScene("EndGame");
		}
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
	void toNoSolo(){
		if(cc.isGrounded){
			nochao=true;
		}
	}
	

}
