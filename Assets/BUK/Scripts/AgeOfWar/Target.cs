using UnityEngine;

namespace Buk.AgeOfWar
{
  [RequireComponent(typeof(Team))]
  public class Target : MonoBehaviour {
    public void OnDestroy() {
      FindObjectOfType<AgeOfWarController>()?.TargetDied(GetComponent<Team>());
    }
  }
}