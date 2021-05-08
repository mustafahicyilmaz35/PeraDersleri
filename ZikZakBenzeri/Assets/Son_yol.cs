using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Son_yol : MonoBehaviour
{
    public GameObject son_yol;
    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < 10; i++)
        {
            yol_olusturma();
        }
    }

    public void yol_olusturma()
    {
        son_yol = Instantiate(son_yol, son_yol.transform.position + Vector3.forward, son_yol.transform.rotation); son_yol = Instantiate(son_yol, son_yol.transform.position + Vector3.forward, son_yol.transform.rotation);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
