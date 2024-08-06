using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DontDestroyAload : MonoBehaviour
{
    public int gold = 0;
    public string sceneName;
    
    // Start is called before the first frame update
    void Start()
    {
        DontDestroyOnLoad(gameObject);
    }

    [ContextMenu("Loadscene")]
    public void LoadScene()
    {
        SceneManager.LoadScene(sceneName);
    }
    public void AddGold()
    {
        gold += 10;
    }
    public void ShowGold()
    {
        Debug.Log(gold);
    }
    public void LoadGold()
    {
        Debug.Log(gold);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
