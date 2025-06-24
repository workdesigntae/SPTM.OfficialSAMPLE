using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader4 : MonoBehaviour
{
 
       public void LoadSceneByName()
       {
              SceneManager.LoadScene("Scenes/2Become A Member Page");
       }


       public void LoadNextInBuild()
       {
              SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
       }


}
