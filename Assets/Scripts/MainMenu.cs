using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu: MonoBehaviour
{
    public void i(int i)
    {
        switch (i)
        {
            default:
            case (0):
                SceneManager.LoadScene("EscolherMundo");
                break;

            case (1):
                Application.Quit();
                break;
        }
    }
   

}
