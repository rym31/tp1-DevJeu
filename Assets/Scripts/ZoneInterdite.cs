using UnityEngine;

public class ZoneInterdite : MonoBehaviour
{
    [SerializeField] private Transform pointDepart;

    private void OnTriggerEnter2D(Collider2D autre)
    {
        // TODO : filtrer l'objet touché.
        if (!autre.CompareTag("Player"))
        {
             return;

        }

        // TODO : empêcher le déplacement si PointDepart est absent.
        if (pointDepart == null)
        {
            Debug.LogError("Le point de départ n'est pas assigné.");

        }
        // TODO : retourner le joueur à sa position initiale.
        autre.transform.position = pointDepart.position;
        Debug.Log("Le robot retourne au point de départ.");
        return;

    }

    /*
     * BANQUE DE LIGNES — GROUPE B
     * La ligne return; doit être utilisée aux deux endroits appropriés.
     *
     */
}
