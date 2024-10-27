using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class ButtonScript : MonoBehaviour
{
    private Button button;
    private GameManager gameManager;
    private int buttonNumber;
    private string buttonText;
    
    // Start is called before the first frame update
   
    void Start()
        {
        button = GetComponent<Button>();
        gameManager = GameObject.Find("Game Manager").GetComponent<GameManager>();
        if (button.CompareTag("QuestionButton"))
            {
            Debug.Log("This is a question button", button.gameObject);
            button.onClick.AddListener(ButtonClicked);
            buttonText = button.GetComponentInChildren<TextMeshProUGUI>().text;
            buttonNumber = int.Parse(buttonText);
            }
        }

   /* private void OnEnable()
        {
        //Debug.Log("This is OnEnable", button.gameObject);
        if (button.CompareTag("QuestionButton"))
            {
            Debug.Log("This is a question button", button.gameObject);
            button.onClick.AddListener(ButtonClicked);
            buttonText = button.GetComponentInChildren<TextMeshProUGUI>().text;
            buttonNumber = int.Parse(buttonText);
            }
        }

    private void OnDisable()
        {
        button.onClick.RemoveListener(ButtonClicked);

        } */

    public void ButtonClicked()
        {
        Debug.Log("ButtonClicked");
        gameManager.numb = buttonNumber-1;
     gameManager.SetQuestion();
        gameManager.timeLeft = 20.0f;
     
        }
}
