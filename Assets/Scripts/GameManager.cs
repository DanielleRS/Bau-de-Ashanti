using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour {

	[SerializeField]
	private Sprite[] cardFace  = null;
	[SerializeField]
	private Sprite cardBack  = null;
	[SerializeField]
	private GameObject[] cards  = null;
	[SerializeField]
	private GameObject textUpdaterMoedas  = null;
	[SerializeField]
	private GameObject invisibleCanvasHandler  = null;
	[SerializeField]
	private GameObject soundFlipPlayder  = null;
	[SerializeField]
	private int tipoMapa = 0;
	[SerializeField]
	private GameObject gerenciadorbd = null;
	[SerializeField]
	private GameObject canvasVitoriaHandler  = null;
	[SerializeField]
	private GameObject canvasTextoMatchHandler = null;
	[SerializeField]
	private GameObject soundVictoryPlayer  = null;
	[SerializeField]
	private GameObject soundStoper = null;
	[SerializeField]
	private Text timerText = null;
	[SerializeField]
	private GameObject acertou = null;
	private bool init = false;
	private int matches = 10;
	private int moedas = 0;
	[SerializeField]
	private GameObject engrenagem = null;
	private float tempoTotal = 0;
	public GameObject canvasDicas = null;
	public GameObject[] canvasDesafio = null;
	private int canvasDesafioSorteado = 0;

	public void desafio(int i) {
		if (canvasDesafioSorteado == 0) {
			if (i == 2) {
				gerenciadorbd.GetComponent<DatabaseBehavior> ().atualizaChaves (tipoMapa, timerText.text, moedas, tempoTotal);
				soundVictoryPlayer.GetComponent<SoundPlayer> ().play ();
				canvasVitoriaHandler.GetComponent<CanvasBehavior> ().Ativar ();
				soundStoper.GetComponent<SongStoper> ().paraMusica ("songJogo");
				canvasDesafio [canvasDesafioSorteado].SetActive (false);
			} else {
				SceneManager.LoadScene ("Mapa");
			}
		}
		if (canvasDesafioSorteado == 1) {
			if (i == 1) {
				gerenciadorbd.GetComponent<DatabaseBehavior> ().atualizaChaves (tipoMapa, timerText.text, moedas, tempoTotal);
				soundVictoryPlayer.GetComponent<SoundPlayer> ().play ();
				canvasVitoriaHandler.GetComponent<CanvasBehavior> ().Ativar ();
				soundStoper.GetComponent<SongStoper> ().paraMusica ("songJogo");
				canvasDesafio [canvasDesafioSorteado].SetActive (false);
			} else {
				SceneManager.LoadScene ("Mapa");
			}
		}
		if (canvasDesafioSorteado == 2) {
			if (i == 0) {
				gerenciadorbd.GetComponent<DatabaseBehavior> ().atualizaChaves (tipoMapa, timerText.text, moedas, tempoTotal);
				soundVictoryPlayer.GetComponent<SoundPlayer> ().play ();
				canvasVitoriaHandler.GetComponent<CanvasBehavior> ().Ativar ();
				soundStoper.GetComponent<SongStoper> ().paraMusica ("songJogo");
				canvasDesafio [canvasDesafioSorteado].SetActive (false);
			} else {
				SceneManager.LoadScene ("Mapa");
			}
		}
	}

	public void comprarDica() {
		if (moedas >= 50) {
			moedas -= 50;
			textUpdaterMoedas.GetComponent<TextBehavior> ().atualiza (moedas.ToString ());
			int n = Random.Range (0, 9);
			while (cards [n].GetComponent<Card> ().virada) {
				n = Random.Range (0, 9);
			}
			int i = 0;	
			for (; i < cards.Length; i++) {
				if (i != n && cards [i].GetComponent<Card> ().metodCardValue == cards [n].GetComponent<Card> ().metodCardValue) {
					break;
				}
			}	
			cards [n].GetComponent<Card> ().flipCard ();
			cards [i].GetComponent<Card> ().flipCard ();
			canvasDicas.SetActive (false);
		}
	}

	public void comprarDicaBarata() {
		if (moedas >= 20) {
			moedas -= 20;
			textUpdaterMoedas.GetComponent<TextBehavior> ().atualiza (moedas.ToString ());
			canvasDicas.SetActive (false);
			StartCoroutine (showcards ());

		}
	}

	void Start(){
		gerenciadorbd.GetComponent<DatabaseBehavior> ().checaChave (tipoMapa);
		//canvasDicas.SetActive (false);
		textoDicas.SetActive(false);
		for(int i = 0; i < canvasDesafio.Length; i++)
			canvasDesafio[i].SetActive (false);
	}

	private bool checaCard = false;

	void Update(){
		if (!init)
			initializeCards ();
		UpdateTimerUI();
		if (!checaCard) {
			if (!Card.isPassed) {
				engrenagem.SetActive (false);
			} else {
				engrenagem.SetActive (true);
				checaCard = true;
			}
		}
	}

	private bool marcado = false;

	public void configuracao () {
		if (!marcado) {
			marcado = true;
			Card.isPassed = false;
		} else {
			marcado = false;
			Card.isPassed = true;
		}
	}


	private float secondsCount;
	private int minuteCount;
	private int hourCount;

	//call this on update
	public void UpdateTimerUI(){
		//set timer UI

		secondsCount += Time.deltaTime;
		tempoTotal+= Time.deltaTime;
		if (timerText != null) {

			if (timerText != null) {
				string t = "";
				if (hourCount < 10){
					t = "0" + hourCount + "h:";
				} else {
					t = hourCount + "h:";
				}

				if (minuteCount < 10){
					t+= "0" + minuteCount + "m:";
				} else {
					t+= minuteCount + "m:";
				}

				if ((int) secondsCount < 10) {
					t+= "0" + (int)secondsCount + "s";
				} else {
					t+= (int)secondsCount + "s";
				}
				timerText.text = t;

			}

		}

		if(secondsCount >= 60){
			minuteCount++;
			secondsCount = 0;
		}else if(minuteCount >= 60){
			hourCount++;
			minuteCount = 0;
		}    
	}




	public void continuar(){
		canvasTextoMatchHandler.GetComponent<CanvasBehavior> ().Desativar();

		if (matches == 0) {
			sortearDesafio ();
		}
	}

	public void sortearDesafio(){
		int rand = (int)Random.Range (0, canvasDesafio.Length);
		canvasDesafio [rand].SetActive (true);
		canvasDesafioSorteado = rand;
	}



	void initializeCards(){
		for(int id=0; id<2; id++){
			for (int i = 0; i < 10; i++) {
				bool test = false;
				int choice = 0;
				while (!test) {
					choice = Random.Range (0, cards.Length);
					test=!(cards[choice].GetComponent<Card>().MetodInitialized);
				}
				cards [choice].GetComponent<Card> ().metodCardValue = i;
				cards [choice].GetComponent<Card> ().MetodInitialized = true;
			}
		}
		foreach (GameObject c in cards)
			c.GetComponent<Card> ().SetupGraphics ();

		StartCoroutine (showcards ());


		if (!init)
			init = true;
	}

	IEnumerator showcards(){
		invisibleCanvasHandler.GetComponent<CanvasBehavior> ().Ativar ();
		for (int i = 0; i < cards.Length; i++){
			cards [i].GetComponent<Card> ().showFace (true);
		}
		yield return new WaitForSeconds(3);
		for (int i = 0; i < cards.Length; i++){
			if (!cards [i].GetComponent<Card> ().par) {
//				print (i);
//				print (cards [i].GetComponent<Card> ().virada);
				cards [i].GetComponent<Card> ().showFace (false);
			}
		}
		soundFlipPlayder.GetComponent<SoundPlayer> ().play ();
		invisibleCanvasHandler.GetComponent<CanvasBehavior> ().Desativar ();


	}


	public Sprite getCardBack(){
		return cardBack;
	}

	public Sprite getCardFace(int i){
		return cardFace [i];
	}

	public void checkCards(){
		List<int> c = new List<int> ();
		for (int i = 0; i < cards.Length; i++) {
			if (cards [i].GetComponent<Card> ().MetodState == 1) {
				c.Add (i);
			}
		}
		if (c.Count == 2)
			cardComparison (c);
	}

	private int contador = 0;

	public void zeraContador() {
		contador = 0;
	}

	[SerializeField]
	private GameObject textoDicas = null;
	[SerializeField]
	private Button dicaCara = null;
	void cardComparison(List<int> c){
		
		int x = 0;
		if (cards [c [0]].GetComponent<Card> ().metodCardValue == cards [c [1]].GetComponent<Card> ().metodCardValue) {
			x = 2;
			contador = 0;
			acertou.GetComponent<SoundPlayer> ().play ();
			matches--;
			moedas += 10;

			if (matches == 0 && Card.isPassed) {

				gerenciadorbd.GetComponent<DatabaseBehavior> ().atualizaChaves (tipoMapa, timerText.text, moedas, tempoTotal);
				soundVictoryPlayer.GetComponent<SoundPlayer> ().play ();
				canvasVitoriaHandler.GetComponent<CanvasBehavior> ().Ativar ();
				soundStoper.GetComponent<SongStoper> ().paraMusica ("songJogo");
			}

		} else {
			if (moedas != 0) {
				moedas -= 1;
			} 
			contador++;

			if (contador == 3) {
				contador = 0;
				//textoDicas.GetComponent<Text> ().fontStyle = FontStyle.Bold;
				//canvasDicas.SetActive (true);
			} else {
//				textoDicas.GetComponent<Text> ().fontStyle = FontStyle.Italic;
			}
		}

		if (moedas >= 20) {
			textoDicas.SetActive (true);
			if (moedas >= 50) {
				dicaCara.interactable = true;
			} else {
				dicaCara.interactable = false;
			}

		} else {
			textoDicas.SetActive (false);
		}

	
		string m = "" + moedas;
		textUpdaterMoedas.GetComponent<TextBehavior> ().atualiza (m);

		for (int i = 0; i < c.Count; i++) {
			cards [c [i]].GetComponent<Card> ().MetodState = x;
			cards [c [i]].GetComponent<Card> ().falseCheck ();
		}


	}
}
