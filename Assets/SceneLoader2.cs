using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader2 : MonoBehaviour
{
 
       public void LoadSceneByName()
       {
              SceneManager.LoadScene("Scenes/Home Page Main Menu");
       }


       public void LoadNextInBuild()
       {
              SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
       }


}
