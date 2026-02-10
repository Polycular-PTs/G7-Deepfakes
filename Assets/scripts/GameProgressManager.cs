using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameProgressManager : MonoBehaviour
{
    public Quizzes gameState;
    public int currentQuiz = 0;
    public Button[] buttons;


    // Start is called before the first frame update
    void Start()
    {
        currentQuiz = gameState.indexQuiz;
        buttons[currentQuiz].interactable = true;

        for (int i = 0; i < buttons.Length; i++)
        {
            if (i == currentQuiz)
            {
                break;
            }
            buttons[i].GetComponent<Animator>().enabled = true;
            buttons[i].GetComponent<Animator>().SetTrigger("AlreadyRevealed");
        }

        if (gameState.quizzes[currentQuiz].quizCompleted)
        {
            buttons[currentQuiz].GetComponent<Animator>().enabled = true;
            buttons[currentQuiz].GetComponent<Animator>().SetTrigger("Reveal_Item");
        }
    }

    public void NextQuiz(int index)
    {
        if (gameState.indexQuiz == index - 1)
        {
            gameState.indexQuiz++;
        }
        
    }
}
