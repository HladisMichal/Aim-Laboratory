using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SkoreScenaManager : MonoBehaviour
{
    public string Scena;
    public void scenaSkore()
    {
        SceneManager.LoadScene(Scena);
    }
}
