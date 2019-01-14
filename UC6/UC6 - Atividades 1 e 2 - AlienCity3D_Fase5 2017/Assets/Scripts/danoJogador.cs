using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class danoJogador : MonoBehaviour {

	// Use this for initialization
	public float life;
	public Image lifeBar;
	public Image heart1;
	public Image heart2;
	private int ctLife;
	public GameObject jogador;
	void Start () {
		life=100;
		ctLife=2;
	}
	
	// Update is called once per frame
	void Update () {
		deadPlayer();

	}
	//Para espinhos
	void OnTriggerEnter(Collider other){
		if(other.gameObject.CompareTag("espinho")){
				life-=20;
				lifeBar.fillAmount=life/100;
				Debug.Log(life);
		}else if (other.gameObject.CompareTag("parede"))
		{ 
				life-=25;
				lifeBar.fillAmount=life/100;
				Debug.Log(life);
		}else if (other.gameObject.CompareTag("chaoLava"))
		{
				life-=30;
				lifeBar.fillAmount=life/100;
				Debug.Log(life);
		}
	}
	void deadPlayer(){
		if(life==0&&ctLife==2){
			Destroy(heart2);
			life=100;
			ctLife-=1;
		}else if(life==0&&ctLife==1){
			Destroy(heart1);
			life=100;
			ctLife-=1;
		}else if(life==0&&ctLife==0){
			Destroy(jogador);
		}
	}
}
