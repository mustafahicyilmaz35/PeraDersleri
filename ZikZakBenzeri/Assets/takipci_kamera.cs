using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class takipci_kamera : MonoBehaviour
{
    public Transform takip_edilen;
    Vector3 mesafe;
    // Start is called before the first frame update
    void Start()
    {
        mesafe = transform.position - takip_edilen.position;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void LateUpdate()
    {
        transform.position = takip_edilen.position + mesafe;
    }
}
