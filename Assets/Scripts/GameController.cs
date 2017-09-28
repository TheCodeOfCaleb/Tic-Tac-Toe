using System.Collections;
using System;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour {

	public struct Board
	{
		int n;
		public ArrayList cells = new ArrayList();
		public GameObject boardGO;

		public Board(int x)
		{
			n = x;
			cells.Capacity = n*n;
		}
	}

	Board gameBoard;
	System.;
	int currentPlayer;

	public GameController(int boardSize)
	{
		gameBoard = new Board (boardSize);

	}

	// Use this for initialization
	void Start () {
		gameBoard.boardGO = Instantiate (Resources.Load("Prefabs/GameBoard") as GameObject);
		currentPlayer = 1;
	}

	// Update is called once per frame
	void Update () {


	}

	void PlayerMove(char playerToken)
	{
		
	}

	void CheckForGameOver(Board board, char PlayerToken)
	{
		for (int i = 0; i < board.cells.Capacity; i++) {
			
		}
	}
}
