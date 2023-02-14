using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

public class ScoreScript : MonoBehaviour
{
    public TextMeshProUGUI myScoreText;
    public int myScore;
    public GameObject WinText;
    public GameObject PlayAgain;

    // Start is called before the first frame update
    void Start()
    {
        WinText.SetActive(false);
        PlayAgain.SetActive(false); 
        myScore = 0;
        myScoreText.text = "Score: " + myScore;


    }

    public void BackGame()
    {

        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);
    }

    public void GameOver()
    {
        SceneManager.LoadScene("GameOver");


    }



    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("coin"))
        {
            myScore++;
            myScoreText.text = "Score: " + myScore;

            if (myScore == 15)
            {
                WinText.SetActive(true);
                GameOver();
                PlayAgain.SetActive(true);
               

            }
        }
       
    }

    
}
