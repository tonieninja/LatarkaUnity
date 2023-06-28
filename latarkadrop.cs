using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class latarkadrop : MonoBehaviour
{
    public KeyCode upusc = KeyCode.G;
    public KeyCode podnies = KeyCode.E;
    public GameObject objlatarki;
    private bool canDrop = true;

    void Update()
    {
        if (Input.GetKeyDown(upusc) && canDrop)
        {
            canDrop = false;

            Rigidbody rb = objlatarki.AddComponent<Rigidbody>();
            rb.useGravity = true;

            Collider col = objlatarki.AddComponent<BoxCollider>();
            col.isTrigger = false;

            objlatarki.transform.parent = null;

            latarka latarkaScript = objlatarki.GetComponent<latarka>();
            if (latarkaScript != null)
            {
                latarkaScript.enabled = false;
            }

            onoffLatarka onoffLatarkaScript = objlatarki.GetComponentInChildren<onoffLatarka>();
            if (onoffLatarkaScript != null)
            {
                onoffLatarkaScript.enabled = false;
            }

            StartCoroutine(EnableDrop());
        }

        if (Input.GetKeyDown(podnies))
        {
            Collider[] hitColliders = Physics.OverlapSphere(transform.position, 2f);
            int i = 0;
            while (i < hitColliders.Length)
            {
                if (hitColliders[i].gameObject == objlatarki)
                {
                    objlatarki.transform.parent = transform;
                    objlatarki.transform.localPosition = new Vector3(-0.603f, 0.831f, 0.975f);

                    Rigidbody rb = objlatarki.GetComponent<Rigidbody>();
                    if (rb != null)
                    {
                        Destroy(rb);
                    }

                    Collider col = objlatarki.GetComponent<Collider>();
                    if (col != null)
                    {
                        Destroy(col);
                    }

                    latarka latarkaScript = objlatarki.GetComponent<latarka>();
                    if (latarkaScript != null)
                    {
                        latarkaScript.enabled = true;
                    }

                    onoffLatarka onoffLatarkaScript = objlatarki.GetComponentInChildren<onoffLatarka>();
                    if (onoffLatarkaScript != null)
                    {
                        onoffLatarkaScript.enabled = true;
                    }

                    canDrop = true;
                    break;
                }
                i++;
            }
        }
    }

    IEnumerator EnableDrop()
    {
        yield return new WaitForSeconds(2f);
        canDrop = true;
    }
}
