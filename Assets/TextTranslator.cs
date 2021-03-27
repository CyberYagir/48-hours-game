using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class TextTranslator : MonoBehaviour
{
    public TMP_Text TMPText;
    [TextArea]
    public string engText, rusText;
    public Menu menu;

    private void Start()
    {
        menu = FindObjectOfType<Menu>();
        TMPText = GetComponent<TMP_Text>();
        if (TMPText != null)
        {
            if (menu != null)
            {
                if (menu.rus == true)
                    TMPText.text = rusText;
                else
                    TMPText.text = engText;
            }
            else
            {
                if (PlayerPrefs.GetInt("Lang") == 1)
                    TMPText.text = rusText;
                else
                    TMPText.text = engText;
            }
        }
    }
    private void Update()
    {
        if (TMPText != null)
        {
            if (menu != null)
            {
                if (menu.rus == true)
                    TMPText.text = rusText;
                else
                    TMPText.text = engText;
            }
        }
    }
}