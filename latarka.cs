using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class latarka : MonoBehaviour
{
    public GameObject objektlatarki;

    void Start()
    {
        objektlatarki.transform.rotation = Camera.main.transform.rotation;
    }

    void Update()
    {
        objektlatarki.transform.rotation = Camera.main.transform.rotation;
    }
}
