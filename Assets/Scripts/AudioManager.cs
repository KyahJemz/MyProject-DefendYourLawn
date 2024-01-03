using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
    public static AudioManager instance;
    public AudioSource Bgm_InGame;
    public AudioSource Bgm_Menu;
    public AudioSource Sfx_Ending;
    public AudioSource Sfx_Intro;
    public AudioSource Sfx_Lose;
    public AudioSource Sfx_Scream;
    public AudioSource Sfx_Siren;
    public AudioSource Sfx_Spalt;
    public AudioSource Sfx_ZombieEat;
    public AudioSource Sfx_ZombieGroan1;
    public AudioSource Sfx_ZombieGroan2;
    public AudioSource Sfx_Buzzer;
    public AudioSource Sfx_Click;
    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
    }
    public void Audio_EndGame()
    {
        Bgm_InGame.Pause();
        Sfx_ZombieEat.Play();
        Sfx_Lose.Play();
        Sfx_Ending.Play();
        Sfx_Scream.PlayDelayed(3.5f);
    }
    public void Audio_ZombieGroan()
    {
        float randomNumber = Random.Range(1, 2);
        switch (randomNumber)
        {
            case 1:
                {
                    Sfx_ZombieGroan1.Play();
                    break;
                }
            case 2:
                {
                    Sfx_ZombieGroan2.Play();
                    break;
                }
            default:
                break;
        }
    }
    public void Audio_Splat()
    {
        Sfx_Spalt.Play();
    }
    public void btnClick()
    {
        Sfx_Click.Play();
    }
    public void btnBuzzer()
    {
        Sfx_Buzzer.Play();
    }
    public void Audio_Intro()
    {
        Sfx_Intro.Play();
    }
}
