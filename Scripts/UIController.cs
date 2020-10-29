using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class UIController : MonoBehaviour
{
    [SerializeField] Move move;
    [SerializeField] CatchBlock catchBlock;
    [SerializeField] Text finalScore;
    [SerializeField] Canvas finishMenu;
    void Start()
    {
        finishMenu.gameObject.SetActive(false);
    }
    public void SetIfDead(bool isDead)
    {
        if (isDead == true)
        {
            finishMenu.gameObject.SetActive(true);
            move.enabled = false; // this disables Move.cs script
            SetFinalScore();
        }
    }
    public void SetFinalScore()
    {
        finalScore.text = "Your Score: " + catchBlock.score.ToString();
    }
    public void Restart()
    {
        SceneManager.LoadScene("MainScene");
    }
    public void Quit()
    {
        Application.Quit();
    }
}
