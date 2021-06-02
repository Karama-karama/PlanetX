using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaveSpanner : MonoBehaviour
{  public enum SpawnState {SPANNING, WAITING, COUNTING};
     [System.Serializable] // This allow us to change the values in Unity
    public class Wave
    {
      public string name; 
      public Transform enemy;
      public int count;
      public float rate;
    }
    public Wave[] array;
    private int nextWave =0;
    
    public float timeBetweenWaves = 5f;
    public float waveCountDown;

    private SpawnState state = SpawnState.COUNTING;
    void Start()
    {
        waveCountDown = timeBetweenWaves;
    }
    void Update()
    {
        if ( waveCountDown <= 0 ) 
        {
           if ( state != spawnState.SPANNiNG)
           {
               // Start spanning wave
               StartCoroutine( Spanwave (waves [nextWave]));
           }
        }
           else 
           {
               waveCountDown = Time.DeltaTime;
           }
        }
        IEnumerator SpanWave(wave _wave)
        {
            state = SpawnState.SPANNING;
            // Span 
            for (int i=0; i< _wave.count; i++) 
            {
               SpanEnemy(wave.enemy);
               yield return new WaitForSeconds(1f/_wave.rate);

            }
            state= SpawnState.WAITING;
            yield break;
        }
        void SpanEnemy (Transform _enemy)
        {
          // span enemy
          Debug.log("Spanning enemy" +_enemy.name);
        }   
         



}
