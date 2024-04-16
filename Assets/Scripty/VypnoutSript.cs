using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VypnoutSript : MonoBehaviour
{
   public void Vypnout()
   {
        Application.Quit();
        Debug.Log("Vypnuto!");
   }
}
