using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerBehaviour : MonoBehaviour
{
    public UnitHealth _playerHealth = new UnitHealth(100, 100);

    [SerializeField] HealthBar _healthbar;

    void Start() 
    {
        
    }


    void Update()
    {
       if(Input.GetKeyDown(KeyCode.RightShift))
       {
            PlayerTakeDmg(2);
            Debug.Log(GameManager.gameManager._playerHealth.Health);
       }

   
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Health"))
            other.gameObject.SetActive(false);
    }


    private void PlayerTakeDmg(int dmg)
    {
        GameManager.gameManager._playerHealth.DmgUnit(dmg);
        Debug.Log(GameManager.gameManager._playerHealth.Health);
        _healthbar.SetHealth(GameManager.gameManager._playerHealth.Health);
    }
    private void PlayerHeal(int healing)
    {
        GameManager.gameManager._playerHealth.HealthUnit(healing);
        _healthbar.SetHealth(GameManager.gameManager._playerHealth.Health);
    }



}
