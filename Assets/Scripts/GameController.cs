using System.Collections;
using System;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour {

	public struct Board
	{
		public int n;
		public ArrayList cells;
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

	char CheckForGameOver(Board board, char PlayerToken, int currentCell)
	{
		for (int i = 0; i < board.cells.Capacity; i++) {
			
		}

		//check for horizontal win
		for(int i = (currentCell - (currentCell % board.n)); i <= (currentCell - (currentCell % board.n) + board.n); i++
		{
			if (board.cells[i].CellController.currentCharacter.Equals(PlayerToken))
			{
				continue;
			} 
			else
			{
				break;
			}
			return PlayerToken;
		}

		//check for vertical win
		for(int i = currentCell % board.n; i <= (currentCell + (board.n(board.n - 1))); i += board.n)
		{
			if (board.cells[i].CellController.currentCharacter.Equals(PlayerToken))
			{
				continue;
			} 
			else
			{
				break;
			}
			return PlayerToken;
		}

		//check for diagonal win
	}
}