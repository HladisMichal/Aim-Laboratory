using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

    
public class NaRychlostScript : MonoBehaviour
{
    public Button ZpustitBtn;
    public GameObject TercPrefab;
    public GameObject infoTxt;
    private GameObject[] tercs = new GameObject[3];
    private bool gameStarted = false;
   
    // Start is called before the first frame update
    void Start()
    {
        ZpustitBtn.onClick.AddListener(ZpustHru);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
    void ZpustHru()
    {
        ZpustitBtn.gameObject.SetActive(false);
        infoTxt.gameObject.SetActive(false);

        gameStarted = true;
        for (int i = 0; i < 3; i++)
        {
            Vector3 nahodnaPozice = new Vector3(Random.Range(1900f, -1420f), Random.Range(-960f, -2550f), -0.1f);
            tercs[i] = Instantiate(TercPrefab, nahodnaPozice, Quaternion.identity);
        }
    }
}

