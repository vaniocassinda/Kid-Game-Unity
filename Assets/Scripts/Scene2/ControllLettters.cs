using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControllLettters : MonoBehaviour
{
    // Start is called before the first frame update
    int urutan = 0;
    void Start()
    {
        Set_Active();
    }

    public void control(int i)
    {
        urutan += i;

        if (urutan > transform.childCount-1)
        {
            urutan = 0;
        }else if (urutan<0)
        {
            urutan = transform.childCount - 1;
        }
        Set_Active();
    }
    // Update is called once per frame

    public void Set_Active()
    {
        for (int i = 0; i < transform.childCount; i++)
        {
            transform.GetChild(i).gameObject.SetActive(false);
        }
        transform.GetChild(urutan).gameObject.SetActive(true);
    }

    void Update()
    {
        
    }
}
