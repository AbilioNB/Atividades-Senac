﻿using UnityEngine;
using System.Collections;
using UnityEngine.UI;

[RequireComponent(typeof(CharacterController))]
public class PlayerController : MonoBehaviour {

	public float MoveSpeed;
	public float RotationSpeed;
	CharacterController cc;
	private Animator anim;
	protected Vector3 gravidade = Vector3.zero;
	protected Vector3 move = Vector3.zero;
	private bool jump = false;

	public int contKeys;
	public Image skey1;
	public Image skey2;

	public int contGema;

	public Text showScoreHud;
	
	void Start()
	{
		cc = GetComponent<CharacterController> ();
		anim = GetComponent<Animator>();
		anim.SetTrigger("Parado");
		contKeys=0;
	}

	void Update()
	{
		Vector3 move = Input.GetAxis ("Vertical") * transform.TransformDirection (Vector3.forward) * MoveSpeed;
		transform.Rotate (new Vector3 (0, Input.GetAxis ("Horizontal") * RotationSpeed * Time.deltaTime, 0));
		
		if (!cc.isGrounded) {
			gravidade += Physics.gravity * Time.deltaTime;
		} 
		else 
		{
			gravidade = Vector3.zero;
			if(jump)
			{
				gravidade.y = 6f;
				jump = false;
			}
		}
		move += gravidade;
		cc.Move (move* Time.deltaTime);
		Anima ();
		showKeys();
		showScoreGems();
		
	}
	 
	void Anima()
	{
		if (!Input.anyKey)
		{
			anim.SetTrigger("Parado");
		} 
		else 
		{
			if(Input.GetKeyDown("space"))
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
	void OnTriggerEnter(Collider other){
		if(other.gameObject.CompareTag("key")){
				contKeys++;
				print(contKeys);
				Destroy(other.gameObject);
		}else if(other.gameObject.CompareTag("gema")){
				contGema++;
				print(contGema);
				Destroy(other.gameObject);
		}
	}
	void showKeys(){
		if(contKeys==1){
			skey1.fillAmount=1;
		}
		if(contKeys==2){
			skey2.fillAmount=1;
		}
	}
	
	void showScoreGems(){
			showScoreHud.text=contGema.ToString();
	} 

}
