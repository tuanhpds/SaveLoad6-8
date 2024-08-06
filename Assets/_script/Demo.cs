using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Demo : MonoBehaviour
{
    public int gold;
    public bool hasPassedTutorial;
    public double aDouble;
    public float aFloat;
    public long aLong;
    public char aChar;
    public GameInfo aGameInfo;
    // Start is called before the first frame update

    public void SaveGameInfo()
    {
        var gameInforvalue = JsonUtility.ToJson(aGameInfo);
        PlayerPrefs.SetString(nameof(aGameInfo), gameInforvalue);
        PlayerPrefs.Save();
    }
    [ContextMenu("LoadGameInfo")]
    public void LoadGameInfo()
    {
        string defaultValua = JsonUtility.ToJson(new GameInfo());
        string gameInfovalue = PlayerPrefs.GetString(nameof(aGameInfo), defaultValua);
        aGameInfo = JsonUtility.FromJson<GameInfo>(gameInfovalue);
    }
    private void Start()
    {
        Debug.Log($"Start gold: {gold}");
        SaveGold();
        loadGold();
    }
    [ContextMenu("UpdateAChar")]
    public void UpdateAChar()
    {
        PlayerPrefs.SetString("aChar", aChar.ToString());
        PlayerPrefs.Save();
    }
    public void LoadAChar()
    {
        var value = PlayerPrefs.GetString("aChar", aChar.ToString());
        aChar = char.Parse(value);
    }
    [ContextMenu("UpdateADpuble")]
    public void UpdateDouble()
    {
        PlayerPrefs.SetString("aDouble", aDouble.ToString());
        PlayerPrefs.Save();
    }
    public void LoadDouble()
    {
        var value = PlayerPrefs.GetString ("aDouble", aDouble.ToString());
        aDouble = double.Parse(value);
    }

    [ContextMenu("UpdateALong")]
    public void UpdateLong()
    {
        PlayerPrefs.SetString("aLong", aLong.ToString());
        PlayerPrefs.Save();
    }
    public void LoadLong()
    {
        var value = PlayerPrefs.GetString("aLong", aLong.ToString());
        aLong = long.Parse(value);
    }

    [ContextMenu("UpdateAFloat")]
    public void UpdateFloat()
    {
        PlayerPrefs.SetString("aFloat",aFloat.ToString());
        PlayerPrefs.Save();
    }
    
    public void LoadFloat()
    {
        var value = PlayerPrefs.GetString("aFloat", aFloat.ToString());
        aFloat = float.Parse(value);
    }

    public void UpdatePassedTutorialState()
    {
        var hasPassedTutorialValue = hasPassedTutorial ? 1 : 0;
        PlayerPrefs.SetInt("hasPassedTutorial", hasPassedTutorialValue);
        PlayerPrefs.Save();
    }

    

    public void LoadPassedTutorialState()
    {
        hasPassedTutorial = PlayerPrefs.GetInt("hasPassedTutorial", 0)==0;
    }
    [ContextMenu("Save Gold")]
    public void SaveGold()
    {
        Debug.Log($"save gold:{gold}");
        PlayerPrefs.SetInt("gold", gold);
        
        PlayerPrefs.Save();
    }
    public void loadGold()
    {
        Debug.Log($"load gold:{gold}");
        PlayerPrefs.GetInt("gold", gold);
        PlayerPrefs.Save();
    }
    
    // Update is called once per frame
    void Update()
    {

    }

}
