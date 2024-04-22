using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ZpusteniScriptu : MonoBehaviour
{
    public Button ZpustitBtn;
    public GameObject TercPrefab;
    private GameObject[] tercs = new GameObject[3];
    private float timer = 0;
    private bool gameStarted = false;

    void Start()
    {
        ZpustitBtn.onClick.AddListener(ZpustHru);
    }

    void Update()
    {
        if (gameStarted)
        {
            timer += Time.deltaTime;
            if (timer > 5f)
            {
                timer = 0f;
                foreach (GameObject terc in tercs)
                {
                    if (terc != null)
                    {
                        Vector3 nahodnaPozice = new Vector3(Random.Range(10f, 1900f), Random.Range(10f, 1000f), -0.1f);
                        terc.transform.position = nahodnaPozice;
                    }
                }
            }
        }
    }

    void ZpustHru()
    {
        ZpustitBtn.gameObject.SetActive(false);
        gameStarted = true;

        for (int i = 0; i < 3; i++)
        {
            Vector3 nahodnaPozice = new Vector3(Random.Range(10f, 1900f), Random.Range(10f, 1000f), -0.1f);
            tercs[i] = Instantiate(TercPrefab, nahodnaPozice, Quaternion.identity);
        }
    }
}
