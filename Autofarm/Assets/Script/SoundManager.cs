using System.Collections;
using UnityEngine;

public class SoundManager : MonoBehaviour
{
    public AudioSource audioSource1;  
    public AudioSource audioSource2;  
    public AudioSource audioSource3;  
     

    void Start()
    {
        
        StartCoroutine(PlaySound(audioSource1, 2f, 10f));  
        StartCoroutine(PlaySound(audioSource2, 14f, 17f));
        StartCoroutine(PlaySound(audioSource3, 33f, 36f));

    }

    IEnumerator PlaySound(AudioSource audioSource, float startTime, float stopTime)
    {
    
        yield return new WaitForSeconds(startTime);
        audioSource.Play();

  
        yield return new WaitForSeconds(stopTime - startTime);
        audioSource.Stop();
    }
}
