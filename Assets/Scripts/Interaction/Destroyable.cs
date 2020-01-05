public class Destroyable : Interactable
{
    public int health = 1;

    public override void Interact()
    {
        base.Interact();
        health -= 1;
        if(health <= 0)
        {
            Destroy(this.gameObject);
        }
    }
}
