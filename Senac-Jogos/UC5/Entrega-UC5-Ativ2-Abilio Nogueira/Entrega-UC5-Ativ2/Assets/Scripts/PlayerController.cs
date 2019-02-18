using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class PlayerController : MonoBehaviour {

    //Implantação do codigo de tiro 
    public GameObject balas;
    public GameObject cano;
	//Função de segundo tiro
	public GameObject balas2;
	public int kbalas;
	//Texto da seleção de Arma
	public Text ArmText;

    // Use this for initialization
    private Animator anim;
	private Rigidbody2D rb2d;

	public Transform posPe;
	[HideInInspector] public bool tocaChao = false;


	public float Velocidade;
	public float ForcaPulo = 1000f;
	[HideInInspector] public bool viradoDireita = true;

	public Image vida;
	private MensagemControle MC;

	void Start () {
		anim = GetComponent<Animator> ();
		rb2d = GetComponent<Rigidbody2D> ();
		//Iniciando o kbalas
		kbalas=1;

		GameObject mensagemControleObject = GameObject.FindWithTag ("MensagemControle");
		if (mensagemControleObject != null) {
			MC = mensagemControleObject.GetComponent<MensagemControle> ();
		}
	}
	
	// Update is called once per frame
	void Update () {
		trocarArma();
		atirar();
		ArmText.text=kbalas.ToString();
    }

	void FixedUpdate()
	{
		float translationY = 0;
		float translationX = Input.GetAxis ("Horizontal") * Velocidade;
		transform.Translate (translationX, translationY, 0);
		transform.Rotate (0, 0, 0);
		if (translationX != 0 && tocaChao) {
			anim.SetTrigger ("corre");
		} else {
			anim.SetTrigger("parado");
		}
			
		if (translationX > 0 && !viradoDireita) {
			Flip ();
		} else if (translationX < 0 && viradoDireita) {
			Flip();
		}

    }
	void Flip()
	{
		viradoDireita = !viradoDireita;
		Vector3 escala = transform.localScale;
		escala.x *= -1;
		transform.localScale = escala;
	}

	public void SubtraiVida()
	{
		vida.fillAmount-=0.1f;
		if (vida.fillAmount <= 0) {
			MC.GameOver();
			Destroy(gameObject);
		}
	}
	/*Função para trocar as armas */
	void trocarArma(){
		if(Input.GetKeyDown(KeyCode.Q)){
			if(kbalas==1){
				kbalas=2;
			}else{
				kbalas=1;
			}
		}
	}

   /*Função que realiza o disparo*/
	void atirar() {

        if (Input.GetKeyDown(KeyCode.F)) {
            anim.SetTrigger("shooter");
			if (kbalas == 1) {
				GameObject balaInst = Instantiate (balas, cano.transform.position, Quaternion.identity) as GameObject;
						balaInst.GetComponent<moviBalas>().Vel *= transform.localScale.x;
			} else {
						GameObject balaInst = Instantiate(balas2, cano.transform.position, Quaternion.identity) as GameObject;
						balaInst.GetComponent<moviBalas>().Vel *= transform.localScale.x;
					}
           


        }

    }
}
	

