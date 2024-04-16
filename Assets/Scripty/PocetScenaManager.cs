using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PocetScenaManager : MonoBehaviour
{
   public string Scena;
    public void scenaPocet()
    {
        SceneManager.LoadScene(Scena);
    }
}
