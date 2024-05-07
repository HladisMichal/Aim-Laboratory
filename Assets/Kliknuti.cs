using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Kliknuti : MonoBehaviour
{
    public static int pocetKliknuti = 0;
    public GameObject TercPrefab;
    public Text VyherniText;
    public Text PocetTxt;
    public Text CasTxt;
    public static float cas = 0;
    public bool GameStarted = false;

    void Start()
    {
       
    }

   
    void Update()
    {
        if (GameStarted)
        {
            cas+= Time.deltaTime;
            CasTxt.text = cas.ToString("F2");
            PocetTxt.text = pocetKliknuti.ToString();
        }
        
        if (pocetKliknuti == 20)
        {
            GameStarted = false;
            TercPrefab.SetActive(false);
            VyherniText.transform.position = new Vector3(21f, 46f,-15f);
            VyherniText.text = "Konec hry tvùj èas byl: "+cas.ToString("F2");
            
        }
    }

    public void Kliknuto()
    {    
            
     Vector3 nahodnaPozice = new Vector3(Random.Range(-788f, 894f), Random.Range(-489f, 364f), -50f);
        TercPrefab.transform.position = nahodnaPozice;
        pocetKliknuti++;
        Debug.Log(pocetKliknuti);
    }
    public void Zpusteno()
    {
        GameStarted = true;
    }
}