using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuManager : MonoBehaviour
{
    public GameObject pnlhowToPlay;
    public GameObject btnPlay;
    public GameObject btnHowToPlay;
    public GameObject pnlDev;
    public void Play()
    {
        SceneManager.LoadScene("Game");
    }
    public void OpenHowToPlay()
    {
        pnlhowToPlay.SetActive(true);
        btnPlay.SetActive(false);
        btnHowToPlay.SetActive(false);
        pnlDev.SetActive(false);
        AudioManager.instance.btnBuzzer();
    }
    public void CloseHowToPlay()
    {
        pnlhowToPlay.SetActive(false);
        btnPlay.SetActive(true);
        btnHowToPlay.SetActive(true);
        pnlDev.SetActive(true);
        AudioManager.instance.btnBuzzer();
    }
}
