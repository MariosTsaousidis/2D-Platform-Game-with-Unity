using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;


public class InteractionController : MonoBehaviour
{
    public GameObject textCanvas;
    //public TextMeshPro interactionText;
    public GameObject imageCanvas;
    //public GameObject movementImage;

    private bool isNearObject = false;
    private bool isImageVisible = false;

    void Start()
    {
        // Disable text and image canvas at start
        textCanvas.SetActive(false);
        imageCanvas.SetActive(false);
    }

    void Update()
    {
        if (isNearObject)
        {
            // Display interaction text
            textCanvas.SetActive(true);

            // Check for key press to show image
            if (Input.GetKeyDown(KeyCode.E))
            {
                ShowImage();
            }
        }
        else
        {
            // Hide text and image canvas if not near object
            HideImage();
            textCanvas.SetActive(false);
        }
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            isNearObject = true;
        }
    }

    void OnTriggerExit2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            isNearObject = false;
        }
    }

    void ShowImage()
    {
        isImageVisible = true;
        imageCanvas.SetActive(true);
    }

    void HideImage()
    {
        if (isImageVisible)
        {
            isImageVisible = false;
            imageCanvas.SetActive(false);
        }
    }
}