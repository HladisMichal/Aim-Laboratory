using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class KliknoutScript : MonoBehaviour
{
    public static int pocetKliknuti = 0;
    public GameObject TercPrefab;
    public Text VyherniText;
    public Text PocetTxt;
    public Text CasTxt;
    public GameObject ZpetButton;
    public SkoreScript skoreScript; // reference na SkoreScript
    private float cas = 60;
    private bool GameStarted = false;

    void Start()
    {
       skoreScript = GameObject.FindObjectOfType<SkoreScript>();
    }

    void Update()
    {
        if (GameStarted)
        {
            if(cas > 0)
            {
                cas -= Time.deltaTime;
            }
            else
            {
                cas = 0;
                
                TercPrefab.SetActive(false);
                VyherniText.text = "Konec hry trefil jsi: "+pocetKliknuti.ToString()+" terčů!";
                PocetTxt.transform.position = new Vector3(-4007f, -200f,0f);
                CasTxt.transform.position = new Vector3(-4007f, -200f,0f);
                ZpetButton.SetActive(true);
                
                if (skoreScript != null) 
                {
                    skoreScript.SaveSkore(pocetKliknuti); 
                }
                pocetKliknuti = 0;
                GameStarted = false;
            }
                
            CasTxt.text = "Zbývající čas: " + cas.ToString("F2");
            PocetTxt.text = "Počet trefených terčů : " + pocetKliknuti.ToString();
        }  
        
    }

    public void Kliknuto()
    {    
        Vector3 nahodnaPozice = new Vector3(Random.Range(-2673f, 891f), Random.Range(-1558f, 111f), -50f);
        TercPrefab.transform.position = nahodnaPozice;
        pocetKliknuti++; // zvýšení počtu kliknutí
    }

    public void Zpusteno()
    {
        GameStarted = true;
    }
}

