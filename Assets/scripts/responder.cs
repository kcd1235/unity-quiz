using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class responder : MonoBehaviour {

    public int themeId;

    public Text question;
    public Text answerA;
    public Text answerB;
    public Text answerC;
    public Text answerD;

    public Text answerInfo;

    public string[] questions;
    public string[] answersA;
    public string[] answersB;
    public string[] answersC;
    public string[] answersD;
    public string[] correctsAnswer;

    private int questionId;

    private float corrects;
    private float media;

    // Use this for initialization
    void Start() {
        questionId = 0;

        populateInfos();
    }

    // Update is called once per frame
    void Update() {

    }

    public void selectAnswer(string answer)
    {
        switch(answer)
        {
            case "A":
                corrects += answer == answersA[questionId] ? 1 : 0;
                break;

            case "B":
                corrects += answer == answersB[questionId] ? 1 : 0;
                break;

            case "C":
                corrects += answer == answersC[questionId] ? 1 : 0;
                break;

            case "D":
                corrects += answer == answersD[questionId] ? 1 : 0;
                break;
        }

        nextQuestion();
    }

    public void nextQuestion()
    {
        if (questionId == questions.Length - 1)
        {
            SceneManager.LoadScene("scores");
            return;
        }

        questionId++;
        populateInfos();
    }

    private void populateInfos()
    {
        question.text = questions[questionId];
        answerA.text = answersA[questionId];
        answerB.text = answersB[questionId];
        answerC.text = answersC[questionId];
        answerD.text = answersD[questionId];

        answerInfo.text = "Respondendo " + (questionId + 1) + " de " + questions.Length;
    }
}
