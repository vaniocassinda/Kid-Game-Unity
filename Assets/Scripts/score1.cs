using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class score1 : MonoBehaviour
{
    // Start is called before the first frame update
    public int scoreGame ;
    public GameObject resultadoFinal;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        GetComponent<Text>().text = scoreGame.ToString();
        resultadoFinal.GetComponent<Text>().text = scoreGame.ToString();
    }
}
