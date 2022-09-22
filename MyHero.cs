using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyHero : MonoBehaviour
{
    public GameObject myHeroObj;

    public string name;

    public int str;
    public int con;
    public int dex;
    public int inte;
    public int wis;
    public int cha;

    public void dizBeni(string namee, int strr, int conn, int dexx, int intee, int wiss, int chaa)
    {
        name = namee;
        str = strr;
        con = conn;
        dex = dexx;
        inte = intee;
        wis = wiss;
        cha = chaa;


    }
    public void statlariSec()
    {
        myHeroObj.GetComponent<MyHero>().dizBeni(name, str, con, dex, inte, wis, cha);
    }
    void Start()
    {
        myHeroObj = GameObject.Find("MyHeroo");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
