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
    private bool gameStarted = false;

    void Start()
    {
        ZpustitBtn.onClick.AddListener(ZpustHru);
    }

    void Update()
    {
        if (gameStarted)
        {
            for (int i = 0; i < 3; i++)
            {
                timers[i] += Time.deltaTime;
                if (timers[i] > 3f)
                {
                    Vector3 nahodnaPozice = new Vector3(Random.Range(10f, 1900f), Random.Range(10f, 1000f), -0.1f);
                    tercs[i].transform.position = nahodnaPozice;
                    timers[i] = 0f;
                }
            }
        }
    }

    void ZpustHru()
    {
        ZpustitBtn.gameObject.SetActive(false);
        infoTxt.gameObject.SetActive(false);

        gameStarted = true;
        for (int i = 0; i < 3; i++)
        {
            Vector3 nahodnaPozice = new Vector3(Random.Range(10f, 1900f), Random.Range(10f, 1000f), -0.1f);
            tercs[i] = Instantiate(TercPrefab, nahodnaPozice, Quaternion.identity);
        }
    }
}