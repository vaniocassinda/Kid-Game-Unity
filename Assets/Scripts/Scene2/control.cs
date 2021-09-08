using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class control : MonoBehaviour
{
    // Start is called before the first frame update
    float x, y;
    public GameObject controllLettters;
    public int incontrol;
    void Start()
    {

        x = transform.localScale.x;
        y = transform.localScale.y;
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnMouseDown()
    {
        GetComponent<AudioSource>().Play();
        transform.localScale = new Vector2(x*1.2f, y/1.2f);
    }

    private void OnMouseUp()
    {
        transform.localScale = new Vector2(x, y);

        controllLettters.GetComponent<ControllLettters>().control(incontrol);
    }
}
