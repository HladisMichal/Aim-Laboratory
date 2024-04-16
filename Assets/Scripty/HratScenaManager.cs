using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class HratScenaManager : MonoBehaviour
{
    public string Scena;
    public void scenaHrat()
    {
        SceneManager.LoadScene(Scena);
    }
}
