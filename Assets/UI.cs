using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class UI : MonoBehaviour
{
    public RectTransform hp, patr, gelch, dead;
    public GameObject deadIndic;
    public TMP_Text hpT, patrT, gelchT, moneyT, deadT;

    public Stats stats;
    public GameObject deadscreen, pauseScreen;
    public bool pause;

    public bool rus;

    private void Start()
    {
        rus = PlayerPrefs.GetInt("Lang") == 1 ? true : false;
    }
    public void ToMenu()
    {
        Application.LoadLevel(0);
    }
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            pause = !pause;
            if (pause)
            {
                Time.timeScale = 0;
            }
            else
            {
                Time.timeScale = 1;
            }
        }
        pauseScreen.SetActive(pause);
        if (pause)
        {
            return;
        }
        if (stats.dead >= 100)
        {
            FindObjectOfType<PlayerMove>().enabled = false;
            FindObjectOfType<PlayerMove>().animator.updateMode = AnimatorUpdateMode.UnscaledTime;
            FindObjectOfType<PlayerMove>().animator.Play("Death");
            Destroy(FindObjectOfType<PlayerMove>().rb);
            deadscreen.SetActive(true);
            Time.timeScale = 0;
            deadIndic.SetActive(false);
            return;
        }

        deadIndic.SetActive(stats.dead > 0);

        hp.localScale = new Vector3(stats.hp / 100, 1, 1);
        patr.localScale = new Vector3(stats.patriot / 100, 1, 1);
        gelch.localScale = new Vector3(stats.zlch / 100, 1, 1);
        dead.localScale = new Vector3(stats.dead / 100, 1, 1);
        if (rus)
        {
            hpT.text = "Здоровье: " + stats.hp.ToString("0") + "/100";
            patrT.text = "Патриотизм: " + stats.patriot.ToString("0") + "/100";
            gelchT.text = "Жёлчь: " + stats.zlch.ToString("0") + "/100";
            moneyT.text = "Рубли: " + stats.money.ToString("0");
            deadT.text = "Смерть: " + stats.dead.ToString("0") + "/100";
        }
        else
        {
            hpT.text = "Health: " + stats.hp.ToString("0") + "/100";
            patrT.text = "Patriotism: " + stats.patriot.ToString("0") + "/100";
            gelchT.text = "Bile: " + stats.zlch.ToString("0") + "/100";
            moneyT.text = "Rubles: " + stats.money.ToString("0");
            deadT.text = "Death: " + stats.dead.ToString("0") + "/100";
        }
    
    }
}
