using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public Text scoreText;
    public float delay = 2f;
    public ParticleSystem particle;

    public void levelCompleted()
    {
        particle.gameObject.SetActive(true);
        Debug.Log("LEVEL COMPLETED...");
        scoreText.gameObject.SetActive(true);
        Invoke("nextLevel", delay);
        
        
    }

    public void nextLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public void restart()
    {
        Invoke("rsScene", 1f);
        
    }

    public void rsScene()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    public void firstScene()
    {
        SceneManager.LoadScene(1);
    }

    public void lvl5()
    {
        SceneManager.LoadScene(5);
    }

    public void lvl11()
    {
        SceneManager.LoadScene(11);
    }
    public void lvl15()
    {
        SceneManager.LoadScene(15);
    }
    public void lvl20()
    {
        SceneManager.LoadScene(20);
    }

}
