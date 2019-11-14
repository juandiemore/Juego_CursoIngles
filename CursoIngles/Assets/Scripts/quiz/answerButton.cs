using UnityEngine;
using System.Collections;
using UnityEngine.UI;
public class answerButton : MonoBehaviour {
    public Text answerText;

    private Respuestas answerData;

    private GameController gameController;


void start() 
{
    gameController = FindObjectOfType<GameController>();

}
    public void Setup(Respuestas data){
        answerData = data;
        answerText.text = answerData.answerText + " is correct "+ answerData.isCorrect;
        }

        public void HandleClick()
            {
            //gameController.AnswerButtonClicked(answerData.isCorrect);
             if(answerData.isCorrect)
    {
        // vida enemigo -damage
        Debug.Log("Text: ");
    }else
    {
        // vida player -damage
Debug.Log("b");
    }
        
            }
        }

