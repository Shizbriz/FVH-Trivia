using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameManager : MonoBehaviour
{
    public int numb;
    public string[] questions;
    public string[] answers;
    public float timeLeft;
    [SerializeField] TextMeshProUGUI question;
    [SerializeField] TextMeshProUGUI answer;
      public TextMeshProUGUI timer;
    // Start is called before the first frame update
       void Start()
    {
        timeLeft = 20.0f;
        numb = 0;
        questions = new string[]
            {
                "What is the capital of France?",
                "How old is the president of Nigeria",
                "Who was the president of Kalakuta Republic?",
                "What is the account of one's life written by one?",
                "How many minutes are in a day?",
                "What two countries start with the letter Z?",
                "What is the name of the longest river in China?",
                "How many dots are on a pair of dice?",
                "What country has a flag that isn't four sided?",
                "How many bones are in the human ear?",
                "What is the only body part that is fully grown at birth?",
                "In what year was the first iPhone released?",
                "In what year did the Titanic sink?",
                "Who painted the Mona Lisa?",
                "What is the largest organ in the human body",
                "What is a group of flamingoes called?",
                "What is the largest country in the world?",
                "What is the best selling book of all time?",
                "What type of rock are fossils predominantly in?",
                "The highest mountain in Nigeria, Chappal Waddi, is in what state?",
                "Who were the first people to make and use iron tools in Nigeria?",
                "What state is the largest by land mass in Nigeria?",
                "What is the name of Barbie's little sister?",
                "What is the name of Barbie's boyfriend?",
                "What song took Whitney Houston to the top of the music charts in 1992?",
                "What is Stefani Germanotta's stage name?",
                "What group was Beyonce in before she went solo?",
                "What country has the unicorn as its national animal?",
                "What soft drink once contained cocaine as part of its ingredients?",
                "What cat breed has no fur?",
                "Who has the highest IQ among all the US presidents?",
                "What country uses over 6 billion km of tissue paper per year?",
                "What table condiment was once sold as a medicinal cure for diarrhoea?",
                "What is Sade Adu's first name?",
                "What is the largest ocean in the world?",
                "Who was the captain of the Nigerian men's football team in Atlanta '96 Olympics?",
                "When did Nigeria begin to use Naira?",
                "Who are the people on N1000 note?",
                "Who did Bill Gates co-found Microsoft with?",
                "What type of animal is the classic 1877 novel, Black Beauty, about?"
                };

        answers = new string[]
            {
                "Paris",
                "72 years",
                "Fela Anikulapo Kuti",
                "Biography",
                "1440",
                "Zambia and Zimbabwe",
                "Yangtze River",
                "42",
                "Nepal",
                "3",
                "Eyes",
                "2007",
                "1912",
                "Leonardo Da Vinci",
                "The skin",
                "Flamboyance",
                "Russia",
                "The Bible",
                "Sedimentary rock",
                "Taraba state",
                "The Nok",
                "Niger state",
                "Skipper",
                "Ken",
                "I will always love you",
                "Lady Gaga",
                "Destiny's Child",
                "Scotland",
                "Coca-cola",
                "Sphynx",
                "John Quincy Adams",
                "China",
                "Ketchup",
                "Helen",
                "Pacific ocean",
                "Kanu Nwankwo",
                "1973",
                "Alhaji Aliyu Mai-Bornu and Clement Isong",
                "Paul Allen",
                "Horse"
                };
    }

   public void SetQuestion()
        {
        question.text = questions[numb];
        answer.text = answers[numb];
        }
    // Update is called once per frame
    void Update()
    {
        timer.text = timeLeft.ToString();
        timeLeft -= Time.deltaTime;
        if (timeLeft < 0.0f)
            {
            timeLeft = 0;
            }
    }


}
