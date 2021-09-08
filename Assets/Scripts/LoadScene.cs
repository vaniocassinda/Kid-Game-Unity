using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadScene : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void SceneBalao()
    {
        SceneManager.LoadScene("TocaBalao");
    }

    public void SceneNumber()
    {
        SceneManager.LoadScene("L4");
    }
    public void SceneNumber2()
    {
        SceneManager.LoadScene("L5");
    }
    public void SceneNumber3()
    {
        SceneManager.LoadScene("L6");
    }
    public void SceneNumber4()
    {
        SceneManager.LoadScene("L9");
    }

    public void SceneLevel1()
    {
        SceneManager.LoadScene("L1");
    }


    public void SceneLetrasE()
    {
        SceneManager.LoadScene("Letras");
    }

    public void SceneQuiz()
    {
        SceneManager.LoadScene("GameQuiz");
    }


    public void Sair()
    {
        Application.Quit();
    }

    public void SceneMenu()
    {
        SceneManager.LoadScene("Menu");
    }

    public void StartMenu()
    {
        SceneManager.LoadScene("MainMenu");
    }


    public void Sound_volume(float volume)
    {
        PlayerPrefs.SetFloat("volume",volume);
    }


    public void Somar()
    {
        SceneManager.LoadScene("SomarScene");

    }

}
