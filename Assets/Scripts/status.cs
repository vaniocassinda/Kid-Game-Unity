using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class status : MonoBehaviour
{
    // Start is called before the first frame update

    public GameObject question_bank, score;
    void Start()
    {
        
    }

    public void feedback()
    {
        question_bank.GetComponent<question_bank>().control(1);
        if(gameObject.name == "correto")
        {
            score.GetComponent<score1>().scoreGame += 10;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
