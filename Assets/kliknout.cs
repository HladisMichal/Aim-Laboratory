using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class kliknout : MonoBehaviour
{
    public int pocetKliknuti = 0;
    public int kliknutiVedle = 0;
    public GameObject TercPrefab;
    public GameObject TercPrefab2;
    public GameObject TercPrefab3;
    public Text VyherniText;
    public Text PocetTxt;
    public Text CasTxt;
    private bool GameStarted = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (GameStarted)
        {
            PocetTxt.text = "Počet trefených terčů: "+pocetKliknuti.ToString();

             if(kliknutiVedle >=10)
            {

                double celkoveKliknuto = pocetKliknuti + kliknutiVedle;
                double procenta = pocetKliknuti/celkoveKliknuto;
                TercPrefab.SetActive(false);
                TercPrefab2.SetActive(false);
                TercPrefab3.SetActive(false);
                VyherniText.text = "Konec hry trefil jsi: "+ pocetKliknuti.ToString()+" tvoje přesnost byla: " + (procenta*100).ToString("F2") + "%";
                GameStarted = false;
            }
        }
    }

    public void Zapnuto()
    {
        GameStarted = true;
    }
    public void Kliknuto1()
    {
        Vector3 nahodnaPozice = new Vector3(Random.Range(101f, 1878f), Random.Range(30f, 904f), -50f);
        TercPrefab.transform.position = nahodnaPozice;
        pocetKliknuti += 1;
    }

    public void Kliknuto2()
    {
        Vector3 nahodnaPozice = new Vector3(Random.Range(101f, 1878f), Random.Range(30f, 904f), -50f);
        TercPrefab2.transform.position = nahodnaPozice;
        pocetKliknuti += 1;
    }

    public void Kliknuto3()
    {
        Vector3 nahodnaPozice = new Vector3(Random.Range(101f, 1878f), Random.Range(30f, 904f), -50f);
        TercPrefab3.transform.position = nahodnaPozice;
        pocetKliknuti += 1;
    }

    public void KliknutoVedle()
    {
        if(GameStarted)
        {
            kliknutiVedle++;
        }
    }

}
