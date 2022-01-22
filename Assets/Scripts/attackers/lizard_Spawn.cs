using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lizard_Spawn : MonoBehaviour
{
    public lizard_move[] attackers;
    bool spwan = true;
    [SerializeField]float min_time = 1f;
    [SerializeField]float max_time = 5f;
  
    IEnumerator Start()
    {
        
        while (spwan)
        {
            yield return new WaitForSeconds(Random.Range(min_time, max_time));
            selectAtacker();
        }
    }
    public void stopSpwaning()
    {
        spwan = false;
    }
    void attack(lizard_move attacker)
    {
        
        lizard_move newLizard = Instantiate(attacker,transform.position,transform.rotation) as lizard_move;
        newLizard.transform.parent = transform;
    }
    void selectAtacker()
    {
        var attackerIndex = Random.Range(0, attackers.Length);
        attack(attackers[attackerIndex]);
    }
}
