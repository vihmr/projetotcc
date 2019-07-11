using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuPlanetas : MonoBehaviour
{
    public void i(int i)
    {
        switch (i)
        {
            default:
            case (0):
                SceneManager.LoadScene("PrimeiraFase");
                break;

        
        }
    }


}
