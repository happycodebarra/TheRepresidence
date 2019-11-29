using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Script : MonoBehaviour
{
    
    public void loadScene(int id)
    {
        SceneManager.LoadScene(id);
    }
}
