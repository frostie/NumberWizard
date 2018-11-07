using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NumberWizard : MonoBehaviour {

    int max = 1000;
    int min = 1;
    int guess = 500;

    // Use this for initialization
    void Start () 
    {
        StartGame();
    }
	
    void StartGame ()
    {
        max = 1000;
        min = 1;
        guess = 500;

        Debug.Log("Ciao a tutti! Benvenuto a Number Wizard!");
        Debug.Log("Pick a number:");
        Debug.Log("Highest number is: " + max);
        Debug.Log("Lowest number is: " + min);
        Debug.Log("Tell me if your number is higher or lower than: " + guess);
        Debug.Log("Push up if it's higher, down if it's lower, or enter if it's correct!");
        max = max + 1;
    }

	// Update is called once per frame
	void Update () 
    {
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            min = guess;
            NextGuess();
        }

        else if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            max = guess;
            NextGuess();
        }

        else if (Input.GetKeyDown(KeyCode.Return))
        {
            Debug.Log("Aha! The Number Wizard has guessed your number!");
            StartGame();
        }
     }

    void NextGuess()
    {
        guess = (max + min) / 2;
        Debug.Log("Is it higher or lower than... " + guess + "?");
    }
}