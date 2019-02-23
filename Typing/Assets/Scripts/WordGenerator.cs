//Byron Hood
//Game Programming
//Assignment #3
//02-21-2019
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

    public class WordGenerator : MonoBehaviour
    {
        private static string[] wordList;

        public static void LoadScript()
        {
            List<string> lstLines = new List<string>();
            string filePath = @"MyCode.cs";
            using (StreamReader sr = File.OpenText(filePath))
            {
                string nextLine = string.Empty;
                while ((nextLine = sr.ReadLine()) != null)
                {
                    lstLines.Add(nextLine);
                }
                wordList = lstLines.ToArray();
            }
        }

        public static string GetRandomWord()
        {
            int randomIndex = Random.Range(0, wordList.Length);
            string randomWord = wordList[randomIndex];
            return randomWord;
        }

    }

