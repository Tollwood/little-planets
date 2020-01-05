using UnityEngine;

public class Interactor : MonoBehaviour
{
    public void Interact(Camera cam)
    {

        Ray ray = cam.ViewportPointToRay(new Vector3(0.5F, 0.5F, 0));
        RaycastHit hit;
        if (Physics.Raycast(ray, out hit,2f))
        {
            Interactable[] interactables = hit.transform.GetComponents<Interactable>();
            for(int i = 0; i< interactables.Length; i++)
            {
                interactables[i].Interact();
            }
        }
    }
}
