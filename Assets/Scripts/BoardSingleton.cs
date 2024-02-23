using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoardSingleton : MonoBehaviour
{
    private static BoardSingleton _instance;

    public static BoardSingleton Instance { get { return _instance; } }
    private void Awake()
    {
        if (_instance != null && _instance != this)
        {
            Destroy(this.gameObject);
        }
        else
        {
            _instance = this;
        }
    }
}
