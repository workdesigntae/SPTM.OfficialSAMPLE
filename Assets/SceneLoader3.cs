using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader3 : MonoBehaviour
{
 
       public void LoadSceneByName()
       {
              SceneManager.LoadScene("Scenes/Become A Member Page");
       }


       public void LoadNextInBuild()
       {
              SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
       }


}
