using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Character : MonoBehaviour
{
    public Transform spawnPosition;
    public Rigidbody cannonBall;
    public float force = 5F;
    public ParticleSystem ps;

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
        
        if (hp <= 0)
        {
            Instantiate<ParticleSystem>(ps, transform.position, ps.transform.rotation).Play();
            Destroy(gameObject);
            SceneManager.LoadScene("Over", LoadSceneMode.Single);
        }
    }
}
