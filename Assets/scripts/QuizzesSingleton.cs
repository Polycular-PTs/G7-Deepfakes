using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuizzesSingleton : MonoBehaviour
{
    public List<Quiz> quizzes;
    public int indexQuiz;

    public static QuizzesSingleton instance;

    void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
        else {
            Destroy(this);
        }

        DontDestroyOnLoad(this);
    }

}
