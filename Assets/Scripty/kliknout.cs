using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class kliknout : MonoBehaviour
{
    public static int Kliknuti = 0;
    public int kliknutiVedle = 0;
    public GameObject TercPrefab;
    public GameObject TercPrefab2;
    public GameObject TercPrefab3;
    public GameObject ZpetButton;
    public Text VyherniText;
    public Text PocetTxt;
    public Text VedleTxt;
    private bool GameStarted = false;
    public static double procenta = 0;
    public SkoreScript skoreScript;
    // Start is called before the first frame update
    void Start()
    {
        Kliknuti = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if (GameStarted)
        {
            PocetTxt.text = "Počet trefených terčů: "+Kliknuti.ToString();
            VedleTxt.text = "Počet kliknutí vedle: "+kliknutiVedle.ToString();

             if(kliknutiVedle >=10)
            {

                double celkoveKliknuto = Kliknuti + kliknutiVedle;
                procenta = Kliknuti/celkoveKliknuto*100;
                TercPrefab.SetActive(false);
                TercPrefab2.SetActive(false);
                TercPrefab3.SetActive(false);
                ZpetButton.SetActive(true);
                VyherniText.transform.position = new Vector3(990, 500, 0);
                VyherniText.text = "Konec hry trefil jsi: "+ Kliknuti.ToString()+"\nTvoje přesnost byla: " + (procenta).ToString("F1") + "%";
                
                skoreScript.SaveKliknuti(Kliknuti);
                skoreScript.SaveProcenta(procenta);
                
                GameStarted = false;
            }
        }
    }

    public void Zapnuto()
    {
        GameStarted = true;
        VyherniText.transform.position = new Vector3(36, -500, 0);
    }
    public void Kliknuto1()
    {
        Vector3 nahodnaPozice = new Vector3(Random.Range(101f, 1878f), Random.Range(30f, 904f), -50f);
        TercPrefab.transform.position = nahodnaPozice;
        Kliknuti += 1;
    }

    public void Kliknuto2()
    {
        Vector3 nahodnaPozice = new Vector3(Random.Range(101f, 1878f), Random.Range(30f, 904f), -50f);
        TercPrefab2.transform.position = nahodnaPozice;
        Kliknuti += 1;
    }

    public void Kliknuto3()
    {
        Vector3 nahodnaPozice = new Vector3(Random.Range(101f, 1878f), Random.Range(30f, 904f), -50f);
        TercPrefab3.transform.position = nahodnaPozice;
        Kliknuti += 1;
    }

    public void KliknutoVedle()
    {
        if(GameStarted)
        {
            kliknutiVedle++;
        }
    }

}
