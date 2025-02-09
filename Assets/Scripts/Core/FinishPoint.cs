using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FinishPoint : MonoBehaviour
{
    [SerializeField] bool goNextLevel;
    [SerializeField] string levelName;
    public GameObject textCanvas;
    //public TextMeshPro interactionText;

    private bool isNearObject = false;

    void Start()
    {
        // Disable text and image canvas at start
        textCanvas.SetActive(false);
    }

    void Update()
    {
        if(Input.GetKeyDown(KeyCode.E) && goNextLevel)
        {
            SceneController.instance.LoadScene(levelName);
            textCanvas.SetActive(false);
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.CompareTag("Player"))
        {
            goNextLevel = true;
            // Display interaction text
            textCanvas.SetActive(true);
            // Check for key press to show image
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            goNextLevel = false;
            // Display interaction text
            textCanvas.SetActive(false);
            // Check for key press to show image
        }
    }
}
