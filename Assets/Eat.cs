using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Eat : MonoBehaviour
{
    public Slider slider;
    public TMP_Text infoText;
    public float price;
    public string namei, nameieng   ;
    public int health;
    private void Update()
    {
        if (infoText != null)
        {
            if (FindObjectOfType<UI>().rus)
            {
                infoText.text = namei + " " + slider.value + " сорта, по цене " + (price * slider.value) + "\nЗдоровье +" + (health * slider.value);
            }
            else
            {
                infoText.text = slider.value + "  grade "+ nameieng + " , at the price " + (price * slider.value) + "\nHealth +" + (health * slider.value);
            }
        }
    }

    public void Buy()
    {
        Stats st = FindObjectOfType<Stats>();
        if (st.money >= price * slider.value)
        {
            st.money -= price * slider.value;
            st.hp += health * slider.value;

            st.patriot -= Mathf.Abs(st.patriotsub * 5 * slider.value);
            st.zlch -= st.patriotsub * 5 * slider.value;
        }
    }

    public void BuyRandom()
    {
        Stats st = FindObjectOfType<Stats>();
        st.hp += Random.Range(10,30);
        st.patriot -= Random.Range(20,30);
        st.zlch -= Random.Range(20, 30);
    }
}
