using UnityEngine;

public class PlayerStatus : MonoBehaviour
{
    [SerializeField] public int maxHealth = 100;
    [SerializeField] public int maxStamina = 100;
    private int health = 0;
    private int stamina = 0;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        health = maxHealth;
        stamina = maxStamina;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void AddHealth(int amount)
    {
        health = Mathf.Clamp(health + amount, 0, maxHealth);
        Debug.Log($"‘Ì—Í : {health}");
    }

    public void AddStamina(int amount)
    {
        stamina = Mathf.Clamp(stamina + amount, 0, maxStamina);
        Debug.Log($"‘Ì—Í : {stamina}");
    }
}
