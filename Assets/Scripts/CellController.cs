using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CellController : MonoBehaviour {

	SpriteRenderer spriteRenderer;
	public char currentCharacter;
	public ArrayList characters;


	// Use this for initialization
	void Start () {
		spriteRenderer = this.GetComponent (SpriteRenderer);
		currentCharacter = null;
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void ChangeToken(char token)
	{

	}
}
