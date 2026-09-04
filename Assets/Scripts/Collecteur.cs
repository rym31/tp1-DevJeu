using UnityEngine;

public class Collecteur : MonoBehaviour
{
    [SerializeField] private int objectif = 3;
    [SerializeField] private GameObject porteSortie;

    private int batteriesCollectees = 0;

    private void Start()
    {
        // TODO : valider la référence, puis cacher la porte au démarrage.
        Debug.LogError("La porte de sortie n'est pas assignée.");
        if (porteSortie == true)
        {
            porteSortie.SetActive(false);

        }

    }

    private void OnTriggerEnter2D(Collider2D autre)
    {
        // TODO : ignorer les objets qui ne sont pas des batteries.
        if (!autre.CompareTag("Batterie"))
        {
            return;

        }
        // TODO : ramasser la batterie et mettre le compteur à jour.
        if (autre.CompareTag("Batterie"))
        {
            batteriesCollectees++;
            Debug.Log($"Batteries : {batteriesCollectees}/{objectif}");
            Destroy(autre.gameObject);
           

        }

        if (batteriesCollectees == objectif)
        {
        Debug.Log("PORTE DÉVERROUILLÉE !");
        porteSortie.SetActive(true);

        }


        // TODO : déverrouiller la porte lorsque l'objectif est atteint.

        return;

    }
}
