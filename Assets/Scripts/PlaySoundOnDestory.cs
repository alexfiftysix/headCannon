using UnityEngine;

public class PlaySoundOnDestory : MonoBehaviour
{
    public AudioClip audioClip;

    private void OnDestroy()
    {
        var empty = new GameObject($"{gameObject.name}-DestroyAudio", typeof(AudioSource));
        empty.transform.position = transform.position;
        var emptyAudio = empty.GetComponent<AudioSource>();
        emptyAudio.PlayOneShot(audioClip);
        Destroy(empty, audioClip.length);
    }
}
