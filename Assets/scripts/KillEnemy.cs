public class KillEnemy : MonoBehaviour 
{
    public GameObject menuItem;
    void OnDestroy () 
    {
        Destroy(this.menuItem);
    }
}
