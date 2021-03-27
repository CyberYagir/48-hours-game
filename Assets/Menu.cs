using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Menu : MonoBehaviour
{
    public Slider slider;
    public bool rus;

   

    public void Rus()
    {
        rus = true;
        PlayerPrefs.SetInt("Lang", 1);
    }
    public void Eng()
    {
        PlayerPrefs.SetInt("Lang", 0);
        rus = false;
    }
    private void Start()
    {
        Time.timeScale = 1;
        slider.value = PlayerPrefs.GetFloat("volume");
        GetComponent<AudioSource>().Stop();
        rus = PlayerPrefs.GetInt("Lang") == 1 ? true : false;
    }
    public void changeVolume()
    {
        PlayerPrefs.SetFloat("volume", slider.value);
        AudioListener.volume = PlayerPrefs.GetFloat("volume");
        GetComponent<AudioSource>().Stop();
        GetComponent<AudioSource>().Play();
    }

    public void Go()
    {
        Application.LoadLevel(1);
    }
    public void Exit()
    {
        Application.Quit();
    }
}
