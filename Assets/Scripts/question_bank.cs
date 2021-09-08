using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class question_bank : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject resultado_jogo;

    int pedido = 0;
    void Start()
    {
        set_balon();
    }

    public void control(int i)
    {
        if (pedido < transform.childCount-1)
        {
            pedido += i;
        }
        else
        {
            resultado_jogo.SetActive(true);
        }
        set_balon();
    }


    public void set_balon()
    {
        for (int i = 0; i < transform.childCount; i++)
        {
            transform.GetChild(i).gameObject.SetActive(false);
        }

        transform.GetChild(pedido).gameObject.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
