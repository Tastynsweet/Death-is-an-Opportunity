using UnityEngine;

public class AudioManager : MonoBehaviour
{
    [SerializeField] AudioSource musicSource;
    [SerializeField] AudioSource purchaseSource;

    public AudioClip musicClip;
    public AudioClip purchaseClip;

    private void Start()
    {
        musicSource.clip = musicClip;
        musicSource.Play();
    }

    public void PlaySFX(AudioClip clip)
    {
        purchaseSource.PlayOneShot(clip);
    }
}
