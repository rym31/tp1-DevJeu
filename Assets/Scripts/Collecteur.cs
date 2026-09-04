using UnityEngine;

public class Collecteur : MonoBehaviour
{
    [SerializeField] private int objectif = 3;
    [SerializeField] private GameObject porteSortie;

    private int batteriesCollectees = 0;

    private void Start()
    {
        // TODO : valider la référence, puis cacher la porte au démarrage.
        if (porteSortie == null)
        {
            porteSortie.SetActive(false);

        }
        Debug.LogError("La porte de sortie n'est pas assignée.");

        return;
    }

    private void OnTriggerEnter2D(Collider2D autre)
    {
        // TODO : ignorer les objets qui ne sont pas des batteries.
        if (!autre.CompareTag("Batterie"))
        {
            Destroy(autre.gameObject);

        }
        // TODO : ramasser la batterie et mettre le compteur à jour.

        if (batteriesCollectees >= objectif)
        {
            batteriesCollectees++;

        }
        Debug.Log($"Batteries : {batteriesCollectees}/{objectif}");

        // TODO : déverrouiller la porte lorsque l'objectif est atteint.
        Debug.Log("PORTE DÉVERROUILLÉE !");
        porteSortie.SetActive(true);
        return;

    }
}
