using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour {

    public int score = 0;
    private Text scoreText;

    void Start()
    {
        score = 0;
        scoreText = gameObject.GetComponent<Text>();
        string textx = "Score: " + score.ToString(); 
        scoreText.text = textx;
    }

    public void incrementScore(GameObject duck)
    {
        scoreText = gameObject.GetComponent<Text>();

        Debug.Log("in");

            if (duck.tag == "PurpleDuck")
                score += 500;
            else if (duck.tag == "BlueDuck")
                score += 300;
            else
                score += 100;
        

        string textx = "Score: " + score.ToString();
        Debug.Log(textx);
        scoreText.text = textx;

    }
}
