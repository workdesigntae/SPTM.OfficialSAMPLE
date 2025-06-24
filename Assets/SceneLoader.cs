using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour
{
 
       public void LoadSceneByName()
       {
              SceneManager.LoadScene("Scenes/Information Page Menu");
       }


       public void LoadNextInBuild()
       {
              SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
       }


}
