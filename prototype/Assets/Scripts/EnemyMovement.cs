using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    public Transform[] waypoints;
    public float speed = 5f;

    private int currentWaypointIndex = 0;

    void Update()
    {
        // Check if there are waypoints to follow
        if (waypoints.Length == 0)
            return;

        // Move towards the current waypoint
        Transform currentWaypoint = waypoints[currentWaypointIndex];
        transform.position = Vector2.MoveTowards(transform.position, currentWaypoint.position, speed * Time.deltaTime);

        // Check if the enemy has reached the current waypoint
        if (Vector2.Distance(transform.position, currentWaypoint.position) < 0.1f)
        {
            // Move to the next waypoint
            currentWaypointIndex = (currentWaypointIndex + 1) % waypoints.Length;
        }
    }
}
