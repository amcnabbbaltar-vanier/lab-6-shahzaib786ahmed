using UnityEngine;
using UnityEngine.UI;

public class EnemyHealth : MonoBehaviour
{
    public int maxHealth = 100;
    private int currentHealth;

    public Slider heathBar;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    private void Start()
    {
        currentHealth = maxHealth;
        heathBar.maxValue = maxHealth;
        heathBar.value = currentHealth;
        
    }

    // Update is called once per frame
    public void TakeDamage(int damage)
    {
        currentHealth -= damage;
        heathBar.value = currentHealth;
        if (currentHealth <= 0)
        {
            Die();
        }
    }

    void Die()
    {
        if(GameManager.Instance != null)
        {
            GameManager.Instance.AddScore(currentHealth);
            GameManager.Instance.LoadNextScene();
        }
    }
}
