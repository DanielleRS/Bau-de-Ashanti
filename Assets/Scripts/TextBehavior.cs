using UnityEngine;
using System.Collections;
using UnityEngine.UI;


public class TextBehavior : MonoBehaviour
{
	private bool menuChoice = true;
	[SerializeField]
	private Text texto = null;
	[SerializeField]
	private GameObject sprite = null;
	[SerializeField]
	private Text texto2 = null;

	public void atualiza(string att){
		texto.text = att;
	}
	public void atualiza(string att,Sprite sprite, int fontsize){
		texto.text = att;
		this.sprite.GetComponent<Image> ().sprite = sprite;
		texto.fontSize = fontsize;
	}

	public void atualiza(string att, string att2, Sprite sprite, int fontsize){
		texto.text = att;
		texto2.text = att2;
		this.sprite.GetComponent<Image> ().sprite = sprite;
		texto.fontSize = fontsize;
	}

	public void atualiza(string att, int fontsize){
		texto.text = att;
		texto.fontSize = fontsize;
	}

	public void trocaTextoMenu(){
		if (menuChoice) {
			int fontSize = 11;
			atualiza ("Todo o material utilizado foi encontrado gratuitamente na internet pelo selo Creative Commons. \nPlanos de fundos criados por vectorpocket / Freepik.\nDesign da Dadá criado por \"iimages\" e cedido em Creative Commons atraves do site 123rf para uso sem fins lucrativos.\n\nProjeto de Monografia realizado por Viviane de Paula Silva\nOrientadora: Amanda Sávio Nascimento e Silva\nCo-orientadora: Kassandra da Silva Muniz\nIniciação cientifica feita em parceria com Danielle Rodrigues, Koda Gabriel e Arilton Junior", fontSize);
			menuChoice = !menuChoice;
		} else {
			int fontSize = 14;
			atualiza ("Ajude Dadá na missão de abrir o baú de Ashanti!\n\nJogue os jogos da memoria, leia atentamente as informações em cada mapa e resolva os desafios para conquistar as chaves! \nFaz parte do Projeto SAP, surgido na UFOP com o objetivo de propor e discutir questões étnico-raciais e de gênero, a fim de enfrentar as várias formas de preconceito e discriminação nas dependências da universidade.", fontSize);
			menuChoice = !menuChoice;
		}
	}


