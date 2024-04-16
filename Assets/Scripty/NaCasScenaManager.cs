using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NaCasScenaManager : MonoBehaviour
{
   public string Scena;
    public void scenaNaCas()
    {
        SceneManager.LoadScene(Scena);
    }
}
