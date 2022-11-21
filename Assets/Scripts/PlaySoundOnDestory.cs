using UnityEngine;

public class PlaySoundOnDestory : MonoBehaviour
{
    public AudioClip audioClip;
    [Range(0, 1)]public float volume = 0.5f;

    private void OnDestroy()
    {
        var empty = new GameObject($"{gameObject.name}-DestroyAudio", typeof(AudioSource));
        empty.transform.position = transform.position;
        var emptyAudio = empty.GetComponent<AudioSource>();
        emptyAudio.volume = volume;
        emptyAudio.PlayOneShot(audioClip);
        Destroy(empty, audioClip.length);
    }
}
