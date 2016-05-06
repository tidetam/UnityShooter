using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System;

public class ScoreBoardManager : MonoBehaviour {

	public static int[] playerScores = new int[50];
	public static int changeCounter = 0;
	// Use this for initialization

	Text text;                      // Reference to the Text component.


	void Awake ()
	{
		// Set up the reference.
		text = GetComponent <Text> ();
	}


	void Update ()
	{
		UpdateText ();
		// Set the displayed text to be the word "Score" followed by the score value.
	}


	public static void AddScore(int score)
	{
		playerScores [changeCounter++] = score;
	}

	public void UpdateText()
	{
		Array.Sort (playerScores);
		Array.Reverse (playerScores);
		text.text = "Score Board\n";
		for (int i = 0; i < 5; i++) {
//			if (playerScores [i] == 0)
//				break;
			text.text +=(i+1) + ":  " + playerScores[i] + "\n";
		}
	}
}