	public void trocaTextoCartas(int tipoMapa, int cardValue, Sprite sprite){
		string aux = "";
		string aux2 = "";
		int fontsize = 10;

		if (tipoMapa == 1){
			//AMERICA DO NORTE
			switch (cardValue) {
			case 0:
				aux = "SOJOURNER TRUTH\nNascimento: Sabe-se apenas que foi no ano de 1797\nLocal: Swartekill, Nova Iorque\nFilha do casal de escravos, James e Elisabeth Baumfree, Sojouner sofreu com o período escravagista nos EUA. Tornou-se a primeira mulher negra a mover um processo contra um homem branco e vencer. Adotou o nome Sojouner Truth (peregrina da verdade) a partir de 1843, tornando-se pregadora pentecostal, ativa abolicionista e defensora dos direitos das mulheres.";
				break;
			case 1:
				//aux2 = "Angela Davis\nNascimento: 26 de janeiro de 1944\nIdade:74 Anos";
				aux = "ANGELA DAVIS\nNascimento: 26 de janeiro de 1944\nLocal: Birmingham, Alabama, EUA\n Angela Yvone Davis é uma feminista negra, filósofa e professora do Departamento de Estudos Feministas da Universidade da Califórnia. Sua infância e juventude foi marcada pela perseguição de uma das organizações civis mais populares da época, que mantinha o hábito de perseguir, linchar e enforcar qualquer negro que cruzasse o caminho. A luta de Angela pelo direito das mulheres começou de fato quando ela sofreu a morte de quatro amigas em um atentado à uma igreja.";
				fontsize = 10;
				break;
			case 2:
				//aux2 = "Rosa Parks\nNascimento: 04 de fevereiro de 1913 \nMorte: 24 de outubro de 2005";
				aux = "ROSA PARKS\nNascimento: 04 de fevereiro de 1913\nLocal: Tuskegee, Alabama, EUA\nRosa Louise McCauley aprendeu na juventude a lutar pelos seus direitos e de todos da comunidade negra. Em 1943 tornou-se militante ativa do Movimento Dos Direitos Civis.Em 1996 foi-lhe atribuída a Medalha Presidencial da Liberdade, do então presidente, concedida a indivíduos que fizeram uma contribuição especial à segurança ou interesse dos EUA ou importantes iniciativas públicas.";
				fontsize = 10;
				break;
			case 3:
				//aux2 = "Harriet Tubman\nNascimento: Entre 1820 e 1825\nMorte: 10 de março de 1913";
				aux = "HARRIET TUBMAN\nNascimento: Acredita-se ter sido entre 1820 e 1825\nLocal: Condado de Dorchester, Maryland, EUA\nHarriet foi uma mulher negra afro-americana, abolicionista e humanitária, nascida sob a condição de escrava. Durante a Guerra Civil americana, trabalhou como espião para o governo dos Estados Unidos. Após o término da guerra, engajou-se na luta pelo direito do voto feminino, frequentando reuniões organizadas pelo movimento sufragista e discursando em várias cidades americanas sobre sua participação na Guerra Civil. Usando sua história como modelo, defendeu o direito de mulheres serem tratadas igualmente aos homens.";
				fontsize = 10;
				break;
			case 4:
				//aux2 = "Maya Angelou\nNascimento: 04 de abril de 1928\nFalecimento: 28 de maio de 2014";
				aux = "MAYA ANGELOU\nNascimento: 04 de abril de 1928\nLocal: Saint Louis, Missouri, EUA\nMaya foi uma escritora, poetisa, cantora, dançarina, atriz, dramaturga e diretora norte-americana. Como ativista dos direitos civis abordou em seus romances temas sobre pressões sociais sofridas pelas mulheres afro-americanas. Traumas da infância, como o estupro, também são refletidos em suas obras.";
				fontsize = 10;
				break;
			case 5:
				//aux2 = "Ella Baker\nNascimento: 13 de dezembro de 1903\nFalecimento: 13 de dezembro de 1986";
				aux = "ELLA BAKER\nNascimento:13 de dezembro de 1903\nLocal: Norfolk, Virgínia, EUA\nElla Josephine Baker foi ativista dos direitos civis e humanos dos afro-americanos. Inspirada pelas histórias de sua avó nos tempos da escravidão, Ella desenvolveu um senso de justiça desde pequena.";
				fontsize = 10;
				break;
			case 6:
				//aux2 = "Afeni Shakur\nNascimento: 22 de janeiro de 1947\nFalecimento: 02 de maio de 2016";
				aux = "AFENI SHAKUR\nNascimento: 22 de janeiro de 1947\n Local: Lumberton, Carolina do Norte, EUA\nAfeni Shakur foi uma empresária musical, filantropista e ativista política norte-americana. Em 1969, Afeni e vários membros do Black Panther Party foram presos, acusados de conspiração por explodir departamentos de lojas, metrôs e estações de polícia. O caso ficou conhecido como “Pantera 21”. Afeni foi absolvida em maio de 1971, juntamente com\noutros membros do grupo Panteras Negras, após defender-se no tribunal dos processos de conspiração contra o governo dos Estados Unidos, atuando como sua própria advogada.";
				fontsize = 10;
				break;
			case 7:
				//aux2 = "Beyoncè\nNascimento: 04 de setembro de 1981\nIdade: 36 anos";
				aux = "BEYONCÉ\nNascimento: 04 de setembro de 1981\nLocal: Houston, Texas, EUA\nBeyoncè Giselle Knowles-Carter é uma cantora, compositora, produtora, dançarina, atriz e empresária norte-americana. Aos sete anos de idade já fazia apresentações de música e dança em programas de talentos, em sua cidade natal.";
				break;
			case 8:
				//aux2 = "Viola Davis\nNascimento: 11 de agosto de 1965\nIdade: 52 anos";
				aux = "VIOLA DAVIS\nNascimento: 11 de agosto de 1965\nLocal: Saint Mathews, Carolina do Sul, EUA\nViola Davis Tennor é uma atriz e produtora norte-americana. De origem humilde, cresceu na fazenda da avó e é a quinta de seis irmãs. Foi na escola que descobriu sua paixão pelos palcos. Começou sua carreira atuando em peças de teatro e em papéis coadjuvantes no cinema.";
				fontsize = 10;
				break;
			case 9:
				//aux2 = "Kathleen Cleaver\nNascimento: 13 de maio de 1945\nIdade: 72 anos";
				aux = "KATHLEEN CLEAVER\nNascimento: 13 de maio de 1945\nLocal: Memphis, Texas, EUA\nKathleen Neal Cleaver é uma ativista norte-americana. Desde muito jovem já era ativa na luta pelos direitos civis. Entre 1967 e 1971 foi secretária de comunicações do Partido dos Panteras Negras, sendo a primeira mulher membro do seu Comitê Central.";
				fontsize = 10;

				break;
			}

		}
		if (tipoMapa == 2){
			//AMERICA LATINA
			switch (cardValue) {
			case 0:
				//aux2 = "Luísa Mahin\nNascimento: Início do século XIX\nFalecimento: Desconhecido";
				aux = "LUISA MAHIN\nNascimento: Aproximadamente em 1812\nLocal: Acredita-se ter sido em Costa Mina, África\nCapturada e trazida ao Brasil sob a condição de escrava, Luisa foi uma quituteira conhecida na Bahia, nos tempos do Brasil Colonial. Apesar do forte regime escravocrata da época, Luisa se manteve forte e fiel às suas raízes africanas, recusando o batismo e a doutrina cristã. É conhecida também por ser mãe do abolicionista e poeta Luíz Gama.";
				fontsize = 10;
				break;
			case 1:
				//aux2 = "Maria Beatriz Nascimento\nNascimento: 12 de julho de 1942\n";
				aux = "MARIA BEATRIZ NASCIMENTO\nNascimento: 12 de julho de 1942\nLocal: Aracaju, Sergipe, Brasil\nFoi uma ativista e pesquisadora brasileira de origem humilde, filha de uma dona de casa e de um pedreiro. Nascida no nordeste, migrou para o Rio de Janeiro na década de 1950, acompanhada de seus pais e seus dez irmãos. Dedicou sua vida à militância e aos estudos ligados à cultura negra. Maria Beatriz integrou o núcleo de mulheres históricas que lutaram contra o sexismo, machismo e violências domésticas.";
				fontsize = 10;
				break;
			case 2:
				//aux2 = "Carolina Maria de Jesus\nNascimento: 14 de março de 1914\nFalecimento: 13 de fevereiro de 1977";
				aux = "CAROLINA MARIA DE JESUS\nNascimento: 14 de março de 1914\nLocal: Sacramento, Minhas Gerais, Brasil\nDescendente de uma família muito humilde, Carolina teve pouco acesso a educação. Em 1947, mudou-se para SP e viveu na favela do Canindé. Para sustentar a si e à família, vivia de catar materiais recicláveis nas ruas da cidade. Do lixo que recolhia, ela extraiu a caderneta que daria início à sua carreira como escritora. O livro “O Quarto de Despejo”, no qual Carolina retrata sua rotina na favela do Canindé, é a obra mais famosa de Carolina.";
				fontsize = 10;
				break;
			case 3:
				aux = "ELZA SOARES\nNascimento: 23 de junho de 1937\nLocal: Rio de janeiro, Brasil\nElza da Conceição Soares, é uma cantora e compositora brasileira. Nascida numa das primeiras favelas do Rio de Janeiro, desde cedo enfrentou a batalha do que é ser uma mulher negra. Aos doze anos de idade foi obrigada pelo pai a se casar com Lourdes Antônio Soares.\n“A força não vem de ninguém. É a deusa que está em dentro de mim. Mas não me coloquem como santa. Me coloquem como a mulher, o ser humano, que tem o direito de pecar, de perdoar, de ser perdoada.”";
				break;
			case 4:
				aux = "SUELI CARNEIRO\nNascimento: 24 de junho de 1950\nLocal: São Paulo, Brasil\nSueli Carneiro é uma filósofa, escritora e ativista negra brasileira. Formada em filosofia pela USP e, Doutora em Educação pela mesma instituição, Sueli é uma das mais importantes figuras no cenário de luta por direitos feministas e negros. Fundou o Coletivo de Mulheres Negras de SP; foi convidada a integrar o Conselho Nacional dos Direitos da Mulher, em Brasília; ajudou a fundar a organização não governamental Geledes – Instituto da Mulher Negra, primeira organização negra e feminista de SP.";
				break;
			case 5:
				aux = "JANETH ARCAIN\nNascimento: 11 de abril de 1969\nLocal: Carapicuíba, São Paulo, Brasil\nJaneth dos Santos Arcain é uma jogadora brasileira de basquetebol. Iniciou a carreira no basquete em 1983, aos 14 anos de idade. Seu primeiro clube foi o Higienópolis, de São Paulo. Janeth é considerada a maior pontuadora da história da seleção brasileira de basquete. Em 2005, Janeth entrou para o Hall da Fama do Basquete Feminino, sendo a terceira brasileira a conseguir o feito.";
				fontsize = 10;
				break;
			case 6:
				aux = "MELÂNIA LUZ\nNascimento: 01 de junho de 1928\nLocal: Bom Retiro, São Paulo, Brasil\nMelânia Luz dos Santos é uma atleta velocista brasileira. Com talento para o atletismo, fez história na equipe do São Paulo. Aos 20 anos de idade, Melânia integrou a primeira equipe feminina do atletismo brasileiro, nos jogos Olímpicos de Helsinque.Apesar da equipe não ter saído com medalhas, foi nessa mesma edição dos Jogos Olímpicos que Melânia se consagrou como a primeira brasileira negra a participar de uma maratona olímpica.";
				break;
			case 7:
				aux = "TEREZA DE BENGUELA\nNascimento: Angola.\nAcredita-se ter vivido no Vale do Guaporé-MS, liderando o quilombo do Quariteré. O nome que carrega, Tereza de Benguela, aponta para a região em que vivia antes da escravidão. É considerada um símbolo de luta e resistência à escravidão. Por duas décadas seguintes, Tereza governou um núcleo de quase trezentas pessoas. Sob a coordenação da rainha Tereza, a população do quilombo, formada por negros e indígenas, mantinham uma agricultura desenvolvida de algodão e alimentos. Além disso, possuíam teares com os quais fabricavam tecidos.";
				break;
			case 8:
				aux = "MACAÉ MARIA EVARISTO DOS SANTOS\nNascida em São Gonçalo do Pará, Minas Gerais\nIniciou sua carreira como professora, em Belo Horizonte em 1984. Aos 50 anos, assumiu a Secretaria de Estado de Educação de Minas Gerais. Ela é a primeira mulher negra a assumir essa função. Criou a campanha AfroConsciência, que luta pelo reconhecimento e valorização da história e da cultura dos africanos na sociedade brasileira.";
				break;
			case 9:
				aux = "TAÍS ARAÚJO\nNascimento: 25 de novembro de 1978\nLocal: Rio de Janeiro, Brasil\nTaís Bianca Gama de Araújo Ramos é uma atriz, apresentadora e jornalista brasileira, formada pela Universidade Estácio de Sá. Além de receber o título de primeira atriz negra a protagonizar em uma novela brasileira, é defensora do direito das mulheres negras em parceria com a ONU Mulheres Brasil. Em 2017 foi eleita uma das cem personalidades afrodescendentes mais influentes do mundo com menos de 40 anos pelo MIPAD.";
				break;
			}

		}

		if (tipoMapa == 3) {
			switch (cardValue) {
			case 0:
				aux = "ELLEN JOHNSON SIRLEAF\nNascimento: 29 de outubro de 1938\nLocal: Monróvia, Libéria\nEllen Johnson Sirleaf é uma política liberiana. Venceu as eleições presidenciais de 8 de novembro de 2005, em que derrotou o ex futebolista George Weah. Em 2011 foi reeleita para um novo mandato.";
				break;
			case 1:
				aux = "RAINHA NZINGA MBANDE\nNascimento: Aproximadamente em 1582\nLocal: Ndongo, Atual Angola\nNzinga foi um arainha dos reinos de Ndongo e de Matamba, no Sudoeste da África. Começou a ser treinada para o combate e uso de armas ainda na infância. Nzinga se revelou ser uma rainha de pulso firme quando, em 1621, desafiou um governador português em um encontro de negócios.";
				fontsize = 10;
				break;
			case 2:
				aux = "RAINHA AMINA MOHAMUD\nNascimento: Aproximadamente em 1533\nLocal: Zaria, uma província da Nigéria\nAmina foi rainha de Zazzua, então Província da Nigéria, hoje conhecida como Zaria. Zazzua foi uma cidade-estado Hauçá, de origem mulçumana. Ao contrário de sua mãe, a rainha Bakwa Turunku, conhecida pelo governo próspero e pacífico, Amina dedicou-se desde criança a aprender habilidades militares com os guerreiros de sua tribo.";
				fontsize = 10;
				break;
			case 3:
				aux = "CLEÓPATRA TEA FILOPATOR\nNascimento: Aproximadamente 69 a.C.\nLocal: Alexandria, Egito\nCleópatra foi a última rainha do Egito da dinastia de Ptolomeu. Falava seis idiomas e\nreinou, ao lado do irmão, Ptolomeu XIII desde os seus 17 anos de idade. Levando o Egito ao máximo de sua prosperidade, Cleópatra é considerada uma das governantes mais conhecidas da história.";
				break;
			case 4:
				aux = "MIRIAM MAKEBA\nNascimento: 04 de março de 1932\nLocal: Joanesburgo, África do Sul\nNascida Zenzile Miriam Makeba, também conhecida como “Mama África”, foi uma cantora sul-africana. Ativista pelos direitos humanos, era contra o sistema do Apartheid em sua terra natal.";
				fontsize = 10;
				break;
			case 5:
				aux = "WANGERI MUTA MAATHAI\nNascimento: 01 de abril de 1940\nLocal: Nyeri, Quênia\nWangeri Muta Maathai foi uma professora e ativista ambiental queniana. Aos oito anos ingressou na escola, um internato da Missão Católica Mathari. Nessa instituição aprendeu inglês, o que lhe abriu as portas para prosseguir nos estudos.";
				break;
			case 6:
				aux = "NÁ AGONTIMÉ\nNascimento: Entre o final do século XVIII e início do século XIX, aproximadamente\nLocal: África\nNá Agontimé foi uma rainha do reino de Daomé. Ná Agontimé foi vendida como escrava pelo seu enteado, em um ímpeto de ambição e vingança após herdar o trono de seu pai. Foi trazida ao Brasil, sob a condição de escrava, e conseguiu manter sua ancestralidade ao conseguir sua alforria. Em torno de 1840, Ná Agontimé funda a Casa das Minas, templo localizado em São Luíz, no Maranhão, no qual ainda hoje se realizam cultos aos Voduns.";
				break;
			case 7:
				aux = "AQUALTUNE\nNascimento: Século XVII, aproximadamente\nLocal: África\nAqualtune foi uma princesa africana, filha do rei do Congo, que após perder uma batalha\npara o exército português foi trazida para o Brasil como escrava. Em 1665, liderou um exército de mais de dez mil homens em uma batalha entre o reino de Congo e Portugal, que buscava controlar o território de Mbwilla em busca de ouro e prata.";
				break;
			case 8:
				aux = "ODETE SEMEDO\nNascimento: 7 de novembro de 1959\nLocal: Bissau, Guiné-Bissau\nMaria Odete da Costa Soares Semedo é uma escritora, política e professora universitária da\nGuiné-Bissau. Iniciou suas atividades como docente aos dezoito anos de idade. Em 2003, recebeu o prêmio de personalidade que contribuiu para o desenvolvimento global da Guiné-Bissau, na categoria escritor.";
				break;
			case 9:
				aux = "NOEMIA DE SOUSA\nNascimento: 20 de setembro de1926\nLocal: Catembe, Moçambique\nCarolina Noemia Abranches de Souza Soares foi uma poetisa, tradutora, jornalista e militante política moçambicana. Escreveu poemas sobre a repressão, resistência da mulher africana e luta do povo moçambicano por sua liberdade.";
				break;
			}
		}

		atualiza (aux, aux2, sprite, fontsize);
	}
}

