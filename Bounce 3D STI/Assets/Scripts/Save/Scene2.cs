using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Scene2 : MonoBehaviour
{
    public TextMeshProUGUI display_user_name;

    public void Awake()
    {
        display_user_name.text = Scene1.scene1.user_name;
    }
}