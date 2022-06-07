using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIManager : MonoBehaviour
{
    // Start is called before the first frame update
    public bool mbPause=false;
    void Start()
    {
        
    }
    public void GamePause()
    {
        if(!mbPause)
        {
            Time.timeScale=0;
        }
        else
        {
            Time.timeScale=1;
        }
        mbPause = !mbPause;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
