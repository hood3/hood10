//Byron Hood
//Game Programming
//Assignment #3
//02-21-2019
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WordManager : MonoBehaviour {
    public List<Word> words;
    public WordSpawner wordSpawner;
    public static bool hasActiveWord;
    public static Word activeWord;
    public AudioClip typingsound;
    public AudioClip typingcarrigereturnsound;
    public Transform scoreObj;
    public int TotalScore = 0;
    public int playerScore = 0;
    public static int points;
    public int wordComplete = 0;
    public int wordDone = 0;

    public void AddWord()
    {
        Word word = new Word(WordGenerator.GetRandomWord(), wordSpawner.SpawnWord());        
        words.Add(word);
    }
    public void TypeLetter(char letter)
    {
        if (hasActiveWord)
        {
            if(activeWord.GetNextLetter() == letter)
            {
                activeWord.TypeLetter();
                GetComponent<AudioSource>().PlayOneShot(typingsound,0.1f);
            }
        }
        else
        {
            foreach(Word word in words)
            {
                if(word.GetNextLetter() == letter)
                {
                    activeWord = word;
                    hasActiveWord = true;
                    GetComponent<AudioSource>().PlayOneShot(typingsound,0.1f);
                    word.TypeLetter();
                    break;
                }
            }
        }
        if(hasActiveWord && activeWord.WordTyped())
        {
            hasActiveWord = false;
            words.Remove(activeWord);
            GetComponent<AudioSource>().PlayOneShot(typingcarrigereturnsound,.01f);
            playerScore = playerScore + points;
            TotalScore = playerScore;
            scoreObj.GetComponent<TextMesh>().text = "Score: " + TotalScore;
            endScore.finalScore = TotalScore;
            wordDone = 1;
            wordComplete = wordDone + wordComplete;
            speedTyp.wordCompleted = 65 / wordComplete;
            speedTyp.wordCompleted = 60 / speedTyp.wordCompleted;
        }
    }

}
