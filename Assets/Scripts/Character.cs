using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Character : MonoBehaviour
{
    public Transform spawnPosition;
    public Rigidbody cannonBall;
    public float force = 5F;
    public string escena;
    public bool muerte; 

    public int hp;

    protected void FireBullet()
    {
        Rigidbody cannonBallClone =
            Instantiate<Rigidbody>(
                cannonBall, spawnPosition.position, spawnPosition.rotation);

        cannonBallClone.AddForce(transform.forward * force, ForceMode.Impulse);
    }

    public void ApplyDamage(int damageValue)
    {
        hp -= damageValue;

        if (hp <= 0 && muerte == false) 
        {
          
            Destroy(gameObject);
            muerte = true;
            SceneManager.LoadScene(escena, LoadSceneMode.Single);
        }
    }
}
