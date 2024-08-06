using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Count : MonoBehaviour
{
    public string nextScene;
    public static int count = 0;
    public int count2 = 0;
    // Start is called before the first frame update
    private void Start()
    {
        Debug.Log($"1 gameobject - {gameObject.name}: static count: {count}");
        Debug.Log($"1 gameobject - {gameObject.name}: count2: {count2}");
        count += 1;
        count2 += 1;
        Debug.Log($"2 gameobject - {gameObject.name}: static count: {count}");
        Debug.Log($"2 gameobject - {gameObject.name}: count2: {count2}");
    }
    [ContextMenu("Loadscene")]
    // Update is called once per frame
    public void LoadScene()
    {
        SceneManager.LoadScene(nextScene);
    }
   public void Update()
    {
        
    }
}

