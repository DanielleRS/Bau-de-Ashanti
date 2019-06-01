using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class DatabaseBehavior : MonoBehaviour
{
	[SerializeField]
	private InputField login = null;
	[SerializeField]
	private InputField senha = null;
	[SerializeField]
	private Text feedback = null;

	[SerializeField]
	private GameObject phpBehavior = null;

	public void checaMoedas(Text moedas) {
		phpBehavior.GetComponent<PHPBehavior> ().checaMoedas (moedas);
	}

	public void checaChave(int tipoMapa){
		phpBehavior.GetComponent<PHPBehavior> ().checaChave (tipoMapa);
	}

	public void checaTempos(Text tempo1, Text tempo2, Text tempo3) {
		phpBehavior.GetComponent<PHPBehavior> ().checaTempo (tempo1, tempo2, tempo3);
	}

	public void atualizaChaves (int i, string tempo, int moedas, float tempoTotal){
		phpBehavior.GetComponent<PHPBehavior> ().atualizaChave (i);


		phpBehavior.GetComponent<PHPBehavior> ().atualizaTempo (i,tempo);

		phpBehavior.GetComponent<PHPBehavior> ().atualizaMoedas (moedas);

		phpBehavior.GetComponent<PHPBehavior> ().atualizaTempoTotal (tempoTotal, i);
	}


	public void checaChaves(GameObject chave1, GameObject chave2, GameObject chave3, GameObject bau, GameObject canvasBehavior){
		phpBehavior.GetComponent<PHPBehavior>().checaChaves(chave1,chave2,chave3, bau,canvasBehavior);
	}


	public void logar(){
		//1 - ok!
		//2 - login encontrado, mas senha incorreta
		//3 - login não existe
		//4 - erro de conexão
		if (checkFields()){
			phpBehavior.GetComponent<PHPBehavior> ().logar (login.text, senha.text);
		
		}
	}

	public void cadastrar(){
		// 1 - ok!
		// 2 - nome de usuario já existe
		// 3 - erro de conexão
		if (checkFields()){
			phpBehavior.GetComponent<PHPBehavior> ().cadastrar (login.text, senha.text);
			}
		}

	public void ganhaChave(int i){
		
	}


	private bool checkFields(){
		if (login.text == "" || senha.text == ""){
			feedback.text = "Preencha todos os campos!";
			return false;
		} else {
			return true;
		}
	}
}

