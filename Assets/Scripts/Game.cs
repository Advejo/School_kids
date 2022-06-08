using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;
using UnityEngine.UI;

public class  Game : MonoBehaviour
{
    int correctAnswer ;
    
    public int[] array = new int[] { 4, 16, 3, 8 };
    public Text[] buttonText;

    public void showForm()
    {
        for(int i=0; i<array.Length && i<buttonText.Length; i++)
        {
            buttonText[i].text = array[i].ToString(); 
        }
    }
    
    
    public void NextQuestion()
    {
        
        correctAnswer = Random.Range(0, array.Length ); 
        Debug.Log(array[correctAnswer].ToString());
 
    }
    void Start()
    {
        
        NextQuestion();
    }
    
    void Update()
    {
        showForm();
    }
    public void OnClik()
    {
        SceneManager.LoadScene("MainMenu");
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
