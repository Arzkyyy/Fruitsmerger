using UnityEngine;

public class audiomanager : MonoBehaviour
{
    [Header("-------- Audio Source -------")]
    [SerializeField] AudioSource musicSource;
    [SerializeField] AudioSource SFXSource;

    [Header("-------- Audio Clip -------")]
    public AudioClip Background;
    public AudioClip B6;
    public AudioClip B5;
    public AudioClip B4;
    public AudioClip B3;
    public AudioClip B2;
    public AudioClip B1;
    public AudioClip Gameover;
    public AudioClip Button;

    private void Start()
    {
        musicSource.clip = Background;
        musicSource.Play();
    }
}
