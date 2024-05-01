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
    private RaycastHit2D hit; 

    void Start()
    {
        ZpustitBtn.onClick.AddListener(ZpustHru);
        hit = new RaycastHit2D();
    }

    void MoveTargets()
    {
        
        for (int i = 0; i < 3; i++)
        {
            timers[i] += Time.deltaTime;
            if (timers[i] > 3f) 
            {
                Vector3 nahodnaPozice = new Vector3(Random.Range(2790f, 1070f), Random.Range(590f, -230f), -50f);
                tercs[i].transform.position = nahodnaPozice;
                timers[i] = 0f;
            }
        }
    }

    void Update()
{
  if (gameStarted)
  {
    MoveTargets();

    if (Input.GetMouseButtonDown(0))
    Debug.Log("stiknuti tlacitka!");
{
  if (Physics2D.Raycast(Camera.main.ScreenToWorldPoint(Input.mousePosition), Vector2.zero))
      Debug.Log("ten dlouhy kod");
  {
    if (hit.collider != null)
{
    
    if (hit.collider.gameObject.tag == "Terc")
    {
        Debug.Log("cosi že tag se rovna Terc");
        Vector3 novaPozice = new Vector3(Random.Range(2790f, 1070f), Random.Range(590f, -230f), -50f);
        hit.collider.gameObject.transform.position = novaPozice;
    }
}
      

    
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
            Vector3 nahodnaPozice = new Vector3(Random.Range(2790f, 1070f), Random.Range(590f, -230f), -50f);
            tercs[i] = Instantiate(TercPrefab, nahodnaPozice, Quaternion.identity);
            tercs[i].tag = "Terc";
        }
    }
}