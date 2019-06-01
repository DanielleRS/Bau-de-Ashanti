using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class Card : MonoBehaviour {
	
	private int state;
	private int cardValue;
	private bool initialized = false;

	[SerializeField]
	private GameObject soundFlip = null;
	[SerializeField]
	private GameObject manager = null;
	[SerializeField]
	private GameObject textUpdater = null;
	[SerializeField]
	private int tipoMapa = -1;
	[SerializeField]
	private GameObject canvasUpdater = null;

	public static bool isPassed = false;
	public bool virada = false;
	private Sprite cardBack = null;
	private Sprite cardFace = null;
	void Start(){
		state = 0;

	}

	public void SetupGraphics(){
		cardBack = manager.GetComponent<GameManager> ().getCardBack ();
		cardFace = manager.GetComponent<GameManager> ().getCardFace (cardValue);


	}

	public void flipCard(){
			
			if (state == 0)
				state = 1;
			else if (state == 1)
				state = 0;
		
		if (state == 0) {
			virada = false;
			GetComponent<Image> ().sprite = cardBack;
		} else if (state == 1){
				virada = true;
				GetComponent<Image> ().sprite = cardFace;
		}
		
			manager.GetComponent<GameManager> ().checkCards ();





	}

	public void showFace(bool i){
		if (i)
			GetComponent<Image> ().sprite = cardFace;
		else 
			GetComponent<Image> ().sprite = cardBack;
	}
	public int metodCardValue{
		get{ return cardValue; }
		set{ cardValue = value; }
	}

	public int MetodState{
		get{ return state; }
		set{ state = value; }
	}

	public bool MetodInitialized{
		get{ return initialized; }
		set{ initialized = value; }
	}

	public void falseCheck(){
		StartCoroutine (pause ());
	}
	public bool par = false;
	IEnumerator pause(){
		yield return new WaitForSeconds ((1 - 1 / 3));
		if (state == 0) {
			soundFlip.GetComponent<SoundPlayer> ().play ();
			GetComponent<Image> ().sprite = cardBack;
		} else {
			GetComponent<Image> ().sprite = cardFace;
			par = true;
			if (!Card.isPassed)
				preencheCanvas ();
		}
		
	}

	public void viraTexto() {
		if (par) {
			preencheCanvas ();
		}
	}

	void preencheCanvas(){
		textUpdater.GetComponent<TextBehavior> ().trocaTextoCartas (tipoMapa, cardValue, cardFace);
		canvasUpdater.GetComponent<CanvasBehavior> ().Ativar ();
	}
}


		

