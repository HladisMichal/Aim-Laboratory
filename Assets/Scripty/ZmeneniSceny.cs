using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ZmeneniSceny : MonoBehaviour
{
    public string Scena;
    public void zmenScenu()
    {
        SceneManager.LoadScene(Scena);
    }
    
}
