using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader1 : MonoBehaviour
{
 
       public void LoadSceneByName()
       {
              SceneManager.LoadScene("Scenes/SampleScene");
       }


       public void LoadNextInBuild()
       {
              SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
       }


}
