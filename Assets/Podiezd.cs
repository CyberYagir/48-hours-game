using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Podiezd : MonoBehaviour
{
    Stats stats;
    public float penciyaTime;
    public GameObject gazeta;
    public TMP_Text gazetaText;
    public GameObject penciyaButton;
    public List<News> news = new List<News>();
    public List<AudioClip> clips;
    public int penciya = 5000;
    void Start()
    {
        stats = FindObjectOfType<Stats>();
    }

    // Update is called once per frame
    public void Update()
    {
        penciyaButton.SetActive(stats.timetopenciya >= penciyaTime);
    }
    public void Vzat()
    {
        if (stats.timetopenciya >= penciyaTime)
        {
            int id = Random.Range(0, news.Count);
            if (FindObjectOfType<UI>().rus)
            {
                gazetaText.text = news[id].newText + "\nВаша пенсия повысилась на " + news[id].pendiyaAdd + " Руб.";
            }
            else
            {
                gazetaText.text = news[id].newTextEn + "\nYour pension has increased by " + news[id].pendiyaAdd + " Rub.";
            }
            penciya += news[id].pendiyaAdd;
            stats.timetopenciya = 0;
            gazeta.SetActive(true);
            FindObjectOfType<Stats>().money += penciya;
            GetComponent<AudioSource>().PlayOneShot(clips[Random.Range(0, clips.Count)]);
        }
    }
    
    [System.Serializable]
    public class News{
        public string newText, newTextEn;
        public int pendiyaAdd;
    }
}
