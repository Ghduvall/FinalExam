using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameScore : MonoBehaviour
{
    public ChangeScene changeScene;
    public Drop drop;
    public ScoreKeeper scoreKeeper;

    public static int playerScore = 10;
    //public Text scoreText;
    public static string score = "";
    public static int playerIndex;
    public Text sizeText;
    //public static string currentStatus;
    public string currentText;
    //public static bool funMode = false;

    

    public Text gameTimer;
    public static string timer = "";
    public static float currentTimer = 0f;

    // Start is called before the first frame update
    void Start()
    {
        sizeText.text = "Small";
        sizeText.text = drop.sizeValue;
    }

    // Update is called once per frame
    void Update()

    {
        
        //scoreText.text = score + playerScore.ToString();
        gameTimer.text = timer + currentTimer.ToString("F0");
        currentTimer += Time.deltaTime;
        funModeCheck();
    }

    public void funModeCheck()
    {
        if (MultiOptions.funModeValue == true)
        {

            if (currentTimer > 60)
            {
                SceneManager.LoadScene(4);
            }
        }
        else if (int.Parse(scoreKeeper.NewScore.text) == 10)
        {
            currentText = scoreKeeper.NewScore.text;
            //currentStatus = (scoreKeeper.NewScore.text);
            SceneManager.LoadScene(3);
        }
    }
}
