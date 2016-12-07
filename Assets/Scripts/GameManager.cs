using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class GameManager : MonoBehaviour
{
	public Game game;

	public class Game
	{
		public int keyPart { get; set; }

		public int keys { get; set; }

		public int currentDoor { get; set; }

		public int riddleIndex { get; set; }

		public int monsterSpeed { get; set; }

		public int monsterDistance { get; set; }

		public Riddle[] riddleArray { get; set; }

		public Game ()
		{
			riddleArray = new Riddle[10];
			riddleIndex = 0;
		}

		public enum Enviroments
		{
			CriadoMudo}
		;

		public enum Doors
		{
			Porta0,
			Porta1,
			Porta2,
			Porta3,
			Porta4,
			Porta5}

		;

		public enum Objects
		{
			Porta,
			FundoEscuro,
		};

		public enum CutScenes
		{
			CTI0101,
			CTI0102,
			CTI0103,
			CTI0104}

		;

		public Riddle CarregarJogada (int door, int cutscene, int enviroment, int m_object)
		{
			// percorrer as charadas
			Riddle found = new Riddle ();
			foreach (Riddle riddle in riddleArray) {
				if (riddle != null) {
					if (riddle.door == door && riddle.cutscene == cutscene && riddle.enviroment == enviroment && riddle.m_object == m_object) {
						found = riddle;
					}
				}
			}

			return found;

		}

		public bool Jogar (Riddle riddle, int answer)
		{			
			bool acertou = false;
			bool achou = false;
			int i = -1;
			foreach (Riddle rid in riddleArray) {
				i++;
				if (rid != null) {
					if (rid.used)
						continue;
					if (rid == riddle) {
						riddleArray [i].used = true;
						achou = true;
						if (riddle.answer == answer) {
							// Acertou
							monsterSpeed--; // 1 - 5
							acertou = true;
							keyPart++;
						} else {
							monsterSpeed++;
						}
					}
				}
			}

			if (!achou) {
				throw new UnityException ("Riddle not found or not available");
			}
			return acertou;	

			// processar a jogada.
		}
	}

	public class Riddle
	{
		public string name { get; set; }

		public string[] options { get; set; }

		public int answer { get; set; }

		public int door { get; set; }

		public int cutscene { get; set; }

		public int enviroment { get; set; }

		public  int m_object { get; set; }

		public bool used { get; set; }
	}

		
	void Awake ()
	{
		DontDestroyOnLoad (transform.gameObject);
	}

	// Use this for initialization
	void Start ()
	{
		LoadGame ();
		Riddle charada = game.CarregarJogada ((int)Game.Doors.Porta0, (int)Game.CutScenes.CTI0101, (int)Game.Enviroments.CriadoMudo, (int)Game.Objects.Porta);
		game.Jogar (charada, 0);
	}
	
	// Update is called once per frame
	void Update ()
	{	
	}

	public void LoadGame ()
	{
		// Create a new game
		game = new Game ();

		AddRiddle (MontaRiddle ("Charada 01-01", (int)Game.Doors.Porta0, "Cima", "Baixo", "Esquerda", "Direita", 4, (int)Game.CutScenes.CTI0101, (int)Game.Enviroments.CriadoMudo, (int)Game.Objects.Porta));
		AddRiddle (MontaRiddle ("Charada 01-02", (int)Game.Doors.Porta0, "Cima", "Baixo", "Esquerda", "Direita", 0, (int)Game.CutScenes.CTI0101, (int)Game.Enviroments.CriadoMudo, (int)Game.Objects.FundoEscuro));
		AddRiddle (MontaRiddle ("Charada 01-03", (int)Game.Doors.Porta0, "Cima", "Baixo", "Esquerda", "Direita", 2, (int)Game.CutScenes.CTI0101, (int)Game.Enviroments.CriadoMudo, (int)Game.Objects.FundoEscuro));
		//string teste = riddle.name;

	}




	public bool AddRiddle (Riddle riddle)
	{
		try {		
			game.riddleArray [game.riddleIndex] = riddle;
			game.riddleIndex++;
			return true;
		} catch {
			return false;
		}
		//game.riddleArray [game.riddleIndex].name = riddle.name;

	}

	public Riddle MontaRiddle (string name, int door, string option1, string option2, string option3, string option4, int answer, int cutscene, int enviroment, int m_object)
	{
		Riddle riddle = new Riddle ();
		game.riddleArray [game.riddleIndex] = riddle;
		game.riddleArray [game.riddleIndex].name = name;
		//riddle.name = name;
		game.riddleArray [game.riddleIndex].door = door;
		game.riddleArray [game.riddleIndex].answer = answer;

		string[] options = new string[4];
		options [0] = option1;
		options [1] = option2;
		options [2] = option3;
		options [3] = option4;

		game.riddleArray [game.riddleIndex].options = options;

		game.riddleArray [game.riddleIndex].cutscene = cutscene;
		game.riddleArray [game.riddleIndex].enviroment = enviroment;
		game.riddleArray [game.riddleIndex].m_object = m_object;

		return riddle;
	}

}