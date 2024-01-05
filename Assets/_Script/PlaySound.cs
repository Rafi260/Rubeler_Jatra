using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlaySound : MonoBehaviour
{
    public AudioSource source;
    public AudioClip clip;
    public bool bPlayOnEnable = true;

    private void OnEnable()
    {
        source = GetComponent<AudioSource>();

        if (bPlayOnEnable)
        {
           
        }
    }
    public void _PlaySound()
    {
        source.Play();
    }

    


}
