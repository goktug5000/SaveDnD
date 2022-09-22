using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class SecHero : MonoBehaviour
{

    public GameObject myIsim;
    public string name;

    // Start is called before the first frame update
    void Start()
    {
        
    }
    public void HeroOlustur()
    {
        string myName;
        myName = myIsim.GetComponent<InputField>().text.ToString();
        string path = @"d:\SaveDnD\" + myName + ".txt";


        if (!File.Exists(path))
        {
            // Create a file to write to.
            using (StreamWriter sw = File.CreateText(path))
            {
                //adı
                sw.Write("Name/");
                sw.Write(myName);
                sw.WriteLine("/$");
                //statları
            }
        }
    }

    public void HeroSec()
    {
        string path = @"d:\SaveDnD\" + name + ".txt";
        string desti = @"d:\SaveDnD\oyundaki.txt";


        if (File.Exists(path))
        {

            SceneManager.LoadScene("lobi");
            if (File.Exists(desti)) {
                File.Delete(desti);
            }
            System.IO.File.Copy(path, desti);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
