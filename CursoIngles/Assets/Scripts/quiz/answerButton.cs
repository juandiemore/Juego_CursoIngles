using UnityEngine;
using System.Collections;
using UnityEngine.UI;
public class answerButton : MonoBehaviour {
    public Text answerText;
    private Respuesta answerData;

    private GameController gameController;


void start() 
{
    gameController = FindObjectOfType<GameController>();
}
    public void Setup(Respuesta data){
        answerData = data;
        answerText.text = answerData.answerText;
        }

        public void HandleClick()
            {
            gameController.AnswerButtonClicked(answerData.isCorrect);
            }
        }

