using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;

public class Reset : MonoBehaviour
{
  
   public void Reiniciar(int Nescena)
    {
       // Time.timeScale = 1f;
        Application.LoadLevel(Nescena);
    }
}
