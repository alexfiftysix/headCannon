using UnityEngine;
using Random = UnityEngine.Random;

public class RandomiseAudioPitch : MonoBehaviour
{
    [Range(0, 3)]public float down;
    [Range(0, 3)]public float up;
    
    private AudioSource _audioSource;
    
    void Awake()
    {
        _audioSource = GetComponent<AudioSource>();
        _audioSource.pitch += Random.Range(-down, up);
    }
}
