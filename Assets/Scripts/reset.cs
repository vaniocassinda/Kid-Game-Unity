using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class reset : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame

    public void desativar_game()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);

    }

    public void Home()
    {
        SceneManager.LoadScene("Menu");

    }

    public void NextLevel()
    {
        SceneManager.LoadScene("L2");

    }


    public void NextLevel2()
    {
        SceneManager.LoadScene("L3");

    }

    public void NextLevel3()
    {
        SceneManager.LoadScene("L4");

    }

    public void NextLevel4()
    {
        SceneManager.LoadScene("L5");

    }

    public void NextLevel5()
    {
        SceneManager.LoadScene("NL10");

    }
    public void NextLevel6()
    {
        SceneManager.LoadScene("L11");

    }

   

    /* public void desativar_game()
     {
         SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);


     }*/


    void Update()
    {
        
    }
}
