using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class ButtonController : MonoBehaviour
{

    public GameObject playerSprite;
    public GameObject checker;
    public GameObject pauseGreyImage;
    public GameObject pause;
    public GameObject HighScore;
    public GameObject gameOverText;

    public Text counter;

    public Button leftButton;
    public Button rightButton;
    public Button startButton;

    private bool isGameOver;

    private SpriteController spriteControllerScript;
    void Start()
    {
        gameOverText.SetActive(false);
        // Time.timeScale = 0;
        spriteControllerScript = playerSprite.GetComponent<SpriteController>();
    }

    public void OnLeftClick()
    {
        checker.transform.position = new Vector3(-1, checker.transform.position.y, checker.transform.position.z);
        spriteControllerScript.FlipLeft();
    }

    public void OnRightClick()
    {
        checker.transform.position = new Vector3(1, checker.transform.position.y, checker.transform.position.z);
        spriteControllerScript.FlipRight();
    }

    public void OnExit()
    {
        checker.transform.position = new Vector3(0, checker.transform.position.y, checker.transform.position.z);
    }

    public void Pause()
    {
        if (Time.timeScale == 0)
        {
            Time.timeScale = 1;
            pauseGreyImage.SetActive(false);
            pause.SetActive(true);
        }
        else
        {
            pauseGreyImage.SetActive(true);
            pause.SetActive(false);
            Time.timeScale = 0;
        }
    }

    //game over
    //0 masked guy escaped
    //1 hit unmasked guy

    public void GameOver(int cause)
    {
        isGameOver = true;
        Debug.Log("game over");
        if (cause == 0)

            Debug.Log("cause = masked escaped");

        else if(cause == 1)
            Debug.Log("cause = unmasked hit");
        HighScore.GetComponent<HighScoreController>().UpdateHighScoreAfterGameOver();

        Time.timeScale = 0;
        pauseGreyImage.SetActive(true);
        pause.SetActive(false);
        gameOverText.SetActive(true);
    }

    public void StartGame()
    {
        Time.timeScale = 1;
        pauseGreyImage.SetActive(false);
        pause.SetActive(true);
        //Destroy(startButton); //w tej kwestii musze jeszcze ocenic czy to na pewno ma sens

        //counter.GetComponent<CounterController>().ResetGame();
        //gameOverText.SetActive(false);

        if (isGameOver)
        {
            Scene scene = SceneManager.GetActiveScene();
            SceneManager.LoadScene(scene.name);
        }
    }
}
