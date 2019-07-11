using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public GameObject PainelCompleto;
    public bool isPaused = false;

    public GameObject lanterna1, lanterna2, lanterna3, lanterna4;
   

    // Start is called before the first frame update
    void Start()
    {
        PainelCompleto.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        //if (Input.GetKey(KeyCode.R))
        //{
        //    isOn = true;
        //    lanterna.SetActive(true);
            
        //}
        //if (Input.GetKey(KeyCode.E))
        //{
        //    isOn = false;
        //    lanterna.SetActive(false);
        //}

    }

        
    public void LanternaVermelha()
    {  
        lanterna1.SetActive(true);
        lanterna2.SetActive(false);
        lanterna3.SetActive(false);
        lanterna4.SetActive(false);
    }

    public void LanternaAzul()
    {
        lanterna2.SetActive(true);
        lanterna1.SetActive(false);
        lanterna3.SetActive(false);
        lanterna4.SetActive(false);
    }

    public void LanternaVerde()
    {
        lanterna3.SetActive(true);
        lanterna2.SetActive(false);
        lanterna1.SetActive(false);
        lanterna4.SetActive(false);   
    }

    public void LanternaBranca()
    {
        lanterna4.SetActive(true);
        lanterna3.SetActive(false);
        lanterna2.SetActive(false);
        lanterna1.SetActive(false);
    }

    public void Pause()
    {

        if (isPaused)
        {
            PainelCompleto.SetActive(false);
            isPaused = false;
            Time.timeScale = 1;
        }
        else
        {
            PainelCompleto.SetActive(true);
            isPaused = true;
            Time.timeScale = 0;
        }

    }

    public void Resume()
    {

        PainelCompleto.SetActive(false);
        isPaused = false;
        Time.timeScale = 1;
    }

    public void Restart()
    {
        SceneManager.LoadScene("PrimeiraFase");
        PainelCompleto.SetActive(false);
        isPaused = false;
        Time.timeScale = 1;
    }
    
    public void MainMenu()
    {
        SceneManager.LoadScene("TelaInicial");
        PainelCompleto.SetActive(false);
        isPaused = false;
        Time.timeScale = 1;
    }
}
