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
    public Text[] text;
    public int error = 0;

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
        text[0].text =  array[correctAnswer].ToString(); 
        
 
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
    public void OnWasted()
    { 
        SceneManager.LoadScene("Wasted");
    }
    public void check(int index)
    {
        if(index == correctAnswer )
        {
            text[1].text = "<color=green>Good</color>";
            NextQuestion();
            
        }else
        {
            error += 1;
            text[1].text = "<color=red>wrong</color>";
            text[2].text = error.ToString();
            if(error == 5)
            {
                OnWasted();
            }
        }
    }
}
