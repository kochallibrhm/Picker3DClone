using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ScoreController : MonoBehaviour
{

    public int score = 0;
    public float delay = 1f;
    public Text scoreText;
    public GameManager gameManager;
    public int needed_score = 0;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("BlackCollectibles"))
        {
            score += 1;
        }

        if (other.CompareTag("YellowCollectibles"))
        {
            score += 2;
        }

        if (other.CompareTag("BlueCollectibles"))
        {
            score += 3;
        }

        if (other.CompareTag("PurpleCollectibles"))
        {
            score += 5;
        }

        if (other.CompareTag("RedCollectibles"))
        {
            score += 10;
        }



        Debug.Log(score);
        scoreText.text = score.ToString();
    }
    
    public void Decider()
    {
        if (SceneManager.GetActiveScene().buildIndex > 8)
        {
            needed_score = 10;
        }

        else if (SceneManager.GetActiveScene().buildIndex > 17)
        {
            needed_score = 55;
        }

        if (score < needed_score + 5)
        {
            scoreText.gameObject.SetActive(true);
            reStart();
        }
        else
        {
            nextLevel();
        }
    }

    public void reStart()
    {
        gameManager.restart();
    }

    public void nextLevel()
    {
        gameManager.levelCompleted();
    }





}
