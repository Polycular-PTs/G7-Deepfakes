using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static QuizzController;

[CreateAssetMenu(fileName = "Data", menuName = "ScriptableObjects/Quizzes", order = 1)]
public class Quizzes : ScriptableObject
{
    public int indexQuiz;
    public List<Quiz> quizzes;
}

[Serializable]
public class Quiz
{
    public string nextSceneToLoad;
    public List<QuestionData> questions;
    public bool quizCompleted = false;
}