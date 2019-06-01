using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using System;
using System.Globalization;

public class PHPBehavior : MonoBehaviour
{


	[SerializeField]
	private Text feedback = null;
	[SerializeField] 
	private GameObject sceneLoader = null;
	[SerializeField]
	private GameObject songStoper = null;
	private WWW www = null;
	private string url = "projetosap.ufop.br/jogos/jogo_da_memoria/bauDeAshanti/";


	public static string login = "jhgjhg";

	public void atualizaTempoTotal(float tempoT,int i) {
		//www = new WWW (url + "atualizaTempoTotal.php?tempo=" + tempoTotal + "&login=" + login);
		www = new WWW (url + "recuperaTempoInt.php?fase=" + i + "&login=" + login);
		int tempoTotal = (int)tempoT;
		StartCoroutine (recuperaTempoInt (www, tempoTotal, i));
	}

	IEnumerator recuperaTempoInt (WWW www, int tempoTotal, int i){
		yield return www;
		if (www.error == null) {
			int tempo = 0;
			tempo = Convert.ToInt32 (www.text);
			if (tempo == 0 | tempoTotal < tempo) {
				www = new WWW (url + "atualizaTempoInt.php?tempo=" + tempoTotal + "&login=" + login + "&fase=" + i);
				StartCoroutine (atualizaTempoInt (www));
			}
		}
	}

	IEnumerator atualizaTempoInt (WWW www) {
		yield return www;
		www = new WWW (url + "atualizaTempoTotal.php?login=" + login);
		StartCoroutine (atualizaTempoTotalInt (www));
	}

	IEnumerator atualizaTempoTotalInt (WWW www) {
		yield return www;
	}

	public void atualizaMoedas(int moedas) {
		www = new WWW (url + "recuperaMoedas.php?login=" + login);
		StartCoroutine (recuperaMoedas (www, moedas));
	}

	public void checaChave(int tipoMapa){
		if (tipoMapa == 1) {
			www = new WWW (url + "verificaNivel1.php?login=" + login); 
		} 
		if (tipoMapa == 2) {
			www = new WWW (url + "verificaNivel2.php?login=" + login);

		} 
		if (tipoMapa == 3) {
			www = new WWW (url + "verificaNivel3.php?login=" + login);
		}

		StartCoroutine (checaChaves (www));
	}


	public void atualizaChave(int i){
		www = new WWW (url + "atualizaChaves.php?login=" + login + "&tipoChave=" + i);
		StartCoroutine (atualizaChaves (www));
	}


	public void logar(string login, string password){

		PlayerPrefs.SetString ("login", login);
		PlayerPrefs.SetString ("password", password);
		www = new WWW (url + "logar.php?login=" + login + "&senha=" + password);
		//feedback.text = "entrou funcao login " + www.text;
		StartCoroutine (validaLogin (www,login));

	}


	public void atualizaTempo(int i, string tempo){ 

		www = new WWW (url + "recuperaTempoE.php?login=" + PHPBehavior.login + "&tipoChave=" + i);
		StartCoroutine (isTempoMenor (www, tempo,i));

	}
		

	public void cadastrar(string login, string password){
		www = new WWW (url + "cadastrar.php?login=" + login + "&senha=" + password);
		StartCoroutine (validaCadastro (www,login));
	}

	public void checaTempo(Text tempo1, Text tempo2, Text tempo3){
		www = new WWW (url + "recuperaTempo1.php?login=" + login);
		StartCoroutine (recuperaTempoM (www, tempo1));
		www = new WWW (url + "recuperaTempo2.php?login=" + login);
		StartCoroutine (recuperaTempoM (www, tempo2));
		www = new WWW (url + "recuperaTempo3.php?login=" + login);
		StartCoroutine (recuperaTempoM (www, tempo3));
	}



	public void checaChaves(GameObject chave1, GameObject chave2, GameObject chave3, GameObject bau, GameObject canvasBehavior){
		www = new WWW (url + "verificaNivel1.php?login=" + login);
		StartCoroutine(checaChaveM (www,chave1));
		www = new WWW (url + "verificaNivel2.php?login=" + login);
		StartCoroutine(checaChaveM (www,chave2));
		www = new WWW (url + "verificaNivel3.php?login=" + login);
		StartCoroutine(checaChaveM (www,chave3));
		www = new WWW (url + "verificaIsOpen.php?login=" + login);
		StartCoroutine(checaBau (www,chave1, chave2, chave3, bau, canvasBehavior));
		
	}

