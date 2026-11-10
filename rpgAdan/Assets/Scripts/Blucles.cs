using TMPro;
using Unity.AppUI.UI;
using Unity.Collections;
using UnityEngine;
using UnityEngine.Video;
using static UnityEditor.PlayerSettings;

public class Blucles : MonoBehaviour
{
    public GameObject initialScreen;
    public GameObject gameScreen;
    public TextMeshProUGUI[] textActorButtons;
    public TextMeshProUGUI[] textEnemyButtons;

    string[] actorNames = { "Cloud", "Nines", "Sunny", "Morgana" };
    int[] actorHealth = { 15, 15, 10, 20 };
    int[] actorDamage = { 5, 5, 10, 4  };

    string[] enemyNames = { "Sephiroth", "Adam", "Omori", "Yaldabaoth" };
    int[] enemyHealth = new int[4];
    int[] enemyDamage = { 3, 3, 3, 3 };


    void Start()
    {
        initialScreen.SetActive(true);
        gameScreen.SetActive(false);

        for (int i = 0; i < enemyHealth.Length; i++)
        {
            enemyHealth[i] = Random.Range(15, 41);
            if (enemyHealth[i] <= 27) //los enemigos con menos vida tendrán más daño y viceversa, para que haya glasscanon y tanques
            {
                enemyDamage[i] = Random.Range(8, 11); 
            }
            else
            {
                enemyDamage[i] = Random.Range(3, 6);
            }
                print(enemyNames[i] + " tiene " + enemyHealth[i] + " HP y " + enemyDamage[i] + " DMG");
        }

        for (int i = 0; i < actorNames.Length; i++)
        {
            textActorButtons[i].text = $"{actorNames[i]} {actorHealth[i]}";
        }
        for (int i = 0; i < enemyNames.Length; i++)
        {
            textEnemyButtons[i].text = $"{enemyNames[i]} {enemyHealth[i]}";
        }


    }
    public void Jugar()
    {
        print("¡Vamos a jugar!");
        initialScreen.SetActive(false);
        gameScreen.SetActive(true);
    }
}
