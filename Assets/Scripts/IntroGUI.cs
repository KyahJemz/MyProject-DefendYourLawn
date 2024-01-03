using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class IntroGUI : MonoBehaviour
{
    public Text txt;
    private void Start()
    {
        StartCoroutine(x());
    }
    IEnumerator x()
    {
        AudioManager.instance.Audio_Intro();
        txt.text = "READY..";
        yield return new WaitForSecondsRealtime(0.7f);
        txt.text = "SET..";
        yield return new WaitForSecondsRealtime(0.7f);
        txt.text = "SHOOT!";
        yield return new WaitForSecondsRealtime(0.7f);
        txt.text = "";
       
    }
}
