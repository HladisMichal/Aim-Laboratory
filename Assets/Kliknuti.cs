using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Kliknuti : MonoBehaviour
{
    public GameObject TercPrefab;
    private GameObject[] tercs = new GameObject[3];

   
    void Start()
    {
       
    }

   
    void Update()
    {
        /*if(GameStarted)
        {
            for (int i = 0; i < tercs.Length; i++)
        {
           tercs = GameObject.FindGameObjectsWithTag("Terc");
        }
        }*/
    }

    public void Kliknuto()
    {    
            
     Vector3 nahodnaPozice = new Vector3(Random.Range(160f, 1850f), Random.Range(30f, 920f), -50f);
     TercPrefab.transform.position = nahodnaPozice;
    //tercs[i].transform.position = nahodnaPozice;
            
        
    }
}