using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Kliknuti : MonoBehaviour
{
    public int pocetKliknuti = 0;
    public GameObject TercPrefab;
    public Text VyherniText;
    public Text PocetTxt;
    public Text CasTxt;
    public GameObject ZpetButton;
    public static float cas;
    private bool GameStarted = false;
    public SkoreScript skoreScript;

    void Start()
    {
       
    }

   
    void Update()
    {
        if (GameStarted)
        {
            cas+= Time.deltaTime;
            CasTxt.text = "Uplynulý čas: " + cas.ToString("F2");
            PocetTxt.text = "Počet trefených terčů: " + pocetKliknuti.ToString();
        
         if (pocetKliknuti == 20)
        {
            TercPrefab.SetActive(false);
            VyherniText.transform.position = new Vector3(21f, 46f,-15f);
            VyherniText.text = "Konec hry tvůj čas byl: "+cas.ToString("F2");
            CasTxt.transform.position = new Vector3(2100f, 4000f,-15f);
            PocetTxt.transform.position = new Vector3(2100f, 4000f,-15f);
            ZpetButton.SetActive(true);
            GameStarted = false;
            if (skoreScript != null) 
                {
                    skoreScript.SaveCas(cas);
                }
        }
        }
       
    }

    public void Kliknuto()
    {    
            
     Vector3 nahodnaPozice = new Vector3(Random.Range(-788f, 894f), Random.Range(-489f, 364f), -50f);
        TercPrefab.transform.position = nahodnaPozice;
        pocetKliknuti++;
    }
    public void Zpusteno()
    {
        GameStarted = true;
    }
}