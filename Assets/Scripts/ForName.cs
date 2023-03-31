using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using System.IO;

public class ForName : MonoBehaviour
{

public static ForName Instance;

private void Awake()
{

    // start of new code
    if (Instance != null)
    {
        Destroy(gameObject);
        return;
        
    }
    // end of new code

    Instance = this;
    DontDestroyOnLoad(gameObject);

}


}
