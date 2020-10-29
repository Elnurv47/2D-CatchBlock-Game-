using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class CatchBlock : MonoBehaviour
{
    public int score = 0;
    public int increase = 1;

    public bool isDead;

    Renderer objectRenderer;

    [SerializeField] Text fiveMessage;
    [SerializeField] Text scoreLabel;
    [SerializeField] UIController controller;

    private void Start()
    {
        fiveMessage.gameObject.SetActive(false);
        objectRenderer = GetComponent<Renderer>();
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("WhiteBlock"))
        {
            StartCoroutine(IncreaseScore());
        }
        if (collision.gameObject.CompareTag("RedBlock") && objectRenderer.material.color == Color.red
                || collision.gameObject.CompareTag("GreenBlock") && objectRenderer.material.color == Color.green
                || collision.gameObject.CompareTag("YellowBlock") && objectRenderer.material.color == Color.yellow
                || collision.gameObject.CompareTag("WhiteBlock"))
        {
            Destroy(collision.gameObject);
            score += increase;
            scoreLabel.text = "Score: " + score;
        }
        else
        {
            if (!collision.gameObject.CompareTag("LeftBorder") && !collision.gameObject.CompareTag("RightBorder"))
            {
                Destroy(collision.gameObject);
                isDead = true;
                controller.SetIfDead(true);
            }
        }
    }
    IEnumerator IncreaseScore()
    {
        increase = 5;
        StartCoroutine(SetEnabled());
        yield return new WaitForSeconds(20);
    }
    IEnumerator SetEnabled()
    {
        fiveMessage.gameObject.SetActive(true);
        yield return new WaitForSeconds(1);
        fiveMessage.gameObject.SetActive(false);
    }
}
