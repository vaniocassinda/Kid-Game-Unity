using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Calcular : MonoBehaviour
{

    int primeiro_valor, segundo_valor, valorTemporario, respostaFinal, Alternativa1, Alternativa2;

    public GameObject slot1, slot2, slot3, slot1_black, Sistemaparticula;

    public GameObject botao;

    Vector2 SlotInitialPos1, SlotInitialPos2, SlotInitialPos3;

    public AudioSource[] AudioM; 

    public GameObject newSoma;

   // public GameObject te;

    public Animator m_Animator;
 
    public Sprite Spritesim, Spritenao;
    public Text PrimeiroDigito, SegundoDigito, signo, Alt_1, Alt_2, Alt_3;
    private string Varsigno;

   


    // Start is called before the first frame update
    void Start()
    {
        //te.SetActive(false);
        SlotInitialPos1 = slot1.transform.position;
        SlotInitialPos2 = slot2.transform.position;
        SlotInitialPos3 = slot3.transform.position;
        FuncaoSomar();
        botao.SetActive(false);



    }

    public void DragSlot1()
    {
        slot1.transform.position = Input.mousePosition;
        
    }

    public void DragSlot2()
    {
        slot2.transform.position = Input.mousePosition;
    }

    public void DragSlot3()
    {
        slot3.transform.position = Input.mousePosition;
    }

    public void DropSlot1()
    {
        float Distance = Vector3.Distance(slot1.transform.position, slot1_black.transform.position);
        if ((Alt_1.text == respostaFinal.ToString()) && (Distance < 50))
        {
            slot1.transform.position = slot1_black.transform.position;
            
        }
        else
        {
            slot1.transform.position = SlotInitialPos1;
         
        }
    }

    public void DropSlot2()
    {
        float Distance = Vector3.Distance(slot2.transform.position, slot1_black.transform.position);
        if ((Alt_2.text == respostaFinal.ToString()) && (Distance < 50))
        {
             
                slot2.transform.position = slot1_black.transform.position;
            
            

        }
        else
        {
            slot2.transform.position = SlotInitialPos2;

        }

    }

    public void DropSlot3()
    {
        float Distance = Vector3.Distance(slot3.transform.position, slot1_black.transform.position);
        if ((Alt_3.text == respostaFinal.ToString()) && (Distance < 50))
        {
            slot3.transform.position = slot1_black.transform.position;

        }/*else if ((Alt_2.text == respostaFinal.ToString()) && (Distance < 50) )
        {
            slot3.transform.position = slot1_black.transform.position;
        }
        else if ((Alt_3.text == respostaFinal.ToString()) && (Distance < 50))
        {
            slot3.transform.position = slot1_black.transform.position;
        }
        */
        else
        {
            slot3.transform.position = SlotInitialPos3;

        }

    }


    // Update is called once per frame
  

    public void voltarMenu()
    {
        SceneManager.LoadScene("Menu");
    }
 

    public void FuncaoSomar()
    {
        Debug.Log("Soma");
    
       

        CalcularFn("somar");

    }
    public void FuncaoSubtrair()
    {
        Debug.Log("Subtracao");
      
        
        CalcularFn("subtrair");
    }

    public void FuncaoMultiplicar()
    {
        Debug.Log("Multiplicacao");
    
       
        CalcularFn("multiplicar");
    }

    public void FuncaoDividir()
    {
        Debug.Log("Divisao");
      
       
        CalcularFn("divisao");
    }

    

    public void CalcularFn(string operacao)
    {

        primeiro_valor = Random.Range(1, 10);
        segundo_valor = Random.Range(1, 10);

        if (primeiro_valor-segundo_valor<0)
        {
            valorTemporario = segundo_valor;
            segundo_valor = primeiro_valor;
            primeiro_valor = valorTemporario;
        }

        if (operacao == "somar")
        {
            respostaFinal = primeiro_valor + segundo_valor;
            
            Varsigno = "somar";
        }

        if (operacao == "subtrair")
        {
            respostaFinal = primeiro_valor - segundo_valor;
            Varsigno = "subtrair";
        }

        if(operacao == "multiplicar")
        {
            respostaFinal = primeiro_valor * segundo_valor;
            Varsigno = "multiplicar";
        }

        if (operacao == "divisao")
        {
            respostaFinal = primeiro_valor / segundo_valor;
            Varsigno = "divisao";
        }


        //Debug.Log("»»»««««1ºPrimeiro: " + primeiro_valor + " ««»» Segundo Valor: " + segundo_valor + " A resposta é: " + respostaFinal);


        PrimeiroDigito.text = primeiro_valor.ToString();
        SegundoDigito.text = segundo_valor.ToString();


        if(Varsigno == "somar")
        {
            signo.text = "+";
        }

        if (Varsigno == "subtrair")
        {
            signo.text = "-";
        }

        if (Varsigno == "multiplicar")
        {
            signo.text = "*";
        }
        if (Varsigno == "divisao")
        {
            signo.text = "/";
        }


        //Primeira Alternativa


        valorTemporario = Random.Range(2, 20);

        while (valorTemporario == respostaFinal)
        {
            valorTemporario = Random.Range(2, 20);
        }

        Alternativa1 = valorTemporario;

       // Debug.Log("Primeiro" + primeiro_valor + "Segundo -" + segundo_valor);


        ///Segunda Alternativa
        ///

        valorTemporario = Random.Range(2, 20);

        while ((valorTemporario == respostaFinal) || (valorTemporario == Alternativa1))
        {
            valorTemporario = Random.Range(2, 20);
        }

        Alternativa2 = valorTemporario;

        Debug.Log("Alternativa:" + Alternativa1 + " - " + Alternativa2 + " - " + respostaFinal);
        Debug.Log("Alternativa:" + primeiro_valor + " - " + segundo_valor   );




        //Ordenando tentativas

        valorTemporario = Random.Range(1, 7);

        if (valorTemporario == 1)
        {

            Alt_1.text = respostaFinal.ToString();
            Alt_2.text = Alternativa1.ToString();
            Alt_3.text = Alternativa2.ToString();
        }

        if (valorTemporario == 2)
        {

            Alt_1.text = respostaFinal.ToString();
            Alt_2.text = Alternativa2.ToString();
            Alt_3.text = Alternativa1.ToString();
        }

        if (valorTemporario == 3)
        {

            Alt_1.text = Alternativa1.ToString();
            Alt_2.text = respostaFinal.ToString();
            Alt_3.text = Alternativa2.ToString();
        }

        if (valorTemporario == 4)
        {

            Alt_1.text = Alternativa1.ToString();
            Alt_2.text = Alternativa2.ToString();
            Alt_3.text = respostaFinal.ToString();
        }

        if (valorTemporario == 5)
        {

            Alt_1.text = Alternativa2.ToString();
            Alt_2.text = respostaFinal.ToString();
            Alt_3.text = Alternativa1.ToString();
        }
        if (valorTemporario == 6)
        {

            Alt_1.text = Alternativa2.ToString();
            Alt_2.text = Alternativa1.ToString();
            Alt_3.text = respostaFinal.ToString();
        }
 

        

    }

    public void desativar_game()
    {
        SceneManager.LoadScene("SomarScene");

    }

    public void Alt_1Acao()
    {

        if (Alt_1.text == respostaFinal.ToString())
        {
            // Right1.GetComponent<Image>().sprite = Spritesim;
            // testeImg1.SetActive(true);
           // StartCoroutine(PerguntaSeguinte());
            m_Animator.enabled = true;
            botao.SetActive(true);
            AudioM[0].Play();
            NewTimer.intance.AddPoint();
            //Sistemaparticula.SetActive(true);
            m_Animator.SetBool("esta", true);
        }
        else
        {
            //Right1.GetComponent<Image>().sprite = Spritenao;

           // wrongtesteImg1.SetActive(true);
            SomErrado();
            m_Animator.enabled = false;
            AudioM[1].Play();
        }

    }

    public void Alt_2Acao()
    {

        if (Alt_2.text == respostaFinal.ToString())
        {
            //Right2.GetComponent<Image>().sprite = Spritesim;
            // testeImg2.SetActive(true);
            //StartCoroutine(PerguntaSeguinte());
            m_Animator.enabled = true;
            botao.SetActive(true);
            AudioM[0].Play();
            NewTimer.intance.AddPoint();
            m_Animator.SetBool("esta", true);
        }
        else
        {
            //Right2.GetComponent<Image>().sprite = Spritenao;
            //wrongtesteImg2.SetActive(true);
            SomErrado();
            m_Animator.enabled = false;
            AudioM[1].Play();
        }

    }

    public void Alt_3Acao()
    {

        if (Alt_3.text == respostaFinal.ToString())
        {
            //Right3.GetComponent<Image>().sprite = Spritesim;
            //testeImg3.SetActive(true);
            Debug.Log("funciona");
            m_Animator.enabled = true;
            botao.SetActive(true);
            AudioM[0].Play();
            NewTimer.intance.AddPoint();
            m_Animator.SetBool("esta", true);
            // StartCoroutine(PerguntaSeguinte());

        }
        else
        {
            //Right3.GetComponent<Image>().sprite = Spritenao;
            Debug.Log("Naoooo");
            //wrongtesteImg3.SetActive(true);
            SomErrado();
            m_Animator.enabled = false;
            AudioM[1].Play();
        }

    }




    public void Acertaste()
    {
        /*if (Alt_1.text == respostaFinal.ToString() || Alt_2.text == respostaFinal.ToString() || Alt_3.text == respostaFinal.ToString())
        {
            panel.SetActive(true);
        }*/


        StartCoroutine(PerguntaSeguinte());
        botao.SetActive(false);
        //m_Animator.enabled = false;
        m_Animator.SetBool("esta", false);

    }

    public void SomErrado()
    {


    }

    IEnumerator PerguntaSeguinte()
    {
       // m_Animator.enabled = true;
        yield return new WaitForSeconds(1f);
        slot3.transform.position = SlotInitialPos3;
        slot2.transform.position = SlotInitialPos2;
        slot1.transform.position = SlotInitialPos1;
        CalcularFn(Varsigno);
        
    }



    void Update()
    {

        /* if (Input.GetKeyDown(KeyCode.S))// para somar
         {
             CalcularFn("somar");
         }
         if (Input.GetKeyDown(KeyCode.R))// para subtrair
         {
             CalcularFn("subtrair");
         }
         if (Input.GetKeyDown(KeyCode.M))// para multiplicar
         {
             CalcularFn("multiplicar");
         }

         if (Input.GetKeyDown(KeyCode.D))// para divisao
         {
             CalcularFn("divisao");
         }
         */
    
        

    }
}
