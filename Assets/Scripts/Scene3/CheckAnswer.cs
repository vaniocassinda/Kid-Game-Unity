using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckAnswer : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject lettreOne, lettreTwo, lettreThree, lettreFor, lettreFive, lettreSix, lettreSeven,
        lettreEight, BoxOne, BoxTwo, Boxthree, BoxFor, BoxFive;

    Vector3 lettreOneIni, lettreTwoIni, lettreThreeIni, lettreForIni, lettreFiveIni, lettreSixIni, lettreSevenIni,
        lettreEightIni;

    //string str = "";
    public string word;

    public GameObject questionHide, questionShow;

    //bool oneCorrect, twoCorrect, threeCorrect, forCorrect, fivecorrect = false;

    Vector3 iniScaleLetreOne, iniScaleLetreTwo, iniScaleLetreThree, iniScaleLetreFor, iniScaleLetreFive, iniScaleLetreSix,
        iniScaleLetreSeven, iniScaleLetreEight;

    public AudioSource source;
    public AudioClip[] correct;
    public AudioClip incorrect;
    public AudioClip buttonDrop;
    public AudioClip reload;


    void Start()
    {
        lettreOneIni = lettreOne.transform.position;
        lettreTwoIni = lettreTwo.transform.position;
        lettreThreeIni = lettreThree.transform.position;
        lettreForIni = lettreFor.transform.position;
        lettreFiveIni = lettreFive.transform.position;
        lettreSixIni = lettreSix.transform.position;
        lettreSevenIni = lettreSeven.transform.position;
        lettreEightIni = lettreEight.transform.position;

        iniScaleLetreOne = lettreOne.transform.localScale;
        iniScaleLetreTwo = lettreTwo.transform.localScale;
        iniScaleLetreThree = lettreThree.transform.localScale;
        iniScaleLetreFor = lettreFor.transform.localScale;
        iniScaleLetreFive = lettreFive.transform.localScale;
        iniScaleLetreSix = lettreSix.transform.localScale;
        iniScaleLetreSeven = lettreSeven.transform.localScale;
        iniScaleLetreEight = lettreEight.transform.localScale;

        //blockPanel.SetActive(false);

    }

    /// <summary>
    /// ///****************drag***********///////
    /// </summary>
    
    public void DagLettreOne()
    {
        lettreOne.transform.position = Input.mousePosition;
    }
    public void DagLettreTwo()
    {
        lettreTwo.transform.position = Input.mousePosition;
    }
    public void DagLettreThree()
    {
        lettreThree.transform.position = Input.mousePosition;
    }
    public void DagLettreFor()
    {
        lettreFor.transform.position = Input.mousePosition;
    }
    public void DagLettreFive()
    {
        lettreFive.transform.position = Input.mousePosition;
    }
    public void DagLettreSix()
    {
        lettreSix.transform.position = Input.mousePosition;
    }
    public void DagLettreSeven()
    {
        lettreSeven.transform.position = Input.mousePosition;
    }
    public void DagLettreEight()
    {
        lettreEight.transform.position = Input.mousePosition;
    }

    // drop ////////////////

        public void DropLettreOne()
    {

    }


    // Update is called once per frame


    void Update()
    {
        
    }
}
