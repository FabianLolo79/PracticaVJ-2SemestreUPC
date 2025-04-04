using UnityEngine;

public class MenuSfxPlay : MonoBehaviour
{

    [Header("Refer-Audios")]

    [SerializeField] private AudioSource _audioSource;
    public AudioClip audioClip_play; // clickAudio
    public AudioClip audioClip_hover; // switchAudio


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        _audioSource = GetComponent<AudioSource>();
    }

    public void ClickAudioOn()
    {
        _audioSource.PlayOneShot(audioClip_play);
    }

    public void ClickHoverOn()
    {
        _audioSource.PlayOneShot(audioClip_hover);
    }
}
