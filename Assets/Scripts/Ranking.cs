using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Ranking : MonoBehaviour {

	[SerializeField]
	private Text[] posicoes = null;
	[SerializeField]
	private Text[] nomes = null;
	[SerializeField]
	private Text[] tempos = null;
	[SerializeField]
	private GameObject canvas = null;

	[SerializeField]
	private Button botao = null;


	private bool atualizado = false;
	// Use this for initialization
	void Start () {
		canvas.SetActive (false);
		banco.GetComponent<BancoDeDadosRanking> ().atualizaNumero ();
		botao.interactable = false;
	}
	
	// Update is called once per frame
	void Update () {
		if (numeroTOTAL != -1 && !definiuposicoes) {
			definePosicoes ();

		}
		if (numero != -1 && atualizado == false && definiuposicoes) {
			atualiza ();
			atualizado = true;
		}
	}
	public static int numeroTOTAL = -1;
	public bool definiuposicoes = false;
	private int pagina = 0;
	public static int numero = -1;
	[SerializeField]
	private GameObject banco = null;

	private void atualizaNumero () {
		//chamar função do banco de dados para atualizar o numero
	}  
	public static bool[] posicoesAUX = null;
	public void definePosicoes() {
		posicoesAUX = new bool[numeroTOTAL];
		for (int i = 1; i <= numeroTOTAL ; i++) {
			banco.GetComponent<BancoDeDadosRanking> ().recuperaBool(i,posicoesAUX[i-1]);
		}
		definiuposicoes = true;


	}

	public static string[] nomesAUX= null;
	public static string[] temposAUX = null;

	public void atualiza() {

		StartCoroutine (espera ());




	}


	IEnumerator espera() {
		yield return new WaitForSeconds (3); 


		nomesAUX = new string[numero];
		temposAUX = new string[numero];
		for (int i = 0, j = 1; j < numeroTOTAL; j++) {
			if (posicoesAUX [j] == true) {
//				print (i);
//				int posicao = j;
//				posicoes [i].text = i.ToString ();
				banco.GetComponent<BancoDeDadosRanking> ().recuperaNome (j, i);
				banco.GetComponent<BancoDeDadosRanking> ().recuperaTempo (j, i);
				i++;
			}
		}
		botao.interactable = true;
	}


	public void preenche (int valor) {



		if (pagina == 0 && valor == -1) {
			return;
		} else {
			pagina += valor;
		}
			
		bool alterou = false;
		for (int i = pagina*10, j=0; i < pagina*10+10 && j  < numero; i++, j++) {
//			print (numero);
			int posicao = (pagina * 10 + j + 1);
//			print (posicao);

			if (posicao <= numero) { 
				posicoes [j].text = posicao.ToString ();
				nomes [j].text = nomesAUX [posicao - 1];
				tempos [j].text = temposAUX [posicao - 1];
				alterou = true;
			}

		}

		if (!alterou) {
			pagina -= valor;
		}
	}
}
