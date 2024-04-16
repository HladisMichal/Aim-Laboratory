using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PresnostScenaManager : MonoBehaviour
{
   public string Scena;
    public void scenaPresnost()
    {
        SceneManager.LoadScene(Scena);
    }
}
