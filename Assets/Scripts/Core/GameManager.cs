using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
  public static GameManager instance = null;

  //Awake is always called before any Start functions
  void Awake()
  {
      //Check if instance already exists
      if (instance == null)
      {
          //if not, set instance to this
          instance = this;
      }
      //If instance already exists and it's not this:
      else if (instance != this)
      {
         Destroy(gameObject);
      }


      //Sets this to not be destroyed when reloading scene
      DontDestroyOnLoad(gameObject);

  }
  void Update()
  {
    //Checks if build index is greater than ("#") 
    if (SceneManager.GetActiveScene ().buildIndex > 1)
    {
      Destroy(GameObject.FindWithTag("GameManager"));
    }
  }
}
