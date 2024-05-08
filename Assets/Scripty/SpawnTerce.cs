using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SpawnTerce : MonoBehaviour
{
    public Button ZpustitBtn;
    public GameObject TercPrefab;
    public GameObject infoTxt;
    private bool GameStarted = false;
    private float timer = 0;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (GameStarted)
        {
            MoveTargets();
        }
    }
    void MoveTargets()
    {

        
            timer += Time.deltaTime;
            if (timer > 3f)
            {
                Vector3 nahodnaPozice = new Vector3(Random.Range(-788f, 894f), Random.Range(-489f, 364f), -50f);
            TercPrefab.transform.position = nahodnaPozice;
                timer = 0f;
            }
        
    }

    

    public void ZpustHru()
    {
        ZpustitBtn.gameObject.SetActive(false);
        infoTxt.gameObject.SetActive(false);

        GameStarted = true;
        
        Vector3 nahodnaPozice = new Vector3(Random.Range(-788f, 894f), Random.Range(-489f, 364f), -50f);
        TercPrefab.transform.position = nahodnaPozice;
    }
}
