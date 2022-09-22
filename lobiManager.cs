using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using UnityEngine;
using UnityEngine.UI;

public class lobiManager : MonoBehaviour
{
    public Text nameTx;
    public Text strTx, conTx, dexTx, intTx, wisTx, chrTx;
    // Start is called before the first frame update
    void Start()
    {
        
    }


    public void baslaOyuna()
    {
        string path = @"d:\SaveDnD\oyundaki.txt";


        if (File.Exists(path))
        {
            string line1 = File.ReadLines(path).First();
            string line2 = File.ReadLines(path).ElementAtOrDefault(1);

            Debug.Log(line1);

            string[] line1s = line1.Split('/');

            nameTx.text = line1s[1];

            string[] line2s = line2.Split('/');
            strTx.text = line2s[1];
            conTx.text = line2s[2];
            dexTx.text = line2s[3];
            intTx.text = line2s[4];
            wisTx.text = line2s[5];
            chrTx.text = line2s[6];


        }
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
