using UnityEngine;

public class Collectable : Interactable
{
    public int min = 1;
    public int max = 1;
    public string text = "collectable item name";
    public override void Interact()
    {
        int value = Random.Range(min, max);
        base.Interact();
        print("Collecting " + value + " " + text);

    }
}
