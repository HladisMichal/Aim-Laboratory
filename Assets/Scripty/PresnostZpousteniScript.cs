using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ZpusteniScriptu : MonoBehaviour
{
    public Button ZpustitBtn;
    public GameObject TercPrefab;
    public GameObject TercPrefab1;
    public GameObject TercPrefab2;
    public GameObject infoTxt;

    private double timer = initialDelay;
    private static double initialDelay = 1000;
    private double rozdil = 10;
    public static bool GameStarted = false; 
    private int kliknutiVedle = 0;

    void Start()
    {
        initialDelay = 1000;
        timer = initialDelay;
    }

    void MoveTargets()
    {

        timer--;
        if (timer <= 0) 
        {
            Vector3 nahodnaPozice = new Vector3(Random.Range(101f, 1878f), Random.Range(30f, 904f), -50f);
            TercPrefab.transform.position = nahodnaPozice;
            Vector3 nahodnaPozice2 = new Vector3(Random.Range(101f, 1878f), Random.Range(30f, 904f), -50f);
            TercPrefab1.transform.position = nahodnaPozice2;
            Vector3 nahodnaPozice3 = new Vector3(Random.Range(101f, 1878f), Random.Range(30f, 904f), -50f);
            TercPrefab2.transform.position = nahodnaPozice3;
            initialDelay -= rozdil;
            timer = initialDelay;
        }
    }

    void Update()
    {
        if (GameStarted)
        {
            MoveTargets();
        }
    }
    

    public void ZpustHru()
    {
        ZpustitBtn.gameObject.SetActive(false);
        infoTxt.gameObject.SetActive(false);
        GameStarted = true;
        Vector3 nahodnaPozice = new Vector3(Random.Range(101f, 1878f), Random.Range(30f, 904f), -50f);
        TercPrefab.transform.position = nahodnaPozice;
        Vector3 nahodnaPozice2 = new Vector3(Random.Range(101f, 1878f), Random.Range(30f, 904f), -50f);
        TercPrefab1.transform.position = nahodnaPozice2;
        Vector3 nahodnaPozice3 = new Vector3(Random.Range(101f, 1878f), Random.Range(30f, 904f), -50f);
        TercPrefab2.transform.position = nahodnaPozice3;
    }
}