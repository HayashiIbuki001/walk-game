using UnityEngine;
using UnityEngine.UI;

public class PlayerStatus : MonoBehaviour
{
    [SerializeField] public int maxHealth = 100;
    [SerializeField] public int maxStamina = 100;
    private int health = 0;
    private int stamina = 0;

    [Header("UI")]
    [SerializeField] private Slider hpBar;
    [SerializeField] private Slider staminaBar;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        health = maxHealth;
        stamina = maxStamina;

        hpBar.maxValue = maxHealth;
        hpBar.minValue = 0;
        hpBar.value = health;

        staminaBar.maxValue = maxStamina;
        staminaBar.minValue = 0;
        staminaBar.value = stamina;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void AddHealth(int amount)
    {
        health = Mathf.Clamp(health + amount, 0, maxHealth);

        hpBar.value = health;

        Debug.Log($"体力 : {health}");
    }

    public void AddStamina(int amount)
    {
        stamina = Mathf.Clamp(stamina + amount, 0, maxStamina);

        staminaBar.value = stamina;

        Debug.Log($"スタミナ : {stamina}");
    }

}
