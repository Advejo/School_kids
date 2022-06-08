using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class  Game : MonoBehaviour
{
    int correctAnswer ;
    
    int[] array = new int[] { 4, 16, 3, 8 };
    public Text[] text;
    
    public void NextQuestion()
    {
        
        correctAnswer = Random.Range(0, array.Length ); 
        Debug.Log(correctAnswer);
 
    }
    void Start()
    {
        
        NextQuestion();
    }
    
    void Update()
    {
    }
   
    public void check(int index)
    {
        if(index == correctAnswer )
        {
            Debug.Log("все верно");
            NextQuestion();
            
        }else
        {
            Debug.Log("неправельный ответ");
        }
    }
}
