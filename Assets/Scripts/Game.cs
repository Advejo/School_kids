using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;
using UnityEngine.UI;

public class  Game : MonoBehaviour
{
	
    int correctAnswer = 0  ;
    List<int> example = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
    List<int> showEx = new List<int> {0,0,0,0};
    List<int> examplesLeft = new List<int>{0, 0, 0, 0, 0, 0, 0, 0, 0};
    public Text[] buttonText;
    public Text placeholder;
    public Text status;
    public Text textError;

    public int error = 0;

    public void showForm()
    {
        for(int i=0; i<showEx.Count && i<buttonText.Length; i++)
        {
            buttonText[i].text = showEx[i].ToString(); 
        }
    }
    
    public void NextQuestion()
    {
        for(int i=0; i<showEx.Count && i<buttonText.Length; i++)
        {
            examplesLeft.Add(example[Random.Range(0, example.Count )]);
            examplesLeft.RemoveAt(i);
            showEx[i] = examplesLeft[Random.Range(0, examplesLeft.Count )];
            correctAnswer += 1 ;
        }
        
        correctAnswer = Random.Range(0, showEx.Count); 
        placeholder.text =  showEx[correctAnswer].ToString(); 
        
 
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
            status.text = "<color=green>Good</color>";
            NextQuestion();
            
        }else
        {
            error += 1;
            status.text = "<color=red>wrong</color>";
            textError.text = error.ToString();
            if(error == 5)
            {
                OnWasted();
            }
        }
    }
}
