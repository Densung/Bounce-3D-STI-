using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class UI : MonoBehaviour
{
    [SerializeField] private Slider healthBar = default;
    [SerializeField] private Slider staminaBar = default;
    [SerializeField] private TextMeshProUGUI healthText = default;
    [SerializeField] private TextMeshProUGUI scoreText = default;
    [SerializeField] private TextMeshProUGUI stateText = default;
    [SerializeField] private TextMeshProUGUI evalText = default;

    private void OnEnable()
    {
        FirstPersonController.OnDamage += UpdateHealth;
        FirstPersonController.OnHeal += UpdateHealth;
        FirstPersonController.OnStaminaChange += UpdateStamina;
    }

    private void OnDisable()
    {
        FirstPersonController.OnDamage -= UpdateHealth;
        FirstPersonController.OnHeal -= UpdateHealth;
        FirstPersonController.OnStaminaChange -= UpdateStamina;
    }

    private void Start()
    {
        UpdateHealth(100);
        UpdateStamina(100);
    }

    private void UpdateHealth(float currentHealth)
    {
        healthBar.value = currentHealth;
        healthText.text = currentHealth.ToString() + "%";
        scoreText.text = currentHealth.ToString() + " Points";
        if (currentHealth <= 0)
        {
            stateText.text = "You Are Dead";
            evalText.text = "You did not survive the earthquake";
        }
        else if (currentHealth >= 1 && currentHealth <= 39)
        {
            stateText.text = "Critically Wounded";
            evalText.text = "You Survived!";
        }
        else if (currentHealth >= 40 && currentHealth <= 69)
        {
            stateText.text = "Wounded";
            evalText.text = "You Survived!";
        }
        else if (currentHealth >= 70 && currentHealth <= 99)
        {
            stateText.text = "Barely Injured";
            evalText.text = "You Survived!";
        }
        else if (currentHealth == 100)
        {
            stateText.text = "Fine";
            evalText.text = "You Survived!";
        }
    }
    private void UpdateStamina(float currentStamina)
    {
        staminaBar.value = currentStamina;
    }
}