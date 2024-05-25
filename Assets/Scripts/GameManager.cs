using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;


    void Awake()
    {
        if(instance == null)
        {
            DontDestroyOnLoad(gameObject);
            instance=this;
        
        }

        else
        {
            Destroy(gameObject);
        }
        
    }

}
