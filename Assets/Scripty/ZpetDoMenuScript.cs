using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ZpetDoMenuScript : MonoBehaviour
{
    public string Scena;
    public void zpetDoMenu()
    {
        SceneManager.LoadScene(Scena);
    }
}
