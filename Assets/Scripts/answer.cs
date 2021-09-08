using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class answer : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject estourar, bolha, feedcorreto, feederrado;
    public bool correto;
    

    void Start()
    {

     
        
    }

  

   

    void OnMouseUp()
    {
        estourar.SetActive(true);
        bolha.SetActive(true);
        

        if (correto)
        {
            feedcorreto.SetActive(false);
            feedcorreto.SetActive(true);
        }
        else
        {
            feederrado.SetActive(false);
            feederrado.SetActive(true);
        }

        Destroy(gameObject);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
