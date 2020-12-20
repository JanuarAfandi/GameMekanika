using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneSelect : MonoBehaviour
{
   public void selectScene(){
       switch (this.gameObject.name){
           case "Start":
                SceneManager.LoadScene ("InGame");
                break;
           case "Settings":
                SceneManager.LoadScene ("Settings");
                break;
            case "Credits":
                SceneManager.LoadScene ("Credits");
                break;
       }
   }
}
