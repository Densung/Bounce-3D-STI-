using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Scene1 : MonoBehaviour
{
    public static Scene1 scene1;
    public TMP_InputField user;

    public string user_name;

    void Awake()
    {
        if (scene1 == null)
        {
            scene1 = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }

    public void SetInfo()
    {
        user_name = user.text;
    }
}