using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.IO;
using TMPro;

public class SaveLoad : MonoBehaviour
{
    public TextMeshProUGUI userName;
    public TextMeshProUGUI score_eval;
    public TextMeshProUGUI state_eval;
    public TextMeshProUGUI result_eval;

    public GameObject[] maxSaveSlot;

    public static int saveSlot = 1;

    void Start()
    {
        LoadGame();
    }

    public void SaveGame()
    {
        userName.text = Scene1.scene1.user_name;

        SaveInfo saveData = new SaveInfo();
        saveData.userName = userName.text;
        saveData.score_eval = score_eval.text;
        saveData.state_eval = state_eval.text;
        saveData.result_eval = result_eval.text;

        bool isExist = true;
        while (isExist != false)
        {
            if (Directory.Exists(Path.Combine(Application.persistentDataPath, "Normal Mode")))
            {
                if (File.Exists(Path.Combine(Application.persistentDataPath, "Normal Mode") + "/SaveData" + saveSlot + ".json"))
                {
                    saveSlot += 1;
                    isExist = true;
                }
                else
                {
                    if (saveSlot <= 50)
                    {
                        string json = JsonUtility.ToJson(saveData, true);
                        File.WriteAllText(Path.Combine(Application.persistentDataPath, "Normal Mode") + "/SaveData" + saveSlot + ".json", json);
                        Debug.Log("Game Saved for /SaveData" + saveSlot);
                        isExist = false;
                    }
                    else if (saveSlot > 50)
                    {
                        foreach (GameObject max in maxSaveSlot)
                        {
                            max.SetActive(true);
                        }
                        Debug.Log("Save has exceeded maximum save slots.");
                        isExist = false;
                    }
                }
            }

            else
            {
                Directory.CreateDirectory(Path.Combine(Application.persistentDataPath, "Normal Mode"));
                isExist = true;
            }
        }
    }

    public void LoadGame()
    {
        if (File.Exists(Path.Combine(Application.persistentDataPath, "Normal Mode") + "/SaveData" + gameObject.name + ".json"))
        {
            string json = File.ReadAllText(Path.Combine(Application.persistentDataPath, "Normal Mode") + "/SaveData" + gameObject.name + ".json");
            SaveInfo saveData = JsonUtility.FromJson<SaveInfo>(json);
            userName.text = saveData.userName;
            score_eval.text = saveData.score_eval;
            state_eval.text = saveData.state_eval;
            result_eval.text = saveData.result_eval;
            Debug.Log("Game Loaded!");
        }
    }

    public void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag.Equals("Player"))
        {
            SaveGame();
        }
    }


    public void DeleteFile()
    {
        if (File.Exists(Path.Combine(Application.persistentDataPath, "Normal Mode") + "/SaveData" + gameObject.name + ".json"))
        {
            string json = File.ReadAllText(Path.Combine(Application.persistentDataPath, "Normal Mode") + "/SaveData" + gameObject.name + ".json");
            SaveInfo saveData = JsonUtility.FromJson<SaveInfo>(json);
            userName.text = "";
            score_eval.text = "";
            state_eval.text = "";
            result_eval.text = "";

            File.Delete(Path.Combine(Application.persistentDataPath, "Normal Mode") + "/SaveData" + gameObject.name + ".json");
        }

        else
        {
            Debug.Log("The slot has no data.");
        }
    }
}