using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TerceScript : MonoBehaviour
{
    public new GameObject Terc;
    // Start is called before the first frame update
    void Start()
    {
        GameObject newTerc = Instantiate(Terc,transform);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
