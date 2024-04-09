using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    public Transform[] waypoints;
    public float speed = 5f;

    private int currentWaypointIndex = 0;
    private int direction = 1;

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
            // Move to the next waypoint based on direction
            currentWaypointIndex += direction;
            
            // Check if reached the end of waypoints array
            if (currentWaypointIndex >= waypoints.Length || currentWaypointIndex < 0)
            {
                direction *= -1; // Reverse the direction
                currentWaypointIndex = Mathf.Clamp(currentWaypointIndex, 0, waypoints.Length - 1);
            }
        }
    }
}
