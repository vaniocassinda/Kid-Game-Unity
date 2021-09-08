using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Timer : MonoBehaviour
{

    public Text text;
    public static float time;

   // public GameObject[] stars;



    void Start()
    {
        time =60;
    }

    void Update()
    {
        time -= Time.deltaTime;
        text.text = "" + Mathf.Round(time);

        if (time <= 10)
        {
            text.color = Color.red;
        }

        if (Timer.time <=0 )
        {

            text.text = "0";
           // StartCoroutine(ShowStars());
           
        }
         
    }

    /* IEnumerator ShowStars()
     {
         if (Timer.time <= 10)
          {
              stars[0].SetActive(true);
          }else if (Timer.time < 15)
          {
              stars[0].SetActive(true);
              yield return new WaitForSeconds(0f);
              stars[1].SetActive(true);
          }
          else
          {
              stars[0].SetActive(true);
              yield return new WaitForSeconds(0f);
              stars[1].SetActive(true);

              yield return new WaitForSeconds(0f);
              stars[2].SetActive(true);
          }

     }
          */






}
