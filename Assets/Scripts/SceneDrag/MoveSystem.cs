using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveSystem : MonoBehaviour
{
    // Start is called before the first frame update

    public GameObject cao, pato, macaco, aguia, ovelha, caoBlack, patoBlack, macacoBlack, aguiaBlack, ovelhaBlack;

    Vector2 caoInitialPos, patoInitialPos, macacoInitialPos, aguiaInitialPos, ovelhaInitialPos;

    public AudioSource source;
    public AudioClip[] correct;
    public AudioClip incorrect;

    void Start()
    {
        caoInitialPos = cao.transform.position;
        patoInitialPos = pato.transform.position;
        macacoInitialPos = macaco.transform.position;
        aguiaInitialPos = aguia.transform.position;
        ovelhaInitialPos = ovelha.transform.position;
        
    }


    public void DragCao()
    {
        cao.transform.position = Input.mousePosition;
    }
    public void DragPato()
    {
        pato.transform.position = Input.mousePosition;
    }
    public void DragMacaco()
    {
        macaco.transform.position = Input.mousePosition;

    }
    public void DragAguia()
    {
        aguia.transform.position = Input.mousePosition;
    }
    public void DragOvelha()
    {
        ovelha.transform.position = Input.mousePosition;
    }


    public void DropCao()
    {
        float Distance = Vector3.Distance(cao.transform.position, caoBlack.transform.position);
        if (Distance < 50)
        {
            cao.transform.position = caoBlack.transform.position;
            source.clip = correct[Random.Range(0, correct.Length)];
            source.Play();
        }
        else
        {
            cao.transform.position = caoInitialPos;
            source.clip = incorrect;
            source.Play();
        }
    }

    public void DropPato()
    {
        float Distance = Vector3.Distance(pato.transform.position, patoBlack.transform.position);
        if (Distance < 50)
        {
            pato.transform.position = patoBlack.transform.position;
            source.clip = correct[Random.Range(0, correct.Length)];
            source.Play();
        }
        else
        {
            pato.transform.position = patoInitialPos;
            source.clip = incorrect;
            source.Play();
        }
    }

    public void DropMacaco()
    {
        float Distance = Vector3.Distance(macaco.transform.position, macacoBlack.transform.position);
        if (Distance < 50)
        {
            macaco.transform.position = macacoBlack.transform.position;
            source.clip = correct[Random.Range(0, correct.Length)];
            source.Play();

        }
        else
        {
            macaco.transform.position = macacoInitialPos;
            source.clip = incorrect;
            source.Play();
        }
    }

    public void DropAguia()
    {
        float Distance = Vector3.Distance(aguia.transform.position, aguiaBlack.transform.position);
        if (Distance < 50)
        {
            aguia.transform.position = aguiaBlack.transform.position;
            source.clip = correct[Random.Range(0, correct.Length)];
            source.Play();
        }
        else
        {
            aguia.transform.position = aguiaInitialPos;
            source.clip = incorrect;
            source.Play();
        }
    }
    public void DropOvelha()
    {
        float Distance = Vector3.Distance(ovelha.transform.position, ovelhaBlack.transform.position);
        if (Distance < 50)
        {
            ovelha.transform.position = ovelhaBlack.transform.position;
            source.clip = correct[Random.Range(0, correct.Length)];
            source.Play();
        }
        else
        {
            ovelha.transform.position = ovelhaInitialPos;
            source.clip = incorrect;
            source.Play();
        }
    }
    // Update is called once per frame
    void Update()
    {


    }

}
