using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Stats : MonoBehaviour
{
    public float hp, patriot, zlch, money,dead;

    public float hard;

    public float hpsub, patriotsub, zlchadd;


    public float timetopenciya;

    

    private void Update()
    {
        if (zlch >= 100 || patriot <= 0 || hp <= 0)
        {
            dead += Time.deltaTime * hard;
        }
        else
        {
            dead = 0;
        }


        timetopenciya += 1 * Time.deltaTime;


        hp += hpsub * Time.deltaTime * hard;
        patriot += patriotsub * Time.deltaTime * hard;
        zlch += zlchadd * Time.deltaTime * hard;

        hard += 0.25f * Time.deltaTime;

        if (hp > 100)
        {
            hp = 100;
        }
        if (patriot > 100)
        {
            patriot = 100;
        }
        if (zlch > 100)
        {
            zlch = 100;
        }


        if (hp < 0)
        {
            hp = 0;
        }
        if (patriot < 0)
        {
            patriot = 0;
        }
        if (zlch < 0)
        {
            zlch = 0;
        }


    }
}
