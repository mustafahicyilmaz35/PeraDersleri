using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RenkDegistir : MonoBehaviour
{
    public Color[] renklerimiz;
    public Material yol_malzemesi;
    int renkSecimi;
    Color renk2;

    void Start()
    {
        renkSecimi = Random.Range(0, 3);
        yol_malzemesi.color = renklerimiz[renkSecimi];
    }

    
    void Update()
    {
        
            yol_malzemesi.color = Color.Lerp(yol_malzemesi.color, renk2, 0.05f);
        
        
           
        
    }
}