	public void checaMoedas(Text moedas) {
		www = new WWW (url + "recuperaMoedas.php?login=" + login);
		StartCoroutine (checaMoedasM (www, moedas));
	}





	// COROUTINES ABAIXO

	IEnumerator checaMoedasM(WWW www, Text moedas){
		yield return www;
		if (www.error == null) {
			moedas.text = www.text;
		}
	}

	IEnumerator recuperaTempoM(WWW www, Text tempo){
		yield return www;
		if (www.error == null){
			tempo.text = www.text;
			}

	}



	IEnumerator atualizaTempos(WWW www){
		yield return www;
	}

	IEnumerator atualizaChaves(WWW www){
		yield return www;

	}

	IEnumerator checaChaveM (WWW www, GameObject chave){
		yield return www;
		if (www.error == null){
			if (www.text == "1"){
				chave.SetActive (true);
			} else {
				if (www.text == "0"){
					chave.SetActive (false);
				} else {
				//	feedback.text = "Erro de conexão!";
				}
			}
		}
	}
		

	IEnumerator checaBau(WWW www, GameObject chave1, GameObject chave2, GameObject chave3, GameObject bau, GameObject canvasBehavior){
		yield return www;
		if (www.error == null){
			if (www.text == "1"){
				chave1.SetActive (true);
				chave2.SetActive (true);
				chave3.SetActive (true);
				canvasBehavior.GetComponent<CanvasBehavior> ().Ativar ();
				bau.SetActive (true);
				www = new WWW (url + "setaIsOpen.php?login=" + login);
				StartCoroutine (attBau (www));
			} else {
				if (www.text == "0"){
					chave1.SetActive (true);
					chave2.SetActive (true);
					chave3.SetActive (true);
					bau.SetActive (true);
				} 	
			}
		}
	}

	IEnumerator attBau(WWW www){
		yield return www;
	}


	IEnumerator validaLogin(WWW www, string log){
		yield return www;

		//yield return new WaitForSeconds (2);

			
			//feedback.text = www.text;
		string s = www.text;

		print (s);

		if ( s == "1") {
				//LOGA

				PHPBehavior.login = log;
				songStoper.GetComponent<SongStoper> ().paraMusica ("songMenu");
				sceneLoader.GetComponent<ButtonsBehavior> ().irPara ("Mapa");

			} else {
			if (s == "2") {
				feedback.text = "Senha incorreta!";
			//	feedback.text = www.text;
				} else {
					feedback.text = "Erro de conexão!";
					//feedback.text = www.text;
				}
			}

	}

	IEnumerator validaCadastro(WWW www, string log){
		yield return www;
		if (www.error == null){
			string s = www.text;
			if (s == "1")
            {
				//CADASTRA
				PHPBehavior.login = log;
				sceneLoader.GetComponent<ButtonsBehavior> ().irPara ("Intro1");
			} else {
				if (s == "2")
                {
					feedback.text = "Usuario já cadastrado!";
				} else {
					feedback.text = "Erro de conexão!";
				}
			}
		}
	}


	IEnumerator checaChaves(WWW www){
		yield return www;
		if (www.error == null){
			if (www.text == "1"){
				Card.isPassed = true;
			} else {
				if (www.text == "0"){
					Card.isPassed = false;
				} else {
					//	feedback.text = "Erro de conexão!";
				}
			}
		}
	} 

	IEnumerator recuperaMoedas(WWW www, int moedas){
		yield return www;
		int m = 0;
		if (www.error == null) {
			m = Convert.ToInt32(www.text);
		}
		moedas += m;
		www = new WWW (url + "atualizaMoedas.php?moedas=" + moedas + "&login=" + login);
		StartCoroutine (atualizaMoedasBD (www));

	}

	IEnumerator atualizaMoedasBD(WWW www) {
		yield return www;
	}	

	IEnumerator isTempoMenor(WWW www, string tempo, int i){
		yield return www;
		string t = "";
		if (www.error == null) {
			t = www.text;
		}

		DateTime t1 = DateTime.ParseExact (t, "HH\\h:mm\\m:ss\\s", CultureInfo.InvariantCulture);
		DateTime t2 = DateTime.ParseExact(tempo,"HH\\h:mm\\m:ss\\s", CultureInfo.InvariantCulture);



		if (t2<t1 | t == "00h:00m:00s"){
			www = new WWW (url + "atualizaTempos.php?login=" + PHPBehavior.login + "&tipoChave=" + i + "&tempo=" + tempo);
			StartCoroutine (atualizaTempos (www));
		}
	}
}

