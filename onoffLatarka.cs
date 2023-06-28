using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class onoffLatarka : MonoBehaviour
{
    public Light swiatlo;
    public AudioClip latarkaon;
    public AudioClip latarkaoff;
    private AudioSource audioSource;

    private void Start()
    {
        audioSource = GetComponent<AudioSource>();
        if (audioSource == null)
        {
            audioSource = gameObject.AddComponent<AudioSource>();
        }
    }

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            swiatlo.enabled = !swiatlo.enabled;
            ToggleSwiatlo();
        }
    }

    private void ToggleSwiatlo()
    {
        if (swiatlo.enabled)
        {
            if (latarkaon != null)
                audioSource.PlayOneShot(latarkaon);
        }
        else
        {
            if (latarkaoff != null)
                audioSource.PlayOneShot(latarkaoff);
        }
    }
}
