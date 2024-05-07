using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ZpusteniScriptu : MonoBehaviour
{
    public Button ZpustitBtn;
    public GameObject TercPrefab;
    public GameObject infoTxt;
    private GameObject[] tercs = new GameObject[3];
    private float[] timers = new float[3];
    public static bool GameStarted = false; 

    void Start()
    {
        ZpustitBtn.onClick.AddListener(ZpustHru);
    }

    void MoveTargets()
    {
        
        for (int i = 0; i < 3; i++)
        {
            timers[i] += Time.deltaTime;
            if (timers[i] > 3f) 
            {
                Vector3 nahodnaPozice = new Vector3(Random.Range(160f, 1850f), Random.Range(30f, 920f), -50f);
                tercs[i].transform.position = nahodnaPozice;
                timers[i] = 0f;
            }
        }
    }

    void Update()
    {
    if (GameStarted)
        {
            MoveTargets();
        }
    }

    void ZpustHru()
    {
        ZpustitBtn.gameObject.SetActive(false);
        infoTxt.gameObject.SetActive(false);

        GameStarted = true;
        for (int i = 0; i < 3; i++)
        {
            Vector3 nahodnaPozice = new Vector3(Random.Range(160f, 1850f), Random.Range(30f, 920f), -50f);
            tercs[i] = Instantiate(TercPrefab, nahodnaPozice, Quaternion.identity);
            tercs[i].tag = i.ToString();
        }
    }
}