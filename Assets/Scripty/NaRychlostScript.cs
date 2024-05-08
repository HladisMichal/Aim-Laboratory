using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

    
public class NaRychlostScript : MonoBehaviour
{
    public Button ZpustitBtn;
    public GameObject TercPrefab;
    public GameObject infoTxt;
    private float timer = 0;
    private bool gameStarted = false;
   
    
    void Start()
    {
        
    }

    void Update()
    {
        if(gameStarted)
        {
            MoveTarget();
        }
    }
    
    public void ZpustHru()
    {
        ZpustitBtn.gameObject.SetActive(false);
        infoTxt.gameObject.SetActive(false);
        gameStarted = true;
        
        Vector3 nahodnaPozice = new Vector3(Random.Range(-2673f, 891f), Random.Range(-1558f, 111f), -50f);
        TercPrefab.transform.position = nahodnaPozice;
        
    }
    void MoveTarget()
    {
        timer += Time.deltaTime;
            if (timer > 3f)
            {
                Vector3 nahodnaPozice = new Vector3(Random.Range(-2673f, 891f), Random.Range(-1558f, 111f), -50f);
                TercPrefab.transform.position = nahodnaPozice;
                timer = 0f;
            }
    }
}

