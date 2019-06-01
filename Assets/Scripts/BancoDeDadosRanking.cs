using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using System;
using System.Globalization;

public class BancoDeDadosRanking : MonoBehaviour
{

	private WWW www = null;
	private string url = "projetosap.ufop.br/jogos/jogo_da_memoria/bauDeAshanti/";

	public void atualizaNumero() {
		www = new WWW (url + "rankingNumero.php");
		StartCoroutine (attNum (www));
	}

	IEnumerator attNum (WWW www){
		yield return www;
		if (www.error == null) {
			Ranking.numero = Convert.ToInt32(www.text);
		}
		www = new WWW (url + "rankingTotal.php");
		StartCoroutine (attNum2 (www));
	}


	IEnumerator attNum2 (WWW www){
		yield return www;
		if (www.error == null) {
			Ranking.numeroTOTAL = Convert.ToInt32 (www.text);
		}
	}
	public void recuperaNome(int i, int j) {
		www = new WWW (url + "rankingNome.php?posicao=" + i);
		StartCoroutine (recNome(www, j));
	}

	IEnumerator recNome (WWW www, int j) {
		yield return www;
		if (www.error == null) {
			Ranking.nomesAUX[j] = www.text;
		}
	}

	public void recuperaTempo(int i, int j) {
		www = new WWW (url + "rankingTempo.php?posicao=" + i);
		StartCoroutine (recTempo(www, j));
	}

	IEnumerator recTempo (WWW www, int j) {
		yield return www;
		if (www.error == null) {
			int cont = Int32.Parse (www.text);
			int sec = 0;
			int min = 0;
			int hor = 0;

			min = cont / 60;
			sec = cont % 60;

			hor = min / 60;
			min = min % 60;

			string t = ""; 
			if (hor < 10){
				t = "0" + hor + "h:";
			} else {
				t = hor + "h:";
			}

			if (min < 10){
				t+= "0" + min + "m:";
			} else {
				t+= min + "m:";
			}

			if ((int) sec < 10) {
				t+= "0" + (int)sec + "s";
			} else {
				t+= (int)sec + "s";
			}




			Ranking.temposAUX[j] = t;
		}
	}

	public void recuperaBool(int p, bool b) {
		www = new WWW (url + "rankingBool.php?posicao=" + p);
		StartCoroutine (recBool(www, p));
	}

	IEnumerator recBool(WWW www, int b) {
		yield return www;
		if (www.error == null) {
			if (www.text == "1") {
				Ranking.posicoesAUX[b-1] = true;
			} else {
				Ranking.posicoesAUX[b-1] = false;
			}

		}
	}
	// Use this for initialization
	void Start ()
	{
	
	}
	
	// Update is called once per frame
	void Update ()
	{
	
	}
}

