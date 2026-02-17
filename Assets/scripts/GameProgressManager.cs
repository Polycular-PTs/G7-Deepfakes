using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameProgressManager : MonoBehaviour
{
    public int currentQuiz = 0;
    public Button[] buttons;

    // Start is called before the first frame update
    void Start()
    {
        currentQuiz = QuizzesSingleton.instance.indexQuiz;
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

        if (QuizzesSingleton.instance.quizzes[currentQuiz].quizCompleted)
        {
            buttons[currentQuiz].GetComponent<Animator>().enabled = true;
            buttons[currentQuiz].GetComponent<Animator>().SetTrigger("Reveal_Item");
        }
    }

    public void NextQuiz(int index)
    {
        if (QuizzesSingleton.instance.indexQuiz == index - 1)
        {
            QuizzesSingleton.instance.indexQuiz++;
        }
        
    }
}
