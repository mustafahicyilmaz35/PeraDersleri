using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class kure_hareketi : MonoBehaviour
{
    public Vector3 yon;
    public float hiz;
    public Son_yol yol_olusturuyoruz;
    public static bool fall;
    public Text skorumuz;
    public int skor_degeri = 0;
    public int en_yuksek_skor_degeri = 0;
    public Text en_yuksek_skor;

    void Start()
    {
        yon = Vector3.forward;
        fall = false;
        en_yuksek_skor_degeri = PlayerPrefs.GetInt("enyuksekskor");
        en_yuksek_skor.text = "En Yüksek Skor: " + en_yuksek_skor_degeri.ToString();
    }

    // Update is called once per frame
    void Update()
    {

        if (fall == true)
        {
            return;
        }

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
        if(transform.position.y < -0.5)
        {
            Destroy(this.gameObject);
            fall = true;
            if(en_yuksek_skor_degeri < skor_degeri)
            {
                en_yuksek_skor_degeri = skor_degeri;
                PlayerPrefs.SetInt("enyuksekskor", en_yuksek_skor_degeri);


            }
        }
    }

    private void FixedUpdate()
    {
        if(fall == true)
        {
            return;
        }
        if(skor_degeri >= 10)
        {
            hiz += 0.02f;
        }
        Vector3 kure_move = yon*Time.deltaTime * hiz;
        transform.position += kure_move;
    }

    private void OnCollisionExit(Collision collision)
    {
        if(collision.gameObject.tag == "yolum")
        {
            StartCoroutine(Yoket(collision.gameObject));
            

            yol_olusturuyoruz.yol_olusturma();
            skor_degeri++;
            skorumuz.text = skor_degeri.ToString();
        }
    }

    IEnumerator Yoket(GameObject yok_edilecek_yok)
    {
        yield return new WaitForSeconds(0.5f);
        yok_edilecek_yok.AddComponent<Rigidbody>();
        yield return new WaitForSeconds(1.2f);
        Destroy(yok_edilecek_yok);
    }
}
