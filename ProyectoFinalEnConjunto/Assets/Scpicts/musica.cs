using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class musica : MonoBehaviour
{
    [SerializeField] private AudioSource audiosource;
    [SerializeField] private Audiomusica music;
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == ("nave"))
        {
            audiosource.clip = music.music;
            audiosource.Play();
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.tag == ("nave"))
        {
            audiosource.clip = music.music;
            audiosource.Stop();
        }
    }
}
