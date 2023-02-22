using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using TMPro;
using System.IO;

public class MenuUIHandler : MonoBehaviour
{
    public GameObject startMenu;
    public string playerName;
    public static MenuUIHandler Instance;
    public TMP_InputField nameInput;

    private void Awake()
    {

        if (Instance != null)
        {
            Destroy(gameObject);
            return;
        }

        Instance  = this;
        DontDestroyOnLoad(gameObject);
    }

    public void SavePlayerName()
    {
        playerName = nameInput.text;
    }

    public void StartNew()
    {
        SceneManager.LoadScene(1);
        startMenu.SetActive(false);
    }

    [System.Serializable]
    class SaveData
    {
        public string savePlayerName;
    }

    public void SaveName()
    {
        SaveData data = new SaveData();
        data.savePlayerName = playerName;

        string json = JsonUtility.ToJson(data);

        File.WriteAllText(Application.persistentDataPath + "/savefile.json", json);
    }

    public void LoadName()
    {
        string path = Application.persistentDataPath + "/savefile.json";
        if(File.Exists(path))
        {
            string json = File.ReadAllText(path);
            SaveData data = JsonUtility.FromJson<SaveData>(json);

            playerName = data.savePlayerName;
        }
    }

}
