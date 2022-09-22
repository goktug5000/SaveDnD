using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using System.Linq;

public class UiManager : MonoBehaviour
{
    public GameObject statPanel,herosPanel,heroBar, ScrollPanel;

    // Start is called before the first frame update
    void Start()
    {
        statPanel.SetActive(false);
        herosPanel.SetActive(false);
    }
    public void statPanelSetActive()
    {
        if (statPanel.activeInHierarchy == true)
        {
            statPanel.SetActive(false);
        }
        else if(statPanel.activeInHierarchy == false)
        {
            statPanel.SetActive(true);
        }
    }
    public void heroPanelSetActive()
    {
        if (herosPanel.activeInHierarchy == true)
        {
            herosPanel.SetActive(false);
        }
        else if (herosPanel.activeInHierarchy == false)
        {
            herosPanel.SetActive(true);

            herolariGetir();
        }
    }
    public void herolariGetir()
    {
        string[] files = Directory.GetFiles(@"d:\SaveDnD\", "*.txt");
        int a = 0;
        foreach (var file in files)
        {
            if (file.Contains("HeroFile&"))
            {
                string araStr;
                araStr = file.Replace(@"d:\SaveDnD\","");
                araStr = araStr.Replace(".txt", "");
                araStr = araStr.Replace("HeroFile&", "");
                Debug.Log(araStr);

                var newHeroBar = Instantiate(heroBar);
                newHeroBar.transform.SetParent(ScrollPanel.transform);
                newHeroBar.GetComponent<RectTransform>().anchoredPosition = new Vector2(80, (-80 - a * 130));
                newHeroBar.transform.GetChild(1).GetComponent<UnityEngine.UI.Text>().text = araStr;
                a++;


                string line2 = File.ReadLines(file).ElementAtOrDefault(1);
                
                Debug.Log(line2);
                
                string[] line2s = line2.Split('/');

                string tempName = araStr;
                int tempStr = int.Parse(line2s[1]);
                int tempcon = int.Parse(line2s[2]);
                int tempdex = int.Parse(line2s[3]);
                int tempinte = int.Parse(line2s[4]);
                int tempwis = int.Parse(line2s[5]);
                int tempcha = int.Parse(line2s[6]);


                newHeroBar.GetComponent<MyHero>().dizBeni(tempName, tempStr, tempcon, tempdex, tempinte, tempwis, tempcha);
            }

        }
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
