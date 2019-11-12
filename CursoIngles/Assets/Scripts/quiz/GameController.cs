using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameController : MonoBehaviour
{
    // Start is called before the first frame update

    public Text questionText;
    public SimpleObject answeButtonPool;
    public Transform answerButtonParent;
    
    private controladorData dataController;
    private RoundData currentData;
    private DatosPreguntas[] questionPool;
    private bool isRoundActive;
    private int questionIndex;
    private List<GameObject> answerButtonGameObjects = new List<GameObject>();
    // traer anim
    // traer vida pj y vida enemigo

    void Start()
    {
        questionIndex = 0;
        dataController = FindObjectOfType<controladorData>();
        currentData = dataController.GetCurrentData();
        questionPool = currentData.questions;
        ShowQuestion();
        isRoundActive = true; 
    }

    private void ShowQuestion()
    {
        RemoveAnsweButtons();
        DatosPreguntas questionData = questionPool[questionIndex];
        questionText.text = questionData.questionText;
        for(int i = 0; i< questionData.respuestas.Length; i++){
            GameObject answerButtonGameObject = answeButtonPool.GetObject();
            answerButtonGameObjects.Add(answerButtonGameObject);
            answerButtonGameObject.transform.SetParent(answerButtonParent,false);
            answerButton ansBut = answerButtonGameObject.GetComponent<answerButton>();

            ansBut.Setup(questionData.respuestas[i]);

        }
    }
    private void RemoveAnsweButtons()
    {
while(answerButtonGameObjects.Count > 0)
    {
        answeButtonPool.ReturnObject(answerButtonGameObjects[0]);
        answerButtonGameObjects.RemoveAt(0);
    }
}

public void AnswerButtonClicked(bool isCorrect){

    if(isCorrect)
    {
        // vida enemigo -damage
        Debug.Log("Text: ");
    }else
    {
        // vida player -damage
Debug.Log("b");
    }

    if(questionPool.Length > questionIndex +1)
{
    ShowQuestion();
}
}
 
    void Update()
    {
        
    }
}
