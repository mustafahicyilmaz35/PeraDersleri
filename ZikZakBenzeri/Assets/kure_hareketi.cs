using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class kure_hareketi : MonoBehaviour
{
    public Vector3 yon;
    public float hiz;
    public Son_yol yol_olusturuyoruz;
    // Start is called before the first frame update
    void Start()
    {
        yon = Vector3.forward;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            if(yon.x == 0)
            {
                yon = Vector3.left;
            }
            else
            {
                yon = Vector3.forward;
            }
        }
    }

    private void FixedUpdate()
    {
        Vector3 kure_move = yon*Time.deltaTime * hiz;
        transform.position += kure_move;
    }

    private void OnCollisionExit(Collision collision)
    {
        if(collision.gameObject.tag == "yolum")
        {
            yol_olusturuyoruz.yol_olusturma();
        }
    }
}
