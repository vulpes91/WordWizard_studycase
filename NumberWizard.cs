using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NumberWizard : MonoBehaviour
{
    int minGuess = 1; 
    int maxGuess = 1000; //объявили переменную. 

    int guess = 500;

    // Start is called before the first frame update
    void Start()
    {
       StartGame(); //вызов StartGame 
    }

    void StartGame(){ //начало игры 

        maxGuess = 1000;
        minGuess = 1;
        guess = 500;
        
        Debug.Log("Добро пожаловать в Мастера цифр!");
        Debug.Log("Загадайте число, не говорите его мне");
        Debug.Log("Минимальное число, которое вы можете выбрать, это " + minGuess);
        Debug.Log("Максимальное число, которое вы можете выбрать, это " + maxGuess);
        

        Debug.Log("Ваше число больше или меньше, чем " + guess + "?");
        Debug.Log("Нажмите вверх, если ваше число больше, и вниз, если оно меньше.");
        Debug.Log("Нажмите Enter, если я угадал число");

        maxGuess = maxGuess + 1;
    }

    // Update is called once per frame
    void Update()
    {
          if (Input.GetKeyDown(KeyCode.UpArrow)) 
          {
              minGuess = guess;
              NextGuess ();
          }
          else if (Input.GetKeyDown(KeyCode.DownArrow)) 
          {
              maxGuess = guess;
              NextGuess ();
          }
          else if (Input.GetKeyDown(KeyCode.Return)) 
          {
              Debug.Log("Я угадал ваше число!");
              Debug.Log("Начинаем сначала");
              StartGame();
          }
    }

    void NextGuess(){
        guess = (maxGuess+minGuess) / 2;
        Debug.Log("Ваше число больше или меньше, чем " + guess + "?");
    }
}
