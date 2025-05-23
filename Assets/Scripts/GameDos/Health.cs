using UnityEngine;

public class Health : MonoBehaviour
{
    [SerializeField] private int LifeRecover;
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.layer == 6)
        {
            GameManager.Instance.ModifyLife(LifeRecover);
            Destroy(this.gameObject);
        }
    }
}
